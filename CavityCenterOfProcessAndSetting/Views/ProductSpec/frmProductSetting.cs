using InputManagement.Controllers;
using InputManagement.Property;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmProductSpecSetting : Form
    {
        public frmProductSpecSetting()
        {
            InitializeComponent();
        }

        public static string PURCHASE_ID;
        public static string PURCHASE_NO;
        public static string PRODUCT_SUB_CODE = "";
        public static string FFT_CODE = "";
        public static string PRODUCT_TITLE = "";
        public static string PART_NO = "";
        public static string MODEL_NO = "";


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

        PurchaseProductTypeController _purchaseProductTypeController = new PurchaseProductTypeController();

        private void InitialinspectionSetting_Load(object sender, EventArgs e)
        {
            getSpec();
        }

        private void getSpec()
        {

            dataGridView1.Rows.Clear();
            List<PurchaseProductTypeProperty> dataListItem = _purchaseProductTypeController.Search(new PurchaseProductTypeProperty { PRODUCT_TYPE = new ProductTypeProperty { PRODUCT_SUB_CODE = Properties.Settings.Default.PRODUCT_SUB_CODE } });

            foreach (PurchaseProductTypeProperty item in dataListItem)
            {

                dataGridView1.Rows.Add(item.PURCHASE.ID, item.PURCHASE.PURCHASE_NO, item.PRODUCT_TYPE.PRODUCT_SUB_CODE, item.PURCHASE_FFTCODE.FFT_CODE.FFT_CODE, item.PRODUCT_TYPE.PRODUCT_TITLE, item.PART_NO.PART_NO, item.MODEL.MODEL_NO, "Edit", "Delete");

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //CommonClassLibraryGlobal.FORM_ACTION_MODE = "Add";
            //InitialinspectionSettingManage frm = new InitialinspectionSettingManage();
            //frm.ShowDialog();
            //frm.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (e.RowIndex >= 0))
            {

                switch (e.ColumnIndex)
                {
                    case 7:

                        PURCHASE_ID = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                        PURCHASE_NO = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                        PRODUCT_SUB_CODE = senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                        FFT_CODE = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                        PRODUCT_TITLE = senderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                        PART_NO = senderGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                        MODEL_NO = senderGrid.Rows[e.RowIndex].Cells[6].Value.ToString();

                        frmProcess frmProcess = new frmProcess();
                        frmProcess.ShowDialog();
                        break;

                }
            }
        }
    }
}
