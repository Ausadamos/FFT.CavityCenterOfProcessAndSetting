using System;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmOperatorChange : Form
    {
        public frmOperatorChange()
        {
            InitializeComponent();
        }

        public string operator_id = "";
        public bool ok_click = false;


        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOperatorId.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วนและถูกต้อง", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorId.Focus();
                return;
            }

            operator_id = txtOperatorId.Text;
            ok_click = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ok_click = false;
            this.Close();
        }


    }
}
