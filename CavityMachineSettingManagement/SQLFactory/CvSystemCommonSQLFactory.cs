using CavityMachineSettingManagement.Property;

namespace CavityMachineSettingManagement.SQLFactory
{
    public class CvSystemCommonSQLFactory
    {
        string tableName = TableName.CV_SYSTEM_COMMON;

        public string Insert(CvSystemCommonProperty dataItem)
        {
            string sql = @"INSERT INTO tableName
                                        (
                                          ID
                                        , SYSTEM_ID
                                        , OSA_GPIB_ADDRESS
                                        , DIO_COM_PORT
                                        , RESIDUAL_COM_PORT
                                        , OPHIR_OUTPUT_POWER_METER_ADDRESS
                                        , OPHIR_FW_METER_ADDRESS
                                        , OPHIR_BW_METER_ADDRESS
                                        , OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS
                                        , GL840_SAFETY_PD_CHANNEL
                                        , GL840_COLD_PLATE_TEMP_CHANNEL
                                        , GL840_MS_IN_TEMP_CHANNEL
                                        , GL840_BASEPLATE_TEMP_CHANNEL
                                        , GL840_MS_OUT_TEMP_CHANNEL
                                        , GL840_CAVITY_PD_CHANNEL
                                        , SAFETY_SHUT_DOWN_THRESHOLD
                                        , SAFETY_OFFSET
                                        , SAFETY_MIN_PD_OUTPUT
                                        , SAFETY_MIN_OUTPUT_POWER
                                        , SAFETY_OUTPUT_CHECK_TIME
                                        , SAFETY_MAX_COLDPLATE_TEMP
                                        , OFFSET_SLOP_EFFICIENCY_RESONATOR
                                        , OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING
                                        , OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1
                                        , OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2
                                        , OFFSET_SLOP_EFFICIENCY_MONITOR_CAL
                                        , OFFSET_SLOP_EFFICIENCY_POST_BURNIN
                                        , DESCRIPTION
                                        , IP_ADDRESS
                                        , NAME_ADDRESS
                                        , INUSE
                                        , USER_CREATE
                                        )
                                        (
                                          SELECT 1 + coalesce((SELECT max(Id) FROM tableName), 0) 
                                        , 'dataItem.SYSTEM_ID'
                                        , 'dataItem.OSA_GPIB_ADDRESS'
                                        , 'dataItem.DIO_COM_PORT'
                                        , 'dataItem.RESIDUAL_COM_PORT'
                                        , 'dataItem.OPHIR_OUTPUT_POWER_METER_ADDRESS'
                                        , 'dataItem.OPHIR_FW_METER_ADDRESS'
                                        , 'dataItem.OPHIR_BW_METER_ADDRESS'
                                        , 'dataItem.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS'
                                        , 'dataItem.GL840_SAFETY_PD_CHANNEL'
                                        , 'dataItem.GL840_COLD_PLATE_TEMP_CHANNEL'
                                        , 'dataItem.GL840_MS_IN_TEMP_CHANNEL'
                                        , 'dataItem.GL840_BASEPLATE_TEMP_CHANNEL'
                                        , 'dataItem.GL840_MS_OUT_TEMP_CHANNEL'
                                        , 'dataItem.GL840_CAVITY_PD_CHANNEL'
                                        , 'dataItem.SAFETY_SHUT_DOWN_THRESHOLD'
                                        , 'dataItem.SAFETY_OFFSET'
                                        , 'dataItem.SAFETY_MIN_PD_OUTPUT'
                                        , 'dataItem.SAFETY_MIN_OUTPUT_POWER'
                                        , 'dataItem.SAFETY_OUTPUT_CHECK_TIME'
                                        , 'dataItem.SAFETY_MAX_COLDPLATE_TEMP'
                                        , 'dataItem.OFFSET_SLOP_EFFICIENCY_RESONATOR'
                                        , 'dataItem.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING'
                                        , 'dataItem.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1'
                                        , 'dataItem.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2'
                                        , 'dataItem.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL'
                                        , 'dataItem.OFFSET_SLOP_EFFICIENCY_POST_BURNIN'
                                        , 'dataItem.DESCRIPTION'
                                        , 'dataItem.IP_ADDRESS'
                                        , 'dataItem.NAME_ADDRESS'
                                        , 1
                                        , 'dataItem.USER_CREATE'
                                        )";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);
            sql = sql.Replace("dataItem.OSA_GPIB_ADDRESS", dataItem.OSA_GPIB_ADDRESS);
            sql = sql.Replace("dataItem.DIO_COM_PORT", dataItem.DIO_COM_PORT);
            sql = sql.Replace("dataItem.RESIDUAL_COM_PORT", dataItem.RESIDUAL_COM_PORT);
            sql = sql.Replace("dataItem.OPHIR_OUTPUT_POWER_METER_ADDRESS", dataItem.OPHIR_OUTPUT_POWER_METER_ADDRESS);
            sql = sql.Replace("dataItem.OPHIR_FW_METER_ADDRESS", dataItem.OPHIR_FW_METER_ADDRESS);
            sql = sql.Replace("dataItem.OPHIR_BW_METER_ADDRESS", dataItem.OPHIR_BW_METER_ADDRESS);
            sql = sql.Replace("dataItem.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS", dataItem.OPHIR_CENTER_PORT_FW_TFB_METER_ADDRESS);
            sql = sql.Replace("dataItem.GL840_SAFETY_PD_CHANNEL", dataItem.GL840_SAFETY_PD_CHANNEL);
            sql = sql.Replace("dataItem.GL840_COLD_PLATE_TEMP_CHANNEL", dataItem.GL840_COLD_PLATE_TEMP_CHANNEL);
            sql = sql.Replace("dataItem.GL840_MS_IN_TEMP_CHANNEL", dataItem.GL840_MS_IN_TEMP_CHANNEL);
            sql = sql.Replace("dataItem.GL840_BASEPLATE_TEMP_CHANNEL", dataItem.GL840_BASEPLATE_TEMP_CHANNEL);
            sql = sql.Replace("dataItem.GL840_MS_OUT_TEMP_CHANNEL", dataItem.GL840_MS_OUT_TEMP_CHANNEL);
            sql = sql.Replace("dataItem.GL840_CAVITY_PD_CHANNEL", dataItem.GL840_CAVITY_PD_CHANNEL);
            sql = sql.Replace("dataItem.SAFETY_SHUT_DOWN_THRESHOLD", dataItem.SAFETY_SHUT_DOWN_THRESHOLD);
            sql = sql.Replace("dataItem.SAFETY_OFFSET", dataItem.SAFETY_OFFSET);
            sql = sql.Replace("dataItem.SAFETY_MIN_PD_OUTPUT", dataItem.SAFETY_MIN_PD_OUTPUT);
            sql = sql.Replace("dataItem.SAFETY_MIN_OUTPUT_POWER", dataItem.SAFETY_MIN_OUTPUT_POWER);
            sql = sql.Replace("dataItem.SAFETY_OUTPUT_CHECK_TIME", dataItem.SAFETY_OUTPUT_CHECK_TIME);
            sql = sql.Replace("dataItem.SAFETY_MAX_COLDPLATE_TEMP", dataItem.SAFETY_MAX_COLDPLATE_TEMP);
            sql = sql.Replace("dataItem.OFFSET_SLOP_EFFICIENCY_RESONATOR", dataItem.OFFSET_SLOP_EFFICIENCY_RESONATOR);
            sql = sql.Replace("dataItem.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING", dataItem.OFFSET_SLOP_EFFICIENCY_THERMAL_SCREENING);
            sql = sql.Replace("dataItem.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1", dataItem.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_1);
            sql = sql.Replace("dataItem.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2", dataItem.OFFSET_SLOP_EFFICIENCY_PRE_BURNIN_2);
            sql = sql.Replace("dataItem.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL", dataItem.OFFSET_SLOP_EFFICIENCY_MONITOR_CAL);
            sql = sql.Replace("dataItem.OFFSET_SLOP_EFFICIENCY_POST_BURNIN", dataItem.OFFSET_SLOP_EFFICIENCY_POST_BURNIN);
            sql = sql.Replace("dataItem.DESCRIPTION", dataItem.DESCRIPTION);
            sql = sql.Replace("dataItem.LAST_DATE", dataItem.LAST_DATE);
            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);
            sql = sql.Replace("dataItem.CREATE_DATE", dataItem.CREATE_DATE);
            sql = sql.Replace("dataItem.IP_ADDRESS", dataItem.IP_ADDRESS);
            sql = sql.Replace("dataItem.NAME_ADDRESS", dataItem.NAME_ADDRESS);
            sql = sql.Replace("dataItem.INUSE", dataItem.INUSE);
            sql = sql.Replace("dataItem.USER_CREATE", dataItem.USER_CREATE);

            return sql;

        }




        public string SearchBySystemId(CvSystemCommonProperty dataItem)
        {
            string sql = @"SELECT * FROM tableName 
                             where 
                              SYSTEM_ID = 'dataItem.SYSTEM_ID'
                             AND INUSE = 1";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);
            return sql;
        }

        public string Delete(CvSystemCommonProperty dataItem)
        {
            string sql = @" UPDATE tableName SET INUSE = 0 
                            , USER_UPDATE = 'dataItem.USER_UPDATE' 
                            , LAST_DATE = NOW()
                             WHERE SYSTEM_ID = 'dataItem.SYSTEM_ID' 
                             AND INUSE = 1 ";

            sql = sql.Replace("tableName", tableName);

            sql = sql.Replace("dataItem.SYSTEM_ID", dataItem.SYSTEM_ID);
            sql = sql.Replace("dataItem.USER_UPDATE", dataItem.USER_UPDATE);

            return sql;


        }
    }
}