using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Project
{
    public partial class AddEditCustomer : Form
    {
        public bool editMode = false;
        int _customerId = 0;
        public AddEditCustomer()
        {
            InitializeComponent();
            this.Text = "Add Customer";
            lbl_addedit.Text = "Add";
            btn_addedit.Text = "Add";
        }

        public AddEditCustomer(int customerId)
        {
            InitializeComponent();
            editMode = true;
            _customerId = customerId;
            this.Text = "Edit Customer";
            lbl_addedit.Text = "Edit";
            btn_addedit.Text = "Edit";
        }

        public void load_DGV()
        {
            
        }

        private void btn_addedit_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
