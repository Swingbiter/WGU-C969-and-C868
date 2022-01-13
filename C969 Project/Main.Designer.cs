
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
            this.dgv_calendar = new System.Windows.Forms.DataGridView();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dgv_customers = new System.Windows.Forms.DataGridView();
            this.btn_customer_add = new System.Windows.Forms.Button();
            this.btn_customer_edit = new System.Windows.Forms.Button();
            this.btn_customer_delete = new System.Windows.Forms.Button();
            this.btn_appt_delete = new System.Windows.Forms.Button();
            this.btn_appt_edit = new System.Windows.Forms.Button();
            this.btn_appt_add = new System.Windows.Forms.Button();
            this.panel_hider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_hider
            // 
            this.panel_hider.Controls.Add(this.btn_appt_delete);
            this.panel_hider.Controls.Add(this.btn_appt_edit);
            this.panel_hider.Controls.Add(this.btn_appt_add);
            this.panel_hider.Controls.Add(this.btn_customer_delete);
            this.panel_hider.Controls.Add(this.btn_customer_edit);
            this.panel_hider.Controls.Add(this.btn_customer_add);
            this.panel_hider.Controls.Add(this.dgv_customers);
            this.panel_hider.Controls.Add(this.radioButton2);
            this.panel_hider.Controls.Add(this.radioButton1);
            this.panel_hider.Controls.Add(this.dgv_calendar);
            this.panel_hider.Controls.Add(this.lbl_welcome);
            this.panel_hider.Location = new System.Drawing.Point(12, 12);
            this.panel_hider.Name = "panel_hider";
            this.panel_hider.Size = new System.Drawing.Size(796, 426);
            this.panel_hider.TabIndex = 0;
            this.panel_hider.Visible = false;
            // 
            // dgv_calendar
            // 
            this.dgv_calendar.AllowUserToAddRows = false;
            this.dgv_calendar.AllowUserToDeleteRows = false;
            this.dgv_calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_calendar.Location = new System.Drawing.Point(393, 69);
            this.dgv_calendar.Name = "dgv_calendar";
            this.dgv_calendar.ReadOnly = true;
            this.dgv_calendar.RowHeadersWidth = 51;
            this.dgv_calendar.RowTemplate.Height = 24;
            this.dgv_calendar.Size = new System.Drawing.Size(381, 290);
            this.dgv_calendar.TabIndex = 1;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(3, 12);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(105, 17);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome, user!";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(664, 367);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Monthly";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(664, 394);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Weekly";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dgv_customers
            // 
            this.dgv_customers.AllowUserToAddRows = false;
            this.dgv_customers.AllowUserToDeleteRows = false;
            this.dgv_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customers.Location = new System.Drawing.Point(6, 69);
            this.dgv_customers.Name = "dgv_customers";
            this.dgv_customers.ReadOnly = true;
            this.dgv_customers.RowHeadersWidth = 51;
            this.dgv_customers.RowTemplate.Height = 24;
            this.dgv_customers.Size = new System.Drawing.Size(381, 290);
            this.dgv_customers.TabIndex = 4;
            // 
            // btn_customer_add
            // 
            this.btn_customer_add.Location = new System.Drawing.Point(6, 365);
            this.btn_customer_add.Name = "btn_customer_add";
            this.btn_customer_add.Size = new System.Drawing.Size(75, 23);
            this.btn_customer_add.TabIndex = 5;
            this.btn_customer_add.Text = "ADD";
            this.btn_customer_add.UseVisualStyleBackColor = true;
            // 
            // btn_customer_edit
            // 
            this.btn_customer_edit.Location = new System.Drawing.Point(87, 365);
            this.btn_customer_edit.Name = "btn_customer_edit";
            this.btn_customer_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_customer_edit.TabIndex = 6;
            this.btn_customer_edit.Text = "EDIT";
            this.btn_customer_edit.UseVisualStyleBackColor = true;
            // 
            // btn_customer_delete
            // 
            this.btn_customer_delete.Location = new System.Drawing.Point(168, 365);
            this.btn_customer_delete.Name = "btn_customer_delete";
            this.btn_customer_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_customer_delete.TabIndex = 7;
            this.btn_customer_delete.Text = "DELETE";
            this.btn_customer_delete.UseVisualStyleBackColor = true;
            // 
            // btn_appt_delete
            // 
            this.btn_appt_delete.Location = new System.Drawing.Point(555, 365);
            this.btn_appt_delete.Name = "btn_appt_delete";
            this.btn_appt_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_appt_delete.TabIndex = 10;
            this.btn_appt_delete.Text = "DELETE";
            this.btn_appt_delete.UseVisualStyleBackColor = true;
            // 
            // btn_appt_edit
            // 
            this.btn_appt_edit.Location = new System.Drawing.Point(474, 365);
            this.btn_appt_edit.Name = "btn_appt_edit";
            this.btn_appt_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_appt_edit.TabIndex = 9;
            this.btn_appt_edit.Text = "EDIT";
            this.btn_appt_edit.UseVisualStyleBackColor = true;
            // 
            // btn_appt_add
            // 
            this.btn_appt_add.Location = new System.Drawing.Point(393, 365);
            this.btn_appt_add.Name = "btn_appt_add";
            this.btn_appt_add.Size = new System.Drawing.Size(75, 23);
            this.btn_appt_add.TabIndex = 8;
            this.btn_appt_add.Text = "ADD";
            this.btn_appt_add.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.panel_hider);
            this.Name = "Main";
            this.Text = "Scheduling";
            this.panel_hider.ResumeLayout(false);
            this.panel_hider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_hider;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.DataGridView dgv_calendar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_appt_delete;
        private System.Windows.Forms.Button btn_appt_edit;
        private System.Windows.Forms.Button btn_appt_add;
        private System.Windows.Forms.Button btn_customer_delete;
        private System.Windows.Forms.Button btn_customer_edit;
        private System.Windows.Forms.Button btn_customer_add;
        private System.Windows.Forms.DataGridView dgv_customers;
    }
}

