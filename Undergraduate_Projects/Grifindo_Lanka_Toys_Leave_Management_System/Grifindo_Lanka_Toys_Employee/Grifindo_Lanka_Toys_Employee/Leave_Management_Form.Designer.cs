namespace Grifindo_Lanka_Toys_Employee
{
    partial class Leave_Management_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leave_Management_Form));
            this.Btn_AddLeave = new System.Windows.Forms.Button();
            this.Management_Form_Panel = new System.Windows.Forms.Panel();
            this.Management_Label = new System.Windows.Forms.Label();
            this.Btn_LeaveHistory = new System.Windows.Forms.Button();
            this.Btn_LeaveStatus = new System.Windows.Forms.Button();
            this.Management_Form_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_AddLeave
            // 
            this.Btn_AddLeave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_AddLeave.FlatAppearance.BorderSize = 0;
            this.Btn_AddLeave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Btn_AddLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddLeave.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddLeave.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AddLeave.Image")));
            this.Btn_AddLeave.Location = new System.Drawing.Point(109, 110);
            this.Btn_AddLeave.Name = "Btn_AddLeave";
            this.Btn_AddLeave.Size = new System.Drawing.Size(150, 150);
            this.Btn_AddLeave.TabIndex = 0;
            this.Btn_AddLeave.Text = "Request Leave";
            this.Btn_AddLeave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_AddLeave.UseVisualStyleBackColor = true;
            this.Btn_AddLeave.Click += new System.EventHandler(this.Btn_AddLeave_Click);
            // 
            // Management_Form_Panel
            // 
            this.Management_Form_Panel.BackColor = System.Drawing.SystemColors.Window;
            this.Management_Form_Panel.Controls.Add(this.Management_Label);
            this.Management_Form_Panel.Controls.Add(this.Btn_LeaveHistory);
            this.Management_Form_Panel.Controls.Add(this.Btn_LeaveStatus);
            this.Management_Form_Panel.Controls.Add(this.Btn_AddLeave);
            this.Management_Form_Panel.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.Management_Form_Panel.Location = new System.Drawing.Point(1, 1);
            this.Management_Form_Panel.Name = "Management_Form_Panel";
            this.Management_Form_Panel.Size = new System.Drawing.Size(1027, 673);
            this.Management_Form_Panel.TabIndex = 2;
            // 
            // Management_Label
            // 
            this.Management_Label.AutoSize = true;
            this.Management_Label.Font = new System.Drawing.Font("Product Sans Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Management_Label.Location = new System.Drawing.Point(103, 61);
            this.Management_Label.Name = "Management_Label";
            this.Management_Label.Size = new System.Drawing.Size(268, 34);
            this.Management_Label.TabIndex = 10;
            this.Management_Label.Text = "Leave Management";
            // 
            // Btn_LeaveHistory
            // 
            this.Btn_LeaveHistory.FlatAppearance.BorderSize = 0;
            this.Btn_LeaveHistory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Btn_LeaveHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LeaveHistory.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LeaveHistory.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LeaveHistory.Image")));
            this.Btn_LeaveHistory.Location = new System.Drawing.Point(421, 110);
            this.Btn_LeaveHistory.Name = "Btn_LeaveHistory";
            this.Btn_LeaveHistory.Size = new System.Drawing.Size(150, 150);
            this.Btn_LeaveHistory.TabIndex = 4;
            this.Btn_LeaveHistory.Text = "Leave History";
            this.Btn_LeaveHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_LeaveHistory.UseVisualStyleBackColor = true;
            this.Btn_LeaveHistory.Click += new System.EventHandler(this.Btn_LeaveHistory_Click);
            // 
            // Btn_LeaveStatus
            // 
            this.Btn_LeaveStatus.FlatAppearance.BorderSize = 0;
            this.Btn_LeaveStatus.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Btn_LeaveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LeaveStatus.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LeaveStatus.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LeaveStatus.Image")));
            this.Btn_LeaveStatus.Location = new System.Drawing.Point(265, 110);
            this.Btn_LeaveStatus.Name = "Btn_LeaveStatus";
            this.Btn_LeaveStatus.Size = new System.Drawing.Size(150, 150);
            this.Btn_LeaveStatus.TabIndex = 1;
            this.Btn_LeaveStatus.Text = "Leave Status";
            this.Btn_LeaveStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_LeaveStatus.UseVisualStyleBackColor = true;
            this.Btn_LeaveStatus.Click += new System.EventHandler(this.Btn_LeaveStatus_Click);
            // 
            // Leave_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 673);
            this.Controls.Add(this.Management_Form_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leave_Management_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave_Management_Form";
            this.Management_Form_Panel.ResumeLayout(false);
            this.Management_Form_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddLeave;
        private System.Windows.Forms.Panel Management_Form_Panel;
        private System.Windows.Forms.Label Management_Label;
        private System.Windows.Forms.Button Btn_LeaveHistory;
        private System.Windows.Forms.Button Btn_LeaveStatus;
    }
}