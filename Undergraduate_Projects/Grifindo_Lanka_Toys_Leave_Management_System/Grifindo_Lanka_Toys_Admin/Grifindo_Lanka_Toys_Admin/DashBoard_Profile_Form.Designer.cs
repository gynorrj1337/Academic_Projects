namespace Grifindo_Lanka_Toys_Admin
{
    partial class DashBoard_Profile_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard_Profile_Form));
            this.pnl_Logger = new System.Windows.Forms.Panel();
            this.lbl_AccessedTime = new System.Windows.Forms.Label();
            this.lbl_AdminGreeting = new System.Windows.Forms.Label();
            this.pic_Logger = new System.Windows.Forms.PictureBox();
            this.Movitvate_PB = new System.Windows.Forms.PictureBox();
            this.pnl_Logger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movitvate_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Logger
            // 
            this.pnl_Logger.Controls.Add(this.lbl_AccessedTime);
            this.pnl_Logger.Controls.Add(this.lbl_AdminGreeting);
            this.pnl_Logger.Controls.Add(this.pic_Logger);
            this.pnl_Logger.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Logger.Location = new System.Drawing.Point(593, 2);
            this.pnl_Logger.Name = "pnl_Logger";
            this.pnl_Logger.Size = new System.Drawing.Size(376, 631);
            this.pnl_Logger.TabIndex = 7;
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
            this.Movitvate_PB.Location = new System.Drawing.Point(12, 25);
            this.Movitvate_PB.Name = "Movitvate_PB";
            this.Movitvate_PB.Size = new System.Drawing.Size(575, 319);
            this.Movitvate_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Movitvate_PB.TabIndex = 8;
            this.Movitvate_PB.TabStop = false;
            // 
            // DashBoard_Profile_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(987, 619);
            this.Controls.Add(this.pnl_Logger);
            this.Controls.Add(this.Movitvate_PB);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DashBoard_Profile_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard_Profile_Form";
            this.pnl_Logger.ResumeLayout(false);
            this.pnl_Logger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movitvate_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Logger;
        private System.Windows.Forms.Label lbl_AccessedTime;
        private System.Windows.Forms.Label lbl_AdminGreeting;
        private System.Windows.Forms.PictureBox pic_Logger;
        private System.Windows.Forms.PictureBox Movitvate_PB;
    }
}