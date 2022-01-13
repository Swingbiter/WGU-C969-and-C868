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
        public AddEditAppt()
        {
            InitializeComponent();
            LoadCust();
            btn_addedit.Text = "Add";
            dtp_end.Value.AddHours(1);
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
            foreach (DataGridViewRow row in dgv_customers.Rows)
            {
                if ((int)row.Cells[0].Value == _apptId)
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

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
