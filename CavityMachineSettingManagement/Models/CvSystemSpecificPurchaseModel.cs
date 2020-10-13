using BusinessData.Property;
using CavityMachineSettingManagement.Property;
using CavityMachineSettingManagement.Services;

namespace CavityMachineSettingManagement.Models
{
    public class CvSystemSpecificPurchaseModel
    {


        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvSystemSpecificPurchaseService _service = new CvSystemSpecificPurchaseService();


        public OutputOnDbProperty InsertAndUpdateInuse(CvSystemSpecificPurchaseProperty dataItem)
        {
            _resultData = _service.InsertAndUpdateInuse(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchBySystemIdAndPurchaseId(CvSystemSpecificPurchaseProperty dataItem)
        {
            _resultData = _service.SearchBySystemIdAndPurchaseId(dataItem);
            return _resultData;
        }

    }
}