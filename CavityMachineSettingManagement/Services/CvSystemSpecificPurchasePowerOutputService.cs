using BusinessData.Interface;
using BusinessData.Property;
using CavityMachineSettingManagement.Property;
using CavityMachineSettingManagement.SQLFactory;
using System;
using System.Collections.Generic;

namespace CavityMachineSettingManagement.Services
{
    public class CvSystemSpecificPurchasePowerOutputService : DatabaseAction<CvSystemSpecificPurchasePowerOutputProperty>
    {

        CvSystemSpecificPurchasePowerOutputSQLFactory _sqlFactory = new CvSystemSpecificPurchasePowerOutputSQLFactory();
        OutputOnDbProperty _resultData = new OutputOnDbProperty();

        public override OutputOnDbProperty Delete(CvSystemSpecificPurchasePowerOutputProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(CvSystemSpecificPurchasePowerOutputProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(CvSystemSpecificPurchasePowerOutputProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public OutputOnDbProperty SearchBySystemIdAndPurchaseIdAndProcessId(CvSystemSpecificPurchasePowerOutputProperty dataItem)
        {


            string sql = _sqlFactory.SearchBySystemIdAndPurchaseIdAndProcessId(dataItem);
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }

        public OutputOnDbProperty InsertAndUpdateInuse(List<CvSystemSpecificPurchasePowerOutputProperty> dataItem)
        {
            List<string> listSQL = new List<string>();
            listSQL.Add(_sqlFactory.Delete(dataItem[0]));
            foreach (CvSystemSpecificPurchasePowerOutputProperty data in dataItem)
            {
                listSQL.Add(_sqlFactory.Insert(data));
            }

            _resultData = base.InsertBySqlList(listSQL);
            return _resultData;
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(CvSystemSpecificPurchasePowerOutputProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}