using CommonClassLibrary;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmMainSetting : Form
    {

        public frmMainSetting()
        {
            InitializeComponent();
        }
        #region move form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void lblProgramName_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picManimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        private void ProductTypeClick(object sender, EventArgs e)
        {
            this.Hide();
            CommonClassLibraryGlobal.Login_TYPE_FORM = "Product Spec";
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Show();
            frm.Close();
        }

        private void systemClick(object sender, EventArgs e)
        {
            this.Hide();
            CommonClassLibraryGlobal.Login_TYPE_FORM = "System Spec";
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Show();
            frm.Close();
        }

        private void frmMainSetting_Load(object sender, EventArgs e)
        {
            lblProgramName.Text = Properties.Settings.Default.PROGRAM_NAME + " SETTING ";
        }
    }
}
