using CavityMachineSettingManagement.Property;

namespace CavityMachineSettingManagement.SQLFactory
{
    public class CvSystemSQLFactory
    {
        string tableName = TableName.CV_SYSTEM;
        public string Search()
        {
            string sql = @"SELECT * FROM tableName";

            sql = sql.Replace("tableName", tableName);

            return sql;
        }

        public string SearchBySystemId(CvSystemProperty dataItem)
        {
            string sql = @" SELECT * FROM tableName 
                            WHERE ID = 'dataItem.ID'";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.ID", dataItem.ID);

            return sql;
        }

        public string SearchByIpAddressSystem(CvSystemProperty dataItem)
        {
            string sql = @" SELECT * FROM tableName 
                            WHERE IP_ADDRESS_SYSTEM = 'dataItem.IP_ADDRESS_SYSTEM' 
                            AND INUSE = 1";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.IP_ADDRESS_SYSTEM", dataItem.IP_ADDRESS_SYSTEM);

            return sql;
        }

        public string Insert(CvSystemProperty dataItem)
        {
            string sql = @"INSERT INTO tableName
                                        (
                                          ID
                                        , SYSTEM_NAME
                                        , IP_ADDRESS_SYSTEM
                                        , INUSE
                                        , DESCRIPTION
                                        , CREATE_USER
                                        , IP_ADDRESS
                                        , NAME_ADDRESS
                                        )
                                        (
                                          SELECT 1 + coalesce((SELECT max(Id) FROM tableName), 0) 
                                        , 'dataItem.SYSTEM_NAME'
                                        , 'dataItem.IP_ADDRESS_SYSTEM'
                                        , 1
                                        , 'dataItem.DESCRIPTION'
                                        , 'dataItem.CREATE_USER'
                                        , 'dataItem.IP_ADDRESS'
                                        , 'dataItem.NAME_ADDRESS'
                                        )";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.SYSTEM_NAME", dataItem.SYSTEM_NAME);
            sql = sql.Replace("dataItem.IP_ADDRESS_SYSTEM", dataItem.IP_ADDRESS_SYSTEM);
            sql = sql.Replace("dataItem.INUSE", dataItem.INUSE);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);
            sql = sql.Replace("dataItem.CREATE_USER", dataItem.CREATE_USER);
            sql = sql.Replace("dataItem.LAST_USER", dataItem.LAST_USER);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);
            sql = sql.Replace("dataItem.IP_ADDRESS", dataItem.IP_ADDRESS);
            sql = sql.Replace("dataItem.NAME_ADDRESS", dataItem.NAME_ADDRESS);


            return sql;

        }


    }
}