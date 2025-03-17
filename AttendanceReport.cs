using DGVPrinterHelper;
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
    public partial class frm_Attendance : Form
    {
        public frm_Attendance()
        {
            InitializeComponent();
        }

        private void Class_Data()
        {
            dgv_Attendance.Rows.Clear();
            dgv_Attendance.Rows.Add("DiIT B23", "Kavishka Pasindu", "E116689");
            dgv_Attendance.Rows.Add("DiIT B23", "Sandun Chamara", "E164233");
            dgv_Attendance.Rows.Add("DiIT B23", "Sachindra Induwara", "E164971");
            dgv_Attendance.Rows.Add("DiIT B23", "Dion Mendis", "E162632");
            dgv_Attendance.Rows.Add("DiIT B23", "Kavishka Pasindu", "E116689");
            dgv_Attendance.Rows.Add("DiIT B23", "Pathum Mendis", "E4856923");
            dgv_Attendance.Rows.Add("DiIT B23", "Ajith Kumara", "E7896321");
            dgv_Attendance.Rows.Add("DiIT B23", "S.K. Sirisena", "E458796");
            dgv_Attendance.Rows.Add("DiIT B23", "Anjali Pushpia", "E112233");
            dgv_Attendance.Rows.Add("DiIT B23", "Sisira Pieris", "E778899");
            dgv_Attendance.Rows.Add("DiIT B23", "Thidas Jayakodi", "E223344");
            dgv_Attendance.Rows.Add("DiIT B23", "Kasun Rajitha", "E334455");
            dgv_Attendance.Rows.Add("DiIT B23", "Charith Asalanka", "E445566");
            dgv_Attendance.Rows.Add("DiIT B23", "Lakitha Wickramasinghe", "E556677");
            dgv_Attendance.Rows.Add("DiIT B23", "Damith Asanka", "E667788");
            dgv_Attendance.Rows.Add("DiIT B23", "Kavindu Sampath", "E889900");
            dgv_Attendance.Rows.Add("DiIT B23", "Danith Sri", "E778899");
            dgv_Attendance.Rows.Add("DiIT B23", "Thilina Basnayaka", "E990011");
            dgv_Attendance.Rows.Add("DiIT B23", "Pamitha Semitha", "E001122");
            dgv_Attendance.Rows.Add("DiIT B23", "Udara Kaushalya", "E998877");
            dgv_Attendance.Rows.Add("DiIT B23", "Aksha Chamudi", "E887766");
            dgv_Attendance.Rows.Add("DiIT B23", "Raveen Kanishka", "E776655");
            dgv_Attendance.Rows.Add("DiIT B23", "Udeni Samalka", "E665544");
            dgv_Attendance.Rows.Add("DiIT B23", "Yash Perera", "E554433");
            dgv_Attendance.Rows.Add("DiIT B23", "Dimuth Karunarathne", "E443322");
            dgv_Attendance.Rows.Add("DiIT B23", "Avishka Fernando", "E332211");
            dgv_Attendance.Rows.Add("DiIT B23", "Rashmika Mandana", "E568423");
            dgv_Attendance.Rows.Add("DiIT B23", "Jhanvi Kapoor", "E946321");
            dgv_Attendance.Rows.Add("DiIT B23", "Shalani Tharaka", "E795462");
            dgv_Attendance.Rows.Add("DiIT B23", "Nimesha Rashmi", "E946123");
            dgv_Attendance.Rows.Add("DiIT B23", "Indika Thotawaththa", "E679452");
            dgv_Attendance.Rows.Add("DiIT B23", "Sanath Jayasooriya", "E613795");
            dgv_Attendance.Rows.Add("DiIT B23", "Thidas Pasindu", "E349516");
            dgv_Attendance.Rows.Add("DiIT B23", "Shehari Manjari", "E531462");
            dgv_Attendance.Rows.Add("DiIT B23", "Ama Nethmini", "E794628");
        }

        private void Print()
        {
            
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Home frm = new frm_Home(ulog.type);
            frm.Show();
        }

        private void frm_AttendanceReport_Load(object sender, EventArgs e)
        {
            Class_Data();
        }

        private void dgv_Attendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Attendance";
            if (txt_LectureName.Text.Trim() == string.Empty)
                printer.SubTitle = dtp_SelectDate.Text + "/n";
            else
                printer.SubTitle = txt_LectureName.Text.Trim() + "/n" + dtp_SelectDate.Text + "/n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit & StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "C# MODERN DESIGN";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_Attendance);
        }
    }
}
