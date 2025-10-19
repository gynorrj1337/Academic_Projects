namespace E_Space_Mars_Colonization
{
    partial class Jet_Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Title_Name_Label = new System.Windows.Forms.Label();
            this.Display_Button = new System.Windows.Forms.Button();
            this.EJet_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EJet_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Name_Label
            // 
            this.Title_Name_Label.AutoSize = true;
            this.Title_Name_Label.Font = new System.Drawing.Font("Product Sans Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Name_Label.Location = new System.Drawing.Point(6, 43);
            this.Title_Name_Label.Name = "Title_Name_Label";
            this.Title_Name_Label.Size = new System.Drawing.Size(133, 26);
            this.Title_Name_Label.TabIndex = 10;
            this.Title_Name_Label.Text = "EJet Report";
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
            this.Display_Button.TabIndex = 9;
            this.Display_Button.Text = "Display";
            this.Display_Button.UseVisualStyleBackColor = false;
            this.Display_Button.Click += new System.EventHandler(this.Display_Button_Click);
            // 
            // EJet_DGV
            // 
            this.EJet_DGV.AllowUserToAddRows = false;
            this.EJet_DGV.AllowUserToDeleteRows = false;
            this.EJet_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.EJet_DGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EJet_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EJet_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EJet_DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.EJet_DGV.Location = new System.Drawing.Point(10, 103);
            this.EJet_DGV.Name = "EJet_DGV";
            this.EJet_DGV.ReadOnly = true;
            this.EJet_DGV.Size = new System.Drawing.Size(983, 335);
            this.EJet_DGV.TabIndex = 8;
            // 
            // Jet_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1005, 665);
            this.Controls.Add(this.Title_Name_Label);
            this.Controls.Add(this.Display_Button);
            this.Controls.Add(this.EJet_DGV);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Jet_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jet_Report";
            ((System.ComponentModel.ISupportInitialize)(this.EJet_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Name_Label;
        private System.Windows.Forms.Button Display_Button;
        private System.Windows.Forms.DataGridView EJet_DGV;
    }
}