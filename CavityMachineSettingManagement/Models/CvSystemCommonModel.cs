using BusinessData.Property;
using CavityMachineSettingManagement.Property;
using CavityMachineSettingManagement.Services;

namespace CavityMachineSettingManagement.Models
{
    public class CvSystemCommonModel
    {


        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvSystemCommonService _service = new CvSystemCommonService();


        public OutputOnDbProperty Insert(CvSystemCommonProperty dataItem)
        {
            _resultData = _service.Insert(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchBySystemId(CvSystemCommonProperty dataItem)
        {
            _resultData = _service.SearchBySystemId(dataItem);
            return _resultData;
        }


    }
}