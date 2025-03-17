using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DiTEC193FinalProject
{
    public partial class frm_Payments : Form
    {
        public frm_Payments()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\DiTEC193FinalProject\DiTEC193FinalProject\DiTEC193FinalProjectDB.mdf;Integrated Security=True");

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_firtsname.Clear();
            txt_LName.Clear();
            txt_RNumber.Clear();
            txt_EAddress.Clear();
            txt_PNumber.Clear();
            txt_HAddress.Clear();
            txt_PCity.Clear();
            cb_PMethod.Text = string.Empty;
            txt_CNumber.Clear();
            cb_CName.Text = string.Empty;
            txt_LectureN.Clear();
            txt_CFee.Clear();
        }

        private void frm_PaymentSRecords_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SubmitData_Click(object sender, EventArgs e)
        {
            // Gathering User Inputs
            string First_Name = txt_firtsname.Text;
            string Last_Name = txt_LName.Text;
            string Registration_Number = txt_RNumber.Text;
            string Email_Address = txt_EAddress.Text;
            string Phone_Number = txt_PNumber.Text;
            string Address = txt_HAddress.Text;
            string City = txt_PCity.Text;
            string Payment_Method = cb_PMethod.Text;
            string Card_Number = txt_CNumber.Text;
            string Course_Name = cb_CName.Text;
            string Lecturer_Name = txt_LectureN.Text;
            string Course_Fee = txt_CFee.Text;

            try
            {
                //Preparing Query Format
                string format = "INSERT INTO tblpayment(First_Name,Last_Name,Registration_Number,Email_Address,Phone_Number,Address,City,Payment_Method,Card_Number,Course_Name,Lecturer_Name,Course_Fee)VALUES(@First_Name,@Last_Name,@Registration_Number,@Email_Address,@Phone_Number,@Address,@City,@Payment_Method,@Card_Number,@Course_Name,@Lecturer_Name,@Course_Fee);";

                //Open the Connection
                con.Open();

                //Converting SQL format to a SQL Command
                SqlCommand inscmd = new SqlCommand(format, con);

                //Setting Values to Parameters
                inscmd.Parameters.AddWithValue("@First_Name", First_Name);
                inscmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                inscmd.Parameters.AddWithValue("@Registration_Number", Registration_Number);
                inscmd.Parameters.AddWithValue("@Email_Address", Email_Address);
                inscmd.Parameters.AddWithValue("@Phone_Number", Phone_Number);
                inscmd.Parameters.AddWithValue("@Address", Address);
                inscmd.Parameters.AddWithValue("@City", City);
                inscmd.Parameters.AddWithValue("@Payment_Method", Payment_Method);
                inscmd.Parameters.AddWithValue("@Card_Number", Card_Number);
                inscmd.Parameters.AddWithValue("@Course_Name", Course_Name);
                inscmd.Parameters.AddWithValue("@Lecturer_Name", Lecturer_Name);
                inscmd.Parameters.AddWithValue("@Course_Fee", Course_Fee);

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

        private void frm_Payments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frm_Home frm = new frm_Home(ulog.type);
            frm.Show();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            try
            {
                string format = "SELECT * FROM tblpayment;";
                con.Open();
                SqlCommand showcmd = new SqlCommand(format, con);
                showcmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(showcmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgv_PaymentsDetails.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
