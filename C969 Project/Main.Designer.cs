
namespace C969_Project
{
    partial class Main
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
            this.panel_hider = new System.Windows.Forms.Panel();
            this.txtBox_search = new System.Windows.Forms.TextBox();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_appt_delete = new System.Windows.Forms.Button();
            this.btn_appt_edit = new System.Windows.Forms.Button();
            this.btn_appt_add = new System.Windows.Forms.Button();
            this.btn_customer_delete = new System.Windows.Forms.Button();
            this.btn_customer_edit = new System.Windows.Forms.Button();
            this.btn_customer_add = new System.Windows.Forms.Button();
            this.dgv_customers = new System.Windows.Forms.DataGridView();
            this.dgv_calendar = new System.Windows.Forms.DataGridView();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_hider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_hider
            // 
            this.panel_hider.Controls.Add(this.label3);
            this.panel_hider.Controls.Add(this.label2);
            this.panel_hider.Controls.Add(this.label1);
            this.panel_hider.Controls.Add(this.txtBox_search);
            this.panel_hider.Controls.Add(this.btn_reports);
            this.panel_hider.Controls.Add(this.btn_appt_delete);
            this.panel_hider.Controls.Add(this.btn_appt_edit);
            this.panel_hider.Controls.Add(this.btn_appt_add);
            this.panel_hider.Controls.Add(this.btn_customer_delete);
            this.panel_hider.Controls.Add(this.btn_customer_edit);
            this.panel_hider.Controls.Add(this.btn_customer_add);
            this.panel_hider.Controls.Add(this.dgv_customers);
            this.panel_hider.Controls.Add(this.dgv_calendar);
            this.panel_hider.Controls.Add(this.lbl_welcome);
            this.panel_hider.Location = new System.Drawing.Point(9, 10);
            this.panel_hider.Margin = new System.Windows.Forms.Padding(2);
            this.panel_hider.Name = "panel_hider";
            this.panel_hider.Size = new System.Drawing.Size(597, 346);
            this.panel_hider.TabIndex = 0;
            this.panel_hider.Visible = false;
            // 
            // txtBox_search
            // 
            this.txtBox_search.Location = new System.Drawing.Point(189, 34);
            this.txtBox_search.Name = "txtBox_search";
            this.txtBox_search.Size = new System.Drawing.Size(101, 20);
            this.txtBox_search.TabIndex = 12;
            this.txtBox_search.TextChanged += new System.EventHandler(this.txtBox_search_TextChanged);
            // 
            // btn_reports
            // 
            this.btn_reports.Location = new System.Drawing.Point(519, 27);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(62, 26);
            this.btn_reports.TabIndex = 11;
            this.btn_reports.Text = "Reports";
            this.btn_reports.UseVisualStyleBackColor = true;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_appt_delete
            // 
            this.btn_appt_delete.Location = new System.Drawing.Point(519, 319);
            this.btn_appt_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_appt_delete.Name = "btn_appt_delete";
            this.btn_appt_delete.Size = new System.Drawing.Size(61, 19);
            this.btn_appt_delete.TabIndex = 10;
            this.btn_appt_delete.Text = "DELETE";
            this.btn_appt_delete.UseVisualStyleBackColor = true;
            this.btn_appt_delete.Click += new System.EventHandler(this.btn_appt_delete_Click);
            // 
            // btn_appt_edit
            // 
            this.btn_appt_edit.Location = new System.Drawing.Point(519, 296);
            this.btn_appt_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_appt_edit.Name = "btn_appt_edit";
            this.btn_appt_edit.Size = new System.Drawing.Size(62, 19);
            this.btn_appt_edit.TabIndex = 9;
            this.btn_appt_edit.Text = "EDIT";
            this.btn_appt_edit.UseVisualStyleBackColor = true;
            this.btn_appt_edit.Click += new System.EventHandler(this.btn_appt_edit_Click);
            // 
            // btn_appt_add
            // 
            this.btn_appt_add.Location = new System.Drawing.Point(295, 297);
            this.btn_appt_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_appt_add.Name = "btn_appt_add";
            this.btn_appt_add.Size = new System.Drawing.Size(56, 19);
            this.btn_appt_add.TabIndex = 8;
            this.btn_appt_add.Text = "ADD";
            this.btn_appt_add.UseVisualStyleBackColor = true;
            this.btn_appt_add.Click += new System.EventHandler(this.btn_appt_add_Click);
            // 
            // btn_customer_delete
            // 
            this.btn_customer_delete.Location = new System.Drawing.Point(228, 319);
            this.btn_customer_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_customer_delete.Name = "btn_customer_delete";
            this.btn_customer_delete.Size = new System.Drawing.Size(62, 19);
            this.btn_customer_delete.TabIndex = 7;
            this.btn_customer_delete.Text = "DELETE";
            this.btn_customer_delete.UseVisualStyleBackColor = true;
            this.btn_customer_delete.Click += new System.EventHandler(this.btn_customer_delete_Click);
            // 
            // btn_customer_edit
            // 
            this.btn_customer_edit.Location = new System.Drawing.Point(228, 296);
            this.btn_customer_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_customer_edit.Name = "btn_customer_edit";
            this.btn_customer_edit.Size = new System.Drawing.Size(62, 19);
            this.btn_customer_edit.TabIndex = 6;
            this.btn_customer_edit.Text = "EDIT";
            this.btn_customer_edit.UseVisualStyleBackColor = true;
            this.btn_customer_edit.Click += new System.EventHandler(this.btn_customer_edit_Click);
            // 
            // btn_customer_add
            // 
            this.btn_customer_add.Location = new System.Drawing.Point(4, 297);
            this.btn_customer_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_customer_add.Name = "btn_customer_add";
            this.btn_customer_add.Size = new System.Drawing.Size(56, 19);
            this.btn_customer_add.TabIndex = 5;
            this.btn_customer_add.Text = "ADD";
            this.btn_customer_add.UseVisualStyleBackColor = true;
            this.btn_customer_add.Click += new System.EventHandler(this.btn_customer_add_Click);
            // 
            // dgv_customers
            // 
            this.dgv_customers.AllowUserToAddRows = false;
            this.dgv_customers.AllowUserToDeleteRows = false;
            this.dgv_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customers.Location = new System.Drawing.Point(4, 56);
            this.dgv_customers.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_customers.MultiSelect = false;
            this.dgv_customers.Name = "dgv_customers";
            this.dgv_customers.ReadOnly = true;
            this.dgv_customers.RowHeadersVisible = false;
            this.dgv_customers.RowHeadersWidth = 51;
            this.dgv_customers.RowTemplate.Height = 24;
            this.dgv_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customers.Size = new System.Drawing.Size(286, 236);
            this.dgv_customers.TabIndex = 4;
            // 
            // dgv_calendar
            // 
            this.dgv_calendar.AllowUserToAddRows = false;
            this.dgv_calendar.AllowUserToDeleteRows = false;
            this.dgv_calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_calendar.Location = new System.Drawing.Point(295, 56);
            this.dgv_calendar.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_calendar.MultiSelect = false;
            this.dgv_calendar.Name = "dgv_calendar";
            this.dgv_calendar.ReadOnly = true;
            this.dgv_calendar.RowHeadersVisible = false;
            this.dgv_calendar.RowHeadersWidth = 51;
            this.dgv_calendar.RowTemplate.Height = 24;
            this.dgv_calendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_calendar.Size = new System.Drawing.Size(286, 236);
            this.dgv_calendar.TabIndex = 1;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(-3, -1);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(81, 13);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome, user!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Appointments:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 366);
            this.Controls.Add(this.panel_hider);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Scheduling";
            this.panel_hider.ResumeLayout(false);
            this.panel_hider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_hider;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.DataGridView dgv_calendar;
        private System.Windows.Forms.Button btn_appt_delete;
        private System.Windows.Forms.Button btn_appt_edit;
        private System.Windows.Forms.Button btn_appt_add;
        private System.Windows.Forms.Button btn_customer_delete;
        private System.Windows.Forms.Button btn_customer_edit;
        private System.Windows.Forms.Button btn_customer_add;
        private System.Windows.Forms.DataGridView dgv_customers;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.TextBox txtBox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

