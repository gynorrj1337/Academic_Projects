namespace Grifindo_Lanka_Toys_Employee
{
    partial class Leave_Status_Report_Form
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
            this.Btn_Display = new System.Windows.Forms.Button();
            this.dgv_EmployeeReport = new System.Windows.Forms.DataGridView();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_Report = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmployeeReport)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Display
            // 
            this.Btn_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Display.FlatAppearance.BorderSize = 0;
            this.Btn_Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Display.Font = new System.Drawing.Font("Product Sans Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Display.Location = new System.Drawing.Point(34, 530);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(86, 35);
            this.Btn_Display.TabIndex = 80;
            this.Btn_Display.Text = "Display";
            this.Btn_Display.UseVisualStyleBackColor = false;
            // 
            // dgv_EmployeeReport
            // 
            this.dgv_EmployeeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EmployeeReport.Location = new System.Drawing.Point(34, 199);
            this.dgv_EmployeeReport.Name = "dgv_EmployeeReport";
            this.dgv_EmployeeReport.Size = new System.Drawing.Size(963, 295);
            this.dgv_EmployeeReport.TabIndex = 79;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDate.Location = new System.Drawing.Point(246, 142);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(253, 21);
            this.dtp_EndDate.TabIndex = 76;
            this.dtp_EndDate.Value = new System.DateTime(2024, 8, 8, 0, 0, 0, 0);
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartDate.Location = new System.Drawing.Point(246, 101);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(253, 21);
            this.dtp_StartDate.TabIndex = 75;
            this.dtp_StartDate.Value = new System.DateTime(2024, 8, 8, 0, 0, 0, 0);
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartDate.Location = new System.Drawing.Point(30, 103);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(91, 20);
            this.lbl_StartDate.TabIndex = 74;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndDate.Location = new System.Drawing.Point(30, 143);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(82, 20);
            this.lbl_EndDate.TabIndex = 72;
            this.lbl_EndDate.Text = "End Date";
            // 
            // lbl_Report
            // 
            this.lbl_Report.AutoSize = true;
            this.lbl_Report.Font = new System.Drawing.Font("Product Sans Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Report.Location = new System.Drawing.Point(29, 50);
            this.lbl_Report.Name = "lbl_Report";
            this.lbl_Report.Size = new System.Drawing.Size(246, 30);
            this.lbl_Report.TabIndex = 69;
            this.lbl_Report.Text = "Leave Status Report";
            // 
            // Leave_Status_Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 673);
            this.Controls.Add(this.Btn_Display);
            this.Controls.Add(this.dgv_EmployeeReport);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.lbl_Report);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Leave_Status_Report_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave_Report_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmployeeReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Display;
        private System.Windows.Forms.DataGridView dgv_EmployeeReport;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_Report;
    }
}