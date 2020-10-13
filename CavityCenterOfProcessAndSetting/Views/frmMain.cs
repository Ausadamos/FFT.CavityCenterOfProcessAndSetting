using CavityCenterOfProcessAndSetting.Views;
using CommonClassLibrary;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting
{
    public partial class frmMain : Form
    {
        public frmMain()
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
            DialogResult res = MessageBox.Show("ปิดโปรแกรม ?", "การยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.Cancel)
            {
                return;
            }

            Application.Exit();
        }
        #endregion

        private void picChangeSerial_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSerialChange frm = new frmSerialChange();
            frm.ShowDialog();
            this.Show();
            frm.Close();

            if (frm.ok_click)
            {
                txtSerialNumber.Text = frm.serial;
            }
            else
            {
                txtSerialNumber.Text = "";
            }

        }

        private void picChangeOperator_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOperatorChange frm = new frmOperatorChange();
            frm.ShowDialog();
            this.Show();
            frm.Close();
            if (frm.ok_click)
            {
                txtOperator.Text = frm.operator_id;
            }
            else
            {
                txtOperator.Text = "";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION;
            lblProgramName.Text = Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION;
            lblFooter.Text = Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION + " © 2020 Furukawa Fitel(Thailand) All rights reserved";


            MaximizeBox = false;
            CommonClassLibraryGlobal.HOST_NAME = CommonClassLibraryGlobal.GetLocalHostName();
            CommonClassLibraryGlobal.IP = CommonClassLibraryGlobal.GetLocalIPAddress();
            txtSerialNumber.Select();
        }

        private void picSettingProcess_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainSetting frm = new frmMainSetting();
            frm.ShowDialog();
            this.Show();
            frm.Close();
        }

        private void btnResonatorTest_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            string pathName = "";
            switch (btn.Name)
            {

            }

            this.Hide();

            string filename = pathName;
            var proc = System.Diagnostics.Process.Start(filename, txtSerialNumber.Text.Trim().Replace(" ", "") + " " + txtOperator.Text.Trim().Replace(" ", "") + " " + "490-N0759-03".Replace(" ", "") + " " + CommonClassLibraryGlobal.IP.Trim().Replace(" ", "") + " " + CommonClassLibraryGlobal.HOST_NAME.Trim().Replace(" ", ""));
            proc.CloseMainWindow();
            this.Show();
            proc.Close();
        }
    }
}
