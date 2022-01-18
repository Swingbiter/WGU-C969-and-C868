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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            LoadReports();
        }

        public void LoadReports()
        {
            typeMonthReport();
            consultantReport();
            addressCountReport();
        }

        public void typeMonthReport()
        {
            string query = $"SELECT COUNT(type), type, date_format(start, '%M') FROM appointment GROUP BY type, date_format(start, '%M')";
            MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<List<string>> appointments = new List<List<string>>();

            while (reader.Read())
            {
                appointments.Add(new List<string> { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() });
            }

            reader.Close();
            conn.Close();

            var apptArray = from row in appointments
                            select new
                            {
                                Month = row[2],
                                Count = row[0],
                                Type = row[1]
                            };


            Console.WriteLine(appointments[0][2]);
            dgv_typeMonth.DataSource = apptArray.ToArray();
            dgv_typeMonth.Refresh();
        }

        public void consultantReport()
        {
            string query = "SELECT userId, customerId, start, end FROM client_schedule.appointment ORDER BY userId";
            MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<List<string>> appointments = new List<List<string>>();

            while (reader.Read())
            {
                appointments.Add(new List<string> { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() });
            }

            reader.Close();
            conn.Close();

            var apptArray = from row in appointments
                            select new
                            {
                                Consultant = DBHelper.getUserName(Convert.ToInt32(row[0])),
                                Customer = DBHelper.getCustomerName(Convert.ToInt32(row[1])),
                                Start = row[2],
                                End = row[3]
                            };


            Console.WriteLine(appointments[0][2]);
            dgv_consultant.DataSource = apptArray.ToArray();
            dgv_consultant.Refresh();
        }

        public void addressCountReport()
        {
            string query = "SELECT COUNT(address), cityId FROM client_schedule.address GROUP BY cityId";
            MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<List<string>> addresses = new List<List<string>>();

            while (reader.Read())
            {
                addresses.Add(new List<string> { reader[0].ToString(), reader[1].ToString() });
            }

            reader.Close();
            conn.Close();

            var addressArray = from row in addresses
                            select new
                            {
                                Count = row[0],
                                City = DBHelper.getCityName(Convert.ToInt32(row[1]))
                            };


            dgv_cityCount.DataSource = addressArray.ToArray();
            dgv_cityCount.Refresh();
        }
    }
}
