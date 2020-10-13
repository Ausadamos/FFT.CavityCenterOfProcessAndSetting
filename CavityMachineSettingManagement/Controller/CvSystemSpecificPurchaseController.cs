using BusinessData.Property;
using CavityMachineSettingManagement.Models;
using CavityMachineSettingManagement.Property;
using System;
using System.Windows.Forms;

namespace CavityMachineSettingManagement.Controller
{
    public class CvSystemSpecificPurchaseController
    {

        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvSystemSpecificPurchaseModel _model = new CvSystemSpecificPurchaseModel();


        public CvSystemSpecificPurchaseProperty SearchBySystemIdAndPurchaseId(CvSystemSpecificPurchaseProperty dataItem)
        {
            CvSystemSpecificPurchaseProperty _property = null;
            try
            {
                _resultData = _model.SearchBySystemIdAndPurchaseId(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        _property = new CvSystemSpecificPurchaseProperty
                        {
                            ID = _resultData.ResultOnDb.Rows[0]["ID"].ToString(),
                            SYSTEM_ID = _resultData.ResultOnDb.Rows[0]["SYSTEM_ID"].ToString(),
                            PURCHASE_ID = _resultData.ResultOnDb.Rows[0]["PURCHASE_ID"].ToString(),
                            PROCESS_NAME = _resultData.ResultOnDb.Rows[0]["PROCESS_NAME"].ToString(),
                            INITIAL_VOLTAGE_OF_INPUT = _resultData.ResultOnDb.Rows[0]["INITIAL_VOLTAGE_OF_INPUT"].ToString(),
                            INITIAL_VOLTAGE_OF_OUTPUT = _resultData.ResultOnDb.Rows[0]["INITIAL_VOLTAGE_OF_OUTPUT"].ToString(),
                            OUTPUT_TEMPERATURE_TARGET_POWER = _resultData.ResultOnDb.Rows[0]["OUTPUT_TEMPERATURE_TARGET_POWER"].ToString(),
                            IP_ADDRESS = _resultData.ResultOnDb.Rows[0]["IP_ADDRESS"].ToString(),
                            NAME_ADDRESS = _resultData.ResultOnDb.Rows[0]["NAME_ADDRESS"].ToString(),
                            USER_CREATE = _resultData.ResultOnDb.Rows[0]["USER_CREATE"].ToString(),
                            USER_UPDATE = _resultData.ResultOnDb.Rows[0]["USER_UPDATE"].ToString(),
                            DESCRIPTION = _resultData.ResultOnDb.Rows[0]["DESCRIPTION"].ToString(),
                            CREATE_DATE = _resultData.ResultOnDb.Rows[0]["CREATE_DATE"].ToString(),
                            LAST_DATE = _resultData.ResultOnDb.Rows[0]["LAST_DATE"].ToString(),
                            INUSE = _resultData.ResultOnDb.Rows[0]["INUSE"].ToString(),
                        };
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

            return _property;
        }

        public bool InsertAndUpdateInuse(CvSystemSpecificPurchaseProperty dataItem)
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