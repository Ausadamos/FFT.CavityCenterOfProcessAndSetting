using CavityMachineSettingManagement.Property;

namespace CavityMachineSettingManagement.SQLFactory
{
    public class CvSystemSpecificPurchaseSQLFactory
    {
        string tableName = TableName.CV_SYSTEM_SPECIFIC_PURCHASE;

        public string SearchBySystemIdAndPurchaseId(CvSystemSpecificPurchaseProperty dataItem)
        {
            string sql = @" SELECT * FROM tableName 
                            WHERE PURCHASE_ID = 'dataItem.PURCHASE_ID' 
                            AND SYSTEM_ID = 'dataItem.SYSTEM_ID' 
                            AND PROCESS_NAME = 'dataItem.PROCESS_NAME' 
                            AND INUSE = 1 ";

            sql = sql.Replace("tableName", tableName);



            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);
            sql = sql.Replace("dataItem.PROCESS_NAME", dataItem.PROCESS_NAME);

            return sql;
        }


        public string Delete(CvSystemSpecificPurchaseProperty dataItem)
        {
            string sql = @" UPDATE tableName SET INUSE = 0 
                            , USER_UPDATE = 'dataItem.USER_UPDATE' 
                            , LAST_DATE = NOW()
                             WHERE PURCHASE_ID = 'dataItem.PURCHASE_ID' 
                             AND PROCESS_NAME = 'dataItem.PROCESS_NAME' 
                             AND SYSTEM_ID = 'dataItem.SYSTEM_ID' ";

            sql = sql.Replace("tableName", tableName);


            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);
            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);
            sql = sql.Replace("dataItem.PROCESS_NAME", dataItem.PROCESS_NAME);
            return sql;

        }

        public string Insert(CvSystemSpecificPurchaseProperty dataItem)
        {
            string sql = @"INSERT INTO tableName
                                        (
                                          ID
                                        , SYSTEM_ID
                                        , PURCHASE_ID
                                        , PROCESS_NAME
                                        , INITIAL_VOLTAGE_OF_INPUT
                                        , INITIAL_VOLTAGE_OF_OUTPUT
                                        , OUTPUT_TEMPERATURE_TARGET_POWER
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
                                        , 'dataItem.PROCESS_NAME'
                                        , 'dataItem.INITIAL_VOLTAGE_OF_INPUT'
                                        , 'dataItem.INITIAL_VOLTAGE_OF_OUTPUT'
                                        , 'dataItem.OUTPUT_TEMPERATURE_TARGET_POWER'
                                        , 'dataItem.IP_ADDRESS'
                                        , 'dataItem.NAME_ADDRESS'
                                        , 'dataItem.USER_CREATE'
                                        , 'dataItem.DESCRIPTION'
                                        , 1


                                        )";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);
            sql = sql.Replace("dataItem.PURCHASE_ID", dataItem.PURCHASE_ID);
            sql = sql.Replace("dataItem.PROCESS_NAME", dataItem.PROCESS_NAME);
            sql = sql.Replace("dataItem.INITIAL_VOLTAGE_OF_INPUT", dataItem.INITIAL_VOLTAGE_OF_INPUT);
            sql = sql.Replace("dataItem.INITIAL_VOLTAGE_OF_OUTPUT", dataItem.INITIAL_VOLTAGE_OF_OUTPUT);
            sql = sql.Replace("dataItem.OUTPUT_TEMPERATURE_TARGET_POWER", dataItem.OUTPUT_TEMPERATURE_TARGET_POWER);
            sql = sql.Replace("dataItem.IP_ADDRESS", dataItem.IP_ADDRESS);
            sql = sql.Replace("dataItem.NAME_ADDRESS", dataItem.NAME_ADDRESS);
            sql = sql.Replace("dataItem.USER_CREATE", dataItem.USER_CREATE);
            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);
            sql = sql.Replace("dataItem.INUSE", dataItem.INUSE);

            return sql;

        }
    }
}