
namespace DiTEC193FinalProject
{
    partial class frm_AddUsers
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
            this.components = new System.ComponentModel.Container();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.tbllogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new DiTEC193FinalProject.AppData();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.btn_NewUser = new System.Windows.Forms.Button();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.btn_SaveUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dgv_UsersData = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbllogTableAdapter = new DiTEC193FinalProject.AppDataTableAdapters.tbllogTableAdapter();
            this.lbl_CreateSystemUsers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsersData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(33, 75);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(85, 17);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "User Name :";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(33, 113);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(77, 17);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password :";
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Role.Location = new System.Drawing.Point(33, 154);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(44, 17);
            this.lbl_Role.TabIndex = 2;
            this.lbl_Role.Text = "Role :";
            // 
            // txt_UserName
            // 
            this.txt_UserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "Username", true));
            this.txt_UserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(135, 63);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(180, 29);
            this.txt_UserName.TabIndex = 3;
            this.txt_UserName.TextChanged += new System.EventHandler(this.txt_UserName_TextChanged);
            // 
            // tbllogBindingSource
            // 
            this.tbllogBindingSource.DataMember = "tbllog";
            this.tbllogBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_Password
            // 
            this.txt_Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "Password", true));
            this.txt_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(135, 100);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(180, 30);
            this.txt_Password.TabIndex = 4;
            // 
            // cb_Role
            // 
            this.cb_Role.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tbllogBindingSource, "Role", true));
            this.cb_Role.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Items.AddRange(new object[] {
            "Administrator",
            "Receptionist",
            "Lecturer"});
            this.cb_Role.Location = new System.Drawing.Point(135, 151);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(180, 25);
            this.cb_Role.TabIndex = 5;
            this.cb_Role.SelectedIndexChanged += new System.EventHandler(this.cb_Role_SelectedIndexChanged);
            // 
            // btn_NewUser
            // 
            this.btn_NewUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_NewUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewUser.ForeColor = System.Drawing.Color.White;
            this.btn_NewUser.Location = new System.Drawing.Point(65, 194);
            this.btn_NewUser.Name = "btn_NewUser";
            this.btn_NewUser.Size = new System.Drawing.Size(250, 40);
            this.btn_NewUser.TabIndex = 6;
            this.btn_NewUser.Text = "New User";
            this.btn_NewUser.UseVisualStyleBackColor = false;
            this.btn_NewUser.Click += new System.EventHandler(this.btn_NewUser_Click);
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_EditUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditUser.ForeColor = System.Drawing.Color.White;
            this.btn_EditUser.Location = new System.Drawing.Point(65, 245);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(250, 40);
            this.btn_EditUser.TabIndex = 7;
            this.btn_EditUser.Text = "Edit User";
            this.btn_EditUser.UseVisualStyleBackColor = false;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // btn_SaveUser
            // 
            this.btn_SaveUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_SaveUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveUser.ForeColor = System.Drawing.Color.White;
            this.btn_SaveUser.Location = new System.Drawing.Point(65, 296);
            this.btn_SaveUser.Name = "btn_SaveUser";
            this.btn_SaveUser.Size = new System.Drawing.Size(250, 40);
            this.btn_SaveUser.TabIndex = 8;
            this.btn_SaveUser.Text = "Save User";
            this.btn_SaveUser.UseVisualStyleBackColor = false;
            this.btn_SaveUser.Click += new System.EventHandler(this.btn_SaveUser_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteUser.Location = new System.Drawing.Point(65, 347);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(250, 40);
            this.btn_DeleteUser.TabIndex = 9;
            this.btn_DeleteUser.Text = "Delete User";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(65, 398);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(250, 40);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(699, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(89, 40);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dgv_UsersData
            // 
            this.dgv_UsersData.AutoGenerateColumns = false;
            this.dgv_UsersData.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_UsersData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_UsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UsersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgv_UsersData.DataSource = this.tbllogBindingSource;
            this.dgv_UsersData.Location = new System.Drawing.Point(384, 69);
            this.dgv_UsersData.Name = "dgv_UsersData";
            this.dgv_UsersData.ReadOnly = true;
            this.dgv_UsersData.Size = new System.Drawing.Size(404, 369);
            this.dgv_UsersData.TabIndex = 12;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 120;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 120;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 120;
            // 
            // tbllogTableAdapter
            // 
            this.tbllogTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_CreateSystemUsers
            // 
            this.lbl_CreateSystemUsers.AutoSize = true;
            this.lbl_CreateSystemUsers.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateSystemUsers.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_CreateSystemUsers.Location = new System.Drawing.Point(33, 9);
            this.lbl_CreateSystemUsers.Name = "lbl_CreateSystemUsers";
            this.lbl_CreateSystemUsers.Size = new System.Drawing.Size(329, 38);
            this.lbl_CreateSystemUsers.TabIndex = 13;
            this.lbl_CreateSystemUsers.Text = "Create System Users";
            // 
            // frm_AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_CreateSystemUsers);
            this.Controls.Add(this.dgv_UsersData);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.btn_SaveUser);
            this.Controls.Add(this.btn_EditUser);
            this.Controls.Add(this.btn_NewUser);
            this.Controls.Add(this.cb_Role);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddUsers";
            this.Load += new System.EventHandler(this.frm_AddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsersData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.ComboBox cb_Role;
        private System.Windows.Forms.Button btn_NewUser;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.Button btn_SaveUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dgv_UsersData;
        private AppData appData;
        private System.Windows.Forms.BindingSource tbllogBindingSource;
        private AppDataTableAdapters.tbllogTableAdapter tbllogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_CreateSystemUsers;
    }
}