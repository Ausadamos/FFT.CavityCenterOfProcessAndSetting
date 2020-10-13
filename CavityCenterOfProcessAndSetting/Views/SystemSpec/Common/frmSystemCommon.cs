
using CavityMachineSettingManagement.Controller;
using CavityMachineSettingManagement.Property;
using CommonClassLibrary;
using CustomUIClassLibrary;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmSystemCommon : Form
    {
        public frmSystemCommon()
        {
            InitializeComponent();
        }

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


        CvSystemCommonController _cvSystemCommonController = new CvSystemCommonController();
        CvSystemController _cvSystemController = new CvSystemController();

        private void btnSave_Click(object sender, EventArgs e)
        {

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultDialog = MessageBox.Show("ยืนยันการบันทึกข้อมูล ?", "message", buttons, MessageBoxIcon.Warning);

            if (resultDialog == DialogResult.No)
            {
                return;
            }


            CvSystemCommonProperty data = new CvSystemCommonProperty();
            data.IP_ADDRESS = CommonClassLibraryGlobal.IP;
            data.NAME_ADDRESS = CommonClassLibraryGlobal.HOST_NAME;
            data.SYSTEM_ID = frmSystem.SYSTEM_ID;
            data.USER_CREATE = CommonClassLibraryGlobal.OPERATOR_ID;
            data.USER_UPDATE = CommonClassLibraryGlobal.OPERATOR_ID;

            foreach (Control toolBox in this.Controls)
            {
                if (toolBox is SettingSpec_Text_Value_Without_Panel)
                {

                    SettingSpec_Text_Value_Without_Panel tool = (SettingSpec_Text_Value_Without_Panel)toolBox;

                    if (!SettingSpec_Text_Value_Without_Panel.checkData(tool))
                    {
                        return;
                    }
                    else
                    {
                        PropertyInfo prop = null;

                        prop = data.GetType().GetProperty(toolBox.Name, BindingFlags.Public | BindingFlags.Instance);
                        if (null != prop && prop.CanWrite)
                        {
                            prop.SetValue(data, tool.TextBoxValue);
                        }
                        else
                        {
                            CommonClassLibraryGlobal.showError("ไม่สามารถเก็บค่าตัวแปรได้ '" + toolBox.Name + "' กรุณาติดต่อโปรแกรมเมอร์");
                            return;
                        }


                    }
                }
            }

            if (_cvSystemCommonController.Insert(data))
            {
                CommonClassLibraryGlobal.showSuccess("แก้ไขข้อมูลสำเร็จ");
                return;
            }
            else
            {
                CommonClassLibraryGlobal.showSuccess("แก้ไขข้อมูลไม่สำเร็จ กรุณาลองใหม่อีกครั้ง");
                return;
            }

        }

        private void frmSystemSpecSettingCommon_Load(object sender, EventArgs e)
        {

            CvSystemProperty CvSystemProperty = _cvSystemController.SearchBySystemId(new CvSystemProperty { ID = frmSystem.SYSTEM_ID });
            system_name.Text = CvSystemProperty.SYSTEM_NAME;
            ip_address_system.Text = CvSystemProperty.IP_ADDRESS_SYSTEM;

            _getDetail();
        }

        private void _getDetail()
        {

            List<CvSystemCommonProperty> listItem = _cvSystemCommonController.SearchBySystemId(new CvSystemCommonProperty { SYSTEM_ID = frmSystem.SYSTEM_ID });

            if (listItem.Count > 1)
            {
                CommonClassLibraryGlobal.showError("Spec มีมากกว่า 1 แถว กรุณาติดต่อโปรแกรมเมอร์");
                this.Dispose();
            }
            else if (listItem.Count == 1)
            {
                setOldValue(listItem[0]);
            }

        }


        private void setOldValue(CvSystemCommonProperty data)
        {
            foreach (Control toolBox in this.Controls)
            {
                if (toolBox is SettingSpec_Text_Value_Without_Panel)
                {

                    SettingSpec_Text_Value_Without_Panel tool = (SettingSpec_Text_Value_Without_Panel)toolBox;

                    tool.TextBoxValue = GetPropValue(data, tool.Name.ToString()).ToString();


                    //var propInfo = data.GetType().GetProperty(tool.Name);
                    //if (propInfo != null)
                    //{
                    //    propInfo.SetValue(info, value, null);
                    //}

                }

            }
        }

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("ยืนยันการล้างข้อมูล ?", "message", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            foreach (Control toolBox in this.Controls)
            {
                if (toolBox is SettingSpec_Text_Value_Without_Panel)
                {
                    SettingSpec_Text_Value_Without_Panel tool = (SettingSpec_Text_Value_Without_Panel)toolBox;
                    tool.clearToDefault();
                }

            }
        }

        private void settingSpec_Text_Value1_Load(object sender, EventArgs e)
        {

        }
    }
}
