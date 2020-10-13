using BusinessData.Property;
using CavityMachineSettingManagement.Property;
using CavityMachineSettingManagement.Services;

namespace CavityMachineSettingManagement.Models
{
    public class CvSystemModel
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvSystemService _service = new CvSystemService();

        public OutputOnDbProperty Delete(CvSystemProperty dataItem)
        {
            _resultData = _service.Delete(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty Insert(CvSystemProperty dataItem)
        {
            _resultData = _service.Insert(dataItem);
            return _resultData;
        }



        public OutputOnDbProperty Search()
        {
            _resultData = _service.Search();
            return _resultData;
        }


        public OutputOnDbProperty Search(CvSystemProperty dataItem)
        {
            _resultData = _service.Search(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty SearchByIpAddressSystem(CvSystemProperty dataItem)
        {
            _resultData = _service.SearchByIpAddressSystem(dataItem);
            return _resultData;
        }


        public OutputOnDbProperty SearchBySystemId(CvSystemProperty dataItem)
        {
            _resultData = _service.SearchBySystemId(dataItem);
            return _resultData;
        }
        public OutputOnDbProperty insert(CvSystemProperty dataItem)
        {
            _resultData = _service.Search();
            return _resultData;
        }

        public OutputOnDbProperty Update(CvSystemProperty dataItem)
        {
            _resultData = _service.Update(dataItem);
            return _resultData;
        }
    }
}