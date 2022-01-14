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
            string query = $"SELECT COUNT(type), type, date_format(start, '%M') FROM appointment GROUP BY type, date_format(start, '%M')";
            MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<List<string>> appointments = new List<List<string>>();

            while (reader.Read())
            {
                appointments.Add(new List<string> {reader[0].ToString(), reader[1].ToString(), reader[2].ToString() });
            }

            reader.Close();
            conn.Close();
            dgv_typeMonth.DataSource = appointments;
        }
    }
}
