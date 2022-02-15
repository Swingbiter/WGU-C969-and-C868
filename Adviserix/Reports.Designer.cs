
namespace Adviserix
{
    partial class Reports
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
            this.dgv_typeMonth = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_consultant = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_cityCount = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_typeMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cityCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_typeMonth
            // 
            this.dgv_typeMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_typeMonth.Location = new System.Drawing.Point(16, 31);
            this.dgv_typeMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_typeMonth.MultiSelect = false;
            this.dgv_typeMonth.Name = "dgv_typeMonth";
            this.dgv_typeMonth.RowHeadersVisible = false;
            this.dgv_typeMonth.RowHeadersWidth = 51;
            this.dgv_typeMonth.Size = new System.Drawing.Size(320, 185);
            this.dgv_typeMonth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment Types By Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consultant Schedules";
            // 
            // dgv_consultant
            // 
            this.dgv_consultant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultant.Location = new System.Drawing.Point(344, 31);
            this.dgv_consultant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_consultant.MultiSelect = false;
            this.dgv_consultant.Name = "dgv_consultant";
            this.dgv_consultant.RowHeadersVisible = false;
            this.dgv_consultant.RowHeadersWidth = 51;
            this.dgv_consultant.Size = new System.Drawing.Size(320, 185);
            this.dgv_consultant.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address Count By City";
            // 
            // dgv_cityCount
            // 
            this.dgv_cityCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cityCount.Location = new System.Drawing.Point(672, 31);
            this.dgv_cityCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_cityCount.MultiSelect = false;
            this.dgv_cityCount.Name = "dgv_cityCount";
            this.dgv_cityCount.RowHeadersVisible = false;
            this.dgv_cityCount.RowHeadersWidth = 51;
            this.dgv_cityCount.Size = new System.Drawing.Size(320, 185);
            this.dgv_cityCount.TabIndex = 4;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 242);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_cityCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_consultant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_typeMonth);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reports";
            this.Text = "Reports [TIME STAMP]";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_typeMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cityCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_typeMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_consultant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_cityCount;
    }
}