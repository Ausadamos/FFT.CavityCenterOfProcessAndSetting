
using CavityMachineSettingManagement.Controller;
using CavityMachineSettingManagement.Property;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmSystem : Form
    {

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

        public frmSystem()
        {
            InitializeComponent();
        }

        private void frmSystemSpecSetting_Load(object sender, EventArgs e)
        {
            _getDetail();
        }

        CvSystemController _cvSystemController = new CvSystemController();
        public static string SYSTEM_ID;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (e.RowIndex >= 0))
            {

                SYSTEM_ID = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                switch (e.ColumnIndex)
                {
                    case 3:
                        this.Hide();
                        frmSystemCommon frmSystemCommon = new frmSystemCommon();

                        frmSystemCommon.ShowDialog();
                        this.Show();
                        frmSystemCommon.Close();
                        break;

                    case 4:
                        this.Hide();
                        frmSystemSpecificPurchase frmSystemSpecificPurchase = new frmSystemSpecificPurchase();

                        frmSystemSpecificPurchase.ShowDialog();
                        this.Show();
                        frmSystemSpecificPurchase.Close();
                        break;

                        //case 5:


                        //    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        //    DialogResult result = MessageBox.Show("คุณต้องการลบข้อมูล ?", "Message", buttons, MessageBoxIcon.Warning);

                        //    if (result == DialogResult.No)
                        //    {
                        //        return;
                        //    }

                        //    else
                        //    {

                        //        if (CvSystemController.Delete(new CvSystemProperty {ID = SYSTEM_ID }))
                        //        {
                        //            CommonClassLibraryGlobal.showSuccess("ลบข้อมูลสำเร็จ");
                        //            _getDetail();
                        //        }
                        //        else
                        //        {
                        //            CommonClassLibraryGlobal.showSuccess("ลบข้อมูลไม่สำเร็จ กรุณาลองใหม่อีกครั้ง");
                        //            _getDetail();
                        //        }

                        //    }

                        break;
                }
            }
        }

        private void _getDetail()
        {

            List<CvSystemProperty> listItem = _cvSystemController.Search().FindAll(x => x.INUSE == "True");
            dataGridView1.Rows.Clear();
            foreach (CvSystemProperty item in listItem)
            {
                dataGridView1.Rows.Add(item.ID, item.SYSTEM_NAME, item.IP_ADDRESS_SYSTEM, "Edit", "Edit");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSystemManage frm = new frmSystemManage();
            frm.ShowDialog();
            _getDetail();
            this.Show();
            frm.Close();
        }


    }
}
