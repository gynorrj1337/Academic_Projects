namespace SM_Application
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.Close_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignOut_Button = new System.Windows.Forms.Button();
            this.SettingsMenu_Button = new System.Windows.Forms.Button();
            this.StudentMenu_Button = new System.Windows.Forms.Button();
            this.Dashoard_Button_Click = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.CourseMenu_Button = new System.Windows.Forms.Button();
            this.Form_Border = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Form_Loader = new System.Windows.Forms.Panel();
            this.AddMember_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Form_Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close_Button
            // 
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.Location = new System.Drawing.Point(1214, 0);
            this.Close_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(38, 30);
            this.Close_Button.TabIndex = 0;
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddMember_Button);
            this.panel1.Controls.Add(this.SignOut_Button);
            this.panel1.Controls.Add(this.SettingsMenu_Button);
            this.panel1.Controls.Add(this.StudentMenu_Button);
            this.panel1.Controls.Add(this.Dashoard_Button_Click);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.CourseMenu_Button);
            this.panel1.Location = new System.Drawing.Point(-2, -10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 801);
            this.panel1.TabIndex = 1;
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
            this.SignOut_Button.Location = new System.Drawing.Point(4, 653);
            this.SignOut_Button.Name = "SignOut_Button";
            this.SignOut_Button.Size = new System.Drawing.Size(148, 57);
            this.SignOut_Button.TabIndex = 5;
            this.SignOut_Button.Text = "Sign Out";
            this.SignOut_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignOut_Button.UseVisualStyleBackColor = true;
            this.SignOut_Button.Click += new System.EventHandler(this.SignOut_Button_Click);
            // 
            // SettingsMenu_Button
            // 
            this.SettingsMenu_Button.FlatAppearance.BorderSize = 0;
            this.SettingsMenu_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.SettingsMenu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsMenu_Button.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsMenu_Button.Image = ((System.Drawing.Image)(resources.GetObject("SettingsMenu_Button.Image")));
            this.SettingsMenu_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsMenu_Button.Location = new System.Drawing.Point(4, 566);
            this.SettingsMenu_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SettingsMenu_Button.Name = "SettingsMenu_Button";
            this.SettingsMenu_Button.Size = new System.Drawing.Size(212, 50);
            this.SettingsMenu_Button.TabIndex = 4;
            this.SettingsMenu_Button.Text = "        Settings";
            this.SettingsMenu_Button.UseVisualStyleBackColor = true;
            this.SettingsMenu_Button.Click += new System.EventHandler(this.SettingsMenu_Button_Click);
            // 
            // StudentMenu_Button
            // 
            this.StudentMenu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentMenu_Button.FlatAppearance.BorderSize = 0;
            this.StudentMenu_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.StudentMenu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentMenu_Button.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentMenu_Button.Image = ((System.Drawing.Image)(resources.GetObject("StudentMenu_Button.Image")));
            this.StudentMenu_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentMenu_Button.Location = new System.Drawing.Point(2, 267);
            this.StudentMenu_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StudentMenu_Button.Name = "StudentMenu_Button";
            this.StudentMenu_Button.Size = new System.Drawing.Size(212, 50);
            this.StudentMenu_Button.TabIndex = 3;
            this.StudentMenu_Button.Text = "          Student";
            this.StudentMenu_Button.UseVisualStyleBackColor = true;
            this.StudentMenu_Button.Click += new System.EventHandler(this.StudentMenu_Button_Click_1);
            // 
            // Dashoard_Button_Click
            // 
            this.Dashoard_Button_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashoard_Button_Click.FlatAppearance.BorderSize = 0;
            this.Dashoard_Button_Click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Dashoard_Button_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashoard_Button_Click.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashoard_Button_Click.Image = ((System.Drawing.Image)(resources.GetObject("Dashoard_Button_Click.Image")));
            this.Dashoard_Button_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashoard_Button_Click.Location = new System.Drawing.Point(2, 211);
            this.Dashoard_Button_Click.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dashoard_Button_Click.Name = "Dashoard_Button_Click";
            this.Dashoard_Button_Click.Size = new System.Drawing.Size(216, 50);
            this.Dashoard_Button_Click.TabIndex = 2;
            this.Dashoard_Button_Click.Text = "          Dash Board";
            this.Dashoard_Button_Click.UseVisualStyleBackColor = true;
            this.Dashoard_Button_Click.Click += new System.EventHandler(this.Dashoard_Button_Click_1);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(9, 30);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(206, 175);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // CourseMenu_Button
            // 
            this.CourseMenu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CourseMenu_Button.FlatAppearance.BorderSize = 0;
            this.CourseMenu_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.CourseMenu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseMenu_Button.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseMenu_Button.Image = ((System.Drawing.Image)(resources.GetObject("CourseMenu_Button.Image")));
            this.CourseMenu_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CourseMenu_Button.Location = new System.Drawing.Point(-1, 323);
            this.CourseMenu_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CourseMenu_Button.Name = "CourseMenu_Button";
            this.CourseMenu_Button.Size = new System.Drawing.Size(216, 50);
            this.CourseMenu_Button.TabIndex = 2;
            this.CourseMenu_Button.Text = "                    Course";
            this.CourseMenu_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CourseMenu_Button.UseVisualStyleBackColor = true;
            // 
            // Form_Border
            // 
            this.Form_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Form_Border.Controls.Add(this.Minimize_Button);
            this.Form_Border.Controls.Add(this.Close_Button);
            this.Form_Border.Location = new System.Drawing.Point(-2, 0);
            this.Form_Border.Name = "Form_Border";
            this.Form_Border.Size = new System.Drawing.Size(1256, 30);
            this.Form_Border.TabIndex = 2;
            this.Form_Border.Click += new System.EventHandler(this.Form_Border_Click);
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.FlatAppearance.BorderSize = 0;
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_Button.Image")));
            this.Minimize_Button.Location = new System.Drawing.Point(1177, 0);
            this.Minimize_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(38, 30);
            this.Minimize_Button.TabIndex = 1;
            this.Minimize_Button.UseVisualStyleBackColor = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Form_Loader
            // 
            this.Form_Loader.Location = new System.Drawing.Point(220, 36);
            this.Form_Loader.Name = "Form_Loader";
            this.Form_Loader.Size = new System.Drawing.Size(1005, 665);
            this.Form_Loader.TabIndex = 3;
            // 
            // AddMember_Button
            // 
            this.AddMember_Button.FlatAppearance.BorderSize = 0;
            this.AddMember_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.AddMember_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMember_Button.Image = ((System.Drawing.Image)(resources.GetObject("AddMember_Button.Image")));
            this.AddMember_Button.Location = new System.Drawing.Point(154, 653);
            this.AddMember_Button.Name = "AddMember_Button";
            this.AddMember_Button.Size = new System.Drawing.Size(61, 56);
            this.AddMember_Button.TabIndex = 6;
            this.AddMember_Button.UseVisualStyleBackColor = true;
            this.AddMember_Button.Click += new System.EventHandler(this.AddMember_Button_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.Form_Loader);
            this.Controls.Add(this.Form_Border);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Form_Border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button CourseMenu_Button;
        private System.Windows.Forms.Panel Form_Border;
        private System.Windows.Forms.Panel Form_Loader;
        private System.Windows.Forms.Button StudentMenu_Button;
        private System.Windows.Forms.Button Dashoard_Button_Click;
        private System.Windows.Forms.Button SettingsMenu_Button;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button SignOut_Button;
        private System.Windows.Forms.Button AddMember_Button;
    }
}