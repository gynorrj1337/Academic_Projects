namespace Grifindo_Lanka_Toys_Employee
{
    partial class Leave_History_Form
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
            this.Grp_Remaining_Leaves = new System.Windows.Forms.GroupBox();
            this.txt_ShortLeaves = new System.Windows.Forms.TextBox();
            this.lbl_ShortLeave = new System.Windows.Forms.Label();
            this.txt_CasualLeaves = new System.Windows.Forms.TextBox();
            this.lbl_CasusalLeave = new System.Windows.Forms.Label();
            this.txt_AnnualLeaves = new System.Windows.Forms.TextBox();
            this.lbl_AnnualLeave = new System.Windows.Forms.Label();
            this.lbl_History = new System.Windows.Forms.Label();
            this.Btn_Display = new System.Windows.Forms.Button();
            this.dgv_History = new System.Windows.Forms.DataGridView();
            this.Grp_Remaining_Leaves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_Remaining_Leaves
            // 
            this.Grp_Remaining_Leaves.Controls.Add(this.txt_ShortLeaves);
            this.Grp_Remaining_Leaves.Controls.Add(this.lbl_ShortLeave);
            this.Grp_Remaining_Leaves.Controls.Add(this.txt_CasualLeaves);
            this.Grp_Remaining_Leaves.Controls.Add(this.lbl_CasusalLeave);
            this.Grp_Remaining_Leaves.Controls.Add(this.txt_AnnualLeaves);
            this.Grp_Remaining_Leaves.Controls.Add(this.lbl_AnnualLeave);
            this.Grp_Remaining_Leaves.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Remaining_Leaves.Location = new System.Drawing.Point(12, 22);
            this.Grp_Remaining_Leaves.Name = "Grp_Remaining_Leaves";
            this.Grp_Remaining_Leaves.Size = new System.Drawing.Size(963, 150);
            this.Grp_Remaining_Leaves.TabIndex = 38;
            this.Grp_Remaining_Leaves.TabStop = false;
            this.Grp_Remaining_Leaves.Text = "Remaining Leaves";
            // 
            // txt_ShortLeaves
            // 
            this.txt_ShortLeaves.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ShortLeaves.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ShortLeaves.Location = new System.Drawing.Point(188, 104);
            this.txt_ShortLeaves.Name = "txt_ShortLeaves";
            this.txt_ShortLeaves.ReadOnly = true;
            this.txt_ShortLeaves.Size = new System.Drawing.Size(253, 27);
            this.txt_ShortLeaves.TabIndex = 41;
            // 
            // lbl_ShortLeave
            // 
            this.lbl_ShortLeave.AutoSize = true;
            this.lbl_ShortLeave.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShortLeave.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_ShortLeave.Location = new System.Drawing.Point(6, 104);
            this.lbl_ShortLeave.Name = "lbl_ShortLeave";
            this.lbl_ShortLeave.Size = new System.Drawing.Size(104, 20);
            this.lbl_ShortLeave.TabIndex = 40;
            this.lbl_ShortLeave.Text = "Short Leave";
            // 
            // txt_CasualLeaves
            // 
            this.txt_CasualLeaves.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CasualLeaves.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_CasualLeaves.Location = new System.Drawing.Point(188, 65);
            this.txt_CasualLeaves.Name = "txt_CasualLeaves";
            this.txt_CasualLeaves.ReadOnly = true;
            this.txt_CasualLeaves.Size = new System.Drawing.Size(253, 27);
            this.txt_CasualLeaves.TabIndex = 39;
            // 
            // lbl_CasusalLeave
            // 
            this.lbl_CasusalLeave.AutoSize = true;
            this.lbl_CasusalLeave.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CasusalLeave.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_CasusalLeave.Location = new System.Drawing.Point(6, 67);
            this.lbl_CasusalLeave.Name = "lbl_CasusalLeave";
            this.lbl_CasusalLeave.Size = new System.Drawing.Size(116, 20);
            this.lbl_CasusalLeave.TabIndex = 38;
            this.lbl_CasusalLeave.Text = "Casual Leave";
            // 
            // txt_AnnualLeaves
            // 
            this.txt_AnnualLeaves.BackColor = System.Drawing.SystemColors.Window;
            this.txt_AnnualLeaves.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_AnnualLeaves.Location = new System.Drawing.Point(188, 28);
            this.txt_AnnualLeaves.Name = "txt_AnnualLeaves";
            this.txt_AnnualLeaves.ReadOnly = true;
            this.txt_AnnualLeaves.Size = new System.Drawing.Size(253, 27);
            this.txt_AnnualLeaves.TabIndex = 37;
            // 
            // lbl_AnnualLeave
            // 
            this.lbl_AnnualLeave.AutoSize = true;
            this.lbl_AnnualLeave.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnnualLeave.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_AnnualLeave.Location = new System.Drawing.Point(6, 30);
            this.lbl_AnnualLeave.Name = "lbl_AnnualLeave";
            this.lbl_AnnualLeave.Size = new System.Drawing.Size(117, 20);
            this.lbl_AnnualLeave.TabIndex = 36;
            this.lbl_AnnualLeave.Text = "Annual Leave";
            // 
            // lbl_History
            // 
            this.lbl_History.AutoSize = true;
            this.lbl_History.Font = new System.Drawing.Font("Product Sans Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_History.Location = new System.Drawing.Point(12, 197);
            this.lbl_History.Name = "lbl_History";
            this.lbl_History.Size = new System.Drawing.Size(88, 26);
            this.lbl_History.TabIndex = 39;
            this.lbl_History.Text = "History";
            // 
            // Btn_Display
            // 
            this.Btn_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.Btn_Display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Display.FlatAppearance.BorderSize = 0;
            this.Btn_Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Display.Font = new System.Drawing.Font("Product Sans Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Display.Location = new System.Drawing.Point(17, 597);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(86, 35);
            this.Btn_Display.TabIndex = 41;
            this.Btn_Display.Text = "Display";
            this.Btn_Display.UseVisualStyleBackColor = false;
            this.Btn_Display.Click += new System.EventHandler(this.Btn_Display_Click);
            // 
            // dgv_History
            // 
            this.dgv_History.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_History.BackgroundColor = System.Drawing.Color.White;
            this.dgv_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_History.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.dgv_History.Location = new System.Drawing.Point(17, 238);
            this.dgv_History.Name = "dgv_History";
            this.dgv_History.Size = new System.Drawing.Size(980, 335);
            this.dgv_History.TabIndex = 42;
            // 
            // Leave_History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 673);
            this.Controls.Add(this.dgv_History);
            this.Controls.Add(this.Btn_Display);
            this.Controls.Add(this.lbl_History);
            this.Controls.Add(this.Grp_Remaining_Leaves);
            this.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Leave_History_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave_History_Form";
            this.Load += new System.EventHandler(this.Leave_History_Form_Load);
            this.Grp_Remaining_Leaves.ResumeLayout(false);
            this.Grp_Remaining_Leaves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_Remaining_Leaves;
        private System.Windows.Forms.TextBox txt_ShortLeaves;
        private System.Windows.Forms.Label lbl_ShortLeave;
        private System.Windows.Forms.TextBox txt_CasualLeaves;
        private System.Windows.Forms.Label lbl_CasusalLeave;
        private System.Windows.Forms.TextBox txt_AnnualLeaves;
        private System.Windows.Forms.Label lbl_AnnualLeave;
        private System.Windows.Forms.Label lbl_History;
        private System.Windows.Forms.Button Btn_Display;
        private System.Windows.Forms.DataGridView dgv_History;
    }
}