using BusinessData.Property;
using CavityMachineSettingManagement.Models;
using CavityMachineSettingManagement.Property;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CavityMachineSettingManagement.Controller
{
    public class CvSystemCommonController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvSystemCommonModel _model = new CvSystemCommonModel();

        public List<CvSystemCommonProperty> SearchBySystemId(CvSystemCommonProperty dataItem)
        {
            List<CvSystemCommonProperty> listItem = new List<CvSystemCommonProperty>();
            try
            {
                _resultData = _model.SearchBySystemId(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    foreach (DataRow row in _resultData.ResultOnDb.Rows)
                    {
                        CvSystemCommonProperty productProperty = new CvSystemCommonProperty
                        {
                            ID = row["ID"].ToString(),
                            SYSTEM_ID = row["SYSTEM_ID"].ToString(),
                            OSA_GPIB_ADDRESS = row["OSA_GPIB_ADDRESS"].ToString(),
                            DIO_COM_PORT = row["DIO_COM_PORT"].ToString(),
                            RESIDUAL_COM_PORT = row["RESIDUAL_COM_PORT"].ToString(),
                            OPHIR_OUTPUT_POWER_METER_ADDRESS = row["OPHIR_OUTPUT_POWER_METER_ADDRESS"].ToString(),
                            OPHIR_FW_METER_ADDRESS = row["OPHIR_FW_METER_ADDRESS"].ToString(),
                            OPHIR_BW_METER_ADDRESS = row["OPHIR_BW_METER_ADDRESS"].ToString(),
                            OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS = row["OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS"].ToString(),
                            GL840_SAFETY_PD_CHANNEL = row["GL840_SAFETY_PD_CHANNEL"].ToString(),
                            GL840_COLD_PLATE_TEMP_CHANNEL = row["GL840_COLD_PLATE_TEMP_CHANNEL"].ToString(),
                            GL840_MS_IN_TEMP_CHANNEL = row["GL840_MS_IN_TEMP_CHANNEL"].ToString(),
                            GL840_BASEPLATE_TEMP_CHANNEL = row["GL840_BASEPLATE_TEMP_CHANNEL"].ToString(),
                            GL840_MS_OUT_TEMP_CHANNEL = row["GL840_MS_OUT_TEMP_CHANNEL"].ToString(),
                            GL840_CAVITY_PD_CHANNEL = row["GL840_CAVITY_PD_CHANNEL"].ToString(),
                            SAFETY_SHUT_DOWN_THRESHOLD = row["SAFETY_SHUT_DOWN_THRESHOLD"].ToString(),
                            SAFETY_OFFSET = row["SAFETY_OFFSET"].ToString(),
                            SAFETY_MIN_PD_OUTPUT = row["SAFETY_MIN_PD_OUTPUT"].ToString(),
                            SAFETY_MIN_OUTPUT_POWER = row["SAFETY_MIN_OUTPUT_POWER"].ToString(),
                            SAFETY_OUTPUT_CHECK_TIME = row["SAFETY_OUTPUT_CHECK_TIME"].ToString(),
                            SAFETY_MAX_COLDPLATE_TEMP = row["SAFETY_MAX_COLDPLATE_TEMP"].ToString(),
                            OFFSET_SLOP_EFFICIENCY_RESONATOR = row["OFFSET_SLOP_EFFICIENCY_RESONATOR"].ToString(),
                            OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING = row["OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING"].ToString(),
                            OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1 = row["OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1"].ToString(),
                            OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2 = row["OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2"].ToString(),
                            OFFSET_SLOP_EFFICIENCY_MONITOR_CAL = row["OFFSET_SLOP_EFFICIENCY_MONITOR_CAL"].ToString(),
                            OFFSET_SLOP_EFFICIENCY_POST_BURNIN = row["OFFSET_SLOP_EFFICIENCY_POST_BURNIN"].ToString(),
                            DESCRIPTION = row["DESCRIPTION"].ToString(),
                            LAST_DATE = row["LAST_DATE"].ToString(),
                            USER_UPDATE = row["USER_UPDATE"].ToString(),
                            CREATE_DATE = row["CREATE_DATE"].ToString(),
                            IP_ADDRESS = row["IP_ADDRESS"].ToString(),
                            NAME_ADDRESS = row["NAME_ADDRESS"].ToString(),
                            INUSE = row["INUSE"].ToString(),
                            USER_CREATE = row["USER_CREATE"].ToString(),

                        };

                        listItem.Add(productProperty);
                    }
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listItem;
        }



        public bool Insert(CvSystemCommonProperty dataItem)
        {
            bool result = true;
            try
            {
                _resultData = _model.Insert(dataItem);
                if (_resultData.StatusOnDb == false)
                {
                    MessageBox.Show(_resultData.MessageOnDb, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            return result;
        }

    }
}