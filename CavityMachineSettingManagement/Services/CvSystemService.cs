using BusinessData.Interface;
using BusinessData.Property;
using CavityMachineSettingManagement.Property;
using CavityMachineSettingManagement.SQLFactory;

namespace CavityMachineSettingManagement.Services
{
    public class CvSystemService : DatabaseAction<CvSystemProperty>
    {
        CvSystemSQLFactory _sqlFactory = new CvSystemSQLFactory();
        OutputOnDbProperty _resultData = new OutputOnDbProperty();

        public override OutputOnDbProperty Delete(CvSystemProperty dataItem)
        {
            throw new System.NotImplementedException();
        }

        public override OutputOnDbProperty Insert(CvSystemProperty dataItem)
        {
            string sql = _sqlFactory.Insert(dataItem);
            _resultData = base.InsertBySql(sql);
            return _resultData;
        }

        public override OutputOnDbProperty Search(CvSystemProperty dataItem)
        {
            throw new System.NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            string sql = _sqlFactory.Search();
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }

        public OutputOnDbProperty SearchBySystemId(CvSystemProperty dataItem)
        {
            string sql = _sqlFactory.SearchBySystemId(dataItem);
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }

        public OutputOnDbProperty SearchByIpAddressSystem(CvSystemProperty dataItem)
        {
            string sql = _sqlFactory.SearchByIpAddressSystem(dataItem);
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }



        public override OutputOnDbProperty Update(CvSystemProperty dataItem)
        {
            throw new System.NotImplementedException();
        }
    }
}