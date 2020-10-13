using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmProductSpecSettingManage : Form
    {
        public frmProductSpecSettingManage()
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

        //PurchaseProductTypeController _purchaseProductTypeController = new PurchaseProductTypeController();

        //private void PURCHASE_NO_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        _checkData();

        //    }
        //}

        //private bool _checkData()
        //{

        //    if (String.IsNullOrWhiteSpace(PURCHASE_NO.Text))
        //    {
        //        CommonClassLibraryGlobal.showError("กรุณากรอก Purchase No");
        //        PURCHASE_NO.Focus();
        //        return false;
        //    }

        //    List<PurchaseProductTypeProperty> listItem = _purchaseProductTypeController.Search(new PurchaseProductTypeProperty { PRODUCT_TYPE = new ProductTypeProperty { PRODUCT_SUB_CODE = Properties.Settings.Default.PRODUCT_SUB_CODE } });


        //    if (listItem.FindIndex(x => x.PURCHASE.PURCHASE_NO == PURCHASE_NO.Text) != -1)
        //    {
        //        CommonClassLibraryGlobal.showError("ไม่พบข้อมูล Purchase No กรุณาตรวจสอบข้อมูล");
        //        _clearData();
        //        return false;
        //    }
        //    else
        //    {

        //        PurchaseProductTypeProperty item = listItem.Find(x => x.PURCHASE.PURCHASE_NO == PURCHASE_NO.Text);

        //        item.PURCHASE.PURCHASE_NO, item.PRODUCT_TYPE.PRODUCT_SUB_CODE, item.PURCHASE_FFTCODE.FFT_CODE.FFT_CODE, item.PRODUCT_TYPE.PRODUCT_TITLE, item.PART_NO.PART_NO, item.MODEL.MODEL_NO




        //        PURCHASE_NO.Text = item.PURCHASE.PURCHASE_NO;
        //        PRODUCT_SUB_CODE.Text = dataListItem.FFT_CODE;
        //        product_name.Text = dataListItem.PRODUCT_NAME;
        //    }

        //    return true;
        //}
    }
}
