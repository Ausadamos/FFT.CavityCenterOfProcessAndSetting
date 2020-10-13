using BusinessData.Interface;
using BusinessData.Property;
using CavityMachineSettingManagement.Property;
using CavityMachineSettingManagement.SQLFactory;
using System;
using System.Collections.Generic;

namespace CavityMachineSettingManagement.Services
{
    public class CvSystemSpecificService : DatabaseAction<CvSystemSpecificProperty>
    {
        CvSystemSpecificSQLFactory _sqlFactory = new CvSystemSpecificSQLFactory();
        OutputOnDbProperty _resultData = new OutputOnDbProperty();

        public OutputOnDbProperty InsertAndUpdateInuse(CvSystemSpecificProperty dataItem)
        {
            List<string> listSQL = new List<string>();
            listSQL.Add(_sqlFactory.Delete(dataItem));
            listSQL.Add(_sqlFactory.Insert(dataItem));

            _resultData = base.InsertBySqlList(listSQL);
            return _resultData;
        }

        public OutputOnDbProperty SearchBySystemIdAndPurchaseId(CvSystemSpecificProperty dataItem)
        {
            string sql = _sqlFactory.SearchBySystemIdAndPurchaseId(dataItem);
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }

        public override OutputOnDbProperty Delete(CvSystemSpecificProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(CvSystemSpecificProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(CvSystemSpecificProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(CvSystemSpecificProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}