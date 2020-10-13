
using InputManagement.Controllers;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmSystemSpecificPurchase : Form
    {
        public frmSystemSpecificPurchase()
        {
            InitializeComponent();
        }

        public static string PURCHASE_ID;
        public static string PURCHASE_NO;

        #region  Move Form

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

        PurchaseProductTypeController _purchaseProductTypeController = new PurchaseProductTypeController();

        private void frmSystemSpecSettingSpecificProductType_Load(object sender, EventArgs e)
        {
            _getDetail();
        }

        private void _getDetail()
        {

            flowLayoutPanel1.Controls.Clear();
            List<PurchaseProductTypeProperty> dataListItem = _purchaseProductTypeController.Search(new PurchaseProductTypeProperty { PRODUCT_TYPE = new ProductTypeProperty { PRODUCT_SUB_CODE = Properties.Settings.Default.PRODUCT_SUB_CODE } });

            foreach (PurchaseProductTypeProperty item in dataListItem)
            {

                Button txt = new Button();
                txt.Margin = new Padding(70, 70, 25, 5);
                txt.Size = new Size(169, 95);
                txt.TextAlign = ContentAlignment.MiddleCenter;
                txt.BackColor = Color.FromArgb(255, 255, 255);
                txt.Name = item.PURCHASE.ID;
                txt.Font = new Font("Century Gothic", 14);
                txt.FlatStyle = FlatStyle.Flat;
                txt.FlatAppearance.BorderSize = 0;
                txt.Text = item.PURCHASE.PURCHASE_NO;
                txt.Cursor = Cursors.Hand;
                txt.Click += new EventHandler(btnPurchase_Click);
                flowLayoutPanel1.Controls.Add(txt);
            }


        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            PURCHASE_ID = btn.Name;
            PURCHASE_NO = btn.Text;

            frmSystemSpecificPurchaseProcess frmSystemSpecificPurchaseProcess = new frmSystemSpecificPurchaseProcess();
            frmSystemSpecificPurchaseProcess.ShowDialog();
            frmSystemSpecificPurchaseProcess.Close();

        }

    }
}
