using BusinessData.Property;
using CavityMachineSettingManagement.Property;
using CavityMachineSettingManagement.Services;

namespace CavityMachineSettingManagement.Models
{
    public class CvSystemSpecificModel
    {


        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvSystemSpecificService _service = new CvSystemSpecificService();


        public OutputOnDbProperty InsertAndUpdateInuse(CvSystemSpecificProperty dataItem)
        {
            _resultData = _service.InsertAndUpdateInuse(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchBySystemIdAndPurchaseId(CvSystemSpecificProperty dataItem)
        {
            _resultData = _service.SearchBySystemIdAndPurchaseId(dataItem);
            return _resultData;
        }


    }
}