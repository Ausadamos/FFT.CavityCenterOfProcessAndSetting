using System;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmSerialChange : Form
    {
        public string serial = "";
        public bool ok_click = false;

        public frmSerialChange()
        {
            InitializeComponent();
        }

        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSerial.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วนและถูกต้อง", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSerial.Focus();
                return;
            }

            serial = txtSerial.Text;
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
