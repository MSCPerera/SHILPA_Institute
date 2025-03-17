
namespace DiTEC193FinalProject
{
    partial class frm_Attendance
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Attendance = new System.Windows.Forms.Label();
            this.dtp_SelectDate = new System.Windows.Forms.DateTimePicker();
            this.dgv_Attendance = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_Print = new System.Windows.Forms.Button();
            this.lbl_SelectDate = new System.Windows.Forms.Label();
            this.lbl_LectureName = new System.Windows.Forms.Label();
            this.txt_LectureName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(696, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(92, 39);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Attendance
            // 
            this.lbl_Attendance.AutoSize = true;
            this.lbl_Attendance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Attendance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Attendance.Location = new System.Drawing.Point(25, 9);
            this.lbl_Attendance.Name = "lbl_Attendance";
            this.lbl_Attendance.Size = new System.Drawing.Size(201, 38);
            this.lbl_Attendance.TabIndex = 3;
            this.lbl_Attendance.Text = "Attendance";
            // 
            // dtp_SelectDate
            // 
            this.dtp_SelectDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_SelectDate.Location = new System.Drawing.Point(528, 83);
            this.dtp_SelectDate.Name = "dtp_SelectDate";
            this.dtp_SelectDate.Size = new System.Drawing.Size(176, 23);
            this.dtp_SelectDate.TabIndex = 5;
            this.dtp_SelectDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dgv_Attendance
            // 
            this.dgv_Attendance.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_Attendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Attendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dgv_Attendance.Location = new System.Drawing.Point(28, 136);
            this.dgv_Attendance.Name = "dgv_Attendance";
            this.dgv_Attendance.ShowCellErrors = false;
            this.dgv_Attendance.ShowEditingIcon = false;
            this.dgv_Attendance.ShowRowErrors = false;
            this.dgv_Attendance.Size = new System.Drawing.Size(743, 289);
            this.dgv_Attendance.TabIndex = 6;
            this.dgv_Attendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Attendance_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select Course";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Reg No.";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Registration No.";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 150;
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(601, 439);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(170, 36);
            this.btn_Print.TabIndex = 8;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // lbl_SelectDate
            // 
            this.lbl_SelectDate.AutoSize = true;
            this.lbl_SelectDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectDate.Location = new System.Drawing.Point(525, 61);
            this.lbl_SelectDate.Name = "lbl_SelectDate";
            this.lbl_SelectDate.Size = new System.Drawing.Size(90, 17);
            this.lbl_SelectDate.TabIndex = 9;
            this.lbl_SelectDate.Text = "Select Date :";
            // 
            // lbl_LectureName
            // 
            this.lbl_LectureName.AutoSize = true;
            this.lbl_LectureName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LectureName.Location = new System.Drawing.Point(25, 61);
            this.lbl_LectureName.Name = "lbl_LectureName";
            this.lbl_LectureName.Size = new System.Drawing.Size(107, 17);
            this.lbl_LectureName.TabIndex = 10;
            this.lbl_LectureName.Text = "Lecture Name :";
            // 
            // txt_LectureName
            // 
            this.txt_LectureName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LectureName.Location = new System.Drawing.Point(28, 83);
            this.txt_LectureName.Name = "txt_LectureName";
            this.txt_LectureName.Size = new System.Drawing.Size(195, 23);
            this.txt_LectureName.TabIndex = 11;
            // 
            // frm_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.txt_LectureName);
            this.Controls.Add(this.lbl_LectureName);
            this.Controls.Add(this.lbl_SelectDate);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.dgv_Attendance);
            this.Controls.Add(this.dtp_SelectDate);
            this.Controls.Add(this.lbl_Attendance);
            this.Controls.Add(this.btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.frm_AttendanceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Attendance;
        private System.Windows.Forms.DateTimePicker dtp_SelectDate;
        private System.Windows.Forms.DataGridView dgv_Attendance;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label lbl_SelectDate;
        private System.Windows.Forms.Label lbl_LectureName;
        private System.Windows.Forms.TextBox txt_LectureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
    }
}