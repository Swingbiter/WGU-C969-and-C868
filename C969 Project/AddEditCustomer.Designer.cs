
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_addedit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dgv_city = new System.Windows.Forms.DataGridView();
            this.dgv_country = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_city)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_country)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(85, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // dgv_city
            // 
            this.dgv_city.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_city.Location = new System.Drawing.Point(212, 9);
            this.dgv_city.MultiSelect = false;
            this.dgv_city.Name = "dgv_city";
            this.dgv_city.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_city.Size = new System.Drawing.Size(240, 150);
            this.dgv_city.TabIndex = 12;
            // 
            // dgv_country
            // 
            this.dgv_country.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_country.Location = new System.Drawing.Point(212, 165);
            this.dgv_country.MultiSelect = false;
            this.dgv_country.Name = "dgv_country";
            this.dgv_country.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_country.Size = new System.Drawing.Size(240, 150);
            this.dgv_country.TabIndex = 13;
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
            // AddEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 327);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dgv_country);
            this.Controls.Add(this.dgv_city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addedit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_addedit);
            this.Name = "AddEditCustomer";
            this.Text = "AddEditCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_city)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_country)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_addedit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_addedit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dgv_city;
        private System.Windows.Forms.DataGridView dgv_country;
        private System.Windows.Forms.Button btn_cancel;
    }
}