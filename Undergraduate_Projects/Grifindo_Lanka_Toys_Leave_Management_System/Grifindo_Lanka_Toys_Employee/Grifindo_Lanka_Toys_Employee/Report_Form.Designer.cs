namespace Grifindo_Lanka_Toys_Employee
{
    partial class Report_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Form));
            this.lbl_Report = new System.Windows.Forms.Label();
            this.Pnl_Management_Form = new System.Windows.Forms.Panel();
            this.Btn_LeaveHistory = new System.Windows.Forms.Button();
            this.Pnl_Management_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Report
            // 
            this.lbl_Report.AutoSize = true;
            this.lbl_Report.Font = new System.Drawing.Font("Product Sans Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Report.Location = new System.Drawing.Point(103, 61);
            this.lbl_Report.Name = "lbl_Report";
            this.lbl_Report.Size = new System.Drawing.Size(103, 34);
            this.lbl_Report.TabIndex = 10;
            this.lbl_Report.Text = "Report";
            // 
            // Pnl_Management_Form
            // 
            this.Pnl_Management_Form.BackColor = System.Drawing.SystemColors.Window;
            this.Pnl_Management_Form.Controls.Add(this.Btn_LeaveHistory);
            this.Pnl_Management_Form.Controls.Add(this.lbl_Report);
            this.Pnl_Management_Form.Location = new System.Drawing.Point(1, 1);
            this.Pnl_Management_Form.Name = "Pnl_Management_Form";
            this.Pnl_Management_Form.Size = new System.Drawing.Size(1027, 673);
            this.Pnl_Management_Form.TabIndex = 2;
            // 
            // Btn_LeaveHistory
            // 
            this.Btn_LeaveHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_LeaveHistory.FlatAppearance.BorderSize = 0;
            this.Btn_LeaveHistory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Btn_LeaveHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LeaveHistory.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LeaveHistory.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LeaveHistory.Image")));
            this.Btn_LeaveHistory.Location = new System.Drawing.Point(109, 110);
            this.Btn_LeaveHistory.Name = "Btn_LeaveHistory";
            this.Btn_LeaveHistory.Size = new System.Drawing.Size(150, 150);
            this.Btn_LeaveHistory.TabIndex = 11;
            this.Btn_LeaveHistory.Text = "Leave History";
            this.Btn_LeaveHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_LeaveHistory.UseVisualStyleBackColor = true;
            this.Btn_LeaveHistory.Click += new System.EventHandler(this.Btn_LeaveHistory_Click);
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 673);
            this.Controls.Add(this.Pnl_Management_Form);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Report_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_Form";
            this.Pnl_Management_Form.ResumeLayout(false);
            this.Pnl_Management_Form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Report;
        private System.Windows.Forms.Panel Pnl_Management_Form;
        private System.Windows.Forms.Button Btn_LeaveHistory;
    }
}