namespace SM_Application
{
    partial class StudentMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMenu));
            this.Student_Loader = new System.Windows.Forms.Panel();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Registration_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Student_Loader
            // 
            this.Student_Loader.BackColor = System.Drawing.Color.Transparent;
            this.Student_Loader.Location = new System.Drawing.Point(2, 1);
            this.Student_Loader.Name = "Student_Loader";
            this.Student_Loader.Size = new System.Drawing.Size(1005, 665);
            this.Student_Loader.TabIndex = 2;
            // 
            // Search_Button
            // 
            this.Search_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Button.FlatAppearance.BorderSize = 0;
            this.Search_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Button.Font = new System.Drawing.Font("Product Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.Image = ((System.Drawing.Image)(resources.GetObject("Search_Button.Image")));
            this.Search_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Search_Button.Location = new System.Drawing.Point(311, 22);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(239, 223);
            this.Search_Button.TabIndex = 3;
            this.Search_Button.Text = "Search";
            this.Search_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Registration_Button
            // 
            this.Registration_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration_Button.FlatAppearance.BorderSize = 0;
            this.Registration_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.Registration_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_Button.Font = new System.Drawing.Font("Product Sans Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_Button.Image = ((System.Drawing.Image)(resources.GetObject("Registration_Button.Image")));
            this.Registration_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Registration_Button.Location = new System.Drawing.Point(33, 22);
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.Size = new System.Drawing.Size(255, 223);
            this.Registration_Button.TabIndex = 4;
            this.Registration_Button.Text = "Registration";
            this.Registration_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Registration_Button.UseVisualStyleBackColor = false;
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 665);
            this.Controls.Add(this.Registration_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Student_Loader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Student_Loader;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Registration_Button;
    }
}