using BusinessData.Property;
using CavityMachineSettingManagement.Models;
using CavityMachineSettingManagement.Property;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CavityMachineSettingManagement.Controller
{
    public class CvSystemController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvSystemModel _model = new CvSystemModel();

        public List<CvSystemProperty> Search()
        {
            List<CvSystemProperty> listItem = new List<CvSystemProperty>();
            try
            {
                _resultData = _model.Search();
                if (_resultData.StatusOnDb == true)
                {
                    foreach (DataRow row in _resultData.ResultOnDb.Rows)
                    {
                        CvSystemProperty productProperty = new CvSystemProperty
                        {
                            ID = row["ID"].ToString(),
                            SYSTEM_NAME = row["SYSTEM_NAME"].ToString(),
                            IP_ADDRESS_SYSTEM = row["IP_ADDRESS_SYSTEM"].ToString(),
                            INUSE = row["INUSE"].ToString(),
                            DESCRIPTION = row["DESCRIPTION"].ToString(),
                            CREATE_USER = row["CREATE_USER"].ToString(),
                            LAST_USER = row["LAST_USER"].ToString(),
                            CREATE_DATE = row["CREATE_DATE"].ToString(),
                            LAST_DATE = row["LAST_DATE"].ToString(),
                            IP_ADDRESS = row["IP_ADDRESS"].ToString(),
                            NAME_ADDRESS = row["NAME_ADDRESS"].ToString(),

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



        public CvSystemProperty SearchBySystemId(CvSystemProperty dataItem)
        {
            CvSystemProperty _property = null;
            try
            {
                _resultData = _model.SearchBySystemId(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        _property = new CvSystemProperty
                        {
                            ID = _resultData.ResultOnDb.Rows[0]["ID"].ToString(),
                            SYSTEM_NAME = _resultData.ResultOnDb.Rows[0]["SYSTEM_NAME"].ToString(),
                            IP_ADDRESS_SYSTEM = _resultData.ResultOnDb.Rows[0]["IP_ADDRESS_SYSTEM"].ToString(),
                            INUSE = _resultData.ResultOnDb.Rows[0]["INUSE"].ToString(),
                            DESCRIPTION = _resultData.ResultOnDb.Rows[0]["DESCRIPTION"].ToString(),
                            CREATE_USER = _resultData.ResultOnDb.Rows[0]["CREATE_USER"].ToString(),
                            LAST_USER = _resultData.ResultOnDb.Rows[0]["LAST_USER"].ToString(),
                            CREATE_DATE = _resultData.ResultOnDb.Rows[0]["CREATE_DATE"].ToString(),
                            LAST_DATE = _resultData.ResultOnDb.Rows[0]["LAST_DATE"].ToString(),
                            IP_ADDRESS = _resultData.ResultOnDb.Rows[0]["IP_ADDRESS"].ToString(),
                            NAME_ADDRESS = _resultData.ResultOnDb.Rows[0]["NAME_ADDRESS"].ToString(),

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
        public CvSystemProperty SearchByIpAddressSystem(CvSystemProperty dataItem)
        {
            CvSystemProperty _property = null;
            try
            {
                _resultData = _model.SearchByIpAddressSystem(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        _property = new CvSystemProperty
                        {
                            ID = _resultData.ResultOnDb.Rows[0]["ID"].ToString(),
                            SYSTEM_NAME = _resultData.ResultOnDb.Rows[0]["SYSTEM_NAME"].ToString(),
                            IP_ADDRESS_SYSTEM = _resultData.ResultOnDb.Rows[0]["IP_ADDRESS_SYSTEM"].ToString(),
                            INUSE = _resultData.ResultOnDb.Rows[0]["INUSE"].ToString(),
                            DESCRIPTION = _resultData.ResultOnDb.Rows[0]["DESCRIPTION"].ToString(),
                            CREATE_USER = _resultData.ResultOnDb.Rows[0]["CREATE_USER"].ToString(),
                            LAST_USER = _resultData.ResultOnDb.Rows[0]["LAST_USER"].ToString(),
                            CREATE_DATE = _resultData.ResultOnDb.Rows[0]["CREATE_DATE"].ToString(),
                            LAST_DATE = _resultData.ResultOnDb.Rows[0]["LAST_DATE"].ToString(),
                            IP_ADDRESS = _resultData.ResultOnDb.Rows[0]["IP_ADDRESS"].ToString(),
                            NAME_ADDRESS = _resultData.ResultOnDb.Rows[0]["NAME_ADDRESS"].ToString(),

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

        public bool Insert(CvSystemProperty dataItem)
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