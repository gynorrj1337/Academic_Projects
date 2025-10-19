namespace SM_Application
{
    partial class Search_Form
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
            this.Student_DGV = new System.Windows.Forms.DataGridView();
            this.Display = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Student_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Student_DGV
            // 
            this.Student_DGV.BackgroundColor = System.Drawing.Color.White;
            this.Student_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Student_DGV.Location = new System.Drawing.Point(7, 44);
            this.Student_DGV.Name = "Student_DGV";
            this.Student_DGV.Size = new System.Drawing.Size(843, 335);
            this.Student_DGV.TabIndex = 0;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Display.FlatAppearance.BorderSize = 0;
            this.Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display.Font = new System.Drawing.Font("Product Sans Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(12, 416);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(89, 37);
            this.Display.TabIndex = 1;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = false;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 614);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Student_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search_Form";
            this.Text = "Search_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Student_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Student_DGV;
        private System.Windows.Forms.Button Display;
    }
}