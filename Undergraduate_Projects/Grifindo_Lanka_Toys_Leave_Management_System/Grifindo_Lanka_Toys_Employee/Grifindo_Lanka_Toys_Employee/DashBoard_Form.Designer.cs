namespace Grifindo_Lanka_Toys_Employee
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
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Btn_Minimize = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Form_Border = new System.Windows.Forms.Panel();
            this.Loger_Panel = new System.Windows.Forms.Panel();
            this.lbl_AccessedTime = new System.Windows.Forms.Label();
            this.lbl_AdminGreeting = new System.Windows.Forms.Label();
            this.pic_Logger = new System.Windows.Forms.PictureBox();
            this.Movitvate_PB = new System.Windows.Forms.PictureBox();
            this.Form_Loader = new System.Windows.Forms.Panel();
            this.Btn_Report_Menu = new System.Windows.Forms.Button();
            this.Btn_Feedback = new System.Windows.Forms.Button();
            this.SignOut_Button = new System.Windows.Forms.Button();
            this.Btn_Dashoard = new System.Windows.Forms.Button();
            this.Btn_Management_Menu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.Form_Border.SuspendLayout();
            this.Loger_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movitvate_PB)).BeginInit();
            this.Form_Loader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Logo_PictureBox.Image")));
            this.Logo_PictureBox.Location = new System.Drawing.Point(-1, 10);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(219, 161);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.FlatAppearance.BorderSize = 0;
            this.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimize.Image")));
            this.Btn_Minimize.Location = new System.Drawing.Point(1159, 0);
            this.Btn_Minimize.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(44, 32);
            this.Btn_Minimize.TabIndex = 1;
            this.Btn_Minimize.UseVisualStyleBackColor = false;
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.Location = new System.Drawing.Point(1203, 0);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(44, 32);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Form_Border
            // 
            this.Form_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Form_Border.Controls.Add(this.Btn_Minimize);
            this.Form_Border.Controls.Add(this.Btn_Close);
            this.Form_Border.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_Border.Location = new System.Drawing.Point(1, 0);
            this.Form_Border.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Form_Border.Name = "Form_Border";
            this.Form_Border.Size = new System.Drawing.Size(1247, 32);
            this.Form_Border.TabIndex = 13;
            // 
            // Loger_Panel
            // 
            this.Loger_Panel.Controls.Add(this.lbl_AccessedTime);
            this.Loger_Panel.Controls.Add(this.lbl_AdminGreeting);
            this.Loger_Panel.Controls.Add(this.pic_Logger);
            this.Loger_Panel.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loger_Panel.Location = new System.Drawing.Point(594, 7);
            this.Loger_Panel.Name = "Loger_Panel";
            this.Loger_Panel.Size = new System.Drawing.Size(376, 631);
            this.Loger_Panel.TabIndex = 5;
            // 
            // lbl_AccessedTime
            // 
            this.lbl_AccessedTime.AutoSize = true;
            this.lbl_AccessedTime.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccessedTime.Location = new System.Drawing.Point(171, 271);
            this.lbl_AccessedTime.Name = "lbl_AccessedTime";
            this.lbl_AccessedTime.Size = new System.Drawing.Size(94, 17);
            this.lbl_AccessedTime.TabIndex = 5;
            this.lbl_AccessedTime.Text = "Accessed Time";
            this.lbl_AccessedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_AdminGreeting
            // 
            this.lbl_AdminGreeting.AutoSize = true;
            this.lbl_AdminGreeting.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminGreeting.Location = new System.Drawing.Point(13, 237);
            this.lbl_AdminGreeting.Name = "lbl_AdminGreeting";
            this.lbl_AdminGreeting.Size = new System.Drawing.Size(139, 20);
            this.lbl_AdminGreeting.TabIndex = 4;
            this.lbl_AdminGreeting.Text = "Admin Greeting";
            this.lbl_AdminGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_Logger
            // 
            this.pic_Logger.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logger.Image")));
            this.pic_Logger.Location = new System.Drawing.Point(80, 37);
            this.pic_Logger.Name = "pic_Logger";
            this.pic_Logger.Size = new System.Drawing.Size(175, 175);
            this.pic_Logger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logger.TabIndex = 0;
            this.pic_Logger.TabStop = false;
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
            // Form_Loader
            // 
            this.Form_Loader.BackColor = System.Drawing.SystemColors.Window;
            this.Form_Loader.Controls.Add(this.Loger_Panel);
            this.Form_Loader.Controls.Add(this.Movitvate_PB);
            this.Form_Loader.Location = new System.Drawing.Point(221, 27);
            this.Form_Loader.Name = "Form_Loader";
            this.Form_Loader.Size = new System.Drawing.Size(1027, 673);
            this.Form_Loader.TabIndex = 14;
            // 
            // Btn_Report_Menu
            // 
            this.Btn_Report_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Report_Menu.FlatAppearance.BorderSize = 0;
            this.Btn_Report_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Report_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Report_Menu.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Report_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Report_Menu.Image")));
            this.Btn_Report_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Report_Menu.Location = new System.Drawing.Point(-1, 311);
            this.Btn_Report_Menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Report_Menu.Name = "Btn_Report_Menu";
            this.Btn_Report_Menu.Size = new System.Drawing.Size(219, 50);
            this.Btn_Report_Menu.TabIndex = 5;
            this.Btn_Report_Menu.Text = "                   Report";
            this.Btn_Report_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Report_Menu.UseVisualStyleBackColor = true;
            this.Btn_Report_Menu.Click += new System.EventHandler(this.Btn_Report_Menu_Click);
            // 
            // Btn_Feedback
            // 
            this.Btn_Feedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Feedback.FlatAppearance.BorderSize = 0;
            this.Btn_Feedback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Feedback.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Feedback.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Feedback.Image")));
            this.Btn_Feedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Feedback.Location = new System.Drawing.Point(2, 367);
            this.Btn_Feedback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Feedback.Name = "Btn_Feedback";
            this.Btn_Feedback.Size = new System.Drawing.Size(216, 50);
            this.Btn_Feedback.TabIndex = 9;
            this.Btn_Feedback.Text = "               Feedback";
            this.Btn_Feedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Feedback.UseVisualStyleBackColor = true;
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
            this.SignOut_Button.Size = new System.Drawing.Size(211, 57);
            this.SignOut_Button.TabIndex = 7;
            this.SignOut_Button.Text = "Sign Out";
            this.SignOut_Button.UseVisualStyleBackColor = true;
            this.SignOut_Button.Click += new System.EventHandler(this.SignOut_Button_Click);
            // 
            // Btn_Dashoard
            // 
            this.Btn_Dashoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Dashoard.FlatAppearance.BorderSize = 0;
            this.Btn_Dashoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Dashoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Dashoard.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dashoard.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Dashoard.Image")));
            this.Btn_Dashoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Dashoard.Location = new System.Drawing.Point(-1, 199);
            this.Btn_Dashoard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Dashoard.Name = "Btn_Dashoard";
            this.Btn_Dashoard.Size = new System.Drawing.Size(219, 50);
            this.Btn_Dashoard.TabIndex = 4;
            this.Btn_Dashoard.Text = "          Dash Board";
            this.Btn_Dashoard.UseVisualStyleBackColor = true;
            this.Btn_Dashoard.Click += new System.EventHandler(this.Btn_Dashoard_Click);
            // 
            // Btn_Management_Menu
            // 
            this.Btn_Management_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Management_Menu.FlatAppearance.BorderSize = 0;
            this.Btn_Management_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Management_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Management_Menu.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Management_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Management_Menu.Image")));
            this.Btn_Management_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Management_Menu.Location = new System.Drawing.Point(-1, 255);
            this.Btn_Management_Menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Management_Menu.Name = "Btn_Management_Menu";
            this.Btn_Management_Menu.Size = new System.Drawing.Size(219, 50);
            this.Btn_Management_Menu.TabIndex = 6;
            this.Btn_Management_Menu.Text = "          Management";
            this.Btn_Management_Menu.UseVisualStyleBackColor = true;
            this.Btn_Management_Menu.Click += new System.EventHandler(this.Btn_Management_Menu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_Feedback);
            this.panel1.Controls.Add(this.Logo_PictureBox);
            this.panel1.Controls.Add(this.SignOut_Button);
            this.panel1.Controls.Add(this.Btn_Dashoard);
            this.panel1.Controls.Add(this.Btn_Report_Menu);
            this.panel1.Controls.Add(this.Btn_Management_Menu);
            this.panel1.Location = new System.Drawing.Point(1, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 681);
            this.panel1.TabIndex = 15;
            // 
            // DashBoard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.Form_Border);
            this.Controls.Add(this.Form_Loader);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DashBoard_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.Form_Border.ResumeLayout(false);
            this.Loger_Panel.ResumeLayout(false);
            this.Loger_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movitvate_PB)).EndInit();
            this.Form_Loader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.Button Btn_Minimize;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel Form_Border;
        private System.Windows.Forms.Panel Loger_Panel;
        private System.Windows.Forms.Label lbl_AccessedTime;
        private System.Windows.Forms.Label lbl_AdminGreeting;
        private System.Windows.Forms.PictureBox pic_Logger;
        private System.Windows.Forms.PictureBox Movitvate_PB;
        private System.Windows.Forms.Panel Form_Loader;
        private System.Windows.Forms.Button Btn_Report_Menu;
        private System.Windows.Forms.Button Btn_Feedback;
        private System.Windows.Forms.Button SignOut_Button;
        private System.Windows.Forms.Button Btn_Dashoard;
        private System.Windows.Forms.Button Btn_Management_Menu;
        private System.Windows.Forms.Panel panel1;
    }
}