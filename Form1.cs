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
    public partial class frm_Login : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.DiTEC193FinalProjectDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_UserName.Clear();
            txt_Password.Clear();
        }
        string log;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbllog WHERE Username='" + txt_UserName.Text + "' and Password='" + txt_Password.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[3].ToString() == "Administrator")
                {
                    ulog.type = "Administrator";
                }
                else if (dr[3].ToString() == "Receptionist")
                {
                    ulog.type = "Receptionist";
                }
                else if (dr[3].ToString() == "Lecturer")
                {
                    ulog.type = "Lecturer";
                }
                log = "Welcome:" + txt_UserName.Text;
                this.Hide();
                frm_Home fh = new frm_Home(log);
                fh.Show();
                
            }
            else
            {
                MessageBox.Show("Please check your User Name or Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
