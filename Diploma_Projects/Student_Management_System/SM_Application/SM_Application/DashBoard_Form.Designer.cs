namespace SM_Application
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
            this.Loger_Panel = new System.Windows.Forms.Panel();
            this.Accessed_Label = new System.Windows.Forms.Label();
            this.UserGreeting_Label = new System.Windows.Forms.Label();
            this.Loger_PictureBox = new System.Windows.Forms.PictureBox();
            this.Movitvate_PB = new System.Windows.Forms.PictureBox();
            this.Loger_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loger_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movitvate_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Loger_Panel
            // 
            this.Loger_Panel.Controls.Add(this.Accessed_Label);
            this.Loger_Panel.Controls.Add(this.UserGreeting_Label);
            this.Loger_Panel.Controls.Add(this.Loger_PictureBox);
            this.Loger_Panel.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loger_Panel.Location = new System.Drawing.Point(488, -8);
            this.Loger_Panel.Name = "Loger_Panel";
            this.Loger_Panel.Size = new System.Drawing.Size(376, 631);
            this.Loger_Panel.TabIndex = 0;
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
            this.UserGreeting_Label.Click += new System.EventHandler(this.UserGreeting_Label_Click);
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
            this.Movitvate_PB.Location = new System.Drawing.Point(12, 12);
            this.Movitvate_PB.Name = "Movitvate_PB";
            this.Movitvate_PB.Size = new System.Drawing.Size(470, 295);
            this.Movitvate_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Movitvate_PB.TabIndex = 4;
            this.Movitvate_PB.TabStop = false;
            // 
            // DashBoard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 614);
            this.Controls.Add(this.Movitvate_PB);
            this.Controls.Add(this.Loger_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard_Form";
            this.Text = "DashBoard_Form";
            this.Loger_Panel.ResumeLayout(false);
            this.Loger_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loger_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movitvate_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Loger_Panel;
        private System.Windows.Forms.PictureBox Loger_PictureBox;
        private System.Windows.Forms.PictureBox Movitvate_PB;
        private System.Windows.Forms.Label Accessed_Label;
        private System.Windows.Forms.Label UserGreeting_Label;
    }
}