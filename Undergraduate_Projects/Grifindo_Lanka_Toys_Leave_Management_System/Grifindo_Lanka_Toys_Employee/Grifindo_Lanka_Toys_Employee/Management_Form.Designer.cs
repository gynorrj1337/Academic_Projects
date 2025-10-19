namespace Grifindo_Lanka_Toys_Employee
{
    partial class Management_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management_Form));
            this.Management_Label = new System.Windows.Forms.Label();
            this.Btn_Leave = new System.Windows.Forms.Button();
            this.Pnl_Management_Form = new System.Windows.Forms.Panel();
            this.Pnl_Management_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // Management_Label
            // 
            this.Management_Label.AutoSize = true;
            this.Management_Label.Font = new System.Drawing.Font("Product Sans Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Management_Label.Location = new System.Drawing.Point(103, 61);
            this.Management_Label.Name = "Management_Label";
            this.Management_Label.Size = new System.Drawing.Size(184, 34);
            this.Management_Label.TabIndex = 10;
            this.Management_Label.Text = "Management";
            // 
            // Btn_Leave
            // 
            this.Btn_Leave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Leave.FlatAppearance.BorderSize = 0;
            this.Btn_Leave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Btn_Leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Leave.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Leave.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Leave.Image")));
            this.Btn_Leave.Location = new System.Drawing.Point(109, 110);
            this.Btn_Leave.Name = "Btn_Leave";
            this.Btn_Leave.Size = new System.Drawing.Size(150, 150);
            this.Btn_Leave.TabIndex = 0;
            this.Btn_Leave.Text = "Leave";
            this.Btn_Leave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Leave.UseVisualStyleBackColor = true;
            this.Btn_Leave.Click += new System.EventHandler(this.Btn_Leave_Click);
            // 
            // Pnl_Management_Form
            // 
            this.Pnl_Management_Form.BackColor = System.Drawing.SystemColors.Window;
            this.Pnl_Management_Form.Controls.Add(this.Management_Label);
            this.Pnl_Management_Form.Controls.Add(this.Btn_Leave);
            this.Pnl_Management_Form.Location = new System.Drawing.Point(1, 1);
            this.Pnl_Management_Form.Name = "Pnl_Management_Form";
            this.Pnl_Management_Form.Size = new System.Drawing.Size(1027, 673);
            this.Pnl_Management_Form.TabIndex = 2;
            // 
            // Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 673);
            this.Controls.Add(this.Pnl_Management_Form);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Management_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management_Form";
            this.Pnl_Management_Form.ResumeLayout(false);
            this.Pnl_Management_Form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Management_Label;
        private System.Windows.Forms.Button Btn_Leave;
        private System.Windows.Forms.Panel Pnl_Management_Form;
    }
}