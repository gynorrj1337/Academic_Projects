namespace Grifindo_Lanka_Toys_Admin
{
    partial class Employee_Leave_Report_Form
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
            this.lbl_Report = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.cmb_EmployeeID = new System.Windows.Forms.ComboBox();
            this.lbl_EmployeeID = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.txt_EmployeeName = new System.Windows.Forms.TextBox();
            this.lbl_EmployeeName = new System.Windows.Forms.Label();
            this.Btn_Display = new System.Windows.Forms.Button();
            this.dgv_History = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Report
            // 
            this.lbl_Report.AutoSize = true;
            this.lbl_Report.Font = new System.Drawing.Font("Product Sans Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Report.Location = new System.Drawing.Point(30, 49);
            this.lbl_Report.Name = "lbl_Report";
            this.lbl_Report.Size = new System.Drawing.Size(202, 30);
            this.lbl_Report.TabIndex = 11;
            this.lbl_Report.Text = "Employee Leave";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartDate.Location = new System.Drawing.Point(247, 135);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(253, 21);
            this.dtp_StartDate.TabIndex = 63;
            this.dtp_StartDate.Value = new System.DateTime(2024, 8, 8, 0, 0, 0, 0);
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartDate.Location = new System.Drawing.Point(31, 137);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(91, 20);
            this.lbl_StartDate.TabIndex = 62;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndDate.Location = new System.Drawing.Point(31, 177);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(82, 20);
            this.lbl_EndDate.TabIndex = 58;
            this.lbl_EndDate.Text = "End Date";
            // 
            // cmb_EmployeeID
            // 
            this.cmb_EmployeeID.FormattingEnabled = true;
            this.cmb_EmployeeID.Location = new System.Drawing.Point(247, 93);
            this.cmb_EmployeeID.Name = "cmb_EmployeeID";
            this.cmb_EmployeeID.Size = new System.Drawing.Size(253, 22);
            this.cmb_EmployeeID.TabIndex = 56;
            this.cmb_EmployeeID.Leave += new System.EventHandler(this.cmb_EmployeeID_Leave);
            // 
            // lbl_EmployeeID
            // 
            this.lbl_EmployeeID.AutoSize = true;
            this.lbl_EmployeeID.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmployeeID.Location = new System.Drawing.Point(31, 97);
            this.lbl_EmployeeID.Name = "lbl_EmployeeID";
            this.lbl_EmployeeID.Size = new System.Drawing.Size(100, 20);
            this.lbl_EmployeeID.TabIndex = 55;
            this.lbl_EmployeeID.Text = "Employe ID";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDate.Location = new System.Drawing.Point(247, 176);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(253, 21);
            this.dtp_EndDate.TabIndex = 64;
            this.dtp_EndDate.Value = new System.DateTime(2024, 8, 8, 0, 0, 0, 0);
            // 
            // txt_EmployeeName
            // 
            this.txt_EmployeeName.BackColor = System.Drawing.SystemColors.Window;
            this.txt_EmployeeName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_EmployeeName.Location = new System.Drawing.Point(710, 95);
            this.txt_EmployeeName.Name = "txt_EmployeeName";
            this.txt_EmployeeName.ReadOnly = true;
            this.txt_EmployeeName.Size = new System.Drawing.Size(223, 21);
            this.txt_EmployeeName.TabIndex = 66;
            // 
            // lbl_EmployeeName
            // 
            this.lbl_EmployeeName.AutoSize = true;
            this.lbl_EmployeeName.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmployeeName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_EmployeeName.Location = new System.Drawing.Point(565, 95);
            this.lbl_EmployeeName.Name = "lbl_EmployeeName";
            this.lbl_EmployeeName.Size = new System.Drawing.Size(139, 20);
            this.lbl_EmployeeName.TabIndex = 65;
            this.lbl_EmployeeName.Text = "Employee Name";
            // 
            // Btn_Display
            // 
            this.Btn_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Display.FlatAppearance.BorderSize = 0;
            this.Btn_Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Display.Font = new System.Drawing.Font("Product Sans Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Display.Location = new System.Drawing.Point(22, 585);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(86, 35);
            this.Btn_Display.TabIndex = 68;
            this.Btn_Display.Text = "Display";
            this.Btn_Display.UseVisualStyleBackColor = false;
            this.Btn_Display.Click += new System.EventHandler(this.Btn_Display_Click);
            // 
            // dgv_History
            // 
            this.dgv_History.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_History.BackgroundColor = System.Drawing.Color.White;
            this.dgv_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_History.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.dgv_History.Location = new System.Drawing.Point(22, 229);
            this.dgv_History.Name = "dgv_History";
            this.dgv_History.Size = new System.Drawing.Size(980, 335);
            this.dgv_History.TabIndex = 69;
            // 
            // Employee_Leave_Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 673);
            this.Controls.Add(this.dgv_History);
            this.Controls.Add(this.Btn_Display);
            this.Controls.Add(this.txt_EmployeeName);
            this.Controls.Add(this.lbl_EmployeeName);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.cmb_EmployeeID);
            this.Controls.Add(this.lbl_EmployeeID);
            this.Controls.Add(this.lbl_Report);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Employee_Leave_Report_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Leave_Report_Form";
            this.Load += new System.EventHandler(this.Employee_Leave_Report_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Report;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.ComboBox cmb_EmployeeID;
        private System.Windows.Forms.Label lbl_EmployeeID;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.TextBox txt_EmployeeName;
        private System.Windows.Forms.Label lbl_EmployeeName;
        private System.Windows.Forms.Button Btn_Display;
        private System.Windows.Forms.DataGridView dgv_History;
    }
}