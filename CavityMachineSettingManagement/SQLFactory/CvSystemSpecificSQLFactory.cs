using CavityMachineSettingManagement.Property;

namespace CavityMachineSettingManagement.SQLFactory
{
    public class CvSystemSpecificSQLFactory
    {

        string tableName = TableName.CV_SYSTEM_SPECIFIC;

        public string SearchBySystemIdAndPurchaseId(CvSystemSpecificProperty dataItem)
        {
            string sql = @" SELECT * FROM tableName 
                            WHERE PURCHASE_ID = 'dataItem.PURCHASE_ID' 
                            AND SYSTEM_ID = 'dataItem.SYSTEM_ID' 
                            AND INUSE = 1 ";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);

            return sql;
        }


        public string Delete(CvSystemSpecificProperty dataItem)
        {
            string sql = @" UPDATE tableName SET INUSE = 0 
                            , USER_UPDATE = 'dataItem.USER_UPDATE' 
                            , LAST_DATE = NOW()
                             WHERE PURCHASE_ID = 'dataItem.PURCHASE_ID' 
                             AND SYSTEM_ID = 'dataItem.SYSTEM_ID' ";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);
            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);
            return sql;

        }

        public string Insert(CvSystemSpecificProperty dataItem)
        {
            string sql = @"INSERT INTO tableName
                                        (
                                          ID
                                        , SYSTEM_ID
                                        , PURCHASE_ID
                                        , KIKUSUI_USB_NAME
                                        , KIKUSUI_ADDRESS
                                        , KIKUSUI_MAX_CURRENT
                                        , KIKUSUI_MAX_VOLTAGE
                                        , IP_ADDRESS
                                        , NAME_ADDRESS
                                        , USER_CREATE
                                        , DESCRIPTION
                                        , INUSE
                                        )
                                        (
                                          SELECT 1 + coalesce((SELECT max(Id) FROM tableName), 0) 
                                        , 'dataItem.SYSTEM_ID'
                                        , 'dataItem.PURCHASE_ID'
                                        , 'dataItem.KIKUSUI_USB_NAME'
                                        , 'dataItem.KIKUSUI_ADDRESS'
                                        , 'dataItem.KIKUSUI_MAX_CURRENT'
                                        , 'dataItem.KIKUSUI_MAX_VOLTAGE'
                                        , 'dataItem.IP_ADDRESS'
                                        , 'dataItem.NAME_ADDRESS'
                                        , 'dataItem.USER_CREATE'
                                        , 'dataItem.DESCRIPTION'
                                        , 1

                                        )";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);
            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.KIKUSUI_USB_NAME", dataItem.KIKUSUI_USB_NAME);
            sql = sql.Replace("dataItem.KIKUSUI_ADDRESS", dataItem.KIKUSUI_ADDRESS);
            sql = sql.Replace("dataItem.KIKUSUI_MAX_CURRENT", dataItem.KIKUSUI_MAX_CURRENT);
            sql = sql.Replace("dataItem.KIKUSUI_MAX_VOLTAGE", dataItem.KIKUSUI_MAX_VOLTAGE);
            sql = sql.Replace("dataItem.IP_ADDRESS", dataItem.IP_ADDRESS);
            sql = sql.Replace("dataItem.NAME_ADDRESS", dataItem.NAME_ADDRESS);
            sql = sql.Replace("dataItem.USER_CREATE", dataItem.USER_CREATE);
            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);



            return sql;

        }

    }
}