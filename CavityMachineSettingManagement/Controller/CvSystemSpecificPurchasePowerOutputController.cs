using BusinessData.Property;
using CavityMachineSettingManagement.Models;
using CavityMachineSettingManagement.Property;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CavityMachineSettingManagement.Controller
{
    public class CvSystemSpecificPurchasePowerOutputController
    {

        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvSystemSpecificPurchasePowerOutputModel _model = new CvSystemSpecificPurchasePowerOutputModel();

        public List<CvSystemSpecificPurchasePowerOutputProperty> SearchBySystemIdAndPurchaseIdAndProcessId(CvSystemSpecificPurchasePowerOutputProperty dataItem)
        {
            List<CvSystemSpecificPurchasePowerOutputProperty> listItem = new List<CvSystemSpecificPurchasePowerOutputProperty>();
            try
            {
                _resultData = _model.SearchBySystemIdAndPurchaseIdAndProcessId(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    foreach (DataRow row in _resultData.ResultOnDb.Rows)
                    {
                        CvSystemSpecificPurchasePowerOutputProperty productProperty = new CvSystemSpecificPurchasePowerOutputProperty
                        {
                            ID = row["ID"].ToString(),
                            SYSTEM_ID = row["SYSTEM_ID"].ToString(),
                            PURCHASE_ID = row["PURCHASE_ID"].ToString(),
                            PROCESS_NAME = row["PROCESS_NAME"].ToString(),
                            NO = row["NO"].ToString(),
                            TARGET_POWER = row["TARGET_POWER"].ToString(),
                            POWER_PERCENT_FROM = row["POWER_PERCENT_FROM"].ToString(),
                            POWER_PERCENT_TO = row["POWER_PERCENT_TO"].ToString(),
                            MAX_VOLTAGE_STEP = row["MAX_VOLTAGE_STEP"].ToString(),
                            VOLTAGE_STEP = row["VOLTAGE_STEP"].ToString(),
                            WAIT_TIME = row["WAIT_TIME"].ToString(),
                            CREATE_DATE = row["CREATE_DATE"].ToString(),
                            LAST_DATE = row["LAST_DATE"].ToString(),
                            IP_ADDRESS = row["IP_ADDRESS"].ToString(),
                            NAME_ADDRESS = row["NAME_ADDRESS"].ToString(),
                            USER_CREATE = row["USER_CREATE"].ToString(),
                            USER_UPDATE = row["USER_UPDATE"].ToString(),
                            INUSE = row["INUSE"].ToString(),
                            DESCRIPTION = row["DESCRIPTION"].ToString(),
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

        public bool InsertAndUpdateInuse(List<CvSystemSpecificPurchasePowerOutputProperty> dataItem)
        {
            bool result = true;
            try
            {
                _resultData = _model.InsertAndUpdateInuse(dataItem);
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