using System;
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
using System.Globalization;
using System.Text.RegularExpressions;

namespace C969_Project
{
    public partial class AddEditCustomer : Form
    {
        public AddEditCustomer()
        {
            InitializeComponent();
            this.Text = "Add Customer";
            lbl_addedit.Text = "Add";
            btn_addedit.Text = "Add";
            load_DGV();
        }
        public void load_DGV()
        {
            dgv_city.DataSource = DBHelper.getCityData();
        }

        

        public virtual void btn_addedit_Click(object sender, EventArgs e)
        {
            if (
                    string.IsNullOrEmpty(txt_name.Text) ||
                    string.IsNullOrEmpty(txt_address.Text) ||
                    string.IsNullOrEmpty(txt_phone.Text) ||
                    string.IsNullOrEmpty(txt_postal.Text)
                    )
            {
                MessageBox.Show("Fields must not be empty!");
                return;
            }
            string name = txt_name.Text;
            string address = txt_address.Text;
            string phone = txt_phone.Text;
            string postal = txt_postal.Text;
            int active = 0;
            int city = (int)dgv_city.SelectedRows[0].Cells[0].Value;

            if (chkBox_active.Checked) { active = 1; }

            MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
            conn.Open();

            // address insert
            string insertStatement = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                $"VALUES ('{address}', '', '{city}', '{postal}', '{phone}', '{DBHelper.getTodayTimeStamp()}', '{DBHelper.currentUserName}', '{DBHelper.getTodayTimeStamp()}', '{DBHelper.currentUserName}')";

            MySqlCommand cmd = new MySqlCommand(insertStatement, conn);
            cmd.ExecuteNonQuery();

            // customer insert
            insertStatement = "INSERT INTO customer (customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                $"VALUES ('{name}', '{DBHelper.getLastId("address")}', '{active}', '{DBHelper.getTodayTimeStamp()}', '{DBHelper.currentUserName}', '{DBHelper.getTodayTimeStamp()}', '{DBHelper.currentUserName}')";
            cmd = new MySqlCommand(insertStatement, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class EditCustomer : AddEditCustomer
    {
        int _customerId = 0;

        public EditCustomer (int customerId)
        {
            _customerId = customerId;
            this.Text = "Edit Customer";
            lbl_addedit.Text = "Edit";
            btn_addedit.Text = "Edit";
            load_customer();
        }

        public void load_customer()
        {
            Dictionary<string, string> customerData = DBHelper.getCustomerData(_customerId);
            txt_name.Text = customerData["customerName"];
            txt_address.Text = customerData["address"];
            txt_postal.Text = customerData["zip"];
            txt_phone.Text = customerData["phone"];
            bool active = Convert.ToBoolean(customerData["active"]);

            int addressId = Convert.ToInt32(customerData["addressId"]);
            foreach (DataGridViewRow row in dgv_city.Rows)
            {
                if ((int)row.Cells[0].Value == addressId)
                {
                    row.Selected = true;
                    dgv_city.CurrentCell = row.Cells[0];
                }

            }

            if (active)
            {
                chkBox_active.Checked = true;
            }
        }

        // polymorph
        public override void btn_addedit_Click(object sender, EventArgs e)
        {
            // validations
            if (
                    string.IsNullOrEmpty(txt_name.Text) ||
                    string.IsNullOrEmpty(txt_address.Text) ||
                    string.IsNullOrEmpty(txt_phone.Text) ||
                    string.IsNullOrEmpty(txt_postal.Text)
                    )
            {
                MessageBox.Show("Fields must not be empty!");
                return;
            }
            //

            string name = txt_name.Text;
            string address = txt_address.Text;
            string phone = txt_phone.Text;
            string postal = txt_postal.Text;
            int active = 0;
            int city = (int)dgv_city.SelectedRows[0].Cells[0].Value;

            if (chkBox_active.Checked)
            {
                active = 1;
            }

            MySqlConnection conn = new MySqlConnection(DBHelper.connection_string);
            conn.Open();

            Dictionary<string, string> customerData = DBHelper.getCustomerData(_customerId);
            string updateStatement = $"UPDATE customer SET customerName = '{name}', active = '{active}', lastUpdate = '{DBHelper.getTodayTimeStamp()}', lastUpdateBy = '{DBHelper.currentUserName}'" +
                $"WHERE customerId = '{_customerId}'";
            MySqlCommand cmd = new MySqlCommand(updateStatement, conn);
            cmd.ExecuteNonQuery();

            updateStatement = $"UPDATE address SET address = '{address}', phone = '{phone}', cityId = {city}, lastUpdate = '{DBHelper.getTodayTimeStamp()}', lastUpdateBy = '{DBHelper.currentUserName}'" +
                $"WHERE addressId = '{customerData["addressId"]}'";
            cmd = new MySqlCommand(updateStatement, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            this.Close();
        }
    }
}
