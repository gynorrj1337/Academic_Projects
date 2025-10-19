namespace E_Space_Mars_Colonization
{
    partial class DashBoard_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard_Form));
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Form_Border = new System.Windows.Forms.Panel();
            this.Form_Loader = new System.Windows.Forms.Panel();
            this.Loger_Panel = new System.Windows.Forms.Panel();
            this.Accessed_Label = new System.Windows.Forms.Label();
            this.UserGreeting_Label = new System.Windows.Forms.Label();
            this.Loger_PictureBox = new System.Windows.Forms.PictureBox();
            this.Movitvate_PB = new System.Windows.Forms.PictureBox();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Management_Menu_Button = new System.Windows.Forms.Button();
            this.Dashoard_Button = new System.Windows.Forms.Button();
            this.Report_Menu_Button = new System.Windows.Forms.Button();
            this.AddMember_Button = new System.Windows.Forms.Button();
            this.SignOut_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Feedback_Button = new System.Windows.Forms.Button();
            this.Form_Border.SuspendLayout();
            this.Form_Loader.SuspendLayout();
            this.Loger_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loger_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movitvate_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.FlatAppearance.BorderSize = 0;
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_Button.Image")));
            this.Minimize_Button.Location = new System.Drawing.Point(1168, 0);
            this.Minimize_Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(44, 32);
            this.Minimize_Button.TabIndex = 1;
            this.Minimize_Button.UseVisualStyleBackColor = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.Location = new System.Drawing.Point(1210, 0);
            this.Close_Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(44, 32);
            this.Close_Button.TabIndex = 0;
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Form_Border
            // 
            this.Form_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Form_Border.Controls.Add(this.Minimize_Button);
            this.Form_Border.Controls.Add(this.Close_Button);
            this.Form_Border.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_Border.Location = new System.Drawing.Point(-2, 0);
            this.Form_Border.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Form_Border.Name = "Form_Border";
            this.Form_Border.Size = new System.Drawing.Size(1254, 32);
            this.Form_Border.TabIndex = 3;
            // 
            // Form_Loader
            // 
            this.Form_Loader.Controls.Add(this.Loger_Panel);
            this.Form_Loader.Controls.Add(this.Movitvate_PB);
            this.Form_Loader.Location = new System.Drawing.Point(218, 27);
            this.Form_Loader.Name = "Form_Loader";
            this.Form_Loader.Size = new System.Drawing.Size(1027, 673);
            this.Form_Loader.TabIndex = 4;
            // 
            // Loger_Panel
            // 
            this.Loger_Panel.Controls.Add(this.Accessed_Label);
            this.Loger_Panel.Controls.Add(this.UserGreeting_Label);
            this.Loger_Panel.Controls.Add(this.Loger_PictureBox);
            this.Loger_Panel.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loger_Panel.Location = new System.Drawing.Point(594, 7);
            this.Loger_Panel.Name = "Loger_Panel";
            this.Loger_Panel.Size = new System.Drawing.Size(376, 631);
            this.Loger_Panel.TabIndex = 5;
            // 
            // Accessed_Label
            // 
            this.Accessed_Label.AutoSize = true;
            this.Accessed_Label.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accessed_Label.Location = new System.Drawing.Point(171, 271);
            this.Accessed_Label.Name = "Accessed_Label";
            this.Accessed_Label.Size = new System.Drawing.Size(94, 17);
            this.Accessed_Label.TabIndex = 5;
            this.Accessed_Label.Text = "Accessed Time";
            this.Accessed_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserGreeting_Label
            // 
            this.UserGreeting_Label.AutoSize = true;
            this.UserGreeting_Label.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGreeting_Label.Location = new System.Drawing.Point(13, 237);
            this.UserGreeting_Label.Name = "UserGreeting_Label";
            this.UserGreeting_Label.Size = new System.Drawing.Size(124, 20);
            this.UserGreeting_Label.TabIndex = 4;
            this.UserGreeting_Label.Text = "User Greeting";
            this.UserGreeting_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loger_PictureBox
            // 
            this.Loger_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Loger_PictureBox.Image")));
            this.Loger_PictureBox.Location = new System.Drawing.Point(80, 37);
            this.Loger_PictureBox.Name = "Loger_PictureBox";
            this.Loger_PictureBox.Size = new System.Drawing.Size(175, 175);
            this.Loger_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Loger_PictureBox.TabIndex = 0;
            this.Loger_PictureBox.TabStop = false;
            // 
            // Movitvate_PB
            // 
            this.Movitvate_PB.Image = ((System.Drawing.Image)(resources.GetObject("Movitvate_PB.Image")));
            this.Movitvate_PB.Location = new System.Drawing.Point(13, 11);
            this.Movitvate_PB.Name = "Movitvate_PB";
            this.Movitvate_PB.Size = new System.Drawing.Size(575, 319);
            this.Movitvate_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Movitvate_PB.TabIndex = 6;
            this.Movitvate_PB.TabStop = false;
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Logo_PictureBox.Image")));
            this.Logo_PictureBox.Location = new System.Drawing.Point(-12, 3);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(238, 161);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            // 
            // Management_Menu_Button
            // 
            this.Management_Menu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Management_Menu_Button.FlatAppearance.BorderSize = 0;
            this.Management_Menu_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Management_Menu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Management_Menu_Button.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Management_Menu_Button.Image = ((System.Drawing.Image)(resources.GetObject("Management_Menu_Button.Image")));
            this.Management_Menu_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Management_Menu_Button.Location = new System.Drawing.Point(-1, 255);
            this.Management_Menu_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Management_Menu_Button.Name = "Management_Menu_Button";
            this.Management_Menu_Button.Size = new System.Drawing.Size(219, 50);
            this.Management_Menu_Button.TabIndex = 6;
            this.Management_Menu_Button.Text = "          Management";
            this.Management_Menu_Button.UseVisualStyleBackColor = true;
            this.Management_Menu_Button.Click += new System.EventHandler(this.Management_Menu_Button_Click);
            // 
            // Dashoard_Button
            // 
            this.Dashoard_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashoard_Button.FlatAppearance.BorderSize = 0;
            this.Dashoard_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Dashoard_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashoard_Button.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashoard_Button.Image = ((System.Drawing.Image)(resources.GetObject("Dashoard_Button.Image")));
            this.Dashoard_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashoard_Button.Location = new System.Drawing.Point(-1, 199);
            this.Dashoard_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dashoard_Button.Name = "Dashoard_Button";
            this.Dashoard_Button.Size = new System.Drawing.Size(219, 50);
            this.Dashoard_Button.TabIndex = 4;
            this.Dashoard_Button.Text = "          Dash Board";
            this.Dashoard_Button.UseVisualStyleBackColor = true;
            this.Dashoard_Button.Click += new System.EventHandler(this.Dashoard_Button_Click);
            // 
            // Report_Menu_Button
            // 
            this.Report_Menu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Report_Menu_Button.FlatAppearance.BorderSize = 0;
            this.Report_Menu_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Report_Menu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report_Menu_Button.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_Menu_Button.Image = ((System.Drawing.Image)(resources.GetObject("Report_Menu_Button.Image")));
            this.Report_Menu_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report_Menu_Button.Location = new System.Drawing.Point(-1, 311);
            this.Report_Menu_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Report_Menu_Button.Name = "Report_Menu_Button";
            this.Report_Menu_Button.Size = new System.Drawing.Size(219, 50);
            this.Report_Menu_Button.TabIndex = 5;
            this.Report_Menu_Button.Text = "                   Report";
            this.Report_Menu_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report_Menu_Button.UseVisualStyleBackColor = true;
            this.Report_Menu_Button.Click += new System.EventHandler(this.Report_Menu_Button_Click);
            // 
            // AddMember_Button
            // 
            this.AddMember_Button.FlatAppearance.BorderSize = 0;
            this.AddMember_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.AddMember_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMember_Button.Image = ((System.Drawing.Image)(resources.GetObject("AddMember_Button.Image")));
            this.AddMember_Button.Location = new System.Drawing.Point(153, 616);
            this.AddMember_Button.Name = "AddMember_Button";
            this.AddMember_Button.Size = new System.Drawing.Size(61, 56);
            this.AddMember_Button.TabIndex = 8;
            this.AddMember_Button.UseVisualStyleBackColor = true;
            this.AddMember_Button.Click += new System.EventHandler(this.AddMember_Button_Click);
            // 
            // SignOut_Button
            // 
            this.SignOut_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignOut_Button.FlatAppearance.BorderSize = 0;
            this.SignOut_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.SignOut_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOut_Button.Font = new System.Drawing.Font("Product Sans Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut_Button.Image = ((System.Drawing.Image)(resources.GetObject("SignOut_Button.Image")));
            this.SignOut_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignOut_Button.Location = new System.Drawing.Point(2, 614);
            this.SignOut_Button.Name = "SignOut_Button";
            this.SignOut_Button.Size = new System.Drawing.Size(150, 57);
            this.SignOut_Button.TabIndex = 7;
            this.SignOut_Button.Text = "Sign Out";
            this.SignOut_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignOut_Button.UseVisualStyleBackColor = true;
            this.SignOut_Button.Click += new System.EventHandler(this.SignOut_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Feedback_Button);
            this.panel1.Controls.Add(this.AddMember_Button);
            this.panel1.Controls.Add(this.Logo_PictureBox);
            this.panel1.Controls.Add(this.SignOut_Button);
            this.panel1.Controls.Add(this.Dashoard_Button);
            this.panel1.Controls.Add(this.Report_Menu_Button);
            this.panel1.Controls.Add(this.Management_Menu_Button);
            this.panel1.Location = new System.Drawing.Point(-2, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 681);
            this.panel1.TabIndex = 9;
            // 
            // Feedback_Button
            // 
            this.Feedback_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Feedback_Button.FlatAppearance.BorderSize = 0;
            this.Feedback_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Feedback_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Feedback_Button.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedback_Button.Image = ((System.Drawing.Image)(resources.GetObject("Feedback_Button.Image")));
            this.Feedback_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Feedback_Button.Location = new System.Drawing.Point(2, 367);
            this.Feedback_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Feedback_Button.Name = "Feedback_Button";
            this.Feedback_Button.Size = new System.Drawing.Size(216, 50);
            this.Feedback_Button.TabIndex = 9;
            this.Feedback_Button.Text = "               Feedback";
            this.Feedback_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Feedback_Button.UseVisualStyleBackColor = true;
            this.Feedback_Button.Click += new System.EventHandler(this.Feedback_Button_Click);
            // 
            // DashBoard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.Form_Border);
            this.Controls.Add(this.Form_Loader);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DashBoard_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard_Form";
            this.Form_Border.ResumeLayout(false);
            this.Form_Loader.ResumeLayout(false);
            this.Loger_Panel.ResumeLayout(false);
            this.Loger_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loger_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movitvate_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Panel Form_Border;
        private System.Windows.Forms.Panel Form_Loader;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.Button Management_Menu_Button;
        private System.Windows.Forms.Button Dashoard_Button;
        private System.Windows.Forms.Button Report_Menu_Button;
        private System.Windows.Forms.Button AddMember_Button;
        private System.Windows.Forms.Button SignOut_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Loger_Panel;
        private System.Windows.Forms.Label Accessed_Label;
        private System.Windows.Forms.Label UserGreeting_Label;
        private System.Windows.Forms.PictureBox Loger_PictureBox;
        private System.Windows.Forms.PictureBox Movitvate_PB;
        private System.Windows.Forms.Button Feedback_Button;
    }
}