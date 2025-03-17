using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiTEC193FinalProject
{
    public partial class frm_Home : Form
    {
        public frm_Home(string log)
        {
            InitializeComponent();
            lbl_Welcome.Text = log;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            if(ulog.type == "Administrator")
            {
                btn_StudentRegistration.Visible = true;
                btn_CreateSystemUsers.Visible = true;
                btn_Attendance.Visible = true;
                btn_Payments.Visible = true;
                btn_StudentsGrading.Visible = true;
                btn_CreateGradingReports.Visible = true;
                btn_Settings.Visible = true;
            }
            else if (ulog.type == "Receptionist")
            {
                btn_StudentRegistration.Visible = true;
                btn_CreateSystemUsers.Visible = false;
                btn_Attendance.Visible = true;
                btn_Payments.Visible = true;
                btn_StudentsGrading.Visible = false;
                btn_CreateGradingReports.Visible = false;
                btn_Settings.Visible = false;
            }
            else if (ulog.type == "Lecturer")
            {
                btn_StudentRegistration.Visible = false;
                btn_CreateSystemUsers.Visible = false;
                btn_Attendance.Visible = true;
                btn_Payments.Visible = false;
                btn_StudentsGrading.Visible = true;
                btn_CreateGradingReports.Visible = true;
                btn_Settings.Visible = false;
            }
        }

        private void btn_CreateSystemUsers_Click(object sender, EventArgs e)
        {
            frm_AddUsers fau = new frm_AddUsers();
            fau.ShowDialog();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login fl = new frm_Login();
            fl.Show();
            this.Hide();
        }

        private void btn_StudentRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_StudentsRegistration fau = new frm_StudentsRegistration();
            fau.ShowDialog();
        }

        private void btn_Attendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Attendance fau = new frm_Attendance();
            fau.ShowDialog();
        }

        private void btn_Payments_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Payments fau = new frm_Payments();
            fau.ShowDialog();
        }

        private void lbl_Welcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_StudentsGrading_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_StudentsGrading fau = new frm_StudentsGrading();
            fau.ShowDialog();
        }
    }
}
