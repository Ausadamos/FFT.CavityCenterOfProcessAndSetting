namespace CavityCenterOfProcessAndSetting.Views
{
    partial class frmSystemCommon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.system_name = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.ip_address_system = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2 = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1 = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.OFFSET_SLOP_EFFICIENCY_RESONATOR = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.SAFETY_MAX_COLDPLATE_TEMP = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.SAFETY_OUTPUT_CHECK_TIME = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.SAFETY_MIN_OUTPUT_POWER = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.SAFETY_MIN_PD_OUTPUT = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.SAFETY_OFFSET = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.panelCustom4 = new CustomUIClassLibrary.PanelCustom();
            this.SAFETY_SHUT_DOWN_THRESHOLD = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.panelCustom3 = new CustomUIClassLibrary.PanelCustom();
            this.panelCustom2 = new CustomUIClassLibrary.PanelCustom();
            this.panelCustom1 = new CustomUIClassLibrary.PanelCustom();
            this.pnlParameterMachine = new CustomUIClassLibrary.PanelCustom();
            this.pnlDeviceConnection = new CustomUIClassLibrary.PanelCustom();
            this.GL840_MS_OUT_TEMP_CHANNEL = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.GL840_CAVITY_PD_CHANNEL = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.GL840_BASEPLATE_TEMP_CHANNEL = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.GL840_MS_IN_TEMP_CHANNEL = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.GL840_COLD_PLATE_TEMP_CHANNEL = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.GL840_SAFETY_PD_CHANNEL = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.OPHIR_BW_METER_ADDRESS = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.OPHIR_FW_METER_ADDRESS = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.OPHIR_OUTPUT_POWER_METER_ADDRESS = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.RESIDUAL_COM_PORT = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.DIO_COM_PORT = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.OSA_GPIB_ADDRESS = new CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picManimise = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManimise)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 577;
            this.label2.Text = "System Name :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(139)))), ((int)(((byte)(89)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(489, 825);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 42);
            this.btnSave.TabIndex = 575;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // system_name
            // 
            this.system_name.AutoSize = true;
            this.system_name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system_name.ForeColor = System.Drawing.Color.White;
            this.system_name.Location = new System.Drawing.Point(176, 78);
            this.system_name.Name = "system_name";
            this.system_name.Size = new System.Drawing.Size(34, 22);
            this.system_name.TabIndex = 578;
            this.system_name.Text = "XX";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(656, 825);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 42);
            this.btnClear.TabIndex = 576;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ip_address_system
            // 
            this.ip_address_system.AutoSize = true;
            this.ip_address_system.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_address_system.ForeColor = System.Drawing.Color.White;
            this.ip_address_system.Location = new System.Drawing.Point(176, 115);
            this.ip_address_system.Name = "ip_address_system";
            this.ip_address_system.Size = new System.Drawing.Size(34, 22);
            this.ip_address_system.TabIndex = 580;
            this.ip_address_system.Text = "XX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 579;
            this.label5.Text = "IP Address :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(1274, 70);
            this.label1.TabIndex = 583;
            this.label1.Text = "System Spec Setting - Common";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblProgramName_MouseMove);
            // 
            // OFFSET_SLOP_EFFICIENCY_POST_BURNIN
            // 
            this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN.BackColor = System.Drawing.Color.Transparent;
            this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN.CheckIsNumeric = true;
            this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN.HeaderColor = System.Drawing.Color.White;
            this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN.HeaderLabel = "Post Burn-In";
            this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN.Location = new System.Drawing.Point(690, 707);
            this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN.Name = "OFFSET_SLOP_EFFICIENCY_POST_BURNIN";
            this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN.PictureOption = null;
            this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN.Size = new System.Drawing.Size(524, 33);
            this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN.TabIndex = 725;
            this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN.TextBoxValue = "";
            // 
            // OFFSET_SLOP_EFFICIENCY_MONITOR_CAL
            // 
            this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL.BackColor = System.Drawing.Color.Transparent;
            this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL.CheckIsNumeric = true;
            this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL.HeaderColor = System.Drawing.Color.White;
            this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL.HeaderLabel = "Monitor Calibration";
            this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL.Location = new System.Drawing.Point(690, 668);
            this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL.Name = "OFFSET_SLOP_EFFICIENCY_MONITOR_CAL";
            this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL.PictureOption = null;
            this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL.Size = new System.Drawing.Size(524, 33);
            this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL.TabIndex = 724;
            this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL.TextBoxValue = "";
            // 
            // OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2
            // 
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2.BackColor = System.Drawing.Color.Transparent;
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2.CheckIsNumeric = true;
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2.HeaderColor = System.Drawing.Color.White;
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2.HeaderLabel = "Pre Burn-In 2";
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2.Location = new System.Drawing.Point(690, 629);
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2.Name = "OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2";
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2.PictureOption = null;
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2.Size = new System.Drawing.Size(524, 33);
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2.TabIndex = 723;
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2.TextBoxValue = "";
            // 
            // OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1
            // 
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1.BackColor = System.Drawing.Color.Transparent;
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1.CheckIsNumeric = true;
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1.HeaderColor = System.Drawing.Color.White;
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1.HeaderLabel = "Pre Burn-In 1";
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1.Location = new System.Drawing.Point(690, 590);
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1.Name = "OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1";
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1.PictureOption = null;
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1.Size = new System.Drawing.Size(524, 33);
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1.TabIndex = 722;
            this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1.TextBoxValue = "";
            // 
            // OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING
            // 
            this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING.BackColor = System.Drawing.Color.Transparent;
            this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING.CheckIsNumeric = true;
            this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING.HeaderColor = System.Drawing.Color.White;
            this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING.HeaderLabel = "Thermal Screening";
            this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING.Location = new System.Drawing.Point(690, 551);
            this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING.Name = "OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING";
            this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING.PictureOption = null;
            this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING.Size = new System.Drawing.Size(524, 33);
            this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING.TabIndex = 721;
            this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING.TextBoxValue = "";
            // 
            // OFFSET_SLOP_EFFICIENCY_RESONATOR
            // 
            this.OFFSET_SLOP_EFFICIENCY_RESONATOR.BackColor = System.Drawing.Color.Transparent;
            this.OFFSET_SLOP_EFFICIENCY_RESONATOR.CheckIsNumeric = true;
            this.OFFSET_SLOP_EFFICIENCY_RESONATOR.HeaderColor = System.Drawing.Color.White;
            this.OFFSET_SLOP_EFFICIENCY_RESONATOR.HeaderLabel = "Resonator Test";
            this.OFFSET_SLOP_EFFICIENCY_RESONATOR.Location = new System.Drawing.Point(690, 512);
            this.OFFSET_SLOP_EFFICIENCY_RESONATOR.Name = "OFFSET_SLOP_EFFICIENCY_RESONATOR";
            this.OFFSET_SLOP_EFFICIENCY_RESONATOR.PictureOption = null;
            this.OFFSET_SLOP_EFFICIENCY_RESONATOR.Size = new System.Drawing.Size(524, 33);
            this.OFFSET_SLOP_EFFICIENCY_RESONATOR.TabIndex = 720;
            this.OFFSET_SLOP_EFFICIENCY_RESONATOR.TextBoxValue = "";
            // 
            // SAFETY_MAX_COLDPLATE_TEMP
            // 
            this.SAFETY_MAX_COLDPLATE_TEMP.BackColor = System.Drawing.Color.Transparent;
            this.SAFETY_MAX_COLDPLATE_TEMP.CheckIsNumeric = true;
            this.SAFETY_MAX_COLDPLATE_TEMP.HeaderColor = System.Drawing.Color.White;
            this.SAFETY_MAX_COLDPLATE_TEMP.HeaderLabel = "Max Coldplate Temp (C) :";
            this.SAFETY_MAX_COLDPLATE_TEMP.Location = new System.Drawing.Point(690, 419);
            this.SAFETY_MAX_COLDPLATE_TEMP.Name = "SAFETY_MAX_COLDPLATE_TEMP";
            this.SAFETY_MAX_COLDPLATE_TEMP.PictureOption = null;
            this.SAFETY_MAX_COLDPLATE_TEMP.Size = new System.Drawing.Size(524, 33);
            this.SAFETY_MAX_COLDPLATE_TEMP.TabIndex = 719;
            this.SAFETY_MAX_COLDPLATE_TEMP.TextBoxValue = "";
            // 
            // SAFETY_OUTPUT_CHECK_TIME
            // 
            this.SAFETY_OUTPUT_CHECK_TIME.BackColor = System.Drawing.Color.Transparent;
            this.SAFETY_OUTPUT_CHECK_TIME.CheckIsNumeric = true;
            this.SAFETY_OUTPUT_CHECK_TIME.HeaderColor = System.Drawing.Color.White;
            this.SAFETY_OUTPUT_CHECK_TIME.HeaderLabel = "Output Check Time (S) :";
            this.SAFETY_OUTPUT_CHECK_TIME.Location = new System.Drawing.Point(690, 380);
            this.SAFETY_OUTPUT_CHECK_TIME.Name = "SAFETY_OUTPUT_CHECK_TIME";
            this.SAFETY_OUTPUT_CHECK_TIME.PictureOption = null;
            this.SAFETY_OUTPUT_CHECK_TIME.Size = new System.Drawing.Size(524, 33);
            this.SAFETY_OUTPUT_CHECK_TIME.TabIndex = 718;
            this.SAFETY_OUTPUT_CHECK_TIME.TextBoxValue = "";
            // 
            // SAFETY_MIN_OUTPUT_POWER
            // 
            this.SAFETY_MIN_OUTPUT_POWER.BackColor = System.Drawing.Color.Transparent;
            this.SAFETY_MIN_OUTPUT_POWER.CheckIsNumeric = true;
            this.SAFETY_MIN_OUTPUT_POWER.HeaderColor = System.Drawing.Color.White;
            this.SAFETY_MIN_OUTPUT_POWER.HeaderLabel = "Min  Output Power (W) :";
            this.SAFETY_MIN_OUTPUT_POWER.Location = new System.Drawing.Point(690, 341);
            this.SAFETY_MIN_OUTPUT_POWER.Name = "SAFETY_MIN_OUTPUT_POWER";
            this.SAFETY_MIN_OUTPUT_POWER.PictureOption = null;
            this.SAFETY_MIN_OUTPUT_POWER.Size = new System.Drawing.Size(524, 33);
            this.SAFETY_MIN_OUTPUT_POWER.TabIndex = 717;
            this.SAFETY_MIN_OUTPUT_POWER.TextBoxValue = "";
            // 
            // SAFETY_MIN_PD_OUTPUT
            // 
            this.SAFETY_MIN_PD_OUTPUT.BackColor = System.Drawing.Color.Transparent;
            this.SAFETY_MIN_PD_OUTPUT.CheckIsNumeric = true;
            this.SAFETY_MIN_PD_OUTPUT.HeaderColor = System.Drawing.Color.White;
            this.SAFETY_MIN_PD_OUTPUT.HeaderLabel = "Min PD Output (V) :";
            this.SAFETY_MIN_PD_OUTPUT.Location = new System.Drawing.Point(690, 302);
            this.SAFETY_MIN_PD_OUTPUT.Name = "SAFETY_MIN_PD_OUTPUT";
            this.SAFETY_MIN_PD_OUTPUT.PictureOption = null;
            this.SAFETY_MIN_PD_OUTPUT.Size = new System.Drawing.Size(524, 33);
            this.SAFETY_MIN_PD_OUTPUT.TabIndex = 716;
            this.SAFETY_MIN_PD_OUTPUT.TextBoxValue = "";
            // 
            // SAFETY_OFFSET
            // 
            this.SAFETY_OFFSET.BackColor = System.Drawing.Color.Transparent;
            this.SAFETY_OFFSET.CheckIsNumeric = true;
            this.SAFETY_OFFSET.HeaderColor = System.Drawing.Color.White;
            this.SAFETY_OFFSET.HeaderLabel = "Offset (V) :";
            this.SAFETY_OFFSET.Location = new System.Drawing.Point(690, 263);
            this.SAFETY_OFFSET.Name = "SAFETY_OFFSET";
            this.SAFETY_OFFSET.PictureOption = null;
            this.SAFETY_OFFSET.Size = new System.Drawing.Size(524, 33);
            this.SAFETY_OFFSET.TabIndex = 715;
            this.SAFETY_OFFSET.TextBoxValue = "";
            // 
            // panelCustom4
            // 
            this.panelCustom4.BackColor = System.Drawing.Color.Transparent;
            this.panelCustom4.HeaderLabel = "Offset Slop Efficiency";
            this.panelCustom4.LineColorLayout = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelCustom4.Location = new System.Drawing.Point(673, 483);
            this.panelCustom4.Name = "panelCustom4";
            this.panelCustom4.Size = new System.Drawing.Size(557, 313);
            this.panelCustom4.TabIndex = 714;
            // 
            // SAFETY_SHUT_DOWN_THRESHOLD
            // 
            this.SAFETY_SHUT_DOWN_THRESHOLD.BackColor = System.Drawing.Color.Transparent;
            this.SAFETY_SHUT_DOWN_THRESHOLD.CheckIsNumeric = true;
            this.SAFETY_SHUT_DOWN_THRESHOLD.HeaderColor = System.Drawing.Color.White;
            this.SAFETY_SHUT_DOWN_THRESHOLD.HeaderLabel = "Shut Down  Threshold (%) :";
            this.SAFETY_SHUT_DOWN_THRESHOLD.Location = new System.Drawing.Point(690, 224);
            this.SAFETY_SHUT_DOWN_THRESHOLD.Name = "SAFETY_SHUT_DOWN_THRESHOLD";
            this.SAFETY_SHUT_DOWN_THRESHOLD.PictureOption = null;
            this.SAFETY_SHUT_DOWN_THRESHOLD.Size = new System.Drawing.Size(524, 33);
            this.SAFETY_SHUT_DOWN_THRESHOLD.TabIndex = 708;
            this.SAFETY_SHUT_DOWN_THRESHOLD.TextBoxValue = "";
            // 
            // panelCustom3
            // 
            this.panelCustom3.BackColor = System.Drawing.Color.Transparent;
            this.panelCustom3.HeaderLabel = "Safety";
            this.panelCustom3.LineColorLayout = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelCustom3.Location = new System.Drawing.Point(673, 194);
            this.panelCustom3.Name = "panelCustom3";
            this.panelCustom3.Size = new System.Drawing.Size(557, 283);
            this.panelCustom3.TabIndex = 707;
            // 
            // panelCustom2
            // 
            this.panelCustom2.BackColor = System.Drawing.Color.Transparent;
            this.panelCustom2.HeaderLabel = "GL840";
            this.panelCustom2.LineColorLayout = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCustom2.Location = new System.Drawing.Point(42, 483);
            this.panelCustom2.Name = "panelCustom2";
            this.panelCustom2.Size = new System.Drawing.Size(589, 313);
            this.panelCustom2.TabIndex = 706;
            // 
            // panelCustom1
            // 
            this.panelCustom1.BackColor = System.Drawing.Color.Transparent;
            this.panelCustom1.HeaderLabel = "Ophir Power Meter";
            this.panelCustom1.LineColorLayout = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelCustom1.Location = new System.Drawing.Point(42, 284);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(589, 193);
            this.panelCustom1.TabIndex = 694;
            // 
            // pnlParameterMachine
            // 
            this.pnlParameterMachine.BackColor = System.Drawing.Color.Transparent;
            this.pnlParameterMachine.HeaderLabel = "Parameter Machine";
            this.pnlParameterMachine.LineColorLayout = System.Drawing.Color.White;
            this.pnlParameterMachine.Location = new System.Drawing.Point(656, 158);
            this.pnlParameterMachine.Name = "pnlParameterMachine";
            this.pnlParameterMachine.Size = new System.Drawing.Size(593, 661);
            this.pnlParameterMachine.TabIndex = 690;
            // 
            // pnlDeviceConnection
            // 
            this.pnlDeviceConnection.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeviceConnection.HeaderLabel = "Device Connection";
            this.pnlDeviceConnection.LineColorLayout = System.Drawing.Color.White;
            this.pnlDeviceConnection.Location = new System.Drawing.Point(30, 158);
            this.pnlDeviceConnection.Name = "pnlDeviceConnection";
            this.pnlDeviceConnection.Size = new System.Drawing.Size(612, 661);
            this.pnlDeviceConnection.TabIndex = 689;
            // 
            // GL840_MS_OUT_TEMP_CHANNEL
            // 
            this.GL840_MS_OUT_TEMP_CHANNEL.BackColor = System.Drawing.Color.Transparent;
            this.GL840_MS_OUT_TEMP_CHANNEL.CheckIsNumeric = false;
            this.GL840_MS_OUT_TEMP_CHANNEL.HeaderColor = System.Drawing.Color.White;
            this.GL840_MS_OUT_TEMP_CHANNEL.HeaderLabel = "MS OUT Temp Channel :";
            this.GL840_MS_OUT_TEMP_CHANNEL.Location = new System.Drawing.Point(60, 671);
            this.GL840_MS_OUT_TEMP_CHANNEL.Name = "GL840_MS_OUT_TEMP_CHANNEL";
            this.GL840_MS_OUT_TEMP_CHANNEL.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.GL840_MS_OUT_TEMP_CHANNEL.Size = new System.Drawing.Size(558, 33);
            this.GL840_MS_OUT_TEMP_CHANNEL.TabIndex = 704;
            this.GL840_MS_OUT_TEMP_CHANNEL.TextBoxValue = "";
            // 
            // GL840_CAVITY_PD_CHANNEL
            // 
            this.GL840_CAVITY_PD_CHANNEL.BackColor = System.Drawing.Color.Transparent;
            this.GL840_CAVITY_PD_CHANNEL.CheckIsNumeric = false;
            this.GL840_CAVITY_PD_CHANNEL.HeaderColor = System.Drawing.Color.White;
            this.GL840_CAVITY_PD_CHANNEL.HeaderLabel = "PD Channel :";
            this.GL840_CAVITY_PD_CHANNEL.Location = new System.Drawing.Point(60, 710);
            this.GL840_CAVITY_PD_CHANNEL.Name = "GL840_CAVITY_PD_CHANNEL";
            this.GL840_CAVITY_PD_CHANNEL.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.GL840_CAVITY_PD_CHANNEL.Size = new System.Drawing.Size(558, 33);
            this.GL840_CAVITY_PD_CHANNEL.TabIndex = 705;
            this.GL840_CAVITY_PD_CHANNEL.TextBoxValue = "";
            // 
            // GL840_BASEPLATE_TEMP_CHANNEL
            // 
            this.GL840_BASEPLATE_TEMP_CHANNEL.BackColor = System.Drawing.Color.Transparent;
            this.GL840_BASEPLATE_TEMP_CHANNEL.CheckIsNumeric = false;
            this.GL840_BASEPLATE_TEMP_CHANNEL.HeaderColor = System.Drawing.Color.White;
            this.GL840_BASEPLATE_TEMP_CHANNEL.HeaderLabel = "Baseplate Temp Channel :";
            this.GL840_BASEPLATE_TEMP_CHANNEL.Location = new System.Drawing.Point(60, 632);
            this.GL840_BASEPLATE_TEMP_CHANNEL.Name = "GL840_BASEPLATE_TEMP_CHANNEL";
            this.GL840_BASEPLATE_TEMP_CHANNEL.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.GL840_BASEPLATE_TEMP_CHANNEL.Size = new System.Drawing.Size(558, 33);
            this.GL840_BASEPLATE_TEMP_CHANNEL.TabIndex = 703;
            this.GL840_BASEPLATE_TEMP_CHANNEL.TextBoxValue = "";
            // 
            // GL840_MS_IN_TEMP_CHANNEL
            // 
            this.GL840_MS_IN_TEMP_CHANNEL.BackColor = System.Drawing.Color.Transparent;
            this.GL840_MS_IN_TEMP_CHANNEL.CheckIsNumeric = false;
            this.GL840_MS_IN_TEMP_CHANNEL.HeaderColor = System.Drawing.Color.White;
            this.GL840_MS_IN_TEMP_CHANNEL.HeaderLabel = "MS IN Temp Channel :";
            this.GL840_MS_IN_TEMP_CHANNEL.Location = new System.Drawing.Point(60, 593);
            this.GL840_MS_IN_TEMP_CHANNEL.Name = "GL840_MS_IN_TEMP_CHANNEL";
            this.GL840_MS_IN_TEMP_CHANNEL.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.GL840_MS_IN_TEMP_CHANNEL.Size = new System.Drawing.Size(558, 33);
            this.GL840_MS_IN_TEMP_CHANNEL.TabIndex = 702;
            this.GL840_MS_IN_TEMP_CHANNEL.TextBoxValue = "";
            // 
            // GL840_COLD_PLATE_TEMP_CHANNEL
            // 
            this.GL840_COLD_PLATE_TEMP_CHANNEL.BackColor = System.Drawing.Color.Transparent;
            this.GL840_COLD_PLATE_TEMP_CHANNEL.CheckIsNumeric = false;
            this.GL840_COLD_PLATE_TEMP_CHANNEL.HeaderColor = System.Drawing.Color.White;
            this.GL840_COLD_PLATE_TEMP_CHANNEL.HeaderLabel = "Cold Plate Temp Channel :";
            this.GL840_COLD_PLATE_TEMP_CHANNEL.Location = new System.Drawing.Point(60, 554);
            this.GL840_COLD_PLATE_TEMP_CHANNEL.Name = "GL840_COLD_PLATE_TEMP_CHANNEL";
            this.GL840_COLD_PLATE_TEMP_CHANNEL.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.GL840_COLD_PLATE_TEMP_CHANNEL.Size = new System.Drawing.Size(558, 33);
            this.GL840_COLD_PLATE_TEMP_CHANNEL.TabIndex = 701;
            this.GL840_COLD_PLATE_TEMP_CHANNEL.TextBoxValue = "";
            // 
            // GL840_SAFETY_PD_CHANNEL
            // 
            this.GL840_SAFETY_PD_CHANNEL.BackColor = System.Drawing.Color.Transparent;
            this.GL840_SAFETY_PD_CHANNEL.CheckIsNumeric = false;
            this.GL840_SAFETY_PD_CHANNEL.HeaderColor = System.Drawing.Color.White;
            this.GL840_SAFETY_PD_CHANNEL.HeaderLabel = "Safety PD Channel :";
            this.GL840_SAFETY_PD_CHANNEL.Location = new System.Drawing.Point(60, 515);
            this.GL840_SAFETY_PD_CHANNEL.Name = "GL840_SAFETY_PD_CHANNEL";
            this.GL840_SAFETY_PD_CHANNEL.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.GL840_SAFETY_PD_CHANNEL.Size = new System.Drawing.Size(558, 33);
            this.GL840_SAFETY_PD_CHANNEL.TabIndex = 700;
            this.GL840_SAFETY_PD_CHANNEL.TextBoxValue = "";
            // 
            // OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS
            // 
            this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS.BackColor = System.Drawing.Color.Transparent;
            this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS.CheckIsNumeric = false;
            this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS.HeaderColor = System.Drawing.Color.White;
            this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS.HeaderLabel = "Center Port FW-TFB Meter  Address :";
            this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS.Location = new System.Drawing.Point(60, 426);
            this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS.Name = "OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS";
            this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS.Size = new System.Drawing.Size(558, 33);
            this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS.TabIndex = 699;
            this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS.TextBoxValue = "";
            // 
            // OPHIR_BW_METER_ADDRESS
            // 
            this.OPHIR_BW_METER_ADDRESS.BackColor = System.Drawing.Color.Transparent;
            this.OPHIR_BW_METER_ADDRESS.CheckIsNumeric = false;
            this.OPHIR_BW_METER_ADDRESS.HeaderColor = System.Drawing.Color.White;
            this.OPHIR_BW_METER_ADDRESS.HeaderLabel = "BW Meter Address :";
            this.OPHIR_BW_METER_ADDRESS.Location = new System.Drawing.Point(60, 387);
            this.OPHIR_BW_METER_ADDRESS.Name = "OPHIR_BW_METER_ADDRESS";
            this.OPHIR_BW_METER_ADDRESS.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.OPHIR_BW_METER_ADDRESS.Size = new System.Drawing.Size(558, 33);
            this.OPHIR_BW_METER_ADDRESS.TabIndex = 698;
            this.OPHIR_BW_METER_ADDRESS.TextBoxValue = "";
            // 
            // OPHIR_FW_METER_ADDRESS
            // 
            this.OPHIR_FW_METER_ADDRESS.BackColor = System.Drawing.Color.Transparent;
            this.OPHIR_FW_METER_ADDRESS.CheckIsNumeric = false;
            this.OPHIR_FW_METER_ADDRESS.HeaderColor = System.Drawing.Color.White;
            this.OPHIR_FW_METER_ADDRESS.HeaderLabel = "FW Meter  Address :";
            this.OPHIR_FW_METER_ADDRESS.Location = new System.Drawing.Point(60, 348);
            this.OPHIR_FW_METER_ADDRESS.Name = "OPHIR_FW_METER_ADDRESS";
            this.OPHIR_FW_METER_ADDRESS.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.OPHIR_FW_METER_ADDRESS.Size = new System.Drawing.Size(558, 33);
            this.OPHIR_FW_METER_ADDRESS.TabIndex = 697;
            this.OPHIR_FW_METER_ADDRESS.TextBoxValue = "";
            // 
            // OPHIR_OUTPUT_POWER_METER_ADDRESS
            // 
            this.OPHIR_OUTPUT_POWER_METER_ADDRESS.BackColor = System.Drawing.Color.Transparent;
            this.OPHIR_OUTPUT_POWER_METER_ADDRESS.CheckIsNumeric = false;
            this.OPHIR_OUTPUT_POWER_METER_ADDRESS.HeaderColor = System.Drawing.Color.White;
            this.OPHIR_OUTPUT_POWER_METER_ADDRESS.HeaderLabel = "Output Power Meter Address :";
            this.OPHIR_OUTPUT_POWER_METER_ADDRESS.Location = new System.Drawing.Point(60, 309);
            this.OPHIR_OUTPUT_POWER_METER_ADDRESS.Name = "OPHIR_OUTPUT_POWER_METER_ADDRESS";
            this.OPHIR_OUTPUT_POWER_METER_ADDRESS.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.OPHIR_OUTPUT_POWER_METER_ADDRESS.Size = new System.Drawing.Size(558, 33);
            this.OPHIR_OUTPUT_POWER_METER_ADDRESS.TabIndex = 696;
            this.OPHIR_OUTPUT_POWER_METER_ADDRESS.TextBoxValue = "";
            // 
            // RESIDUAL_COM_PORT
            // 
            this.RESIDUAL_COM_PORT.BackColor = System.Drawing.Color.Transparent;
            this.RESIDUAL_COM_PORT.CheckIsNumeric = false;
            this.RESIDUAL_COM_PORT.HeaderColor = System.Drawing.Color.White;
            this.RESIDUAL_COM_PORT.HeaderLabel = "Residual Com Port :";
            this.RESIDUAL_COM_PORT.Location = new System.Drawing.Point(60, 257);
            this.RESIDUAL_COM_PORT.Name = "RESIDUAL_COM_PORT";
            this.RESIDUAL_COM_PORT.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.RESIDUAL_COM_PORT.Size = new System.Drawing.Size(558, 33);
            this.RESIDUAL_COM_PORT.TabIndex = 693;
            this.RESIDUAL_COM_PORT.TextBoxValue = "";
            // 
            // DIO_COM_PORT
            // 
            this.DIO_COM_PORT.BackColor = System.Drawing.Color.Transparent;
            this.DIO_COM_PORT.CheckIsNumeric = false;
            this.DIO_COM_PORT.HeaderColor = System.Drawing.Color.White;
            this.DIO_COM_PORT.HeaderLabel = "DIO COM Port :";
            this.DIO_COM_PORT.Location = new System.Drawing.Point(60, 218);
            this.DIO_COM_PORT.Name = "DIO_COM_PORT";
            this.DIO_COM_PORT.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.DIO_COM_PORT.Size = new System.Drawing.Size(558, 33);
            this.DIO_COM_PORT.TabIndex = 692;
            this.DIO_COM_PORT.TextBoxValue = "";
            // 
            // OSA_GPIB_ADDRESS
            // 
            this.OSA_GPIB_ADDRESS.BackColor = System.Drawing.Color.Transparent;
            this.OSA_GPIB_ADDRESS.CheckIsNumeric = false;
            this.OSA_GPIB_ADDRESS.HeaderColor = System.Drawing.Color.White;
            this.OSA_GPIB_ADDRESS.HeaderLabel = "OSA GPIB  Address :";
            this.OSA_GPIB_ADDRESS.Location = new System.Drawing.Point(42, 179);
            this.OSA_GPIB_ADDRESS.Name = "OSA_GPIB_ADDRESS";
            this.OSA_GPIB_ADDRESS.PictureOption = global::CavityCenterOfProcessAndSetting.Properties.Resources.info;
            this.OSA_GPIB_ADDRESS.Size = new System.Drawing.Size(576, 33);
            this.OSA_GPIB_ADDRESS.TabIndex = 691;
            this.OSA_GPIB_ADDRESS.TextBoxValue = "";
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::CavityCenterOfProcessAndSetting.Properties.Resources.power_white;
            this.picClose.Location = new System.Drawing.Point(1242, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(20, 20);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 687;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picManimise
            // 
            this.picManimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picManimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picManimise.Image = global::CavityCenterOfProcessAndSetting.Properties.Resources.minus_white;
            this.picManimise.Location = new System.Drawing.Point(1210, 12);
            this.picManimise.Name = "picManimise";
            this.picManimise.Size = new System.Drawing.Size(20, 20);
            this.picManimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManimise.TabIndex = 688;
            this.picManimise.TabStop = false;
            this.picManimise.Click += new System.EventHandler(this.picManimise_Click);
            // 
            // frmSystemCommon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1274, 889);
            this.Controls.Add(this.OFFSET_SLOP_EFFICIENCY_POST_BURNIN);
            this.Controls.Add(this.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL);
            this.Controls.Add(this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2);
            this.Controls.Add(this.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1);
            this.Controls.Add(this.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING);
            this.Controls.Add(this.OFFSET_SLOP_EFFICIENCY_RESONATOR);
            this.Controls.Add(this.SAFETY_MAX_COLDPLATE_TEMP);
            this.Controls.Add(this.SAFETY_OUTPUT_CHECK_TIME);
            this.Controls.Add(this.SAFETY_MIN_OUTPUT_POWER);
            this.Controls.Add(this.SAFETY_MIN_PD_OUTPUT);
            this.Controls.Add(this.SAFETY_OFFSET);
            this.Controls.Add(this.panelCustom4);
            this.Controls.Add(this.SAFETY_SHUT_DOWN_THRESHOLD);
            this.Controls.Add(this.panelCustom3);
            this.Controls.Add(this.GL840_MS_OUT_TEMP_CHANNEL);
            this.Controls.Add(this.GL840_CAVITY_PD_CHANNEL);
            this.Controls.Add(this.GL840_BASEPLATE_TEMP_CHANNEL);
            this.Controls.Add(this.GL840_MS_IN_TEMP_CHANNEL);
            this.Controls.Add(this.GL840_COLD_PLATE_TEMP_CHANNEL);
            this.Controls.Add(this.GL840_SAFETY_PD_CHANNEL);
            this.Controls.Add(this.panelCustom2);
            this.Controls.Add(this.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS);
            this.Controls.Add(this.OPHIR_BW_METER_ADDRESS);
            this.Controls.Add(this.OPHIR_FW_METER_ADDRESS);
            this.Controls.Add(this.OPHIR_OUTPUT_POWER_METER_ADDRESS);
            this.Controls.Add(this.panelCustom1);
            this.Controls.Add(this.RESIDUAL_COM_PORT);
            this.Controls.Add(this.DIO_COM_PORT);
            this.Controls.Add(this.OSA_GPIB_ADDRESS);
            this.Controls.Add(this.pnlParameterMachine);
            this.Controls.Add(this.pnlDeviceConnection);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picManimise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.system_name);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.ip_address_system);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSystemCommon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSystemSpecSettingManage";
            this.Load += new System.EventHandler(this.frmSystemSpecSettingCommon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManimise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label system_name;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label ip_address_system;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picManimise;
        private CustomUIClassLibrary.PanelCustom pnlDeviceConnection;
        private CustomUIClassLibrary.PanelCustom pnlParameterMachine;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel OSA_GPIB_ADDRESS;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel DIO_COM_PORT;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel RESIDUAL_COM_PORT;
        private CustomUIClassLibrary.PanelCustom panelCustom1;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel OPHIR_BW_METER_ADDRESS;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel OPHIR_FW_METER_ADDRESS;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel OPHIR_OUTPUT_POWER_METER_ADDRESS;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel GL840_BASEPLATE_TEMP_CHANNEL;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel GL840_MS_IN_TEMP_CHANNEL;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel GL840_COLD_PLATE_TEMP_CHANNEL;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel GL840_SAFETY_PD_CHANNEL;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel GL840_CAVITY_PD_CHANNEL;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel GL840_MS_OUT_TEMP_CHANNEL;
        private CustomUIClassLibrary.PanelCustom panelCustom2;
        private CustomUIClassLibrary.PanelCustom panelCustom3;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel SAFETY_SHUT_DOWN_THRESHOLD;
        private CustomUIClassLibrary.PanelCustom panelCustom4;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel SAFETY_OFFSET;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel SAFETY_MIN_PD_OUTPUT;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel SAFETY_MIN_OUTPUT_POWER;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel SAFETY_OUTPUT_CHECK_TIME;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel SAFETY_MAX_COLDPLATE_TEMP;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel OFFSET_SLOP_EFFICIENCY_RESONATOR;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel OFFSET_SLOP_EFFICIENCY_MONITOR_CAL;
        private CustomUIClassLibrary.SettingSpec_Text_Value_Without_Panel OFFSET_SLOP_EFFICIENCY_POST_BURNIN;
    }
}