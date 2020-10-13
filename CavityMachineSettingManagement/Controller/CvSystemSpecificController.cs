using BusinessData.Property;
using CavityMachineSettingManagement.Models;
using CavityMachineSettingManagement.Property;
using System;
using System.Windows.Forms;

namespace CavityMachineSettingManagement.Controller
{
    public class CvSystemSpecificController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvSystemSpecificModel _model = new CvSystemSpecificModel();


        public CvSystemSpecificProperty SearchBySystemIdAndPurchaseId(CvSystemSpecificProperty dataItem)
        {
            CvSystemSpecificProperty _property = null;
            try
            {
                _resultData = _model.SearchBySystemIdAndPurchaseId(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        _property = new CvSystemSpecificProperty
                        {
                            ID = _resultData.ResultOnDb.Rows[0]["ID"].ToString(),
                            SYSTEM_ID = _resultData.ResultOnDb.Rows[0]["SYSTEM_ID"].ToString(),
                            PURCHASE_ID = _resultData.ResultOnDb.Rows[0]["PURCHASE_ID"].ToString(),
                            KIKUSUI_USB_NAME = _resultData.ResultOnDb.Rows[0]["KIKUSUI_USB_NAME"].ToString(),
                            KIKUSUI_ADDRESS = _resultData.ResultOnDb.Rows[0]["KIKUSUI_ADDRESS"].ToString(),
                            KIKUSUI_MAX_CURRENT = _resultData.ResultOnDb.Rows[0]["KIKUSUI_MAX_CURRENT"].ToString(),
                            KIKUSUI_MAX_VOLTAGE = _resultData.ResultOnDb.Rows[0]["KIKUSUI_MAX_VOLTAGE"].ToString(),
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



        public bool InsertAndUpdateInuse(CvSystemSpecificProperty dataItem)
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