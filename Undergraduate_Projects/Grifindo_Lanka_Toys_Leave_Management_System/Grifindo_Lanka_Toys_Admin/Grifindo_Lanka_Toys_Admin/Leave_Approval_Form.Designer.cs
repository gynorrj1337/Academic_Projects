namespace Grifindo_Lanka_Toys_Admin
{
    partial class Leave_Approval_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leave_Approval_Form));
            this.Grp_LeaveApproval = new System.Windows.Forms.GroupBox();
            this.Grp_EmployeeDetails = new System.Windows.Forms.GroupBox();
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.lbl_Reason = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_EndTime = new System.Windows.Forms.TextBox();
            this.lbl_EndTime = new System.Windows.Forms.Label();
            this.txt_StartTime = new System.Windows.Forms.TextBox();
            this.lbl_StartTime = new System.Windows.Forms.Label();
            this.txt_LeaveType = new System.Windows.Forms.TextBox();
            this.lbl_LeaveType = new System.Windows.Forms.Label();
            this.txt_EmployeeName = new System.Windows.Forms.TextBox();
            this.lbl_EmployeeName = new System.Windows.Forms.Label();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.lbl_EmployeeID = new System.Windows.Forms.Label();
            this.Btn_Reject = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Approve = new System.Windows.Forms.Button();
            this.cmb_LeaveID = new System.Windows.Forms.ComboBox();
            this.lbl_LeaveID = new System.Windows.Forms.Label();
            this.txt_LeaveDate = new System.Windows.Forms.TextBox();
            this.lbl_LeaveDate = new System.Windows.Forms.Label();
            this.Grp_LeaveApproval.SuspendLayout();
            this.Grp_EmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_LeaveApproval
            // 
            this.Grp_LeaveApproval.Controls.Add(this.Grp_EmployeeDetails);
            this.Grp_LeaveApproval.Controls.Add(this.Btn_Reject);
            this.Grp_LeaveApproval.Controls.Add(this.Btn_Search);
            this.Grp_LeaveApproval.Controls.Add(this.Btn_Approve);
            this.Grp_LeaveApproval.Controls.Add(this.cmb_LeaveID);
            this.Grp_LeaveApproval.Controls.Add(this.lbl_LeaveID);
            this.Grp_LeaveApproval.Font = new System.Drawing.Font("Product Sans Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_LeaveApproval.Location = new System.Drawing.Point(12, 12);
            this.Grp_LeaveApproval.Name = "Grp_LeaveApproval";
            this.Grp_LeaveApproval.Size = new System.Drawing.Size(994, 547);
            this.Grp_LeaveApproval.TabIndex = 6;
            this.Grp_LeaveApproval.TabStop = false;
            this.Grp_LeaveApproval.Text = "Leave Approval";
            // 
            // Grp_EmployeeDetails
            // 
            this.Grp_EmployeeDetails.Controls.Add(this.txt_LeaveDate);
            this.Grp_EmployeeDetails.Controls.Add(this.lbl_LeaveDate);
            this.Grp_EmployeeDetails.Controls.Add(this.txt_Reason);
            this.Grp_EmployeeDetails.Controls.Add(this.lbl_Reason);
            this.Grp_EmployeeDetails.Controls.Add(this.txt_Status);
            this.Grp_EmployeeDetails.Controls.Add(this.lbl_Status);
            this.Grp_EmployeeDetails.Controls.Add(this.txt_EndTime);
            this.Grp_EmployeeDetails.Controls.Add(this.lbl_EndTime);
            this.Grp_EmployeeDetails.Controls.Add(this.txt_StartTime);
            this.Grp_EmployeeDetails.Controls.Add(this.lbl_StartTime);
            this.Grp_EmployeeDetails.Controls.Add(this.txt_LeaveType);
            this.Grp_EmployeeDetails.Controls.Add(this.lbl_LeaveType);
            this.Grp_EmployeeDetails.Controls.Add(this.txt_EmployeeName);
            this.Grp_EmployeeDetails.Controls.Add(this.lbl_EmployeeName);
            this.Grp_EmployeeDetails.Controls.Add(this.txt_EmployeeID);
            this.Grp_EmployeeDetails.Controls.Add(this.lbl_EmployeeID);
            this.Grp_EmployeeDetails.Location = new System.Drawing.Point(12, 61);
            this.Grp_EmployeeDetails.Name = "Grp_EmployeeDetails";
            this.Grp_EmployeeDetails.Size = new System.Drawing.Size(963, 402);
            this.Grp_EmployeeDetails.TabIndex = 37;
            this.Grp_EmployeeDetails.TabStop = false;
            this.Grp_EmployeeDetails.Text = "Employee Details";
            // 
            // txt_Reason
            // 
            this.txt_Reason.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Reason.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Reason.Location = new System.Drawing.Point(188, 296);
            this.txt_Reason.Multiline = true;
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.ReadOnly = true;
            this.txt_Reason.Size = new System.Drawing.Size(750, 78);
            this.txt_Reason.TabIndex = 49;
            // 
            // lbl_Reason
            // 
            this.lbl_Reason.AutoSize = true;
            this.lbl_Reason.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reason.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Reason.Location = new System.Drawing.Point(6, 296);
            this.lbl_Reason.Name = "lbl_Reason";
            this.lbl_Reason.Size = new System.Drawing.Size(68, 20);
            this.lbl_Reason.TabIndex = 48;
            this.lbl_Reason.Text = "Reason";
            // 
            // txt_Status
            // 
            this.txt_Status.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Status.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Status.Location = new System.Drawing.Point(188, 257);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(253, 22);
            this.txt_Status.TabIndex = 47;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Status.Location = new System.Drawing.Point(6, 257);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(61, 20);
            this.lbl_Status.TabIndex = 46;
            this.lbl_Status.Text = "Status";
            // 
            // txt_EndTime
            // 
            this.txt_EndTime.BackColor = System.Drawing.SystemColors.Window;
            this.txt_EndTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_EndTime.Location = new System.Drawing.Point(188, 220);
            this.txt_EndTime.Name = "txt_EndTime";
            this.txt_EndTime.ReadOnly = true;
            this.txt_EndTime.Size = new System.Drawing.Size(253, 22);
            this.txt_EndTime.TabIndex = 45;
            // 
            // lbl_EndTime
            // 
            this.lbl_EndTime.AutoSize = true;
            this.lbl_EndTime.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndTime.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_EndTime.Location = new System.Drawing.Point(6, 220);
            this.lbl_EndTime.Name = "lbl_EndTime";
            this.lbl_EndTime.Size = new System.Drawing.Size(82, 20);
            this.lbl_EndTime.TabIndex = 44;
            this.lbl_EndTime.Text = "End Date";
            // 
            // txt_StartTime
            // 
            this.txt_StartTime.BackColor = System.Drawing.SystemColors.Window;
            this.txt_StartTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_StartTime.Location = new System.Drawing.Point(188, 183);
            this.txt_StartTime.Name = "txt_StartTime";
            this.txt_StartTime.ReadOnly = true;
            this.txt_StartTime.Size = new System.Drawing.Size(253, 22);
            this.txt_StartTime.TabIndex = 43;
            // 
            // lbl_StartTime
            // 
            this.lbl_StartTime.AutoSize = true;
            this.lbl_StartTime.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartTime.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_StartTime.Location = new System.Drawing.Point(6, 183);
            this.lbl_StartTime.Name = "lbl_StartTime";
            this.lbl_StartTime.Size = new System.Drawing.Size(91, 20);
            this.lbl_StartTime.TabIndex = 42;
            this.lbl_StartTime.Text = "Start Date";
            // 
            // txt_LeaveType
            // 
            this.txt_LeaveType.BackColor = System.Drawing.SystemColors.Window;
            this.txt_LeaveType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_LeaveType.Location = new System.Drawing.Point(188, 104);
            this.txt_LeaveType.Name = "txt_LeaveType";
            this.txt_LeaveType.ReadOnly = true;
            this.txt_LeaveType.Size = new System.Drawing.Size(253, 22);
            this.txt_LeaveType.TabIndex = 41;
            this.txt_LeaveType.TextChanged += new System.EventHandler(this.txt_LeaveType_TextChanged);
            // 
            // lbl_LeaveType
            // 
            this.lbl_LeaveType.AutoSize = true;
            this.lbl_LeaveType.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LeaveType.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_LeaveType.Location = new System.Drawing.Point(6, 104);
            this.lbl_LeaveType.Name = "lbl_LeaveType";
            this.lbl_LeaveType.Size = new System.Drawing.Size(98, 20);
            this.lbl_LeaveType.TabIndex = 40;
            this.lbl_LeaveType.Text = "Leave Type";
            // 
            // txt_EmployeeName
            // 
            this.txt_EmployeeName.BackColor = System.Drawing.SystemColors.Window;
            this.txt_EmployeeName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_EmployeeName.Location = new System.Drawing.Point(188, 65);
            this.txt_EmployeeName.Name = "txt_EmployeeName";
            this.txt_EmployeeName.ReadOnly = true;
            this.txt_EmployeeName.Size = new System.Drawing.Size(253, 22);
            this.txt_EmployeeName.TabIndex = 39;
            // 
            // lbl_EmployeeName
            // 
            this.lbl_EmployeeName.AutoSize = true;
            this.lbl_EmployeeName.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmployeeName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_EmployeeName.Location = new System.Drawing.Point(6, 67);
            this.lbl_EmployeeName.Name = "lbl_EmployeeName";
            this.lbl_EmployeeName.Size = new System.Drawing.Size(139, 20);
            this.lbl_EmployeeName.TabIndex = 38;
            this.lbl_EmployeeName.Text = "Employee Name";
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.BackColor = System.Drawing.SystemColors.Window;
            this.txt_EmployeeID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_EmployeeID.Location = new System.Drawing.Point(188, 28);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.ReadOnly = true;
            this.txt_EmployeeID.Size = new System.Drawing.Size(253, 22);
            this.txt_EmployeeID.TabIndex = 37;
            // 
            // lbl_EmployeeID
            // 
            this.lbl_EmployeeID.AutoSize = true;
            this.lbl_EmployeeID.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmployeeID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_EmployeeID.Location = new System.Drawing.Point(6, 30);
            this.lbl_EmployeeID.Name = "lbl_EmployeeID";
            this.lbl_EmployeeID.Size = new System.Drawing.Size(110, 20);
            this.lbl_EmployeeID.TabIndex = 36;
            this.lbl_EmployeeID.Text = "Employee ID";
            // 
            // Btn_Reject
            // 
            this.Btn_Reject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Reject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Reject.FlatAppearance.BorderSize = 0;
            this.Btn_Reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reject.Font = new System.Drawing.Font("Product Sans Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reject.Location = new System.Drawing.Point(864, 484);
            this.Btn_Reject.Name = "Btn_Reject";
            this.Btn_Reject.Size = new System.Drawing.Size(86, 35);
            this.Btn_Reject.TabIndex = 36;
            this.Btn_Reject.Text = "Reject";
            this.Btn_Reject.UseVisualStyleBackColor = false;
            this.Btn_Reject.Click += new System.EventHandler(this.Btn_Reject_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Search.Image")));
            this.Btn_Search.Location = new System.Drawing.Point(456, 18);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(40, 40);
            this.Btn_Search.TabIndex = 9;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Approve
            // 
            this.Btn_Approve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Approve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Approve.FlatAppearance.BorderSize = 0;
            this.Btn_Approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Approve.Font = new System.Drawing.Font("Product Sans Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Approve.Location = new System.Drawing.Point(747, 484);
            this.Btn_Approve.Name = "Btn_Approve";
            this.Btn_Approve.Size = new System.Drawing.Size(86, 35);
            this.Btn_Approve.TabIndex = 35;
            this.Btn_Approve.Text = "Approve";
            this.Btn_Approve.UseVisualStyleBackColor = false;
            this.Btn_Approve.Click += new System.EventHandler(this.Btn_Approve_Click);
            // 
            // cmb_LeaveID
            // 
            this.cmb_LeaveID.FormattingEnabled = true;
            this.cmb_LeaveID.Location = new System.Drawing.Point(200, 28);
            this.cmb_LeaveID.Name = "cmb_LeaveID";
            this.cmb_LeaveID.Size = new System.Drawing.Size(253, 24);
            this.cmb_LeaveID.TabIndex = 3;
            // 
            // lbl_LeaveID
            // 
            this.lbl_LeaveID.AutoSize = true;
            this.lbl_LeaveID.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LeaveID.Location = new System.Drawing.Point(18, 28);
            this.lbl_LeaveID.Name = "lbl_LeaveID";
            this.lbl_LeaveID.Size = new System.Drawing.Size(176, 20);
            this.lbl_LeaveID.TabIndex = 2;
            this.lbl_LeaveID.Text = "Leave Application ID";
            // 
            // txt_LeaveDate
            // 
            this.txt_LeaveDate.BackColor = System.Drawing.SystemColors.Window;
            this.txt_LeaveDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_LeaveDate.Location = new System.Drawing.Point(188, 143);
            this.txt_LeaveDate.Name = "txt_LeaveDate";
            this.txt_LeaveDate.ReadOnly = true;
            this.txt_LeaveDate.Size = new System.Drawing.Size(253, 22);
            this.txt_LeaveDate.TabIndex = 51;
            // 
            // lbl_LeaveDate
            // 
            this.lbl_LeaveDate.AutoSize = true;
            this.lbl_LeaveDate.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LeaveDate.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_LeaveDate.Location = new System.Drawing.Point(6, 143);
            this.lbl_LeaveDate.Name = "lbl_LeaveDate";
            this.lbl_LeaveDate.Size = new System.Drawing.Size(99, 20);
            this.lbl_LeaveDate.TabIndex = 50;
            this.lbl_LeaveDate.Text = "Leave Date";
            // 
            // Leave_Approval_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 673);
            this.Controls.Add(this.Grp_LeaveApproval);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Leave_Approval_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave_Approval_Form";
            this.Load += new System.EventHandler(this.Leave_Approval_Form_Load);
            this.Grp_LeaveApproval.ResumeLayout(false);
            this.Grp_LeaveApproval.PerformLayout();
            this.Grp_EmployeeDetails.ResumeLayout(false);
            this.Grp_EmployeeDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_LeaveApproval;
        private System.Windows.Forms.Button Btn_Reject;
        private System.Windows.Forms.Button Btn_Approve;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.ComboBox cmb_LeaveID;
        private System.Windows.Forms.Label lbl_LeaveID;
        private System.Windows.Forms.GroupBox Grp_EmployeeDetails;
        private System.Windows.Forms.TextBox txt_Reason;
        private System.Windows.Forms.Label lbl_Reason;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox txt_EndTime;
        private System.Windows.Forms.Label lbl_EndTime;
        private System.Windows.Forms.TextBox txt_StartTime;
        private System.Windows.Forms.Label lbl_StartTime;
        private System.Windows.Forms.TextBox txt_LeaveType;
        private System.Windows.Forms.Label lbl_LeaveType;
        private System.Windows.Forms.TextBox txt_EmployeeName;
        private System.Windows.Forms.Label lbl_EmployeeName;
        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.Label lbl_EmployeeID;
        private System.Windows.Forms.TextBox txt_LeaveDate;
        private System.Windows.Forms.Label lbl_LeaveDate;
    }
}