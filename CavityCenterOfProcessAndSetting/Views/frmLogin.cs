using CommonClassLibrary;
using CommonClassLibrary.Controllers;
using CommonClassLibrary.Propertys;
using System;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmLogin : Form
    {
        EmployeeController employeeController = new EmployeeController();

        public frmLogin()
        {
            InitializeComponent();
            this.Text = Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION;
            MaximizeBox = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrWhiteSpace(txtUserID.Text))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก UserID");
                txtUserID.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก Password");
                txtPassword.Focus();
                return;
            }

            if (txtUserID.Text.Substring(0, 1) != "S")
            {
                CommonClassLibraryGlobal.showError("UserID นี้ไม่สามารถแก้ไขข้อมูลได้");
                txtPassword.Text = "";
                txtUserID.Text = "";
                txtUserID.Focus();
                return;
            }


            EmployeeProperty employeeProperty = new EmployeeProperty();
            employeeProperty.EmpCode = txtUserID.Text;

            employeeProperty = employeeController.SearchOne(employeeProperty);

            if (employeeProperty == null)
            {
                CommonClassLibraryGlobal.showError("ไม่พบข้อมูล UserID");
                txtPassword.Text = "";
                txtUserID.Text = "";
                txtUserID.Focus();
                return;
            }

            if (txtPassword.Text != "FL12345")
            {
                CommonClassLibraryGlobal.showError("UserID / Password ไม่ถูกต้อง");
                txtPassword.Text = "";
                txtUserID.Text = "";
                txtUserID.Focus();
                return;
            }

            CommonClassLibraryGlobal.OPERATOR_ID = txtUserID.Text;

            switch (CommonClassLibraryGlobal.Login_TYPE_FORM)
            {
                case "Product Spec":

                    frmProductSpecSetting frmProduct = new frmProductSpecSetting();
                    frmProduct.ShowDialog();
                    this.Dispose();
                    frmProduct.Close();

                    break;

                case "System Spec":

                    frmSystem frmSystem = new frmSystem();
                    frmSystem.ShowDialog();
                    this.Dispose();
                    frmSystem.Close();

                    break;

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(txtUserID.Text))
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก UserID");
                    txtUserID.Focus();
                    return;
                }
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก Password");
                    txtPassword.Focus();
                    return;
                }

                btnOK.PerformClick();

            }
        }
    }
}
