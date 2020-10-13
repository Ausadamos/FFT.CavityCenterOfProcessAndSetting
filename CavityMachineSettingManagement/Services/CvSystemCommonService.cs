using BusinessData.Interface;
using BusinessData.Property;
using CavityMachineSettingManagement.Property;
using CavityMachineSettingManagement.SQLFactory;
using System;
using System.Collections.Generic;

namespace CavityMachineSettingManagement.Services
{
    public class CvSystemCommonService : DatabaseAction<CvSystemCommonProperty>
    {
        CvSystemCommonSQLFactory _sqlFactory = new CvSystemCommonSQLFactory();
        OutputOnDbProperty _resultData = new OutputOnDbProperty();


        public override OutputOnDbProperty Delete(CvSystemCommonProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(CvSystemCommonProperty dataItem)
        {
            List<string> listSQL = new List<string>();
            listSQL.Add(_sqlFactory.Delete(dataItem));
            listSQL.Add(_sqlFactory.Insert(dataItem));
            _resultData = base.InsertBySqlList(listSQL);
            return _resultData;
        }

        public override OutputOnDbProperty Search(CvSystemCommonProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public OutputOnDbProperty SearchBySystemId(CvSystemCommonProperty dataItem)
        {
            string sql = _sqlFactory.SearchBySystemId(dataItem);
            _resultData = base.SearchBySql(sql);
            return _resultData;

        }


        public override OutputOnDbProperty Update(CvSystemCommonProperty dataItem)
        {
            throw new NotImplementedException();
        }
    }
}