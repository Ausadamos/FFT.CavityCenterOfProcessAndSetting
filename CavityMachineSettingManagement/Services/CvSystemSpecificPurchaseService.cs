using BusinessData.Interface;
using BusinessData.Property;
using CavityMachineSettingManagement.Property;
using CavityMachineSettingManagement.SQLFactory;
using System;
using System.Collections.Generic;

namespace CavityMachineSettingManagement.Services
{
    public class CvSystemSpecificPurchaseService : DatabaseAction<CvSystemSpecificPurchaseProperty>
    {


        CvSystemSpecificPurchaseSQLFactory _sqlFactory = new CvSystemSpecificPurchaseSQLFactory();
        OutputOnDbProperty _resultData = new OutputOnDbProperty();

        public override OutputOnDbProperty Delete(CvSystemSpecificPurchaseProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(CvSystemSpecificPurchaseProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(CvSystemSpecificPurchaseProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public OutputOnDbProperty InsertAndUpdateInuse(CvSystemSpecificPurchaseProperty dataItem)
        {
            List<string> listSQL = new List<string>();
            listSQL.Add(_sqlFactory.Delete(dataItem));
            listSQL.Add(_sqlFactory.Insert(dataItem));

            _resultData = base.InsertBySqlList(listSQL);
            return _resultData;
        }

        public OutputOnDbProperty SearchBySystemIdAndPurchaseId(CvSystemSpecificPurchaseProperty dataItem)
        {
            string sql = _sqlFactory.SearchBySystemIdAndPurchaseId(dataItem);
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }


        public override OutputOnDbProperty Update(CvSystemSpecificPurchaseProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}