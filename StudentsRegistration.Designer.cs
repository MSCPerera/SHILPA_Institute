
namespace DiTEC193FinalProject
{
    partial class frm_StudentsRegistration
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
            this.lbl_StudentRegistrationNumber = new System.Windows.Forms.Label();
            this.txt_StudentRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lbl_RegistrationDate = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.dtp_RegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.cb_Title = new System.Windows.Forms.ComboBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_NIC = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_DateofBirth = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.dtp_DateofBirth = new System.Windows.Forms.DateTimePicker();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.lbl_Emergency = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Home = new System.Windows.Forms.TextBox();
            this.txt_Mobile = new System.Windows.Forms.TextBox();
            this.txt_Emergency = new System.Windows.Forms.TextBox();
            this.lbl_EducationalQualification = new System.Windows.Forms.Label();
            this.lbl_Other = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.cb_EducationalQualification = new System.Windows.Forms.ComboBox();
            this.txt_Other = new System.Windows.Forms.TextBox();
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_StudentsRegistration = new System.Windows.Forms.DataGridView();
            this.pnl_StudentsRegistration = new System.Windows.Forms.Panel();
            this.lbl_StudentRegistration = new System.Windows.Forms.Label();
            this.lbl_SelectCourse = new System.Windows.Forms.Label();
            this.cb_SelectCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentsRegistration)).BeginInit();
            this.pnl_StudentsRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(840, 11);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(92, 39);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_StudentRegistrationNumber
            // 
            this.lbl_StudentRegistrationNumber.AutoSize = true;
            this.lbl_StudentRegistrationNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentRegistrationNumber.ForeColor = System.Drawing.Color.Black;
            this.lbl_StudentRegistrationNumber.Location = new System.Drawing.Point(23, 150);
            this.lbl_StudentRegistrationNumber.Name = "lbl_StudentRegistrationNumber";
            this.lbl_StudentRegistrationNumber.Size = new System.Drawing.Size(201, 17);
            this.lbl_StudentRegistrationNumber.TabIndex = 1;
            this.lbl_StudentRegistrationNumber.Text = "Student Registration Number :";
            // 
            // txt_StudentRegistrationNumber
            // 
            this.txt_StudentRegistrationNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentRegistrationNumber.Location = new System.Drawing.Point(230, 147);
            this.txt_StudentRegistrationNumber.Multiline = true;
            this.txt_StudentRegistrationNumber.Name = "txt_StudentRegistrationNumber";
            this.txt_StudentRegistrationNumber.Size = new System.Drawing.Size(145, 24);
            this.txt_StudentRegistrationNumber.TabIndex = 2;
            // 
            // lbl_RegistrationDate
            // 
            this.lbl_RegistrationDate.AutoSize = true;
            this.lbl_RegistrationDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistrationDate.Location = new System.Drawing.Point(403, 149);
            this.lbl_RegistrationDate.Name = "lbl_RegistrationDate";
            this.lbl_RegistrationDate.Size = new System.Drawing.Size(128, 17);
            this.lbl_RegistrationDate.TabIndex = 3;
            this.lbl_RegistrationDate.Text = "Registration Date :";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(24, 77);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(40, 17);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Title :";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // dtp_RegistrationDate
            // 
            this.dtp_RegistrationDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_RegistrationDate.Location = new System.Drawing.Point(537, 145);
            this.dtp_RegistrationDate.Name = "dtp_RegistrationDate";
            this.dtp_RegistrationDate.Size = new System.Drawing.Size(164, 23);
            this.dtp_RegistrationDate.TabIndex = 5;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(235, 77);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(83, 17);
            this.lbl_FirstName.TabIndex = 6;
            this.lbl_FirstName.Text = "First Name :";
            // 
            // cb_Title
            // 
            this.cb_Title.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Title.FormattingEnabled = true;
            this.cb_Title.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms."});
            this.cb_Title.Location = new System.Drawing.Point(70, 74);
            this.cb_Title.Name = "cb_Title";
            this.cb_Title.Size = new System.Drawing.Size(131, 25);
            this.cb_Title.TabIndex = 7;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastName.Location = new System.Drawing.Point(485, 77);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(85, 17);
            this.lbl_LastName.TabIndex = 8;
            this.lbl_LastName.Text = "Last Name :";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(405, 194);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(64, 17);
            this.lbl_Gender.TabIndex = 9;
            this.lbl_Gender.Text = "Gender :";
            // 
            // lbl_NIC
            // 
            this.lbl_NIC.AutoSize = true;
            this.lbl_NIC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NIC.Location = new System.Drawing.Point(22, 233);
            this.lbl_NIC.Name = "lbl_NIC";
            this.lbl_NIC.Size = new System.Drawing.Size(104, 17);
            this.lbl_NIC.TabIndex = 10;
            this.lbl_NIC.Text = "NIC/ Passport :";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstName.Location = new System.Drawing.Point(324, 74);
            this.txt_FirstName.Multiline = true;
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(136, 26);
            this.txt_FirstName.TabIndex = 11;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.Location = new System.Drawing.Point(576, 74);
            this.txt_LastName.Multiline = true;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(147, 26);
            this.txt_LastName.TabIndex = 12;
            // 
            // cb_Gender
            // 
            this.cb_Gender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cb_Gender.Location = new System.Drawing.Point(475, 191);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(121, 25);
            this.cb_Gender.TabIndex = 13;
            // 
            // lbl_DateofBirth
            // 
            this.lbl_DateofBirth.AutoSize = true;
            this.lbl_DateofBirth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateofBirth.Location = new System.Drawing.Point(23, 194);
            this.lbl_DateofBirth.Name = "lbl_DateofBirth";
            this.lbl_DateofBirth.Size = new System.Drawing.Size(96, 17);
            this.lbl_DateofBirth.TabIndex = 14;
            this.lbl_DateofBirth.Text = "Date of Birth :";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(19, 270);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(65, 17);
            this.lbl_Address.TabIndex = 15;
            this.lbl_Address.Text = "Address :";
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telephone.Location = new System.Drawing.Point(18, 337);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(74, 17);
            this.lbl_Telephone.TabIndex = 16;
            this.lbl_Telephone.Text = "Telephone";
            // 
            // dtp_DateofBirth
            // 
            this.dtp_DateofBirth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DateofBirth.Location = new System.Drawing.Point(133, 189);
            this.dtp_DateofBirth.Name = "dtp_DateofBirth";
            this.dtp_DateofBirth.Size = new System.Drawing.Size(166, 23);
            this.dtp_DateofBirth.TabIndex = 17;
            // 
            // txt_NIC
            // 
            this.txt_NIC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NIC.Location = new System.Drawing.Point(133, 230);
            this.txt_NIC.Multiline = true;
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(210, 27);
            this.txt_NIC.TabIndex = 18;
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(132, 267);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(210, 53);
            this.txt_Address.TabIndex = 19;
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.Location = new System.Drawing.Point(120, 337);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(55, 17);
            this.lbl_Home.TabIndex = 20;
            this.lbl_Home.Text = "Home :";
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile.Location = new System.Drawing.Point(345, 334);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(59, 17);
            this.lbl_Mobile.TabIndex = 21;
            this.lbl_Mobile.Text = "Mobile :";
            // 
            // lbl_Emergency
            // 
            this.lbl_Emergency.AutoSize = true;
            this.lbl_Emergency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emergency.Location = new System.Drawing.Point(547, 334);
            this.lbl_Emergency.Name = "lbl_Emergency";
            this.lbl_Emergency.Size = new System.Drawing.Size(87, 17);
            this.lbl_Emergency.TabIndex = 22;
            this.lbl_Emergency.Text = "Emergency :";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(19, 372);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(51, 17);
            this.lbl_Email.TabIndex = 23;
            this.lbl_Email.Text = "Email :";
            // 
            // txt_Home
            // 
            this.txt_Home.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Home.Location = new System.Drawing.Point(175, 334);
            this.txt_Home.Name = "txt_Home";
            this.txt_Home.Size = new System.Drawing.Size(143, 23);
            this.txt_Home.TabIndex = 24;
            // 
            // txt_Mobile
            // 
            this.txt_Mobile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mobile.Location = new System.Drawing.Point(406, 334);
            this.txt_Mobile.Name = "txt_Mobile";
            this.txt_Mobile.Size = new System.Drawing.Size(118, 23);
            this.txt_Mobile.TabIndex = 25;
            // 
            // txt_Emergency
            // 
            this.txt_Emergency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Emergency.Location = new System.Drawing.Point(640, 334);
            this.txt_Emergency.Name = "txt_Emergency";
            this.txt_Emergency.Size = new System.Drawing.Size(131, 23);
            this.txt_Emergency.TabIndex = 26;
            // 
            // lbl_EducationalQualification
            // 
            this.lbl_EducationalQualification.AutoSize = true;
            this.lbl_EducationalQualification.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EducationalQualification.Location = new System.Drawing.Point(20, 407);
            this.lbl_EducationalQualification.Name = "lbl_EducationalQualification";
            this.lbl_EducationalQualification.Size = new System.Drawing.Size(181, 17);
            this.lbl_EducationalQualification.TabIndex = 27;
            this.lbl_EducationalQualification.Text = "Educational Qualification :";
            // 
            // lbl_Other
            // 
            this.lbl_Other.AutoSize = true;
            this.lbl_Other.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Other.Location = new System.Drawing.Point(458, 406);
            this.lbl_Other.Name = "lbl_Other";
            this.lbl_Other.Size = new System.Drawing.Size(52, 17);
            this.lbl_Other.TabIndex = 28;
            this.lbl_Other.Text = "Other :";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(132, 369);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(211, 23);
            this.txt_Email.TabIndex = 29;
            // 
            // cb_EducationalQualification
            // 
            this.cb_EducationalQualification.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EducationalQualification.FormattingEnabled = true;
            this.cb_EducationalQualification.Items.AddRange(new object[] {
            "O/L",
            "A/L"});
            this.cb_EducationalQualification.Location = new System.Drawing.Point(207, 403);
            this.cb_EducationalQualification.Name = "cb_EducationalQualification";
            this.cb_EducationalQualification.Size = new System.Drawing.Size(135, 25);
            this.cb_EducationalQualification.TabIndex = 30;
            // 
            // txt_Other
            // 
            this.txt_Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Other.Location = new System.Drawing.Point(518, 403);
            this.txt_Other.Multiline = true;
            this.txt_Other.Name = "txt_Other";
            this.txt_Other.Size = new System.Drawing.Size(253, 53);
            this.txt_Other.TabIndex = 31;
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.BackColor = System.Drawing.Color.White;
            this.btn_AddStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStudent.ForeColor = System.Drawing.Color.Black;
            this.btn_AddStudent.Location = new System.Drawing.Point(17, 9);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(121, 35);
            this.btn_AddStudent.TabIndex = 0;
            this.btn_AddStudent.Text = "Add Student";
            this.btn_AddStudent.UseVisualStyleBackColor = false;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(17, 71);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(121, 35);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(17, 135);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(121, 35);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.White;
            this.btn_Show.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Location = new System.Drawing.Point(17, 202);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(121, 35);
            this.btn_Show.TabIndex = 3;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.White;
            this.btn_Clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(17, 269);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(121, 35);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(17, 339);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(121, 38);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_StudentsRegistration
            // 
            this.dgv_StudentsRegistration.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_StudentsRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_StudentsRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentsRegistration.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_StudentsRegistration.Location = new System.Drawing.Point(14, 472);
            this.dgv_StudentsRegistration.Name = "dgv_StudentsRegistration";
            this.dgv_StudentsRegistration.Size = new System.Drawing.Size(918, 151);
            this.dgv_StudentsRegistration.TabIndex = 33;
            // 
            // pnl_StudentsRegistration
            // 
            this.pnl_StudentsRegistration.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_StudentsRegistration.Controls.Add(this.btn_AddStudent);
            this.pnl_StudentsRegistration.Controls.Add(this.btn_Delete);
            this.pnl_StudentsRegistration.Controls.Add(this.btn_Search);
            this.pnl_StudentsRegistration.Controls.Add(this.btn_Update);
            this.pnl_StudentsRegistration.Controls.Add(this.btn_Clear);
            this.pnl_StudentsRegistration.Controls.Add(this.btn_Show);
            this.pnl_StudentsRegistration.Location = new System.Drawing.Point(777, 68);
            this.pnl_StudentsRegistration.Name = "pnl_StudentsRegistration";
            this.pnl_StudentsRegistration.Size = new System.Drawing.Size(155, 398);
            this.pnl_StudentsRegistration.TabIndex = 34;
            // 
            // lbl_StudentRegistration
            // 
            this.lbl_StudentRegistration.AutoSize = true;
            this.lbl_StudentRegistration.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentRegistration.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_StudentRegistration.Location = new System.Drawing.Point(14, 11);
            this.lbl_StudentRegistration.Name = "lbl_StudentRegistration";
            this.lbl_StudentRegistration.Size = new System.Drawing.Size(322, 38);
            this.lbl_StudentRegistration.TabIndex = 35;
            this.lbl_StudentRegistration.Text = "Student Registration";
            // 
            // lbl_SelectCourse
            // 
            this.lbl_SelectCourse.AutoSize = true;
            this.lbl_SelectCourse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectCourse.ForeColor = System.Drawing.Color.Black;
            this.lbl_SelectCourse.Location = new System.Drawing.Point(23, 112);
            this.lbl_SelectCourse.Name = "lbl_SelectCourse";
            this.lbl_SelectCourse.Size = new System.Drawing.Size(111, 17);
            this.lbl_SelectCourse.TabIndex = 36;
            this.lbl_SelectCourse.Text = "Selecte Course :";
            // 
            // cb_SelectCourse
            // 
            this.cb_SelectCourse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SelectCourse.FormattingEnabled = true;
            this.cb_SelectCourse.Items.AddRange(new object[] {
            "Diploma in Information Technology (DiIT B23)",
            "Diploma in English (DiE B23)",
            "Dual Diploma ( DiIT B23 & DiE B23)",
            ""});
            this.cb_SelectCourse.Location = new System.Drawing.Point(148, 109);
            this.cb_SelectCourse.Name = "cb_SelectCourse";
            this.cb_SelectCourse.Size = new System.Drawing.Size(151, 25);
            this.cb_SelectCourse.TabIndex = 37;
            // 
            // frm_StudentsRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 635);
            this.Controls.Add(this.cb_SelectCourse);
            this.Controls.Add(this.lbl_SelectCourse);
            this.Controls.Add(this.lbl_StudentRegistration);
            this.Controls.Add(this.pnl_StudentsRegistration);
            this.Controls.Add(this.dgv_StudentsRegistration);
            this.Controls.Add(this.txt_Other);
            this.Controls.Add(this.cb_EducationalQualification);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Other);
            this.Controls.Add(this.lbl_EducationalQualification);
            this.Controls.Add(this.txt_Emergency);
            this.Controls.Add(this.txt_Mobile);
            this.Controls.Add(this.txt_Home);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Emergency);
            this.Controls.Add(this.lbl_Mobile);
            this.Controls.Add(this.lbl_Home);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_NIC);
            this.Controls.Add(this.dtp_DateofBirth);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_DateofBirth);
            this.Controls.Add(this.cb_Gender);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.lbl_NIC);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.cb_Title);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.dtp_RegistrationDate);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_RegistrationDate);
            this.Controls.Add(this.txt_StudentRegistrationNumber);
            this.Controls.Add(this.lbl_StudentRegistrationNumber);
            this.Controls.Add(this.btn_Back);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StudentsRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentsRegistration";
            this.Load += new System.EventHandler(this.frm_StudentsRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentsRegistration)).EndInit();
            this.pnl_StudentsRegistration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_StudentRegistrationNumber;
        private System.Windows.Forms.TextBox txt_StudentRegistrationNumber;
        private System.Windows.Forms.Label lbl_RegistrationDate;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DateTimePicker dtp_RegistrationDate;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.ComboBox cb_Title;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_NIC;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.Label lbl_DateofBirth;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.DateTimePicker dtp_DateofBirth;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_Home;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.Label lbl_Emergency;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Home;
        private System.Windows.Forms.TextBox txt_Mobile;
        private System.Windows.Forms.TextBox txt_Emergency;
        private System.Windows.Forms.Label lbl_EducationalQualification;
        private System.Windows.Forms.Label lbl_Other;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.ComboBox cb_EducationalQualification;
        private System.Windows.Forms.TextBox txt_Other;
        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_StudentsRegistration;
        private System.Windows.Forms.Panel pnl_StudentsRegistration;
        private System.Windows.Forms.Label lbl_StudentRegistration;
        private System.Windows.Forms.Label lbl_SelectCourse;
        private System.Windows.Forms.ComboBox cb_SelectCourse;
    }
}