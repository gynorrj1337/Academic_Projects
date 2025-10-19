namespace Grifindo_Lanka_Toys_Employee
{
    partial class Add_Leave_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Leave_Form));
            this.Grp_Add_Leave = new System.Windows.Forms.GroupBox();
            this.dtp_LeaveDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_LeaveDate = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.lbl_Reason = new System.Windows.Forms.Label();
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.dtp_EndTime = new System.Windows.Forms.DateTimePicker();
            this.cmb_LeaveType = new System.Windows.Forms.ComboBox();
            this.lbl_LeaveType = new System.Windows.Forms.Label();
            this.dtp_StartTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_StartTime = new System.Windows.Forms.Label();
            this.lbl_EndTime = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.cmb_LeaveID = new System.Windows.Forms.ComboBox();
            this.lbl_LeaveID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grp_Add_Leave.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_Add_Leave
            // 
            this.Grp_Add_Leave.Controls.Add(this.dtp_LeaveDate);
            this.Grp_Add_Leave.Controls.Add(this.lbl_LeaveDate);
            this.Grp_Add_Leave.Controls.Add(this.Btn_Search);
            this.Grp_Add_Leave.Controls.Add(this.lbl_Reason);
            this.Grp_Add_Leave.Controls.Add(this.txt_Reason);
            this.Grp_Add_Leave.Controls.Add(this.dtp_EndTime);
            this.Grp_Add_Leave.Controls.Add(this.cmb_LeaveType);
            this.Grp_Add_Leave.Controls.Add(this.lbl_LeaveType);
            this.Grp_Add_Leave.Controls.Add(this.dtp_StartTime);
            this.Grp_Add_Leave.Controls.Add(this.lbl_StartTime);
            this.Grp_Add_Leave.Controls.Add(this.lbl_EndTime);
            this.Grp_Add_Leave.Controls.Add(this.Btn_Delete);
            this.Grp_Add_Leave.Controls.Add(this.Btn_Clear);
            this.Grp_Add_Leave.Controls.Add(this.Btn_Update);
            this.Grp_Add_Leave.Controls.Add(this.Btn_Register);
            this.Grp_Add_Leave.Controls.Add(this.cmb_LeaveID);
            this.Grp_Add_Leave.Controls.Add(this.lbl_LeaveID);
            this.Grp_Add_Leave.Font = new System.Drawing.Font("Product Sans Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Add_Leave.Location = new System.Drawing.Point(12, 12);
            this.Grp_Add_Leave.Name = "Grp_Add_Leave";
            this.Grp_Add_Leave.Size = new System.Drawing.Size(981, 389);
            this.Grp_Add_Leave.TabIndex = 6;
            this.Grp_Add_Leave.TabStop = false;
            this.Grp_Add_Leave.Text = "Request Leave";
            // 
            // dtp_LeaveDate
            // 
            this.dtp_LeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_LeaveDate.Location = new System.Drawing.Point(224, 108);
            this.dtp_LeaveDate.Name = "dtp_LeaveDate";
            this.dtp_LeaveDate.Size = new System.Drawing.Size(253, 22);
            this.dtp_LeaveDate.TabIndex = 54;
            this.dtp_LeaveDate.Value = new System.DateTime(2024, 8, 8, 0, 0, 0, 0);
            // 
            // lbl_LeaveDate
            // 
            this.lbl_LeaveDate.AutoSize = true;
            this.lbl_LeaveDate.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LeaveDate.Location = new System.Drawing.Point(8, 110);
            this.lbl_LeaveDate.Name = "lbl_LeaveDate";
            this.lbl_LeaveDate.Size = new System.Drawing.Size(99, 20);
            this.lbl_LeaveDate.TabIndex = 53;
            this.lbl_LeaveDate.Text = "Leave Date";
            // 
            // Btn_Search
            // 
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Search.Image")));
            this.Btn_Search.Location = new System.Drawing.Point(480, 18);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(40, 40);
            this.Btn_Search.TabIndex = 52;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // lbl_Reason
            // 
            this.lbl_Reason.AutoSize = true;
            this.lbl_Reason.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reason.Location = new System.Drawing.Point(8, 223);
            this.lbl_Reason.Name = "lbl_Reason";
            this.lbl_Reason.Size = new System.Drawing.Size(68, 20);
            this.lbl_Reason.TabIndex = 51;
            this.lbl_Reason.Text = "Reason";
            // 
            // txt_Reason
            // 
            this.txt_Reason.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Reason.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Reason.Location = new System.Drawing.Point(224, 223);
            this.txt_Reason.Multiline = true;
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(731, 78);
            this.txt_Reason.TabIndex = 50;
            // 
            // dtp_EndTime
            // 
            this.dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_EndTime.Location = new System.Drawing.Point(224, 185);
            this.dtp_EndTime.Name = "dtp_EndTime";
            this.dtp_EndTime.Size = new System.Drawing.Size(253, 22);
            this.dtp_EndTime.TabIndex = 44;
            this.dtp_EndTime.Value = new System.DateTime(2024, 8, 9, 0, 0, 0, 0);
            // 
            // cmb_LeaveType
            // 
            this.cmb_LeaveType.FormattingEnabled = true;
            this.cmb_LeaveType.Items.AddRange(new object[] {
            "Annual",
            "Casual",
            "Short"});
            this.cmb_LeaveType.Location = new System.Drawing.Point(224, 70);
            this.cmb_LeaveType.Name = "cmb_LeaveType";
            this.cmb_LeaveType.Size = new System.Drawing.Size(253, 24);
            this.cmb_LeaveType.TabIndex = 42;
            this.cmb_LeaveType.SelectedIndexChanged += new System.EventHandler(this.cmb_LeaveType_SelectedIndexChanged);
            // 
            // lbl_LeaveType
            // 
            this.lbl_LeaveType.AutoSize = true;
            this.lbl_LeaveType.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LeaveType.Location = new System.Drawing.Point(8, 74);
            this.lbl_LeaveType.Name = "lbl_LeaveType";
            this.lbl_LeaveType.Size = new System.Drawing.Size(98, 20);
            this.lbl_LeaveType.TabIndex = 41;
            this.lbl_LeaveType.Text = "Leave Type";
            // 
            // dtp_StartTime
            // 
            this.dtp_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_StartTime.Location = new System.Drawing.Point(224, 148);
            this.dtp_StartTime.Name = "dtp_StartTime";
            this.dtp_StartTime.Size = new System.Drawing.Size(253, 22);
            this.dtp_StartTime.TabIndex = 43;
            this.dtp_StartTime.Value = new System.DateTime(2024, 8, 8, 0, 0, 0, 0);
            // 
            // lbl_StartTime
            // 
            this.lbl_StartTime.AutoSize = true;
            this.lbl_StartTime.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartTime.Location = new System.Drawing.Point(8, 150);
            this.lbl_StartTime.Name = "lbl_StartTime";
            this.lbl_StartTime.Size = new System.Drawing.Size(144, 20);
            this.lbl_StartTime.TabIndex = 41;
            this.lbl_StartTime.Text = "Leave Start Time";
            // 
            // lbl_EndTime
            // 
            this.lbl_EndTime.AutoSize = true;
            this.lbl_EndTime.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndTime.Location = new System.Drawing.Point(8, 187);
            this.lbl_EndTime.Name = "lbl_EndTime";
            this.lbl_EndTime.Size = new System.Drawing.Size(135, 20);
            this.lbl_EndTime.TabIndex = 42;
            this.lbl_EndTime.Text = "Leave End Time";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Product Sans Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(128, 339);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(86, 35);
            this.Btn_Delete.TabIndex = 36;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.FlatAppearance.BorderSize = 0;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Font = new System.Drawing.Font("Product Sans Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.Location = new System.Drawing.Point(11, 339);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(86, 35);
            this.Btn_Clear.TabIndex = 35;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Product Sans Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(767, 339);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(86, 35);
            this.Btn_Update.TabIndex = 34;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Register.FlatAppearance.BorderSize = 0;
            this.Btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Register.Font = new System.Drawing.Font("Product Sans Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Register.Location = new System.Drawing.Point(881, 339);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(86, 35);
            this.Btn_Register.TabIndex = 33;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = false;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // cmb_LeaveID
            // 
            this.cmb_LeaveID.FormattingEnabled = true;
            this.cmb_LeaveID.Location = new System.Drawing.Point(224, 30);
            this.cmb_LeaveID.Name = "cmb_LeaveID";
            this.cmb_LeaveID.Size = new System.Drawing.Size(253, 24);
            this.cmb_LeaveID.TabIndex = 3;
            // 
            // lbl_LeaveID
            // 
            this.lbl_LeaveID.AutoSize = true;
            this.lbl_LeaveID.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LeaveID.Location = new System.Drawing.Point(8, 34);
            this.lbl_LeaveID.Name = "lbl_LeaveID";
            this.lbl_LeaveID.Size = new System.Drawing.Size(78, 20);
            this.lbl_LeaveID.TabIndex = 2;
            this.lbl_LeaveID.Text = "Leave ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 60);
            this.label1.TabIndex = 43;
            this.label1.Text = "Note: Need to add conditions for Casual leave\r\n\r\nNeed to add remaining leaves to " +
    "calculate the remaining leaves";
            this.label1.Visible = false;
            // 
            // Add_Leave_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grp_Add_Leave);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Add_Leave_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Leave_Form";
            this.Load += new System.EventHandler(this.Add_Leave_Form_Load);
            this.Grp_Add_Leave.ResumeLayout(false);
            this.Grp_Add_Leave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_Add_Leave;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.ComboBox cmb_LeaveID;
        private System.Windows.Forms.Label lbl_LeaveID;
        private System.Windows.Forms.DateTimePicker dtp_EndTime;
        private System.Windows.Forms.ComboBox cmb_LeaveType;
        private System.Windows.Forms.Label lbl_LeaveType;
        private System.Windows.Forms.DateTimePicker dtp_StartTime;
        private System.Windows.Forms.Label lbl_StartTime;
        private System.Windows.Forms.Label lbl_EndTime;
        private System.Windows.Forms.Label lbl_Reason;
        private System.Windows.Forms.TextBox txt_Reason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_LeaveDate;
        private System.Windows.Forms.Label lbl_LeaveDate;
    }
}