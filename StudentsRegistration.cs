using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DiTEC193FinalProject
{
    public partial class frm_StudentsRegistration : Form
    {
       
        public frm_StudentsRegistration()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\DiTEC193FinalProject\DiTEC193FinalProject\DiTEC193FinalProjectDB.mdf;Integrated Security=True");

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Home frm = new frm_Home(ulog.type);
            frm.Show();
        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cb_Title.Text = string.Empty;
            txt_FirstName.Clear();
            txt_LastName.Clear();
            cb_SelectCourse.Text = string.Empty;
            txt_StudentRegistrationNumber.Clear();
            cb_Gender.Text = string.Empty;
            txt_NIC.Clear();
            txt_Address.Clear();
            txt_Home.Clear();
            txt_Mobile.Clear();
            txt_Emergency.Clear();
            txt_Email.Clear();
            cb_EducationalQualification.Text = string.Empty;
            txt_Other.Clear();
        }

        private void frm_StudentsRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            //Gathering User Inputs
            string Title = cb_Title.Text;
            string First_Name = txt_FirstName.Text;
            string Last_Name = txt_LastName.Text;
            string Select_Courses = cb_SelectCourse.Text;
            int Student_Registration_NUmber = int.Parse(txt_StudentRegistrationNumber.Text);
            string Registration_Date = dtp_RegistrationDate.Text;
            string Date_of_Birth = dtp_DateofBirth.Text;
            string Gender = cb_Gender.Text;
            int NIC = int.Parse(txt_NIC.Text);
            string Address = txt_Address.Text;
            string Home = txt_Home.Text;
            string Mobile = txt_Mobile.Text;
            string Emergency = txt_Emergency.Text;
            string Email = txt_Email.Text;
            string Educational_Qualifications = cb_EducationalQualification.Text;
            string Other = txt_Other.Text;

            try
            {
                //Preparing Query Format
                string format = "INSERT INTO tblstudent(Title,First_Name,Last_Name,Select_Courses,Student_Registration_Number,Registration_Date,Date_of_Birth,Gender,NIC,Address,Home,Mobile,Emergency,Email,Educational_Qualifications,Other)VALUES(@Title,@First_Name,@Last_Name,@Select_Courses,@Student_Registration_Number,@Registration_Date,@Date_of_Birth,@Gender,@NIC,@Address,@Home,@Mobile,@Emergency,@Email,@Educational_Qualifications,@Other);";

                //Open the Connection
                con.Open();

                //Converting SQL format to a SQL Command
                SqlCommand inscmd = new SqlCommand(format, con);

                //Setting Values to Parameters
                inscmd.Parameters.AddWithValue("@Title", Title);
                inscmd.Parameters.AddWithValue("@First_Name", First_Name);
                inscmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                inscmd.Parameters.AddWithValue("@Select_Courses", Select_Courses);
                inscmd.Parameters.AddWithValue("@Student_Registration_Number", Student_Registration_NUmber);
                inscmd.Parameters.AddWithValue("@Registration_Date", Registration_Date);
                inscmd.Parameters.AddWithValue("@Date_of_Birth", Date_of_Birth);
                inscmd.Parameters.AddWithValue("@Gender", Gender);
                inscmd.Parameters.AddWithValue("@NIC", NIC);
                inscmd.Parameters.AddWithValue("@Address", Address);
                inscmd.Parameters.AddWithValue("@Home", Home);
                inscmd.Parameters.AddWithValue("@Mobile", Mobile);
                inscmd.Parameters.AddWithValue("@Emergency", Emergency);
                inscmd.Parameters.AddWithValue("@Email", Email);
                inscmd.Parameters.AddWithValue("@Educational_Qualifications", Educational_Qualifications);
                inscmd.Parameters.AddWithValue("@Other", Other);

                //Execute the Command
                int r = inscmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Student Added Successfully...");
                }
                else
                {
                    MessageBox.Show("Error with Student Adding");
                }

                //Close the Connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            try
            {
                string format = "SELECT * FROM tblstudent;";
                con.Open();
                SqlCommand showcmd = new SqlCommand(format, con);
                showcmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(showcmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgv_StudentsRegistration.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Gathering User Inputs
            string Student_Registration_Number = txt_StudentRegistrationNumber.Text;

            try
            {
                //Preparing SQL Query Format
                string format = "DELETE FROM tblstudent WHERE Student_Registration_number = @Student_Registration_Number";

                //Open the Connection
                con.Open();

                //Converting SQL Query format to a SQL Command
                SqlCommand delcmd = new SqlCommand(format, con);

                delcmd.Parameters.AddWithValue("@Student_Registration_Number", Student_Registration_Number);

                //Execute the Query
                int r = delcmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Student Deleted");
                }
                else
                {
                    MessageBox.Show("Student not Deleted");
                }

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Gathering User Inputs
            string Student_Registration_Number = txt_StudentRegistrationNumber.Text;

            try
            {
                //Preparing the Query format
                string format = "SELECT * FROM tblstudent WHERE Student_Registration_Number = @Student_Registration_Number;";

                //Open the Connection
                con.Open();

                //Convert SQL Format to SQL Command
                SqlCommand searchcmd = new SqlCommand(format, con);

                searchcmd.Parameters.AddWithValue("@Student_Registration_Number", Student_Registration_Number);

                SqlDataReader rd = searchcmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        cb_Title.Text = rd[1].ToString();
                        txt_FirstName.Text = rd[2].ToString();
                        txt_LastName.Text = rd[3].ToString();
                        cb_SelectCourse.Text = rd[4].ToString();
                        dtp_RegistrationDate.Value = DateTime.Parse(rd[6].ToString());                      
                        dtp_DateofBirth.Value = DateTime.Parse(rd[7].ToString()); 
                        cb_Gender.Text = rd[8].ToString();
                        txt_NIC.Text = rd[9].ToString();
                        txt_Address.Text = rd[10].ToString();
                        txt_Home.Text = rd[11].ToString();
                        txt_Mobile.Text = rd[12].ToString();
                        txt_Emergency.Text = rd[13].ToString();
                        txt_Email.Text = rd[14].ToString();
                        cb_EducationalQualification.Text = rd[15].ToString();
                        txt_Other.Text = rd[16].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No students with this Registration Number");
                }

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //Gathering User Inputs
            string Title = cb_Title.Text;
            string First_Name = txt_FirstName.Text;
            string Last_Name = txt_LastName.Text;
            string Select_Courses = cb_SelectCourse.Text;
            int Student_Registration_Number = int.Parse(txt_StudentRegistrationNumber.Text);
            string Registration_Date = dtp_RegistrationDate.Text;
            string Date_of_Birth = dtp_DateofBirth.Text;
            string Gender = cb_Gender.Text;
            int NIC = int.Parse(txt_NIC.Text);
            string Address = txt_Address.Text;
            string Home = txt_Home.Text;
            string Mobile = txt_Mobile.Text;
            string Emergency = txt_Emergency.Text;
            string Email = txt_Email.Text;
            string Educational_Qualifications = cb_EducationalQualification.Text;
            string Other = txt_Other.Text;

            try
            {
                //Preparing Query Format
                string format = "UPDATE tblstudet SET Title = @Title, First_Name = @First_Name, Last_Name = @Last_Name, Select_Courses = @Select_Courses, Student_Registration_Number = @Student_Registration_Number, Registration_Date = @Registration_Date, Date_of_Birth = @Date_of_Birth, Gender = @Gender, NIC = @NIC, Address = @Address, Home = @Home, Mobile = @Mobile, Emergency = @Emergency, Email = @Email, Educational_Qualifications = @Educational_Qualifications, Other = @Other;";

                //Open the Connection
                con.Open();

                //Convert SQL Format to SQL Command
                SqlCommand updatecmd = new SqlCommand(format, con);

                //Setting values to Parameters
                updatecmd.Parameters.AddWithValue("@Title", Title);
                updatecmd.Parameters.AddWithValue("@First_Name", First_Name);
                updatecmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                updatecmd.Parameters.AddWithValue("@Select_Courses", Select_Courses);
                updatecmd.Parameters.AddWithValue("@Student_Registration_Number", Student_Registration_Number);
                updatecmd.Parameters.AddWithValue("@Registration_Date", Registration_Date);
                updatecmd.Parameters.AddWithValue("@Date_of_Birth", Date_of_Birth);
                updatecmd.Parameters.AddWithValue("@Gender", Gender);
                updatecmd.Parameters.AddWithValue("@NIC", NIC);
                updatecmd.Parameters.AddWithValue("@Address", Address);
                updatecmd.Parameters.AddWithValue("@Home", Home);
                updatecmd.Parameters.AddWithValue("@Mobile", Mobile);
                updatecmd.Parameters.AddWithValue("@Emergency", Emergency);
                updatecmd.Parameters.AddWithValue("@Email", Email);
                updatecmd.Parameters.AddWithValue("@Educational_Qualifications", Educational_Qualifications);
                updatecmd.Parameters.AddWithValue("@Other", Other);

                //Close the Connection
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
