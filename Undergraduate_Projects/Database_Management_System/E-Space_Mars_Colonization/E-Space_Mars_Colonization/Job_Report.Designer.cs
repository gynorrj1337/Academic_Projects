namespace E_Space_Mars_Colonization
{
    partial class Job_Report
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
            this.Title_Name_Label = new System.Windows.Forms.Label();
            this.Display_Button = new System.Windows.Forms.Button();
            this.Job_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Job_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Name_Label
            // 
            this.Title_Name_Label.AutoSize = true;
            this.Title_Name_Label.Font = new System.Drawing.Font("Product Sans Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Name_Label.Location = new System.Drawing.Point(6, 43);
            this.Title_Name_Label.Name = "Title_Name_Label";
            this.Title_Name_Label.Size = new System.Drawing.Size(125, 26);
            this.Title_Name_Label.TabIndex = 13;
            this.Title_Name_Label.Text = "Job Report";
            // 
            // Display_Button
            // 
            this.Display_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Display_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Display_Button.FlatAppearance.BorderSize = 0;
            this.Display_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display_Button.Font = new System.Drawing.Font("Product Sans Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_Button.Location = new System.Drawing.Point(15, 475);
            this.Display_Button.Name = "Display_Button";
            this.Display_Button.Size = new System.Drawing.Size(89, 37);
            this.Display_Button.TabIndex = 12;
            this.Display_Button.Text = "Display";
            this.Display_Button.UseVisualStyleBackColor = false;
            this.Display_Button.Click += new System.EventHandler(this.Display_Button_Click);
            // 
            // Job_DGV
            // 
            this.Job_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Job_DGV.BackgroundColor = System.Drawing.Color.White;
            this.Job_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Job_DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Job_DGV.Location = new System.Drawing.Point(10, 103);
            this.Job_DGV.Name = "Job_DGV";
            this.Job_DGV.Size = new System.Drawing.Size(843, 335);
            this.Job_DGV.TabIndex = 11;
            // 
            // Job_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(862, 614);
            this.Controls.Add(this.Title_Name_Label);
            this.Controls.Add(this.Display_Button);
            this.Controls.Add(this.Job_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Job_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job_Report";
            ((System.ComponentModel.ISupportInitialize)(this.Job_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Name_Label;
        private System.Windows.Forms.Button Display_Button;
        private System.Windows.Forms.DataGridView Job_DGV;
    }
}