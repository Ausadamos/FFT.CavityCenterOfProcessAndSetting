using CavityMachineSettingManagement.Property;

namespace CavityMachineSettingManagement.SQLFactory
{
    public class CvSystemSpecificPurchasePowerOutputSQLFactory
    {
        string tableName = TableName.CV_SYSTEM_SPECIFIC_PURCHASE_POWER_OUTPUT;

        public string SearchBySystemIdAndPurchaseIdAndProcessId(CvSystemSpecificPurchasePowerOutputProperty dataItem)
        {
            string sql = @" SELECT * FROM tableName 
                            WHERE PURCHASE_ID = 'dataItem.PURCHASE_ID' 
                            AND SYSTEM_ID = 'dataItem.SYSTEM_ID'
                            AND PROCESS_NAME = 'dataItem.PROCESS_NAME'
                            AND INUSE = 1 ";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.PROCESS_NAME", dataItem.PROCESS_NAME);
            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);

            return sql;
        }


        public string Delete(CvSystemSpecificPurchasePowerOutputProperty dataItem)
        {
            string sql = @" UPDATE tableName SET INUSE = 0 
                            , USER_UPDATE = 'dataItem.USER_UPDATE' 
                            , LAST_DATE = NOW()
                             WHERE PURCHASE_ID = 'dataItem.PURCHASE_ID' 
                             AND SYSTEM_ID = 'dataItem.SYSTEM_ID' 
                             AND PROCESS_NAME = 'dataItem.PROCESS_NAME'
                             AND INUSE = 1 ";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.PROCESS_NAME", dataItem.PROCESS_NAME);
            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);
            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);

            return sql;

        }

        public string Insert(CvSystemSpecificPurchasePowerOutputProperty dataItem)
        {
            string sql = @"INSERT INTO tableName
                                        (
                                          ID
                                        , SYSTEM_ID
                                        , PURCHASE_ID
                                        , PROCESS_NAME
                                        , NO
                                        , TARGET_POWER
                                        , POWER_PERCENT_FROM
                                        , POWER_PERCENT_TO
                                        , MAX_VOLTAGE_STEP
                                        , VOLTAGE_STEP
                                        , WAIT_TIME
                                        , IP_ADDRESS
                                        , NAME_ADDRESS
                                        , USER_CREATE
                                        , INUSE
                                        , DESCRIPTION
                                        )
                                        (
                                          SELECT 1 + coalesce((SELECT max(Id) FROM tableName), 0) 
                                        , 'dataItem.SYSTEM_ID'
                                        , 'dataItem.PURCHASE_ID'
                                        , 'dataItem.PROCESS_NAME'
                                        , 'dataItem.NO'
                                        , 'dataItem.TARGET_POWER'
                                        , 'dataItem.POWER_PERCENT_FROM'
                                        , 'dataItem.POWER_PERCENT_TO'
                                        , 'dataItem.MAX_VOLTAGE_STEP'
                                        , 'dataItem.VOLTAGE_STEP'
                                        , 'dataItem.WAIT_TIME'
                                        , 'dataItem.IP_ADDRESS'
                                        , 'dataItem.NAME_ADDRESS'
                                        , 'dataItem.USER_CREATE'
                                        , 1
                                        , 'dataItem.DESCRIPTION'

                                        )";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);
            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.PROCESS_NAME", dataItem.PROCESS_NAME);
            sql = sql.Replace("dataItem.NO", dataItem.NO);
            sql = sql.Replace("dataItem.TARGET_POWER", dataItem.TARGET_POWER);
            sql = sql.Replace("dataItem.POWER_PERCENT_FROM", dataItem.POWER_PERCENT_FROM);
            sql = sql.Replace("dataItem.POWER_PERCENT_TO", dataItem.POWER_PERCENT_TO);
            sql = sql.Replace("dataItem.MAX_VOLTAGE_STEP", dataItem.MAX_VOLTAGE_STEP);
            sql = sql.Replace("dataItem.VOLTAGE_STEP", dataItem.VOLTAGE_STEP);
            sql = sql.Replace("dataItem.WAIT_TIME", dataItem.WAIT_TIME);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);
            sql = sql.Replace("dataItem.IP_ADDRESS", dataItem.IP_ADDRESS);
            sql = sql.Replace("dataItem.NAME_ADDRESS", dataItem.NAME_ADDRESS);
            sql = sql.Replace("dataItem.USER_CREATE", dataItem.USER_CREATE);
            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);
            sql = sql.Replace("dataItem.INUSE", dataItem.INUSE);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);

            return sql;

        }
    }
}