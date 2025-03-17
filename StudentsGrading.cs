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
    public partial class frm_StudentsGrading : Form
    {
        public frm_StudentsGrading()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Home frm = new frm_Home(ulog.type);
            frm.Show();
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            //Marks Gathering
            int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, Total, Obtain, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, Per;

            num1 = Convert.ToInt32(txt_IT.Text);
            num2 = Convert.ToInt32(txt_MO.Text);
            num3 = Convert.ToInt32(txt_CH.Text);
            num4 = Convert.ToInt32(txt_NT.Text);
            num5 = Convert.ToInt32(txt_WD.Text);
            num6 = Convert.ToInt32(txt_M.Text);
            num7 = Convert.ToInt32(txt_SE.Text);
            num8 = Convert.ToInt32(txt_PP.Text);
            num9 = Convert.ToInt32(txt_DC.Text);
            num10 = Convert.ToInt32(txt_PWC.Text);

            Total = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
            lbl_OMTotal.Text = Total.ToString();

            //Grading
            int A;
            A = Convert.ToInt32(txt_IT.Text);
            if (A >= 95 && A <= 100)
            {
                lbl_GIT.Text = "A+";
            }
            else if (A >= 75 && A <= 94)
            {
                lbl_GIT.Text = "A";
            }
            else if (A >= 65 && A <= 74)
            {
                lbl_GIT.Text = "B";
            }
            else if (A >= 55 && A <= 64)
            {
                lbl_GIT.Text = "C";
            }
            else if (A >= 35 && A<= 54)
            {
                lbl_GIT.Text = "S";
            }
            else if (A <= 34)
            {
                lbl_GIT.Text = "Fail";
            }

            int B;
            B = Convert.ToInt32(txt_IT.Text);
            if (B >= 95 && B <= 100)
            {
                lbl_GMO.Text = "A+";
            }
            else if (B >= 75 && B <= 94)
            {
                lbl_GMO.Text = "A";
            }
            else if (B >= 65 && B <= 74)
            {
                lbl_GMO.Text = "B";
            }
            else if (B >= 55 && B <= 64)
            {
                lbl_GMO.Text = "C";
            }
            else if (B >= 35 && B <= 54)
            {
                lbl_GMO.Text = "S";
            }
            else if (B <= 34)
            {
                lbl_GMO.Text = "Fail";
            }

            int C;
            C = Convert.ToInt32(txt_IT.Text);
            if (C >= 95 && C <= 100)
            {
                lbl_GCH.Text = "A+";
            }
            else if (C >= 75 && C <= 94)
            {
                lbl_GCH.Text = "A";
            }
            else if (C >= 65 && C <= 74)
            {
                lbl_GCH.Text = "B";
            }
            else if (C >= 55 && C <= 64)
            {
                lbl_GCH.Text = "C";
            }
            else if (C >= 35 && C <= 54)
            {
                lbl_GCH.Text = "S";
            }
            else if (C <= 34)
            {
                lbl_GCH.Text = "Fail";
            }

            int D;
            D = Convert.ToInt32(txt_IT.Text);
            if (D >= 95 && D <= 100)
            {
                lbl_GNT.Text = "A+";
            }
            else if (D >= 75 && D <= 94)
            {
                lbl_GNT.Text = "A";
            }
            else if (D >= 65 && D <= 74)
            {
                lbl_GNT.Text = "B";
            }
            else if (D >= 55 && D <= 64)
            {
                lbl_GNT.Text = "C";
            }
            else if (D >= 35 && D <= 54)
            {
                lbl_GNT.Text = "S";
            }
            else if (D <= 34)
            {
                lbl_GNT.Text = "Fail";
            }

            int E;
            E = Convert.ToInt32(txt_IT.Text);
            if (E >= 95 && E <= 100)
            {
                lbl_GWD.Text = "A+";
            }
            else if (E >= 75 && E <= 94)
            {
                lbl_GWD.Text = "A";
            }
            else if (E >= 65 && E <= 74)
            {
                lbl_GWD.Text = "B";
            }
            else if (E >= 55 && E <= 64)
            {
                lbl_GWD.Text = "C";
            }
            else if (E >= 35 && E <= 54)
            {
                lbl_GWD.Text = "S";
            }
            else if (E <= 34)
            {
                lbl_GWD.Text = "Fail";
            }

            int F;
            F = Convert.ToInt32(txt_IT.Text);
            if (F >= 95 && F <= 100)
            {
                lbl_GM.Text = "A+";
            }
            else if (F >= 75 && F <= 94)
            {
                lbl_GM.Text = "A";
            }
            else if (F >= 65 && F <= 74)
            {
                lbl_GM.Text = "B";
            }
            else if (F >= 55 && F <= 64)
            {
                lbl_GM.Text = "C";
            }
            else if (F >= 35 && F <= 54)
            {
                lbl_GM.Text = "S";
            }
            else if (F <= 34)
            {
                lbl_GM.Text = "Fail";
            }

            int G;
            G = Convert.ToInt32(txt_IT.Text);
            if (G >= 95 && G <= 100)
            {
                lbl_GSE.Text = "A+";
            }
            else if (G >= 75 && G <= 94)
            {
                lbl_GSE.Text = "A";
            }
            else if (G >= 65 && G <= 74)
            {
                lbl_GSE.Text = "B";
            }
            else if (G >= 55 && G <= 64)
            {
                lbl_GSE.Text = "C";
            }
            else if (G >= 35 && G <= 54)
            {
                lbl_GSE.Text = "S";
            }
            else if (G <= 34)
            {
                lbl_GSE.Text = "Fail";
            }

            int H;
            H = Convert.ToInt32(txt_IT.Text);
            if (H >= 95 && H <= 100)
            {
                lbl_GPP.Text = "A+";
            }
            else if (H >= 75 && H <= 94)
            {
                lbl_GPP.Text = "A";
            }
            else if (H >= 65 && H <= 74)
            {
                lbl_GPP.Text = "B";
            }
            else if (H >= 55 && H <= 64)
            {
                lbl_GPP.Text = "C";
            }
            else if (H >= 35 && H <= 54)
            {
                lbl_GPP.Text = "S";
            }
            else if (H <= 34)
            {
                lbl_GPP.Text = "Fail";
            }

            int I;
            I = Convert.ToInt32(txt_IT.Text);
            if (I >= 95 && I <= 100)
            {
                lbl_GDC.Text = "A+";
            }
            else if (I >= 75 && I <= 94)
            {
                lbl_GDC.Text = "A";
            }
            else if (I >= 65 && I <= 74)
            {
                lbl_GDC.Text = "B";
            }
            else if (I >= 55 && I <= 64)
            {
                lbl_GDC.Text = "C";
            }
            else if (I >= 35 && I <= 54)
            {
                lbl_GDC.Text = "S";
            }
            else if (I <= 34)
            {
                lbl_GDC.Text = "Fail";
            }

            int J;
            J = Convert.ToInt32(txt_IT.Text);
            if (J >= 95 && J <= 100)
            {
                lbl_GPWC.Text = "A+";
            }
            else if (J >= 75 && J <= 94)
            {
                lbl_GPWC.Text = "A";
            }
            else if (J >= 65 && J <= 74)
            {
                lbl_GPWC.Text = "B";
            }
            else if (J >= 55 && J <= 64)
            {
                lbl_GPWC.Text = "C";
            }
            else if (J >= 35 && J <= 54)
            {
                lbl_GPWC.Text = "S";
            }
            else if (J <= 34)
            {
                lbl_GPWC.Text = "Fail";
            }

            //Final Grading
            Total = Convert.ToInt32(lbl_OMTotal.Text);
            if (Total >= 950 && Total <= 1000)
            {
                lbl_Grade.Text = "A+";
            }
            else if (Total >= 750 && Total <= 949)
            {
                lbl_Grade.Text = "A";
            }
            else if (Total >= 650 && Total <= 749)
            {
                lbl_Grade.Text = "B";
            }
            else if (Total >= 550 && Total <= 649)
            {
                lbl_Grade.Text = "C";
            }
            else if (Total >= 350 && Total <= 549)
            {
                lbl_Grade.Text = "S";
            }
            else if (Total <= 349)
            {
                lbl_Grade.Text = "Fail";
            }

            //For Individual Course Percentage
            p1 = num1 * 100 / 100;
            lbl_PIT.Text = p1.ToString();
            p2 = num2 * 100 / 100;
            lbl_PMO.Text = p2.ToString();
            p3 = num3 * 100 / 100;
            lbl_PCH.Text = p3.ToString();
            p4 = num4 * 100 / 100;
            lbl_PNT.Text = p4.ToString();
            p5 = num5 * 100 / 100;
            lbl_PWD.Text = p5.ToString();
            p6 = num6 * 100 / 100;
            lbl_PM.Text = p6.ToString();
            p7 = num7 * 100 / 100;
            lbl_PSE.Text = p7.ToString();
            p8 = num8 * 100 / 100;
            lbl_PPP.Text = p8.ToString();
            p9 = num9 * 100 / 100;
            lbl_PDC.Text = p9.ToString();
            p10 = num10 * 100 / 100;
            lbl_PPWC.Text = p10.ToString();

            //For All Cources Percentage
            Per = Total / 10;
            lbl_Percentage.Text = Per.ToString();

            //For All Courses GPA
            Per = Convert.ToInt32(lbl_Percentage.Text);
            if (Per >= 85 && Per <= 100)
            {
                lbl_GPA.Text = "4.0";
            }
            else if (Per >= 80 && Per <= 84)
            {
                lbl_GPA.Text = "3.7";
            }
            else if (Per >= 75 && Per <= 79)
            {
                lbl_GPA.Text = "3.3";
            }
            else if (Per >= 70 && Per <= 74)
            {
                lbl_GPA.Text = "3.0";
            }
            else if (Per >= 65 && Per <= 69)
            {
                lbl_GPA.Text = "2.7";
            }
            else if (Per >= 61 && Per <= 64)
            {
                lbl_GPA.Text = "2.3";
            }
            else if (Per >= 58 && Per <= 60)
            {
                lbl_GPA.Text = "2.0";
            }
            else if (Per >= 55 && Per <= 57)
            {
                lbl_GPA.Text = "1.7";
            }
            else if (Per >= 50 && Per <= 54)
            {
                lbl_GPA.Text = "1.0";
            }
            else if (Per >= 0 && Per <= 49)
            {
                lbl_GPA.Text = "0.0";
            }
        }

        private void frm_StudentsGrading_Load(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }
    }
}
