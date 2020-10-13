using CavityMachineSettingManagement.Controller;
using CavityMachineSettingManagement.Property;
using CommonClassLibrary;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmSystemManage : Form
    {
        public frmSystemManage()
        {
            InitializeComponent();
        }


        #region move form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void picManimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblProgramName_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        CvSystemController CvSystemController = new CvSystemController();

        private bool _checkData()
        {

            if (String.IsNullOrWhiteSpace(system_name.Text))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก System Name");
                system_name.Focus();
                return false;
            }


            if (String.IsNullOrWhiteSpace(ip_address_system.Text))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก ip address system");
                ip_address_system.Focus();
                return false;
            }

            return true;
        }

        private void _clearData()
        {
            system_name.Text = "";
            ip_address_system.Text = "";
            system_name.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _clearData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_checkData() == true)
            {
                CvSystemProperty dataItem = new CvSystemProperty
                {
                    SYSTEM_NAME = system_name.Text,
                    IP_ADDRESS_SYSTEM = ip_address_system.Text,
                    DESCRIPTION = description.Text,
                    IP_ADDRESS = CommonClassLibraryGlobal.IP,
                    NAME_ADDRESS = CommonClassLibraryGlobal.HOST_NAME,
                    CREATE_USER = CommonClassLibraryGlobal.OPERATOR_ID,
                };

                DialogResult res = MessageBox.Show("ยืนยันการบันทึกข้อมูล ?", "การยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.Cancel)
                {
                    return;
                }

                CvSystemProperty dataItemCheck = new CvSystemProperty();
                dataItemCheck = CvSystemController.SearchByIpAddressSystem(dataItem);
                if (dataItemCheck != null)
                {
                    CommonClassLibraryGlobal.showSuccess("ip address system นี้มีข้อมูลอยู่แล้ว");
                    _clearData();
                    return;
                }

                if (CvSystemController.Insert(dataItem))
                {
                    CommonClassLibraryGlobal.showSuccess("เพิ่มข้อมูลสำเร็จ");
                    this.Close();
                    return;
                }
                else
                {
                    CommonClassLibraryGlobal.showSuccess("เพิ่มไม่ข้อมูลสำเร็จ กรุณาลองใหม่อีกครั้ง");
                    return;
                }
            }
        }

        private void frmSystemSpecSettingManage_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION;
            MaximizeBox = false;
            system_name.Select();
        }
    }
}
