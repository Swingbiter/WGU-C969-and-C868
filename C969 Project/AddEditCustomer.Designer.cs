
namespace C969_Project
{
    partial class AddEditCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_addedit = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_addedit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_postal = new System.Windows.Forms.TextBox();
            this.dgv_city = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chkBox_active = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_city)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_addedit
            // 
            this.lbl_addedit.AutoSize = true;
            this.lbl_addedit.Location = new System.Drawing.Point(12, 9);
            this.lbl_addedit.Name = "lbl_addedit";
            this.lbl_addedit.Size = new System.Drawing.Size(55, 13);
            this.lbl_addedit.TabIndex = 0;
            this.lbl_addedit.Text = "Add / Edit";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(85, 52);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // btn_addedit
            // 
            this.btn_addedit.Location = new System.Drawing.Point(15, 191);
            this.btn_addedit.Name = "btn_addedit";
            this.btn_addedit.Size = new System.Drawing.Size(75, 23);
            this.btn_addedit.TabIndex = 2;
            this.btn_addedit.Text = "Add/Edit";
            this.btn_addedit.UseVisualStyleBackColor = true;
            this.btn_addedit.Click += new System.EventHandler(this.btn_addedit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Active:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(85, 104);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 20);
            this.txt_address.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone:";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(85, 156);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 20);
            this.txt_phone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Postal Code:";
            // 
            // txt_postal
            // 
            this.txt_postal.Location = new System.Drawing.Point(85, 130);
            this.txt_postal.Name = "txt_postal";
            this.txt_postal.Size = new System.Drawing.Size(100, 20);
            this.txt_postal.TabIndex = 10;
            // 
            // dgv_city
            // 
            this.dgv_city.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_city.Location = new System.Drawing.Point(213, 52);
            this.dgv_city.MultiSelect = false;
            this.dgv_city.Name = "dgv_city";
            this.dgv_city.RowHeadersVisible = false;
            this.dgv_city.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_city.Size = new System.Drawing.Size(240, 150);
            this.dgv_city.TabIndex = 12;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(96, 191);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Select desired city:";
            // 
            // chkBox_active
            // 
            this.chkBox_active.AutoSize = true;
            this.chkBox_active.Location = new System.Drawing.Point(85, 81);
            this.chkBox_active.Name = "chkBox_active";
            this.chkBox_active.Size = new System.Drawing.Size(15, 14);
            this.chkBox_active.TabIndex = 16;
            this.chkBox_active.UseVisualStyleBackColor = true;
            // 
            // AddEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 232);
            this.Controls.Add(this.chkBox_active);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dgv_city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_postal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addedit);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_addedit);
            this.Name = "AddEditCustomer";
            this.Text = "AddEditCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_city)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_addedit;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_addedit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_postal;
        private System.Windows.Forms.DataGridView dgv_city;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkBox_active;
    }
}