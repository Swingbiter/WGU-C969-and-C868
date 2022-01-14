
namespace C969_Project
{
    partial class AddEditAppt
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
            this.dgv_customers = new System.Windows.Forms.DataGridView();
            this.lbl_select_cust = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.btn_addedit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_customers
            // 
            this.dgv_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customers.Location = new System.Drawing.Point(12, 34);
            this.dgv_customers.MultiSelect = false;
            this.dgv_customers.Name = "dgv_customers";
            this.dgv_customers.RowHeadersVisible = false;
            this.dgv_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customers.Size = new System.Drawing.Size(240, 150);
            this.dgv_customers.TabIndex = 0;
            // 
            // lbl_select_cust
            // 
            this.lbl_select_cust.AutoSize = true;
            this.lbl_select_cust.Location = new System.Drawing.Point(9, 18);
            this.lbl_select_cust.Name = "lbl_select_cust";
            this.lbl_select_cust.Size = new System.Drawing.Size(87, 13);
            this.lbl_select_cust.TabIndex = 1;
            this.lbl_select_cust.Text = "Select Customer:";
            // 
            // dtp_start
            // 
            this.dtp_start.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start.Location = new System.Drawing.Point(52, 227);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_start.TabIndex = 2;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(152, 201);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(100, 20);
            this.txt_type.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "End:";
            // 
            // dtp_end
            // 
            this.dtp_end.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end.Location = new System.Drawing.Point(52, 253);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 20);
            this.dtp_end.TabIndex = 6;
            // 
            // btn_addedit
            // 
            this.btn_addedit.Location = new System.Drawing.Point(12, 297);
            this.btn_addedit.Name = "btn_addedit";
            this.btn_addedit.Size = new System.Drawing.Size(75, 23);
            this.btn_addedit.TabIndex = 8;
            this.btn_addedit.Text = "Add/Edit";
            this.btn_addedit.UseVisualStyleBackColor = true;
            this.btn_addedit.Click += new System.EventHandler(this.btn_addedit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(177, 297);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddEditAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 352);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addedit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.lbl_select_cust);
            this.Controls.Add(this.dgv_customers);
            this.Name = "AddEditAppt";
            this.Text = "AddEditAppt";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_customers;
        private System.Windows.Forms.Label lbl_select_cust;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Button btn_addedit;
        private System.Windows.Forms.Button btn_cancel;
    }
}