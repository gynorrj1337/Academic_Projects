namespace SM_Application
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName_TextBox = new System.Windows.Forms.TextBox();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.SignIn_Button = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Label();
            this.Hide_Button = new System.Windows.Forms.Button();
            this.Show_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Close_Button
            // 
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.Location = new System.Drawing.Point(650, 0);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(31, 26);
            this.Close_Button.TabIndex = 1;
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans Medium", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(443, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sign In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Font = new System.Drawing.Font("Product Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_TextBox.Location = new System.Drawing.Point(400, 167);
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.Size = new System.Drawing.Size(208, 26);
            this.UserName_TextBox.TabIndex = 5;
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Font = new System.Drawing.Font("Product Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Textbox.Location = new System.Drawing.Point(400, 223);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(208, 26);
            this.Password_Textbox.TabIndex = 7;
            this.Password_Textbox.UseSystemPasswordChar = true;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.Location = new System.Drawing.Point(396, 200);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(84, 20);
            this.Password_Label.TabIndex = 6;
            this.Password_Label.Text = "Password";
            // 
            // SignIn_Button
            // 
            this.SignIn_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.SignIn_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SignIn_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn_Button.FlatAppearance.BorderSize = 0;
            this.SignIn_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn_Button.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_Button.ForeColor = System.Drawing.Color.White;
            this.SignIn_Button.Location = new System.Drawing.Point(500, 276);
            this.SignIn_Button.Name = "SignIn_Button";
            this.SignIn_Button.Size = new System.Drawing.Size(108, 39);
            this.SignIn_Button.TabIndex = 8;
            this.SignIn_Button.Text = "Sign In";
            this.SignIn_Button.UseVisualStyleBackColor = false;
            this.SignIn_Button.Click += new System.EventHandler(this.SignIn_Button_Click);
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Product Sans Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Clear.Location = new System.Drawing.Point(397, 276);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(41, 18);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Hide_Button
            // 
            this.Hide_Button.BackColor = System.Drawing.Color.White;
            this.Hide_Button.FlatAppearance.BorderSize = 0;
            this.Hide_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide_Button.Image = ((System.Drawing.Image)(resources.GetObject("Hide_Button.Image")));
            this.Hide_Button.Location = new System.Drawing.Point(583, 224);
            this.Hide_Button.Name = "Hide_Button";
            this.Hide_Button.Size = new System.Drawing.Size(24, 24);
            this.Hide_Button.TabIndex = 11;
            this.Hide_Button.UseVisualStyleBackColor = false;
            this.Hide_Button.Click += new System.EventHandler(this.Hide_Button_Click);
            // 
            // Show_Button
            // 
            this.Show_Button.FlatAppearance.BorderSize = 0;
            this.Show_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Button.Image = ((System.Drawing.Image)(resources.GetObject("Show_Button.Image")));
            this.Show_Button.Location = new System.Drawing.Point(583, 224);
            this.Show_Button.Name = "Show_Button";
            this.Show_Button.Size = new System.Drawing.Size(24, 24);
            this.Show_Button.TabIndex = 12;
            this.Show_Button.UseVisualStyleBackColor = true;
            this.Show_Button.Click += new System.EventHandler(this.Show_Button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 389);
            this.Controls.Add(this.Show_Button);
            this.Controls.Add(this.Hide_Button);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.SignIn_Button);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.UserName_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName_TextBox;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button SignIn_Button;
        private System.Windows.Forms.Label Clear;
        private System.Windows.Forms.Button Hide_Button;
        private System.Windows.Forms.Button Show_Button;
    }
}

