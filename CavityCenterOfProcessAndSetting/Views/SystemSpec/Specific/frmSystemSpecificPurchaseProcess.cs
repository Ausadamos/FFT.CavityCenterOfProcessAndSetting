using CavityMachineSettingManagement.Controller;
using CavityMachineSettingManagement.Property;
using CommonClassLibrary;
using InputManagement.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmSystemSpecificPurchaseProcess : Form
    {
        public frmSystemSpecificPurchaseProcess()
        {
            InitializeComponent();
        }

        CvSystemSpecificController _cvSystemSpecificController = new CvSystemSpecificController();
        CvSystemController _cvSystemController = new CvSystemController();
        PurchaseControllers _purchaseController = new PurchaseControllers();
        CvSystemSpecificPurchaseController _cvSystemSpecificPurchaseController = new CvSystemSpecificPurchaseController();
        CvSystemSpecificPurchasePowerOutputController _cvSystemSpecificPurchasePowerOutputController = new CvSystemSpecificPurchasePowerOutputController();

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

        #endregion  Move Form

        private void frmSystemSpecSettingSpecific_Load(object sender, EventArgs e)
        {

            CvSystemProperty CvSystemProperty = _cvSystemController.SearchBySystemId(new CvSystemProperty { ID = frmSystem.SYSTEM_ID });
            SYSTEM_NAME.Text = CvSystemProperty.SYSTEM_NAME;
            IP_ADDRESS_SYSTEM.Text = CvSystemProperty.IP_ADDRESS_SYSTEM;

            PURCHASE_NO.Text = frmSystemSpecificPurchase.PURCHASE_NO;

            _getDetailKikusuiPowerSupply();
        }

        private void _getDetailKikusuiPowerSupply()
        {

            //-- Kikusui
            CvSystemSpecificProperty itemData = _cvSystemSpecificController.SearchBySystemIdAndPurchaseId(new CvSystemSpecificProperty { SYSTEM_ID = frmSystem.SYSTEM_ID, PURCHASE_ID = frmSystemSpecificPurchase.PURCHASE_ID });

            if (itemData != null)
            {
                KIKUSUI_ADDRESS.Text = itemData.KIKUSUI_ADDRESS;
                KIKUSUI_USB_NAME.Text = itemData.KIKUSUI_USB_NAME;
                KIKUSUI_MAX_CURRENT.Text = itemData.KIKUSUI_MAX_CURRENT;
                KIKUSUI_MAX_VOLTAGE.Text = itemData.KIKUSUI_MAX_VOLTAGE;
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(KIKUSUI_USB_NAME.Text))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก kikusui usb name");
                KIKUSUI_USB_NAME.Focus();
                return;
            }


            if (String.IsNullOrWhiteSpace(KIKUSUI_ADDRESS.Text))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก kikusui address");
                KIKUSUI_ADDRESS.Focus();
                return;
            }

            if (!double.TryParse(KIKUSUI_MAX_CURRENT.Text, out CommonClassLibraryGlobal.chkDouble))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก kikusui max current เป็นตัวเลขเท่านั้น");
                KIKUSUI_MAX_CURRENT.Text = "";
                KIKUSUI_MAX_CURRENT.Focus();
                return;
            }


            if (!double.TryParse(KIKUSUI_MAX_VOLTAGE.Text, out CommonClassLibraryGlobal.chkDouble))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก kikusui max voltage เป็นตัวเลขเท่านั้น");
                KIKUSUI_MAX_VOLTAGE.Text = "";
                KIKUSUI_MAX_VOLTAGE.Focus();
                return;
            }

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("คุณต้องการบันทึกข้อมูล ?", "Message", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            CvSystemSpecificProperty itemData = new CvSystemSpecificProperty
            {
                SYSTEM_ID = frmSystem.SYSTEM_ID,
                PURCHASE_ID = frmSystemSpecificPurchase.PURCHASE_ID,
                KIKUSUI_USB_NAME = KIKUSUI_USB_NAME.Text,
                KIKUSUI_ADDRESS = KIKUSUI_ADDRESS.Text,
                KIKUSUI_MAX_CURRENT = KIKUSUI_MAX_CURRENT.Text,
                KIKUSUI_MAX_VOLTAGE = KIKUSUI_MAX_VOLTAGE.Text,
                IP_ADDRESS = CommonClassLibraryGlobal.IP,
                NAME_ADDRESS = CommonClassLibraryGlobal.HOST_NAME,
                USER_CREATE = CommonClassLibraryGlobal.OPERATOR_ID,
                USER_UPDATE = CommonClassLibraryGlobal.OPERATOR_ID,
            };

            if (_cvSystemSpecificController.InsertAndUpdateInuse(itemData) == true)
            {
                CommonClassLibraryGlobal.showSuccess("แก้ไขข้อมูลสำเร็จ");
            }
            else
            {
                CommonClassLibraryGlobal.showSuccess("แก้ไขข้อมูลไม่สำเร็จ กรุณาลองใหม่อีกครั้ง");
            }

        }

        private void processClick(object sender, EventArgs e)
        {
            btnResonatorTest.BackColor = Color.FromArgb(181, 234, 215);
            btnThermalScreening.BackColor = Color.FromArgb(181, 234, 215);
            btnPreBurnIn1.BackColor = Color.FromArgb(181, 234, 215);
            btnPreKinkTest.BackColor = Color.FromArgb(181, 234, 215);
            btnSRS1.BackColor = Color.FromArgb(181, 234, 215);
            btnPreBurnIn2.BackColor = Color.FromArgb(181, 234, 215);
            btnKinkTest.BackColor = Color.FromArgb(181, 234, 215);
            btnBurnIn.BackColor = Color.FromArgb(181, 234, 215);
            btnPostBI.BackColor = Color.FromArgb(181, 234, 215);
            btnSRS2.BackColor = Color.FromArgb(181, 234, 215);

            Button btn = (Button)sender;
            //txtProcessSelected.Text = btn.Name.Replace("btn", "").Replace("no", "");
            txtProcessSelected.Text = btn.Text;
            //CommonClass.targetPower = txtTargetPower.Text;
            //CommonClass.processName = txtProcess.Text;
            flowLayoutPanelProcess.Controls["btn" + btn.Name.Replace("btn", "").Replace("no", "")].BackColor = Color.FromArgb(245, 183, 177);

            CvSystemSpecificPurchasePowerOutputProperty CvSystemSpecificProcessPowerOutputProperty = new CvSystemSpecificPurchasePowerOutputProperty
            {

                SYSTEM_ID = frmSystem.SYSTEM_ID,
                PURCHASE_ID = frmSystemSpecificPurchase.PURCHASE_ID,
                PROCESS_NAME = txtProcessSelected.Text,
            };

            CvSystemSpecificPurchaseProperty CvSystemSpecificProcessProperty = new CvSystemSpecificPurchaseProperty()
            {
                SYSTEM_ID = frmSystem.SYSTEM_ID,
                PURCHASE_ID = frmSystemSpecificPurchase.PURCHASE_ID,
                PROCESS_NAME = txtProcessSelected.Text,
            };

            if (_getInitialVoltage(CvSystemSpecificProcessProperty) == false)
            {
                this.Close();
            }

            if (_getTargetPower(CvSystemSpecificProcessPowerOutputProperty) == false)
            {
                this.Close();
            }

            _backToSet();

        }

        private bool _getInitialVoltage(CvSystemSpecificPurchaseProperty dataItem)
        {

            bool result = true;

            try
            {
                dataGridView1.Rows.Clear();

                CvSystemSpecificPurchaseProperty CvSystemSpecificProcessProperty = _cvSystemSpecificPurchaseController.SearchBySystemIdAndPurchaseId(dataItem);

                if (CvSystemSpecificProcessProperty != null)
                {
                    INITIAL_VOLTAGE_OF_INPUT.Text = CvSystemSpecificProcessProperty.INITIAL_VOLTAGE_OF_INPUT;
                    INITIAL_VOLTAGE_OF_OUTPUT.Text = CvSystemSpecificProcessProperty.INITIAL_VOLTAGE_OF_OUTPUT;
                    OUTPUT_TEMPERATURE_TARGET_POWER.Text = CvSystemSpecificProcessProperty.OUTPUT_TEMPERATURE_TARGET_POWER;
                }
                else
                {
                    INITIAL_VOLTAGE_OF_INPUT.Text = "";
                    INITIAL_VOLTAGE_OF_OUTPUT.Text = "";
                    OUTPUT_TEMPERATURE_TARGET_POWER.Text = "";
                }
            }
            catch (Exception ex)
            {
                CommonClassLibraryGlobal.showError(ex.Message);
                result = false;
            }

            return result;
        }

        private bool _getTargetPower(CvSystemSpecificPurchasePowerOutputProperty dataItem)
        {

            bool result = true;

            try
            {
                TARGET_POWER.Text = "";
                MAX_VOLTAGE_STEP.Text = "";

                dataGridView1.Rows.Clear();

                List<CvSystemSpecificPurchasePowerOutputProperty> list = _cvSystemSpecificPurchasePowerOutputController.SearchBySystemIdAndPurchaseIdAndProcessId(dataItem);

                foreach (CvSystemSpecificPurchasePowerOutputProperty systemSpecificConfigPower in list)
                {
                    TARGET_POWER.Text = systemSpecificConfigPower.TARGET_POWER.ToString();
                    MAX_VOLTAGE_STEP.Text = systemSpecificConfigPower.MAX_VOLTAGE_STEP.ToString();
                    break;
                }

                foreach (CvSystemSpecificPurchasePowerOutputProperty systemSpecificConfigPower in list)
                {
                    dataGridView1.Rows.Add(systemSpecificConfigPower.NO, systemSpecificConfigPower.POWER_PERCENT_FROM, systemSpecificConfigPower.POWER_PERCENT_TO, systemSpecificConfigPower.VOLTAGE_STEP, systemSpecificConfigPower.WAIT_TIME, "Delete");
                }

            }
            catch (Exception ex)
            {
                CommonClassLibraryGlobal.showError(ex.Message);
                result = false;
            }

            return result;

        }





        void _backToSet()
        {
            btnSet_Add.Text = "Set";
            btnClearPowerAll.Visible = false;
            dataGridView1.ReadOnly = true;
        }

        private void btnSaveKikusui_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(KIKUSUI_USB_NAME.Text))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก kikusui usb name");
                KIKUSUI_USB_NAME.Focus();
                return;
            }


            if (String.IsNullOrWhiteSpace(KIKUSUI_ADDRESS.Text))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก kikusui address");
                KIKUSUI_ADDRESS.Focus();
                return;
            }

            if (!double.TryParse(KIKUSUI_MAX_CURRENT.Text, out CommonClassLibraryGlobal.chkDouble))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก kikusui max current เป็นตัวเลขเท่านั้น");
                KIKUSUI_MAX_CURRENT.Text = "";
                KIKUSUI_MAX_CURRENT.Focus();
                return;
            }


            if (!double.TryParse(KIKUSUI_MAX_VOLTAGE.Text, out CommonClassLibraryGlobal.chkDouble))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก kikusui max voltage เป็นตัวเลขเท่านั้น");
                KIKUSUI_MAX_VOLTAGE.Text = "";
                KIKUSUI_MAX_VOLTAGE.Focus();
                return;
            }

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("คุณต้องการบันทึกข้อมูล ?", "Message", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }



            CvSystemSpecificProperty dataItem = new CvSystemSpecificProperty
            {
                SYSTEM_ID = frmSystem.SYSTEM_ID,
                PURCHASE_ID = frmSystemSpecificPurchase.PURCHASE_ID,
                KIKUSUI_USB_NAME = KIKUSUI_USB_NAME.Text,
                KIKUSUI_ADDRESS = KIKUSUI_ADDRESS.Text,
                KIKUSUI_MAX_CURRENT = KIKUSUI_MAX_CURRENT.Text,
                KIKUSUI_MAX_VOLTAGE = KIKUSUI_MAX_VOLTAGE.Text,
                IP_ADDRESS = CommonClassLibraryGlobal.IP,
                NAME_ADDRESS = CommonClassLibraryGlobal.HOST_NAME,
                USER_CREATE = CommonClassLibraryGlobal.OPERATOR_ID,
                USER_UPDATE = CommonClassLibraryGlobal.OPERATOR_ID,
            };


            if (_cvSystemSpecificController.InsertAndUpdateInuse(dataItem) == true)
            {
                CommonClassLibraryGlobal.showSuccess("แก้ไขข้อมูลสำเร็จ");
                _getDetailKikusuiPowerSupply();
                return;
            }
            else
            {
                CommonClassLibraryGlobal.showSuccess("แก้ไขข้อมูลไม่สำเร็จ กรุณาลองใหม่อีกครั้ง");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (e.RowIndex >= 0))
            {

                switch (e.ColumnIndex)
                {


                    case 5:

                        if (btnSet_Add.Text == "Set")
                        {
                            CommonClassLibraryGlobal.showError("กรุณากดปุ่ม Set ก่อนที่จะดำเนินการลบข้อมูล");
                        }
                        else
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result = MessageBox.Show("Are your sure ?", "Message", buttons, MessageBoxIcon.Warning);

                            if (result == DialogResult.No)
                            {
                                return;
                            }
                            else
                            {
                                dataGridView1.Rows.RemoveAt(e.RowIndex);
                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                {
                                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                }
                            }
                        }
                        break;

                }
            }
        }

        private void btnAddAndSet_Click(object sender, EventArgs e)
        {
            //CommonClass.typeMenu = "Add";

            //frm004_system_setting_specific_power  frm_add = new frm004_system_setting_specific_power();
            //frm_add.ShowDialog();
            //getDetailProcess();
            //frm_add.Close();

            if (txtProcessSelected.Text == "XXX")
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือกโปรเซสที่ต้องการ");
                return;
            }

            Button senderBtn = (Button)sender;

            if (senderBtn.Text == "Set")
            {
                senderBtn.Text = "Add";
                btnClearPowerAll.Visible = true;
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[0].ReadOnly = true;
            }
            else
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, "", "", "", "", "Delete");
            }

        }

        private void btnSaveInitialVoltage_Click(object sender, EventArgs e)
        {

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("คุณต้องการบันทึกข้อมูล ?", "Message", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            if (txtProcessSelected.Text == "XXX")
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือกโปรเซสที่ต้องการ");
                return;
            }

            if (!double.TryParse(INITIAL_VOLTAGE_OF_INPUT.Text, out CommonClassLibraryGlobal.chkDouble))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก Initial Voltage Of Input power control เป็นตัวเลขเท่านั้น");
                INITIAL_VOLTAGE_OF_INPUT.Text = "";
                INITIAL_VOLTAGE_OF_INPUT.Focus();
                return;
            }

            if (double.Parse(INITIAL_VOLTAGE_OF_INPUT.Text) > Properties.Settings.Default.MAX_VOLTAGE || double.Parse(INITIAL_VOLTAGE_OF_INPUT.Text) < Properties.Settings.Default.MIN_VOLTAGE)
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก Initial Voltage Of Input power control ให้อยู่ระหว่าง " + Properties.Settings.Default.MIN_VOLTAGE + " ถึง " + Properties.Settings.Default.MAX_VOLTAGE);
                INITIAL_VOLTAGE_OF_INPUT.Text = "";
                INITIAL_VOLTAGE_OF_INPUT.Focus();
                return;

            }

            if (!double.TryParse(INITIAL_VOLTAGE_OF_OUTPUT.Text, out CommonClassLibraryGlobal.chkDouble))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก Initial Voltage Of Output power control เป็นตัวเลขเท่านั้น");
                INITIAL_VOLTAGE_OF_OUTPUT.Text = "";
                INITIAL_VOLTAGE_OF_OUTPUT.Focus();
                return;
            }

            //if (double.Parse(INITIAL_VOLTAGE_OF_OUTPUT.Text) > Properties.Settings.Default.MAX_VOLTAGE || double.Parse(INITIAL_VOLTAGE_OF_OUTPUT.Text) < Properties.Settings.Default.MIN_VOLTAGE)
            //{
            //    CommonClassLibraryGlobal.showError("กรุณากรอก Initial Voltage Of Output power control ให้อยู่ระหว่าง " + Properties.Settings.Default.MIN_VOLTAGE + " ถึง " + Properties.Settings.Default.MAX_VOLTAGE);
            //    INITIAL_VOLTAGE_OF_OUTPUT.Text = "";
            //    INITIAL_VOLTAGE_OF_OUTPUT.Focus();
            //    return;

            //}

            if (!string.IsNullOrWhiteSpace(OUTPUT_TEMPERATURE_TARGET_POWER.Text))
            {
                if (!double.TryParse(OUTPUT_TEMPERATURE_TARGET_POWER.Text, out CommonClassLibraryGlobal.chkDouble))
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก Target Power Of Output Temperature เป็นตัวเลขเท่านั้น");
                    OUTPUT_TEMPERATURE_TARGET_POWER.Text = "";
                    OUTPUT_TEMPERATURE_TARGET_POWER.Focus();
                    return;

                }
            }




            CvSystemSpecificPurchaseProperty dataItem = new CvSystemSpecificPurchaseProperty()
            {
                SYSTEM_ID = frmSystem.SYSTEM_ID,
                PURCHASE_ID = frmSystemSpecificPurchase.PURCHASE_ID,
                PROCESS_NAME = txtProcessSelected.Text,
                INITIAL_VOLTAGE_OF_INPUT = INITIAL_VOLTAGE_OF_INPUT.Text,
                INITIAL_VOLTAGE_OF_OUTPUT = INITIAL_VOLTAGE_OF_OUTPUT.Text,
                OUTPUT_TEMPERATURE_TARGET_POWER = OUTPUT_TEMPERATURE_TARGET_POWER.Text,
                IP_ADDRESS = CommonClassLibraryGlobal.IP,
                NAME_ADDRESS = CommonClassLibraryGlobal.HOST_NAME,
                USER_CREATE = CommonClassLibraryGlobal.OPERATOR_ID,
                USER_UPDATE = CommonClassLibraryGlobal.OPERATOR_ID,
            };


            if (_cvSystemSpecificPurchaseController.InsertAndUpdateInuse(dataItem) == true)
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

        //private bool getProcessId()
        //{
        //    switch (txtProcessSelected.Text)
        //    {
        //        case "Resonator Test":
        //            IS_SUB_PROCESS = CavityMachineSettingManagementGlobal.ResonatorTest[0] == "0" ? true : false;
        //            PROCESS_ID = CavityMachineSettingManagementGlobal.ResonatorTest[1];
        //            break;
        //        case "Thermal Screening":
        //            IS_SUB_PROCESS = CavityMachineSettingManagementGlobal.ThermalScreening[0] == "0" ? true : false;
        //            PROCESS_ID = CavityMachineSettingManagementGlobal.ThermalScreening[1];
        //            break;
        //        case "Pre Burn-In 1":
        //            IS_SUB_PROCESS = CavityMachineSettingManagementGlobal.PreBurnIn1[0] == "0" ? true : false;
        //            PROCESS_ID = CavityMachineSettingManagementGlobal.PreBurnIn1[1];
        //            break;
        //        case "SRS 1":
        //            IS_SUB_PROCESS = CavityMachineSettingManagementGlobal.SRS1[0] == "0" ? true : false;
        //            PROCESS_ID = CavityMachineSettingManagementGlobal.SRS1[1];
        //            break;
        //        case "Pre-kink-test":
        //            IS_SUB_PROCESS = CavityMachineSettingManagementGlobal.PreKinkTest[0] == "0" ? true : false;
        //            PROCESS_ID = CavityMachineSettingManagementGlobal.PreKinkTest[1];
        //            break;
        //        case "Pre Burn-In 2":
        //            IS_SUB_PROCESS = CavityMachineSettingManagementGlobal.PreBurnIn2[0] == "0" ? true : false;
        //            PROCESS_ID = CavityMachineSettingManagementGlobal.PreBurnIn2[1];
        //            break;
        //        case "Kink-test":
        //            IS_SUB_PROCESS = CavityMachineSettingManagementGlobal.KinkTest[0] == "0" ? true : false;
        //            PROCESS_ID = CavityMachineSettingManagementGlobal.KinkTest[1];
        //            break;
        //        case "Burn-in":
        //            IS_SUB_PROCESS = CavityMachineSettingManagementGlobal.BurnIn[0] == "0" ? true : false;
        //            PROCESS_ID = CavityMachineSettingManagementGlobal.BurnIn[1];
        //            break;
        //        case "SRS 2":
        //            IS_SUB_PROCESS = CavityMachineSettingManagementGlobal.SRS2[0] == "0" ? true : false;
        //            PROCESS_ID = CavityMachineSettingManagementGlobal.SRS2[1];
        //            break;
        //        case "Post Burn-In":
        //            IS_SUB_PROCESS = CavityMachineSettingManagementGlobal.PostBurnIn[0] == "0" ? true : false;
        //            PROCESS_ID = CavityMachineSettingManagementGlobal.PostBurnIn[1];
        //            break;
        //        default:
        //            CommonClassLibraryGlobal.showError("ไม่พบ Process id กรุณาติดต่อโปรแกรมเมอร์");
        //            return false;
        //            break;
        //    }

        //    return true;
        //}
        private void btnClearInitialVoltage_Click(object sender, EventArgs e)
        {
            INITIAL_VOLTAGE_OF_INPUT.Text = "";
            INITIAL_VOLTAGE_OF_OUTPUT.Text = "";
            OUTPUT_TEMPERATURE_TARGET_POWER.Text = "";
        }

        private void btnClearPowerAll_Click(object sender, EventArgs e)
        {
            if (txtProcessSelected.Text == "XXX")
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือกโปรเซสที่ต้องการ");
                return;
            }

            dataGridView1.Rows.Clear();
        }

        private void btnSavePower_Click(object sender, EventArgs e)
        {

            if (txtProcessSelected.Text == "XXX")
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือกโปรเซสที่ต้องการ");
                return;
            }

            //-------------------------- ตรวจสอบข้อมูล ------------------------------------------

            if (!double.TryParse(TARGET_POWER.Text, out CommonClassLibraryGlobal.chkDouble))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก Target Power เป็นตัวเลขเท่านั้น");
                TARGET_POWER.Text = "";
                TARGET_POWER.Focus();
                return;
            }

            if (!double.TryParse(MAX_VOLTAGE_STEP.Text, out CommonClassLibraryGlobal.chkDouble))
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก Max Voltage Step เป็นตัวเลขเท่านั้น");
                MAX_VOLTAGE_STEP.Text = "";
                MAX_VOLTAGE_STEP.Focus();
                return;
            }

            if (double.Parse(MAX_VOLTAGE_STEP.Text) <= 0)
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก Max Voltage Step ให้มากกว่า 0 ");
                return;
            }

            int percent = 0;
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {


                if (!int.TryParse(dataGridView1.Rows[rows].Cells[1].Value.ToString(), out CommonClassLibraryGlobal.chkInt))
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก Power From (%) เป็นตัวเลขจำนวนเต็มเท่านั้น ");
                    return;
                }

                if (!int.TryParse(dataGridView1.Rows[rows].Cells[2].Value.ToString(), out CommonClassLibraryGlobal.chkInt))
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก Power To (%) เป็นตัวเลขจำนวนเต็มเท่านั้น ");
                    return;
                }

                if (int.Parse(dataGridView1.Rows[rows].Cells[1].Value.ToString()) > int.Parse(dataGridView1.Rows[rows].Cells[2].Value.ToString()))
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก Power From (%) ให้น้อยกว่า Power To (%) ");
                    return;
                }

                if (!double.TryParse(dataGridView1.Rows[rows].Cells[3].Value.ToString(), out CommonClassLibraryGlobal.chkDouble))
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก Voltage Step (V) เป็นตัวเลขเท่านั้น ");
                    return;
                }

                if (double.Parse(dataGridView1.Rows[rows].Cells[3].Value.ToString()) <= 0)
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก Voltage Step (V) ให้มากกว่า 0 ");
                    return;
                }

                if (double.Parse(dataGridView1.Rows[rows].Cells[3].Value.ToString()) > double.Parse(MAX_VOLTAGE_STEP.Text))
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก Voltage Step (V) ให้น้อยกว่าหรือเท่ากับ Max Voltage Step");
                    return;
                }

                if (!double.TryParse(dataGridView1.Rows[rows].Cells[4].Value.ToString(), out CommonClassLibraryGlobal.chkDouble))
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก Wait Time (S) เป็นตัวเลขเท่านั้น ");
                    return;
                }


            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) != percent)
                {
                    CommonClassLibraryGlobal.showError("ไม่พบ Power (%) ที่ " + percent + " ของ No." + (i + 1));
                    return;
                }

                percent = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + 1;

            }

            if (percent - 1 != 100)
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก Power To (%) ให้ครบ 100% ");
                return;
            }

            //-------------------------- End of ตรวจสอบข้อมูล ------------------------------------------

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show("ต้องการบันทึกข้อมูล ?", "Message", buttons, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            List<CvSystemSpecificPurchasePowerOutputProperty> listItem = new List<CvSystemSpecificPurchasePowerOutputProperty>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                CvSystemSpecificPurchasePowerOutputProperty dataItem = new CvSystemSpecificPurchasePowerOutputProperty()
                {

                    SYSTEM_ID = frmSystem.SYSTEM_ID,
                    PURCHASE_ID = frmSystemSpecificPurchase.PURCHASE_ID,
                    PROCESS_NAME = txtProcessSelected.Text,
                    NO = row.Cells[0].Value.ToString(),
                    TARGET_POWER = TARGET_POWER.Text,
                    POWER_PERCENT_FROM = row.Cells[1].Value.ToString(),
                    POWER_PERCENT_TO = row.Cells[2].Value.ToString(),
                    MAX_VOLTAGE_STEP = MAX_VOLTAGE_STEP.Text,
                    VOLTAGE_STEP = row.Cells[3].Value.ToString(),
                    WAIT_TIME = row.Cells[4].Value.ToString(),
                    IP_ADDRESS = CommonClassLibraryGlobal.IP,
                    NAME_ADDRESS = CommonClassLibraryGlobal.HOST_NAME,
                    USER_CREATE = CommonClassLibraryGlobal.OPERATOR_ID,
                    USER_UPDATE = CommonClassLibraryGlobal.OPERATOR_ID,
                };

                listItem.Add(dataItem);
            }

            if (_cvSystemSpecificPurchasePowerOutputController.InsertAndUpdateInuse(listItem) == true)
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

        private void btnClearKikusui_Click(object sender, EventArgs e)
        {
            KIKUSUI_ADDRESS.Text = "";
            KIKUSUI_MAX_CURRENT.Text = "";
            KIKUSUI_MAX_VOLTAGE.Text = "";
            KIKUSUI_USB_NAME.Text = "";
        }


    }
}
