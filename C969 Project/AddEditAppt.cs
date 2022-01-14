using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class AddEditAppt : Form
    {
        bool editMode = false;
        int _apptId = 0;
        Dictionary<string, string> appointment;
        public AddEditAppt()
        {
            InitializeComponent();
            LoadCust();
            btn_addedit.Text = "Add";
            dtp_end.Value = dtp_end.Value.AddHours(1);
        }

        public AddEditAppt(int apptId)
        {
            InitializeComponent();
            editMode = true;
            _apptId = apptId;
            lbl_select_cust.Hide();
            dgv_customers.ReadOnly = true;
            btn_addedit.Text = "Edit";
            LoadCust();
            loadAppt();

        }

        public void loadAppt()
        {
            appointment = DBHelper.getAppointmentData(_apptId);
            dtp_start.Value = DateTime.Parse(appointment["start"]).ToLocalTime();
            dtp_end.Value = DateTime.Parse(appointment["end"]).ToLocalTime();


            foreach (DataGridViewRow row in dgv_customers.Rows)
            {
                if ((int)row.Cells[0].Value == Convert.ToInt32(appointment["customerId"]))
                {
                    row.Selected = true;
                    dgv_customers.CurrentCell = row.Cells[0];
                }
            }



        }

        public void LoadCust()
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
                                Name = row.Value["customerName"],
                                AddressID = row.Value["addressId"]
                            };

            dgv_customers.DataSource = custArray.ToArray();
        }

        private void btn_addedit_Click(object sender, EventArgs e)
        {
            if (dgv_customers.SelectedRows.Count < 1 || string.IsNullOrEmpty(txt_type.Text))
            {
                MessageBox.Show("Values can not be empty!");
                return;
            }
            else if (dtp_start.Value > dtp_end.Value)
            {
                MessageBox.Show("Appointment can't end before it starts! Please adjust start and end times.");
                return;
            }
            else if (dtp_start.Value.Hour < 8 || dtp_end.Value.Hour >= 17)
            {
                MessageBox.Show("Appointment can't be schedule outside business hours of 8 A.M to 5 P.M.");
                return;
            }

            foreach (var appt in DBHelper.appointments)
            {
                if ((int)appt.Value["appointmentId"] != _apptId)
                {
                    string appt_start = DBHelper.convertToDBTime(appt.Value["start"].ToString());
                    string appt_end = DBHelper.convertToDBTime(appt.Value["start"].ToString());
                    string start = DBHelper.convertToDBTime(dtp_start.Value.ToString());
                    string end = DBHelper.convertToDBTime(dtp_end.Value.ToString());
                    if (DateTime.Parse(start) >= DateTime.Parse(appt_start) && DateTime.Parse(start) < DateTime.Parse(appt_end))
                    {
                        MessageBox.Show("Appointment can't overlap a scheduled appointment");
                        return;
                    }
                }
            }

            if (!editMode)
            {
                int customerId = (int)dgv_customers.SelectedRows[0].Cells[0].Value;
                string start = DBHelper.convertToDBTime(dtp_start.Value.ToString());
                string end = DBHelper.convertToDBTime(dtp_end.Value.ToString());
                string type = txt_type.Text;
                string fields = "customerID, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy";
                string inserts = $"'{customerId}', '{DBHelper.currentUserId}', 'na', 'na', 'na', 'na', '{type}', 'na', '{start}', '{end}', '{DBHelper.getTodayTimeStamp()}', '{DBHelper.currentUserName}', '{DBHelper.getTodayTimeStamp()}', '{DBHelper.currentUserName}'";

                string insertStatement = $"INSERT INTO appointment ({fields}) VALUES ({inserts})";


                MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(insertStatement, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                string updateStatement = "";
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
