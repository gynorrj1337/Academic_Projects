namespace Grifindo_Lanka_Toys_Admin
{
    partial class Employee_Management_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Management_Form));
            this.Management_Form_Panel = new System.Windows.Forms.Panel();
            this.Management_Label = new System.Windows.Forms.Label();
            this.Btn_Roster = new System.Windows.Forms.Button();
            this.Btn_LeaveApproval = new System.Windows.Forms.Button();
            this.Btn_LeavePolicy = new System.Windows.Forms.Button();
            this.Btn_RegisterEmployee = new System.Windows.Forms.Button();
            this.Management_Form_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Management_Form_Panel
            // 
            this.Management_Form_Panel.BackColor = System.Drawing.SystemColors.Window;
            this.Management_Form_Panel.Controls.Add(this.Management_Label);
            this.Management_Form_Panel.Controls.Add(this.Btn_Roster);
            this.Management_Form_Panel.Controls.Add(this.Btn_LeaveApproval);
            this.Management_Form_Panel.Controls.Add(this.Btn_LeavePolicy);
            this.Management_Form_Panel.Controls.Add(this.Btn_RegisterEmployee);
            this.Management_Form_Panel.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.Management_Form_Panel.Location = new System.Drawing.Point(1, 1);
            this.Management_Form_Panel.Name = "Management_Form_Panel";
            this.Management_Form_Panel.Size = new System.Drawing.Size(1027, 673);
            this.Management_Form_Panel.TabIndex = 1;
            this.Management_Form_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Management_Form_Panel_Paint);
            // 
            // Management_Label
            // 
            this.Management_Label.AutoSize = true;
            this.Management_Label.Font = new System.Drawing.Font("Product Sans Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Management_Label.Location = new System.Drawing.Point(103, 61);
            this.Management_Label.Name = "Management_Label";
            this.Management_Label.Size = new System.Drawing.Size(316, 34);
            this.Management_Label.TabIndex = 10;
            this.Management_Label.Text = "Employee Management";
            this.Management_Label.Click += new System.EventHandler(this.Management_Label_Click);
            // 
            // Btn_Roster
            // 
            this.Btn_Roster.FlatAppearance.BorderSize = 0;
            this.Btn_Roster.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Btn_Roster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Roster.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Roster.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Roster.Image")));
            this.Btn_Roster.Location = new System.Drawing.Point(441, 110);
            this.Btn_Roster.Name = "Btn_Roster";
            this.Btn_Roster.Size = new System.Drawing.Size(150, 150);
            this.Btn_Roster.TabIndex = 4;
            this.Btn_Roster.Text = "Roster";
            this.Btn_Roster.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Roster.UseVisualStyleBackColor = true;
            this.Btn_Roster.Click += new System.EventHandler(this.Btn_Roster_Click);
            // 
            // Btn_LeaveApproval
            // 
            this.Btn_LeaveApproval.FlatAppearance.BorderSize = 0;
            this.Btn_LeaveApproval.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Btn_LeaveApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LeaveApproval.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LeaveApproval.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LeaveApproval.Image")));
            this.Btn_LeaveApproval.Location = new System.Drawing.Point(597, 110);
            this.Btn_LeaveApproval.Name = "Btn_LeaveApproval";
            this.Btn_LeaveApproval.Size = new System.Drawing.Size(150, 150);
            this.Btn_LeaveApproval.TabIndex = 2;
            this.Btn_LeaveApproval.Text = "Leave Approval";
            this.Btn_LeaveApproval.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_LeaveApproval.UseVisualStyleBackColor = true;
            this.Btn_LeaveApproval.Click += new System.EventHandler(this.Btn_LeaveApproval_Click);
            // 
            // Btn_LeavePolicy
            // 
            this.Btn_LeavePolicy.FlatAppearance.BorderSize = 0;
            this.Btn_LeavePolicy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Btn_LeavePolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LeavePolicy.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LeavePolicy.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LeavePolicy.Image")));
            this.Btn_LeavePolicy.Location = new System.Drawing.Point(285, 110);
            this.Btn_LeavePolicy.Name = "Btn_LeavePolicy";
            this.Btn_LeavePolicy.Size = new System.Drawing.Size(150, 150);
            this.Btn_LeavePolicy.TabIndex = 1;
            this.Btn_LeavePolicy.Text = "Leave Policy";
            this.Btn_LeavePolicy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_LeavePolicy.UseVisualStyleBackColor = true;
            this.Btn_LeavePolicy.Click += new System.EventHandler(this.Btn_LeavePolicy_Click);
            // 
            // Btn_RegisterEmployee
            // 
            this.Btn_RegisterEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_RegisterEmployee.FlatAppearance.BorderSize = 0;
            this.Btn_RegisterEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Btn_RegisterEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RegisterEmployee.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RegisterEmployee.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RegisterEmployee.Image")));
            this.Btn_RegisterEmployee.Location = new System.Drawing.Point(109, 110);
            this.Btn_RegisterEmployee.Name = "Btn_RegisterEmployee";
            this.Btn_RegisterEmployee.Size = new System.Drawing.Size(170, 150);
            this.Btn_RegisterEmployee.TabIndex = 0;
            this.Btn_RegisterEmployee.Text = "Register Employee";
            this.Btn_RegisterEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RegisterEmployee.UseVisualStyleBackColor = true;
            this.Btn_RegisterEmployee.Click += new System.EventHandler(this.Btn_RegisterEmployee_Click);
            // 
            // Employee_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 673);
            this.Controls.Add(this.Management_Form_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Management_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Management_Form";
            this.Management_Form_Panel.ResumeLayout(false);
            this.Management_Form_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Management_Form_Panel;
        private System.Windows.Forms.Label Management_Label;
        private System.Windows.Forms.Button Btn_Roster;
        private System.Windows.Forms.Button Btn_LeaveApproval;
        private System.Windows.Forms.Button Btn_LeavePolicy;
        private System.Windows.Forms.Button Btn_RegisterEmployee;
    }
}