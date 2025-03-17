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
    public partial class frm_AddUsers : Form
    {
        public frm_AddUsers()
        {
            InitializeComponent();
        }

        private void frm_AddUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.appData.tbllog);
            Edit(false);
        }

        private void Edit(bool value)
        {
            txt_UserName.Enabled = value;
            txt_Password.Enabled = value;
            cb_Role.Enabled = value;
        }
        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.tbllog.AddtbllogRow(appData.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
                txt_UserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_UserName.Focus();
        }

        private void btn_SaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(appData.tbllog);
                dgv_UsersData.Refresh();
                txt_UserName.Focus();
                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            {
                tbllogBindingSource.RemoveCurrent();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.ResetBindings(false);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Home frm = new frm_Home(ulog.type);
            frm.Show();
        }

        private void cb_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

