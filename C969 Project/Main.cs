using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace C969_Project
{
    public partial class Main : Form
    {
        public Login loginform;
        public Main()
        {
            InitializeComponent();

            if (DBHelper.loggedIn != true)
            {
                loginform = new Login();
                loginform.Show();
                loginform.FormClosed += LoginFormClosed;
                loginform.TopMost = true;
            }
        }

        private void LoginFormClosed(object sender, FormClosedEventArgs e)
        {
            if (DBHelper.loggedIn == true)
            {
                lbl_welcome.Text = $"Welcome, {DBHelper.currentUserName}";
                panel_hider.Visible = true;
                update_calendar(radio_weekly.Checked);
                update_customers();
                reminder();
            }
            else
            {
                Application.Exit();
            }
        }

        private void customerFormClosed(object sender, FormClosedEventArgs e)
        {
            update_customers();
        }

        private void apptFormClosed(object sender, FormClosedEventArgs e)
        {
            update_calendar(radio_weekly.Checked);
            reminder();
        }

        public void update_calendar(bool weekly)
        {
            string query = "SELECT customerId, type, start, end, userId, appointmentId FROM appointment";
            MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            Dictionary<int, Hashtable> appointments = new Dictionary<int, Hashtable>();

            while(reader.Read())
            {
                Hashtable appt = new Hashtable();
                appt.Add("customerId", reader[0]);
                appt.Add("type", reader[1]);
                appt.Add("start", reader[2]);
                appt.Add("end", reader[3]);
                appt.Add("userId", reader[4]);
                appt.Add("appointmentId", reader[5]);

                appointments.Add(Convert.ToInt32(reader[5]), appt);
            }
            reader.Close();

            // Populate each appt in appoints with relevant UserName and CustomerName
            foreach (var appt in appointments.Values)
            {
                query = $"SELECT userName FROM user WHERE userId = {appt["userId"]}";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                appt.Add("userName", reader[0]);
                reader.Close();

                query = $"SELECT customerName FROM customer WHERE customerId = {appt["customerId"]}";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                appt.Add("customerName", reader[0]);
                reader.Close();
            }

            conn.Close();

            Dictionary<int, Hashtable> selectedAppointments = new Dictionary<int, Hashtable>();

            // Month / Week functionality.
            foreach (var appt in appointments)
            {
                DateTime start = DateTime.Parse(appt.Value["start"].ToString());
                DateTime end = DateTime.Parse(appt.Value["end"].ToString());
                DateTime today = DateTime.UtcNow;

                if (weekly)
                {
                    DateTime sunday = today.AddDays(-(int)today.DayOfWeek); // get sunday date by today's date by today's day of the week
                    DateTime saturday = sunday.AddDays((int)DayOfWeek.Saturday); // Get saturday by adding day of week to sunday

                    if (start >= sunday && end < saturday)
                    {
                        selectedAppointments.Add(appt.Key, appt.Value);
                    }
                }
                else
                {
                    DateTime monthStart = new DateTime(today.Year, today.Month, 1); // months always start on the first, obviously.
                    DateTime monthEnd = monthStart.AddMonths(1).AddDays(-1); // but they don't end the same, add a month, minus a day = 28 - 31

                    if (start >= monthStart && end < monthEnd)
                    {
                        selectedAppointments.Add(appt.Key, appt.Value);
                    }
                }
            }

            var appt_datasource = from row in selectedAppointments
                                  select new
                                  {
                                      ID = row.Key,
                                      Type = row.Value["type"],
                                      StartTime = DBHelper.convertToTimeZone(row.Value["start"].ToString()),
                                      EndTime = DBHelper.convertToTimeZone(row.Value["end"].ToString()),
                                      Customer = row.Value["customerName"]
                                  };
            DBHelper.appointments = appointments;
            dgv_calendar.DataSource = appt_datasource.ToArray();
            dgv_calendar.Refresh();
        }

        public void reminder()
        {
            foreach (DataGridViewRow row in dgv_calendar.Rows)
            {
                DateTime start = DateTime.UtcNow;
                DateTime appt_start = DateTime.Parse(row.Cells[2].Value.ToString()).ToUniversalTime();
                TimeSpan timeUntilAppt = start - appt_start;

                if (timeUntilAppt.TotalMinutes >= -15 && timeUntilAppt.TotalMinutes < 1)
                {
                    MessageBox.Show($"You have a meeting at {row.Cells[2].Value} with {row.Cells[4].Value}");
                }    

            }
        }

        public void update_customer_alt()
        {
            string query = "SELECT * FROM customer";
            MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            DataTable dt = new DataTable("customers");
            dt.Load(cmd.ExecuteReader());

            dgv_customers.DataSource = dt;
        
        }

        public void update_customers()
        {
            string query = "SELECT * FROM customer";
            MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            Dictionary<int, Hashtable> customers = new Dictionary<int, Hashtable>();

            while (reader.Read())
            {
                Hashtable customer = new Hashtable();
                customer.Add("customerName", reader[1]);
                customer.Add("addressId", reader[2]);
                customer.Add("createDate", reader[3]);
                customer.Add("createdBy", reader[4]);
                customer.Add("lastUpdate", reader[5]);
                customer.Add("lastUpdateBy", reader[6]);

                customers.Add(Convert.ToInt32(reader[0]), customer);
            }

            reader.Close();

            

            conn.Close();

            var custArray = from row in customers
                            select new
                            {
                                ID = row.Key,
                                Name = row.Value["customerName"],
                                AddressID = row.Value["addressId"]
                            };

            dgv_customers.DataSource = custArray.ToArray();
        }

        // Customers
        private void btn_customer_add_Click(object sender, EventArgs e)
        {
            AddEditCustomer addCust = new AddEditCustomer();
            addCust.FormClosed += customerFormClosed;
            addCust.Show();
        }

        private void btn_customer_edit_Click(object sender, EventArgs e)
        {
            // try catch. Error handling type 1!!!
            try
            {
                var row = dgv_customers.SelectedRows[0];
                int customerID = (int)row.Cells[0].Value;
                EditCustomer editCust = new EditCustomer(customerID);
                editCust.FormClosed += customerFormClosed;
                editCust.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No appointment selected!");
            }
            
        }

        private void btn_customer_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Attention!", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                // make like a tree & leaf
                return;
            }

            // you gotta select a row to delete row. Error handling type 2!!!
            if (dgv_customers.SelectedRows.Count < 1)
            {
                MessageBox.Show("No appointment selected!");
                return;
            }

            // selected entry
            var row = dgv_customers.SelectedRows[0];
            int customerId = (int)row.Cells[0].Value;
            int addressId = (int)row.Cells[2].Value;

            // db
            MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
            conn.Open();

            // delete customer
            string delete_statement = $"DELETE FROM customer WHERE customerId = {customerId}";
            MySqlCommand cmd = new MySqlCommand(delete_statement, conn);
            cmd.ExecuteNonQuery();

            // delete related address
            delete_statement = $"DELETE FROM address WHERE addressId = {addressId}";
            cmd = new MySqlCommand(delete_statement, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            update_customers();
        }

        private void btn_appt_add_Click(object sender, EventArgs e)
        {
            AddEditAppt addAppt = new AddEditAppt();
            addAppt.FormClosed += apptFormClosed;
            addAppt.Show();
        }

        // Appointments
        private void btn_appt_edit_Click(object sender, EventArgs e)
        {
            int apptId;
            
            if (dgv_calendar.SelectedRows.Count >= 1)
            {
                apptId = (int)dgv_calendar.SelectedRows[0].Cells[0].Value;
                AddEditAppt editAppt = new AddEditAppt(apptId);
                editAppt.FormClosed += apptFormClosed;
                editAppt.Show();
            }
            else
            {
                Console.WriteLine($"Selected row: {dgv_calendar.SelectedRows.Count}");
                MessageBox.Show("No appointment selected!");
            }
            
            
        }

        private void btn_appt_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Attention!", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                // make like a tree & leaf
                return;
            }

            // you gotta select a row to delete row
            if (dgv_calendar.SelectedRows.Count < 1)
            {
                MessageBox.Show("No appointment selected!");
                return;
            }
            // selected entry
            var row = dgv_calendar.SelectedRows[0];
            int apptId = (int)row.Cells[0].Value;

            // db
            MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
            conn.Open();

            // delete appt
            string delete_statement = $"DELETE FROM appointment WHERE appointmentId = {apptId}";
            MySqlCommand cmd = new MySqlCommand(delete_statement, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            update_calendar(radio_weekly.Checked);
        }

        private void radio_weekly_CheckedChanged(object sender, EventArgs e)
        {
            // update calender if radio changed
            update_calendar(radio_weekly.Checked);
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            report.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search = txtBox_search.Text.ToLower();

            try
            {
                foreach (DataGridViewRow row in dgv_customers.Rows)
                {

                    string rowValue = row.Cells[1].Value.ToString().ToLower();
                    if (rowValue.Contains(search))
                    {
                        Console.WriteLine("Ding");
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                return;
            }
        }
    }
}
