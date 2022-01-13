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
            }
            else
            {
                Application.Exit();
            }
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

            dgv_calendar.DataSource = appt_datasource.ToArray();
            dgv_calendar.Refresh();
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
                customer.Add("addresssId", reader[2]);
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
                                Name = row.Value["customerName"]

                            };

            dgv_customers.DataSource = custArray.ToArray();
        }
    }
}
