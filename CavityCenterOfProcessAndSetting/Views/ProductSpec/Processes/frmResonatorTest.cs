using CommonClassLibrary;
using ResonatorTestManagement.Controller;
using ResonatorTestManagement.Property;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CavityCenterOfProcessAndSetting.Views
{
    public partial class frmResonatorTest : Form
    {
        public frmResonatorTest()
        {
            InitializeComponent();
        }

        CvResonatorSettingController resonatorSettingCommonController = new CvResonatorSettingController();
        CvResonatorSettingStepController resonatorSettingStepVoltageController = new CvResonatorSettingStepController();
        CvResonatorSetting_CvResonatorSettingStepController resonatorSettingController = new CvResonatorSetting_CvResonatorSettingStepController();


        //private static string processName;
        //private static string productTypeId;

        //private static string typeMenu;
        //private static string stepVoltageId;
        //private static string stepNumber;

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

        private void P_RESONATOR_Load(object sender, EventArgs e)
        {

            PURCHASE_NO.Text = frmProductSpecSetting.PURCHASE_NO;

            //frmProcess frmProcess = new frmProcess();
            //processName = frmProcess.getProcessName();

            //frmProductSpecSetting frmProductSpecSetting = new frmProductSpecSetting();
            //productTypeId = frmProductSpecSetting.getProductTypeId();

            if (_getDetailCommon() == false)
            {
                this.Close();
                return;
            }
            if (_getDetailVoltage() == false)
            {
                this.Close();
                return;
            }

            btnSave.Select();
        }

        private bool _getDetailVoltage()
        {
            try
            {
                List<CvResonatorSettingStepProperty> listItem = resonatorSettingStepVoltageController.SearchByPurchaseId(new CvResonatorSettingStepProperty { PURCHASE_ID = frmProductSpecSetting.PURCHASE_ID });
                dataGridView1.Rows.Clear();

                foreach (CvResonatorSettingStepProperty item in listItem)
                {
                    dataGridView1.Rows.Add(item.STEP_NUMBER, item.VOLTAGE, "Delete");
                }

            }
            catch (Exception ex)
            {
                CommonClassLibraryGlobal.showError(ex.Message);
                return false;
            }

            return true;
        }


        private bool _getDetailCommon()
        {
            try
            {
                CvResonatorSettingProperty dataItem = new CvResonatorSettingProperty();
                dataItem.PURCHASE_ID = frmProductSpecSetting.PURCHASE_ID;
                dataItem = resonatorSettingCommonController.Search(dataItem);

                if (dataItem != null)
                {
                    if (dataItem.INCREASE_STEP == "One Time")
                    {
                        rbIncreaseStep_OneTime.Checked = true;
                    }
                    else
                    {
                        rbIncreaseStep_01.Checked = true;
                    }

                    if (dataItem.EFF_NEED.ToString() == "1")
                    {
                        rbNeed_Eff.Checked = true;
                        txtMinSlope_Eff.Text = dataItem.EFF_MIN_SLOPE.ToString();
                        txtMaxSlope_Eff.Text = dataItem.EFF_MAX_SLOPE.ToString();
                        txtMinR2_Eff.Text = dataItem.EFF_MIN_R2.ToString();
                        txtMaxR2_Eff.Text = dataItem.EFF_MAX_R2.ToString();
                    }
                    else
                    {
                        rbNoNeed_Eff.Checked = true;
                    }


                    if (dataItem.OC_TEMP_NEED.ToString() == "1")
                    {
                        rbNeed_OcTemp.Checked = true;
                        txtMinSlope_OcTemp.Text = dataItem.OC_TEMP_MIN_SLOPE.ToString();
                        txtMaxSlope_OcTemp.Text = dataItem.OC_TEMP_MAX_SLOPE.ToString();
                        txtMinR2_OcTemp.Text = dataItem.OC_TEMP_MIN_R2.ToString();
                        txtMaxR2_OcTemp.Text = dataItem.OC_TEMP_MAX_R2.ToString();
                    }
                    else
                    {
                        rbNoNeed_OcTemp.Checked = true;
                    }

                    if (dataItem.HR_TEMP_NEED.ToString() == "1")
                    {
                        rbNeed_HrTemp.Checked = true;
                        txtMinSlope_HrTemp.Text = dataItem.HR_TEMP_MIN_SLOPE.ToString();
                        txtMaxSlope_HrTemp.Text = dataItem.HR_TEMP_MAX_SLOPE.ToString();
                        txtMinR2_HrTemp.Text = dataItem.HR_TEMP_MIN_R2.ToString();
                        txtMaxR2_HrTemp.Text = dataItem.HR_TEMP_MAX_R2.ToString();
                    }
                    else
                    {
                        rbNoNeed_HrTemp.Checked = true;
                    }


                    if (dataItem.COLDPLATE_TEMP_NEED.ToString() == "1")
                    {
                        rbNeed_ColdPlateTemp.Checked = true;
                        txtMinSlope_ColdPlateTemp.Text = dataItem.COLDPLATE_TEMP_MIN_SLOPE.ToString();
                        txtMaxSlope_ColdPlateTemp.Text = dataItem.COLDPLATE_TEMP_MAX_SLOPE.ToString();
                        txtMinR2_ColdPlateTemp.Text = dataItem.COLDPLATE_TEMP_MIN_R2.ToString();
                        txtMaxR2_ColdPlateTemp.Text = dataItem.COLDPLATE_TEMP_MAX_R2.ToString();
                    }
                    else
                    {
                        rbNoNeed_ColdPlateTemp.Checked = true;
                    }

                    if (dataItem.CENTERPORT_NEED.ToString() == "1")
                    {
                        rbNeed_CenterPort.Checked = true;

                        txtMinSignal_CenterPort.Text = dataItem.CENTERPORT_SIGNAL_MIN.ToString();
                        txtMaxSignal_CenterPort.Text = dataItem.CENTERPORT_SIGNAL_MAX.ToString();
                        txtMinPump_CenterPort.Text = dataItem.CENTERPORT_PUMP_MIN.ToString();
                        txtMaxPump_CenterPort.Text = dataItem.CENTERPORT_PUMP_MAX.ToString();

                    }
                    else
                    {
                        rbNoNeed_CenterPort.Checked = true;
                    }

                    if (dataItem.RESIDUAL_NEED.ToString() == "1")
                    {
                        rbNeed_Residual.Checked = true;

                        txtMinSlope_Eff.Text = dataItem.EFF_MIN_SLOPE.ToString();
                        txtMaxSlope_Eff.Text = dataItem.EFF_MAX_SLOPE.ToString();
                        txtMinR2_Eff.Text = dataItem.EFF_MIN_R2.ToString();
                        txtMaxR2_Eff.Text = dataItem.EFF_MAX_R2.ToString();

                        txtMinSignalFW_Residual.Text = dataItem.RESIDUAL_MIN_SIGNAL_FW.ToString();
                        txtMaxSignalFW_Residual.Text = dataItem.RESIDUAL_MAX_SIGNAL_FW.ToString();
                        txtMinSignalBW_Residual.Text = dataItem.RESIDUAL_MIN_SIGNAL_BW.ToString();
                        txtMaxSignalBW_Residual.Text = dataItem.RESIDUAL_MAX_SIGNAL_BW.ToString();
                        txtMinPumpFW_Residual.Text = dataItem.RESIDUAL_MIN_PUMP_FW.ToString();
                        txtMaxPumpFW_Residual.Text = dataItem.RESIDUAL_MAX_PUMP_FW.ToString();
                        txtMinPumpBW_Residual.Text = dataItem.RESIDUAL_MIN_PUMP_BW.ToString();
                        txtMaxPumpBW_Residual.Text = dataItem.RESIDUAL_MAX_PUMP_BW.ToString();
                    }
                    else
                    {
                        rbNoNeed_Residual.Checked = true;
                    }

                    if (dataItem.OUTPUT_TEMP_NEED.ToString() == "1")
                    {
                        rbNeed_OutputTemp.Checked = true;

                        txtMinSlope_Eff.Text = dataItem.EFF_MIN_SLOPE.ToString();
                        txtMaxSlope_Eff.Text = dataItem.EFF_MAX_SLOPE.ToString();
                        txtMinR2_Eff.Text = dataItem.EFF_MIN_R2.ToString();
                        txtMaxR2_Eff.Text = dataItem.EFF_MAX_R2.ToString();


                        txtMinPoint1_OutputTemp.Text = dataItem.OUTPUT_TEMP_MIN_POINT1;
                        txtMaxPoint1_OutputTemp.Text = dataItem.OUTPUT_TEMP_MAX_POINT1;
                        txtMinPoint2_OutputTemp.Text = dataItem.OUTPUT_TEMP_MIN_POINT2;
                        txtMaxPoint2_OutputTemp.Text = dataItem.OUTPUT_TEMP_MAX_POINT2;


                    }
                    else
                    {
                        rbNoNeed_OutputTemp.Checked = true;
                    }


                }
            }
            catch (Exception ex)
            {
                CommonClassLibraryGlobal.showError(ex.Message);
                return false;
            }

            return true;
        }

        private void rbClick(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            string[] rbs = rb.Name.Split('_');

            if (rbs[0] == "rbNoNeed")
            {

                this.Controls["groupBox_" + rbs[1]].Controls["lblMinSlope_" + rbs[1]].Visible = false;
                this.Controls["groupBox_" + rbs[1]].Controls["lblMaxSlope_" + rbs[1]].Visible = false;
                this.Controls["groupBox_" + rbs[1]].Controls["txtMinSlope_" + rbs[1]].Visible = false;
                this.Controls["groupBox_" + rbs[1]].Controls["txtMaxSlope_" + rbs[1]].Visible = false;
                this.Controls["groupBox_" + rbs[1]].Controls["txtMinSlope_" + rbs[1]].Text = "";
                this.Controls["groupBox_" + rbs[1]].Controls["txtMaxSlope_" + rbs[1]].Text = "";

                this.Controls["groupBox_" + rbs[1]].Controls["lblMinR2_" + rbs[1]].Visible = false;
                this.Controls["groupBox_" + rbs[1]].Controls["lblMaxR2_" + rbs[1]].Visible = false;
                this.Controls["groupBox_" + rbs[1]].Controls["txtMinR2_" + rbs[1]].Visible = false;
                this.Controls["groupBox_" + rbs[1]].Controls["txtMaxR2_" + rbs[1]].Visible = false;
                this.Controls["groupBox_" + rbs[1]].Controls["txtMinR2_" + rbs[1]].Text = "";
                this.Controls["groupBox_" + rbs[1]].Controls["txtMaxR2_" + rbs[1]].Text = "";

            }
            else
            {
                this.Controls["groupBox_" + rbs[1]].Controls["lblMinSlope_" + rbs[1]].Visible = true;
                this.Controls["groupBox_" + rbs[1]].Controls["lblMaxSlope_" + rbs[1]].Visible = true;
                this.Controls["groupBox_" + rbs[1]].Controls["txtMinSlope_" + rbs[1]].Visible = true;
                this.Controls["groupBox_" + rbs[1]].Controls["txtMaxSlope_" + rbs[1]].Visible = true;

                this.Controls["groupBox_" + rbs[1]].Controls["lblMinR2_" + rbs[1]].Visible = true;
                this.Controls["groupBox_" + rbs[1]].Controls["lblMaxR2_" + rbs[1]].Visible = true;
                this.Controls["groupBox_" + rbs[1]].Controls["txtMinR2_" + rbs[1]].Visible = true;
                this.Controls["groupBox_" + rbs[1]].Controls["txtMaxR2_" + rbs[1]].Visible = true;

            }

            this.Controls["groupBox_" + rbs[1]].Controls["txtMinSlope_" + rbs[1]].Focus();
        }

        private void residualClick(object sender, EventArgs e)
        {

            RadioButton rb = (RadioButton)sender;
            string[] rbs = rb.Name.Split('_');

            if (rbs[0] == "rbNoNeed")
            {

                lblMinSignalFW_Residual.Visible = false;
                lblMaxSignalFW_Residual.Visible = false;
                lblMinSignalBW_Residual.Visible = false;
                lblMaxSignalBW_Residual.Visible = false;
                lblMinPumpFW_Residual.Visible = false;
                lblMaxPumpFW_Residual.Visible = false;
                lblMinPumpBW_Residual.Visible = false;
                lblMaxPumpBW_Residual.Visible = false;

                txtMinSignalFW_Residual.Visible = false;
                txtMaxSignalFW_Residual.Visible = false;
                txtMinSignalBW_Residual.Visible = false;
                txtMaxSignalBW_Residual.Visible = false;

                txtMinSignalFW_Residual.Text = "";
                txtMaxSignalFW_Residual.Text = "";
                txtMinSignalBW_Residual.Text = "";
                txtMaxSignalBW_Residual.Text = "";

                txtMinPumpFW_Residual.Visible = false;
                txtMaxPumpFW_Residual.Visible = false;
                txtMinPumpBW_Residual.Visible = false;
                txtMaxPumpBW_Residual.Visible = false;

                txtMinPumpFW_Residual.Text = "";
                txtMaxPumpFW_Residual.Text = "";
                txtMinPumpBW_Residual.Text = "";
                txtMaxPumpBW_Residual.Text = "";


            }
            else
            {
                lblMinSignalFW_Residual.Visible = true;
                lblMaxSignalFW_Residual.Visible = true;
                lblMinSignalBW_Residual.Visible = true;
                lblMaxSignalBW_Residual.Visible = true;
                lblMinPumpFW_Residual.Visible = true;
                lblMaxPumpFW_Residual.Visible = true;
                lblMinPumpBW_Residual.Visible = true;
                lblMaxPumpBW_Residual.Visible = true;

                txtMinSignalFW_Residual.Visible = true;
                txtMaxSignalFW_Residual.Visible = true;
                txtMinSignalBW_Residual.Visible = true;
                txtMaxSignalBW_Residual.Visible = true;
                txtMinPumpFW_Residual.Visible = true;
                txtMaxPumpFW_Residual.Visible = true;
                txtMinPumpBW_Residual.Visible = true;
                txtMaxPumpBW_Residual.Visible = true;
            }
        }

        private void outputTempClick(object sender, EventArgs e)
        {

            RadioButton rb = (RadioButton)sender;
            string[] rbs = rb.Name.Split('_');

            if (rbs[0] == "rbNoNeed")
            {

                lblMinPoint1_OutputTemp.Visible = false;
                lblMaxPoint1_OutputTemp.Visible = false;
                lblMinPoint2_OutputTemp.Visible = false;
                lblMaxPoint2_OutputTemp.Visible = false;

                txtMinPoint1_OutputTemp.Visible = false;
                txtMaxPoint1_OutputTemp.Visible = false;
                txtMinPoint2_OutputTemp.Visible = false;
                txtMaxPoint2_OutputTemp.Visible = false;

                txtMinPoint1_OutputTemp.Text = "";
                txtMaxPoint1_OutputTemp.Text = "";
                txtMinPoint2_OutputTemp.Text = "";
                txtMaxPoint2_OutputTemp.Text = "";



            }
            else
            {

                lblMinPoint1_OutputTemp.Visible = true;
                lblMaxPoint1_OutputTemp.Visible = true;
                lblMinPoint2_OutputTemp.Visible = true;
                lblMaxPoint2_OutputTemp.Visible = true;

                txtMinPoint1_OutputTemp.Visible = true;
                txtMaxPoint1_OutputTemp.Visible = true;
                txtMinPoint2_OutputTemp.Visible = true;
                txtMaxPoint2_OutputTemp.Visible = true;
                txtMinPoint1_OutputTemp.Focus();

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView senderGrid = (DataGridView)sender;

            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (e.RowIndex >= 0))
            {

                switch (e.ColumnIndex)
                {

                    case 2:


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

                            }
                        }
                        break;

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //typeMenu = "Add";
            //this.Hide();
            //P_RESONATOR_STEP_VOLTAGE frm = new P_RESONATOR_STEP_VOLTAGE();
            //frm.ShowDialog();
            //_getDetailVoltage();
            //this.Show();
            //frm.Close();


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
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, "", "Delete");
            }


        }



        private void btnSorting_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("ยืนยันการบันทึกข้อมูล ?", "message", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            if (rbNeed_Eff.Checked == false && rbNoNeed_Eff.Checked == false)
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือก Efficiency");
                return;
            }
            else
            {
                if (rbNeed_Eff.Checked == true)
                {
                    if (!double.TryParse(txtMinSlope_Eff.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope Efficiency เป็นตัวเลขเท่านั้น");
                        txtMinSlope_Eff.Text = "";
                        txtMinSlope_Eff.Focus();
                        return;
                    }
                    if (!double.TryParse(txtMaxSlope_Eff.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Slope Efficiency เป็นตัวเลขเท่านั้น");
                        txtMaxSlope_Eff.Text = "";
                        txtMaxSlope_Eff.Focus();
                        return;
                    }

                    //----------- Slope_Eff 0-100 (%) ------------------
                    if (double.Parse(txtMinSlope_Eff.Text) > 100 || double.Parse(txtMinSlope_Eff.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope Efficiency ให้อยู่ระหว่าง 0-100 เท่านั้น");
                        txtMinSlope_Eff.Text = "";
                        txtMinSlope_Eff.Focus();
                        return;
                    }

                    if (double.Parse(txtMaxSlope_Eff.Text) > 100 || double.Parse(txtMaxSlope_Eff.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Slope Efficiency ให้อยู่ระหว่าง 0-100 เท่านั้น");
                        txtMaxSlope_Eff.Text = "";
                        txtMaxSlope_Eff.Focus();
                        return;
                    }
                    //----------- End of Slope_Eff 0-100 (%) --------------

                    if (double.Parse(txtMinSlope_Eff.Text) > double.Parse(txtMaxSlope_Eff.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope Efficiency ให้น้อยกว่าหรือเท่ากับ Max Slope Efficiency");
                        txtMinSlope_Eff.Text = "";
                        txtMinSlope_Eff.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMinR2_Eff.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Efficiency เป็นตัวเลขเท่านั้น");
                        txtMinR2_Eff.Text = "";
                        txtMinR2_Eff.Focus();
                        return;
                    }
                    if (!double.TryParse(txtMaxR2_Eff.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Efficiency เป็นตัวเลขเท่านั้น");
                        txtMaxR2_Eff.Text = "";
                        txtMaxR2_Eff.Focus();
                        return;
                    }

                    //----------- R2_Eff 0-100 (%) ------------------
                    if (double.Parse(txtMinR2_Eff.Text) > 100 || double.Parse(txtMinR2_Eff.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Efficiency ให้อยู่ระหว่าง 0-100 เท่านั้น");
                        txtMinR2_Eff.Text = "";
                        txtMinR2_Eff.Focus();
                        return;
                    }

                    if (double.Parse(txtMaxR2_Eff.Text) > 100 || double.Parse(txtMaxR2_Eff.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max R2 Efficiency ให้อยู่ระหว่าง 0-100 เท่านั้น");
                        txtMaxR2_Eff.Text = "";
                        txtMaxR2_Eff.Focus();
                        return;
                    }
                    //----------- End of R2_Eff 0-100 (%) ------------------

                    if (double.Parse(txtMinR2_Eff.Text) > double.Parse(txtMaxR2_Eff.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Efficiency ให้น้อยกว่าหรือเท่ากับ Max R2 Efficiency");
                        txtMinR2_Eff.Text = "";
                        txtMinR2_Eff.Focus();
                        return;
                    }
                }
            }


            if (rbNeed_OcTemp.Checked == false && rbNoNeed_OcTemp.Checked == false)
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือก OC Temp");
                return;
            }
            else
            {
                if (rbNeed_OcTemp.Checked == true)
                {
                    if (!double.TryParse(txtMinSlope_OcTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope Oc Temp เป็นตัวเลขเท่านั้น");
                        txtMinSlope_OcTemp.Text = "";
                        txtMinSlope_OcTemp.Focus();
                        return;
                    }
                    if (!double.TryParse(txtMaxSlope_OcTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Slope Oc Temp เป็นตัวเลขเท่านั้น");
                        txtMaxSlope_OcTemp.Text = "";
                        txtMaxSlope_OcTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMinSlope_OcTemp.Text) > 1 || double.Parse(txtMinSlope_OcTemp.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope Oc Temp ให้อยู่ระหว่าง 0-1 เท่านั้น");
                        txtMinSlope_OcTemp.Text = "";
                        txtMinSlope_OcTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMaxSlope_OcTemp.Text) > 1 || double.Parse(txtMaxSlope_OcTemp.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Slope Oc Temp ให้อยู่ระหว่าง 0-1 เท่านั้น");
                        txtMaxSlope_OcTemp.Text = "";
                        txtMaxSlope_OcTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMinSlope_OcTemp.Text) > double.Parse(txtMaxSlope_OcTemp.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope Oc Temp ให้น้อยกว่าหรือเท่ากับ Max Slope Oc Temp");
                        txtMinSlope_OcTemp.Text = "";
                        txtMinSlope_OcTemp.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMinR2_OcTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Oc Temp เป็นตัวเลขเท่านั้น");
                        txtMinR2_OcTemp.Text = "";
                        txtMinR2_OcTemp.Focus();
                        return;
                    }
                    if (!double.TryParse(txtMaxR2_OcTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Oc Temp เป็นตัวเลขเท่านั้น");
                        txtMaxR2_OcTemp.Text = "";
                        txtMaxR2_OcTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMinR2_Eff.Text) > 100 || double.Parse(txtMinR2_Eff.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Oc Temp ให้อยู่ระหว่าง 0-100 เท่านั้น");
                        txtMinR2_Eff.Text = "";
                        txtMinR2_Eff.Focus();
                        return;
                    }

                    if (double.Parse(txtMaxR2_Eff.Text) > 100 || double.Parse(txtMaxR2_Eff.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max R2 Oc Temp ให้อยู่ระหว่าง 0-100 เท่านั้น");
                        txtMaxR2_Eff.Text = "";
                        txtMaxR2_Eff.Focus();
                        return;
                    }

                    if (double.Parse(txtMinR2_OcTemp.Text) > double.Parse(txtMaxR2_OcTemp.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Oc Temp ให้น้อยกว่าหรือเท่ากับ Max R2 Oc Temp");
                        txtMinR2_OcTemp.Text = "";
                        txtMinR2_OcTemp.Focus();
                        return;
                    }

                }
            }


            if (rbNeed_HrTemp.Checked == false && rbNoNeed_HrTemp.Checked == false)
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือก HR Temp");
                return;
            }
            else
            {
                if (rbNeed_HrTemp.Checked == true)
                {
                    if (!double.TryParse(txtMinSlope_HrTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope Hr Temp เป็นตัวเลขเท่านั้น");
                        txtMinSlope_HrTemp.Text = "";
                        txtMinSlope_HrTemp.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMaxSlope_HrTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Slope Hr Temp เป็นตัวเลขเท่านั้น");
                        txtMaxSlope_HrTemp.Text = "";
                        txtMaxSlope_HrTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMinSlope_HrTemp.Text) > 1 || double.Parse(txtMinSlope_HrTemp.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope HR Temp ให้อยู่ระหว่าง 0-1 เท่านั้น");
                        txtMinSlope_HrTemp.Text = "";
                        txtMinSlope_HrTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMaxSlope_HrTemp.Text) > 1 || double.Parse(txtMaxSlope_HrTemp.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Slope HR Temp ให้อยู่ระหว่าง 0-1 เท่านั้น");
                        txtMaxSlope_HrTemp.Text = "";
                        txtMaxSlope_HrTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMinSlope_HrTemp.Text) > double.Parse(txtMaxSlope_HrTemp.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope Hr Temp ให้น้อยกว่าหรือเท่ากับ Max Slope Hr Temp");
                        txtMinSlope_HrTemp.Text = "";
                        txtMinSlope_HrTemp.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMinR2_HrTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Hr Temp เป็นตัวเลขเท่านั้น");
                        txtMinR2_HrTemp.Text = "";
                        txtMinR2_HrTemp.Focus();
                        return;
                    }
                    if (!double.TryParse(txtMaxR2_HrTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Hr Temp เป็นตัวเลขเท่านั้น");
                        txtMaxR2_HrTemp.Text = "";
                        txtMaxR2_HrTemp.Focus();
                        return;
                    }

                    //----------- R2_HrTemp 0-100 (%) ------------------
                    if (double.Parse(txtMinR2_HrTemp.Text) > 100 || double.Parse(txtMinR2_HrTemp.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Hr Temp ให้อยู่ระหว่าง 0-100 เท่านั้น");
                        txtMinR2_HrTemp.Text = "";
                        txtMinR2_HrTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMaxR2_HrTemp.Text) > 100 || double.Parse(txtMaxR2_HrTemp.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max R2 Hr Temp ให้อยู่ระหว่าง 0-100 เท่านั้น");
                        txtMaxR2_HrTemp.Text = "";
                        txtMaxR2_HrTemp.Focus();
                        return;
                    }
                    //----------- End of R2_HrTemp 0-100 (%) ------------------

                    if (double.Parse(txtMinR2_HrTemp.Text) > double.Parse(txtMaxR2_HrTemp.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 Hr Temp ให้น้อยกว่าหรือเท่ากับ Max R2 Hr Temp");
                        txtMinR2_HrTemp.Text = "";
                        txtMinR2_HrTemp.Focus();
                        return;
                    }

                }
            }

            if (rbNeed_ColdPlateTemp.Checked == false && rbNoNeed_ColdPlateTemp.Checked == false)
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือก ColdPlate Temp");
                return;
            }
            else
            {
                if (rbNeed_ColdPlateTemp.Checked == true)
                {
                    if (!double.TryParse(txtMinSlope_ColdPlateTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope ColdPlate Temp เป็นตัวเลขเท่านั้น");
                        txtMinSlope_ColdPlateTemp.Text = "";
                        txtMinSlope_ColdPlateTemp.Focus();
                        return;
                    }
                    if (!double.TryParse(txtMaxSlope_ColdPlateTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Slope ColdPlate Temp เป็นตัวเลขเท่านั้น");
                        txtMaxSlope_ColdPlateTemp.Text = "";
                        txtMaxSlope_ColdPlateTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMinSlope_ColdPlateTemp.Text) > 1 || double.Parse(txtMinSlope_ColdPlateTemp.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope ColdPlate Temp ให้อยู่ระหว่าง 0-1 เท่านั้น");
                        txtMinSlope_ColdPlateTemp.Text = "";
                        txtMinSlope_ColdPlateTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMaxSlope_ColdPlateTemp.Text) > 1 || double.Parse(txtMaxSlope_ColdPlateTemp.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Slope ColdPlate Temp ให้อยู่ระหว่าง 0-1 เท่านั้น");
                        txtMaxSlope_ColdPlateTemp.Text = "";
                        txtMaxSlope_ColdPlateTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMinSlope_ColdPlateTemp.Text) > double.Parse(txtMaxSlope_ColdPlateTemp.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Slope ColdPlate Temp ให้น้อยกว่าหรือเท่ากับ Max Slope ColdPlate Temp");
                        txtMinSlope_ColdPlateTemp.Text = "";
                        txtMinSlope_ColdPlateTemp.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMinR2_ColdPlateTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 ColdPlate Temp เป็นตัวเลขเท่านั้น");
                        txtMinR2_ColdPlateTemp.Text = "";
                        txtMinR2_ColdPlateTemp.Focus();
                        return;
                    }
                    if (!double.TryParse(txtMaxR2_ColdPlateTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 ColdPlate Temp เป็นตัวเลขเท่านั้น");
                        txtMaxR2_ColdPlateTemp.Text = "";
                        txtMaxR2_ColdPlateTemp.Focus();
                        return;
                    }

                    //----------- R2_ColdPlateTemp 0-100 (%) ------------------
                    if (double.Parse(txtMinR2_ColdPlateTemp.Text) > 100 || double.Parse(txtMinR2_ColdPlateTemp.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 ColdPlate Temp ให้อยู่ระหว่าง 0-100 เท่านั้น");
                        txtMinR2_ColdPlateTemp.Text = "";
                        txtMinR2_ColdPlateTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMaxR2_ColdPlateTemp.Text) > 100 || double.Parse(txtMaxR2_ColdPlateTemp.Text) < 0)
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max R2 ColdPlate Temp ให้อยู่ระหว่าง 0-100 เท่านั้น");
                        txtMaxR2_ColdPlateTemp.Text = "";
                        txtMaxR2_ColdPlateTemp.Focus();
                        return;
                    }
                    //----------- End of R2_ColdPlateTemp 0-100 (%) ------------------

                    if (double.Parse(txtMinR2_ColdPlateTemp.Text) > double.Parse(txtMaxR2_ColdPlateTemp.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min R2 ColdPlate Temp ให้น้อยกว่าหรือเท่ากับ Max R2 ColdPlate Temp");
                        txtMinR2_ColdPlateTemp.Text = "";
                        txtMinR2_ColdPlateTemp.Focus();
                        return;
                    }

                }
            }

            if (rbNeed_CenterPort.Checked == false && rbNoNeed_CenterPort.Checked == false)
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือก Center Port");
                return;
            }
            else
            {
                if (rbNeed_CenterPort.Checked == true)
                {


                    if (!double.TryParse(txtMinSignal_CenterPort.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Signal Center Port เป็นตัวเลขเท่านั้น");
                        txtMinSignal_CenterPort.Text = "";
                        txtMinSignal_CenterPort.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMaxSignal_CenterPort.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Signal Center Port เป็นตัวเลขเท่านั้น");
                        txtMaxSignal_CenterPort.Text = "";
                        txtMaxSignal_CenterPort.Focus();
                        return;
                    }

                    if (double.Parse(txtMinSignal_CenterPort.Text) > double.Parse(txtMaxSignal_CenterPort.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Signal Center Port ให้น้อยกว่าหรือเท่ากับ Max Signal Center Port");
                        txtMinSignal_CenterPort.Text = "";
                        txtMinSignal_CenterPort.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMinPump_CenterPort.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Pump Center Port เป็นตัวเลขเท่านั้น");
                        txtMinPump_CenterPort.Text = "";
                        txtMinPump_CenterPort.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMaxPump_CenterPort.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Pump Center Port เป็นตัวเลขเท่านั้น");
                        txtMaxPump_CenterPort.Text = "";
                        txtMaxPump_CenterPort.Focus();
                        return;
                    }

                    if (double.Parse(txtMinPump_CenterPort.Text) > double.Parse(txtMaxPump_CenterPort.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Signal FW Residual ให้น้อยกว่าหรือเท่ากับ Max Signal FW Residual");
                        txtMinPump_CenterPort.Text = "";
                        txtMinPump_CenterPort.Focus();
                        return;
                    }

                }
            }

            if (rbNeed_Residual.Checked == false && rbNoNeed_Residual.Checked == false)
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือก Residual");
                return;
            }
            else
            {
                if (rbNeed_Residual.Checked == true)
                {

                    if (!double.TryParse(txtMinSignalFW_Residual.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Signal FW Residual เป็นตัวเลขเท่านั้น");
                        txtMinSignalFW_Residual.Text = "";
                        txtMinSignalFW_Residual.Focus();
                        return;
                    }
                    if (!double.TryParse(txtMaxSignalFW_Residual.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Signal FW Residual เป็นตัวเลขเท่านั้น");
                        txtMaxSignalFW_Residual.Text = "";
                        txtMaxSignalFW_Residual.Focus();
                        return;
                    }

                    if (double.Parse(txtMinSignalFW_Residual.Text) > double.Parse(txtMaxSignalFW_Residual.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Signal FW Residual ให้น้อยกว่าหรือเท่ากับ Max Signal FW Residual");
                        txtMinSignalFW_Residual.Text = "";
                        txtMinSignalFW_Residual.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMinSignalBW_Residual.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Signal BW Residual เป็นตัวเลขเท่านั้น");
                        txtMinSignalBW_Residual.Text = "";
                        txtMinSignalBW_Residual.Focus();
                        return;
                    }
                    if (!double.TryParse(txtMaxSignalBW_Residual.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Signal BW Residual เป็นตัวเลขเท่านั้น");
                        txtMaxSignalBW_Residual.Text = "";
                        txtMaxSignalBW_Residual.Focus();
                        return;
                    }

                    if (double.Parse(txtMinSignalBW_Residual.Text) > double.Parse(txtMaxSignalBW_Residual.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Signal BW Residual ให้น้อยกว่าหรือเท่ากับ Max Signal BW Residual");
                        txtMinSignalBW_Residual.Text = "";
                        txtMinSignalBW_Residual.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMinPumpFW_Residual.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Pump FW Residual เป็นตัวเลขเท่านั้น");
                        txtMinPumpFW_Residual.Text = "";
                        txtMinPumpFW_Residual.Focus();
                        return;
                    }
                    if (!double.TryParse(txtMaxPumpFW_Residual.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Pump FW Residual เป็นตัวเลขเท่านั้น");
                        txtMaxPumpFW_Residual.Text = "";
                        txtMaxPumpFW_Residual.Focus();
                        return;
                    }

                    if (double.Parse(txtMinPumpFW_Residual.Text) > double.Parse(txtMaxPumpFW_Residual.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Pump FW Residual ให้น้อยกว่าหรือเท่ากับ Max Pump FW Residual");
                        txtMinPumpFW_Residual.Text = "";
                        txtMinPumpFW_Residual.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMinPumpBW_Residual.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Pump BW Residual เป็นตัวเลขเท่านั้น");
                        txtMinPumpBW_Residual.Text = "";
                        txtMinPumpBW_Residual.Focus();
                        return;
                    }
                    if (!double.TryParse(txtMaxPumpBW_Residual.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Pump BW Residual เป็นตัวเลขเท่านั้น");
                        txtMaxPumpBW_Residual.Text = "";
                        txtMaxPumpBW_Residual.Focus();
                        return;
                    }

                    if (double.Parse(txtMinPumpBW_Residual.Text) > double.Parse(txtMaxPumpBW_Residual.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Pump BW Residual ให้น้อยกว่าหรือเท่ากับ Max Pump BW Residual");
                        txtMinPumpBW_Residual.Text = "";
                        txtMinPumpBW_Residual.Focus();
                        return;
                    }

                }
            }

            if (rbNeed_OutputTemp.Checked == false && rbNoNeed_OutputTemp.Checked == false)
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือก Output temperature");
                return;
            }
            else
            {
                if (rbNeed_OutputTemp.Checked == true)
                {


                    if (!double.TryParse(txtMinPoint1_OutputTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Point1 Output temperature เป็นตัวเลขเท่านั้น");
                        txtMinPoint1_OutputTemp.Text = "";
                        txtMinPoint1_OutputTemp.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMaxPoint1_OutputTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Point1 Output temperature เป็นตัวเลขเท่านั้น");
                        txtMaxPoint1_OutputTemp.Text = "";
                        txtMaxPoint1_OutputTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMinPoint1_OutputTemp.Text) > double.Parse(txtMaxPoint1_OutputTemp.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Point1 Output temperature ให้น้อยกว่าหรือเท่ากับ Max Point1 Output temperature");
                        txtMinPoint1_OutputTemp.Text = "";
                        txtMinPoint1_OutputTemp.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMinPoint2_OutputTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Min Point2 Output temperature เป็นตัวเลขเท่านั้น");
                        txtMinPoint2_OutputTemp.Text = "";
                        txtMinPoint2_OutputTemp.Focus();
                        return;
                    }

                    if (!double.TryParse(txtMaxPoint2_OutputTemp.Text, out CommonClassLibraryGlobal.chkDouble))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Max Point2 Output temperature เป็นตัวเลขเท่านั้น");
                        txtMaxPoint2_OutputTemp.Text = "";
                        txtMaxPoint2_OutputTemp.Focus();
                        return;
                    }

                    if (double.Parse(txtMinPoint2_OutputTemp.Text) > double.Parse(txtMaxPoint2_OutputTemp.Text))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก  Min Point2 Output temperature  ให้น้อยกว่าหรือเท่ากับ  Max Point2 Output temperature ");
                        txtMinPoint2_OutputTemp.Text = "";
                        txtMinPoint2_OutputTemp.Focus();
                        return;
                    }

                }
            }
            //---------------------------------------- Voltage ---------------------------------------------------
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                if (!double.TryParse(dataGridView1.Rows[rows].Cells[1].Value.ToString(), out CommonClassLibraryGlobal.chkDouble))
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก Voltage เป็นตัวเลขจำนวนเต็มเท่านั้น ");
                    return;
                }

                if (double.Parse(dataGridView1.Rows[rows].Cells[1].Value.ToString()) > Properties.Settings.Default.MAX_VOLTAGE || double.Parse(dataGridView1.Rows[rows].Cells[1].Value.ToString()) < Properties.Settings.Default.MIN_VOLTAGE)
                {
                    CommonClassLibraryGlobal.showError("กรุณากรอก Voltage ให้อยู่ระหว่าง " + Properties.Settings.Default.MAX_VOLTAGE + " ถึง " + Properties.Settings.Default.MAX_VOLTAGE);
                    dataGridView1.Rows[rows].Cells[1].Value = "";
                    return;

                }

            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i != 0)
                {
                    if (double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) <= double.Parse(dataGridView1.Rows[i - 1].Cells[1].Value.ToString()))
                    {
                        CommonClassLibraryGlobal.showError("กรุณากรอก Voltage ลำดับที่ " + (i + 1) + " ให้มากกว่า ลำดับที่ " + (i));
                        return;
                    }
                }
            }

            if (dataGridView1.Rows.Count == 0)
            {
                CommonClassLibraryGlobal.showError("กรุณากรอก Voltage อย่างน้อย 1 ข้อมูล");
                return;
            }

            if (rbIncreaseStep_01.Checked == false && rbIncreaseStep_OneTime.Checked == false)
            {
                CommonClassLibraryGlobal.showError("กรุณาเลือก Increase Step");
                return;
            }

            List<CvResonatorSettingStepProperty> list_CvResonatorSettingStepProperty = new List<CvResonatorSettingStepProperty>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                CvResonatorSettingStepProperty CvResonatorSettingStepProperty = new CvResonatorSettingStepProperty()
                {
                    PURCHASE_ID = frmProductSpecSetting.PURCHASE_ID,
                    STEP_NUMBER = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    VOLTAGE = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    USER_CREATE = CommonClassLibraryGlobal.OPERATOR_ID,
                    USER_UPDATE = CommonClassLibraryGlobal.OPERATOR_ID,
                };

                list_CvResonatorSettingStepProperty.Add(CvResonatorSettingStepProperty);


            }
            //---------------------------------------- End of Voltage ---------------------------------------------------

            CvResonatorSettingProperty resonatorSetting = new CvResonatorSettingProperty
            {
                PURCHASE_ID = frmProductSpecSetting.PURCHASE_ID,
                IP_ADDRESS = CommonClassLibraryGlobal.IP,
                NAME_ADDRESS = CommonClassLibraryGlobal.HOST_NAME,

                EFF_NEED = rbNeed_Eff.Checked == true ? "1" : "0",
                EFF_MIN_SLOPE = txtMinSlope_Eff.Text,
                EFF_MAX_SLOPE = txtMaxSlope_Eff.Text,
                EFF_MIN_R2 = txtMinR2_Eff.Text,
                EFF_MAX_R2 = txtMaxR2_Eff.Text,

                CENTERPORT_NEED = rbNeed_CenterPort.Checked == true ? "1" : "0",
                CENTERPORT_PUMP_MIN = txtMinPump_CenterPort.Text,
                CENTERPORT_PUMP_MAX = txtMaxPump_CenterPort.Text,
                CENTERPORT_SIGNAL_MIN = txtMinSignal_CenterPort.Text,
                CENTERPORT_SIGNAL_MAX = txtMaxSignal_CenterPort.Text,

                COLDPLATE_TEMP_NEED = rbNeed_ColdPlateTemp.Checked == true ? "1" : "0",
                COLDPLATE_TEMP_MIN_R2 = txtMinR2_ColdPlateTemp.Text,
                COLDPLATE_TEMP_MAX_R2 = txtMaxR2_ColdPlateTemp.Text,
                COLDPLATE_TEMP_MIN_SLOPE = txtMinSlope_ColdPlateTemp.Text,
                COLDPLATE_TEMP_MAX_SLOPE = txtMaxSlope_ColdPlateTemp.Text,

                HR_TEMP_NEED = rbNeed_HrTemp.Checked == true ? "1" : "0",
                HR_TEMP_MIN_R2 = txtMinR2_HrTemp.Text,
                HR_TEMP_MAX_R2 = txtMaxR2_HrTemp.Text,
                HR_TEMP_MIN_SLOPE = txtMinSlope_HrTemp.Text,
                HR_TEMP_MAX_SLOPE = txtMaxSlope_HrTemp.Text,

                OC_TEMP_NEED = rbNeed_OcTemp.Checked == true ? "1" : "0",
                OC_TEMP_MIN_R2 = txtMinR2_OcTemp.Text,
                OC_TEMP_MAX_R2 = txtMaxR2_OcTemp.Text,
                OC_TEMP_MIN_SLOPE = txtMinSlope_OcTemp.Text,
                OC_TEMP_MAX_SLOPE = txtMaxSlope_OcTemp.Text,

                OUTPUT_TEMP_NEED = rbNeed_OutputTemp.Checked == true ? "1" : "0",
                OUTPUT_TEMP_MIN_POINT1 = txtMinPoint1_OutputTemp.Text,
                OUTPUT_TEMP_MAX_POINT1 = txtMaxPoint1_OutputTemp.Text,
                OUTPUT_TEMP_MIN_POINT2 = txtMinPoint2_OutputTemp.Text,
                OUTPUT_TEMP_MAX_POINT2 = txtMaxPoint2_OutputTemp.Text,

                RESIDUAL_NEED = rbNeed_Residual.Checked == true ? "1" : "0",
                RESIDUAL_MIN_PUMP_BW = txtMinPumpBW_Residual.Text,
                RESIDUAL_MAX_PUMP_BW = txtMaxPumpBW_Residual.Text,
                RESIDUAL_MIN_PUMP_FW = txtMinPumpFW_Residual.Text,
                RESIDUAL_MAX_PUMP_FW = txtMaxPumpFW_Residual.Text,
                RESIDUAL_MIN_SIGNAL_BW = txtMinSignalBW_Residual.Text,
                RESIDUAL_MAX_SIGNAL_BW = txtMaxSignalBW_Residual.Text,
                RESIDUAL_MIN_SIGNAL_FW = txtMinSignalFW_Residual.Text,
                RESIDUAL_MAX_SIGNAL_FW = txtMaxSignalFW_Residual.Text,
                INCREASE_STEP = rbIncreaseStep_01.Checked == true ? "0.1" : "One Time",
                CREATE_DATE = CommonClassLibraryGlobal.OPERATOR_ID,
                USER_UPDATE = CommonClassLibraryGlobal.OPERATOR_ID
            };

            CvResonatorSetting_CvResonatorSettingStepProperty resonatorSettingProperty = new CvResonatorSetting_CvResonatorSettingStepProperty()
            {
                CV_RESONATOR_SETTING = resonatorSetting,
                LIST_CV_RESONATOR_SETTING_STEP = list_CvResonatorSettingStepProperty,
            };

            if (resonatorSettingController.InsertAndUpdateInuse(resonatorSettingProperty) == true)
            {
                CommonClassLibraryGlobal.showSuccess("แก้ไขข้อมูลสำเร็จ");
            }
            else
            {
                CommonClassLibraryGlobal.showSuccess("แก้ไขข้อมูลไม่สำเร็จ กรุณาลองใหม่อีกครั้ง");
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            rbNoNeed_Eff.Checked = true;
            rbNoNeed_Eff.Checked = false;

            rbNoNeed_HrTemp.Checked = true;
            rbNoNeed_HrTemp.Checked = false;

            rbNoNeed_OcTemp.Checked = true;
            rbNoNeed_OcTemp.Checked = false;

            rbNoNeed_ColdPlateTemp.Checked = true;
            rbNoNeed_ColdPlateTemp.Checked = false;

            rbNoNeed_Residual.Checked = true;
            rbNoNeed_Residual.Checked = false;

        }

        private void rbNeed_CenterPort_CheckedChanged(object sender, EventArgs e)
        {

            lblMinSignal_CenterPort.Visible = true;
            lblMaxSignal_CenterPort.Visible = true;
            txtMinSignal_CenterPort.Visible = true;
            txtMaxSignal_CenterPort.Visible = true;

            lblMinPump_CenterPort.Visible = true;
            lblMaxPump_CenterPort.Visible = true;
            txtMinPump_CenterPort.Visible = true;
            txtMaxPump_CenterPort.Visible = true;
            txtMinSignal_CenterPort.Focus();
        }

        private void rbNoNeed_CenterPort_CheckedChanged(object sender, EventArgs e)
        {
            lblMinSignal_CenterPort.Visible = false;
            lblMaxSignal_CenterPort.Visible = false;
            txtMinSignal_CenterPort.Visible = false;
            txtMaxSignal_CenterPort.Visible = false;
            txtMinSignal_CenterPort.Text = "";
            txtMaxSignal_CenterPort.Text = "";

            lblMinPump_CenterPort.Visible = false;
            lblMaxPump_CenterPort.Visible = false;
            txtMinPump_CenterPort.Visible = false;
            txtMaxPump_CenterPort.Visible = false;
            txtMinPump_CenterPort.Text = "";
            txtMaxPump_CenterPort.Text = "";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if ((senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (e.RowIndex >= 0))
            {

                switch (e.ColumnIndex)
                {
                    case 2:

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

        private void btnClearPowerAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
