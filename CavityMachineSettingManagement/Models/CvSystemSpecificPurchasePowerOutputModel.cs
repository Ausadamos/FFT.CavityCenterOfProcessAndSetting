using BusinessData.Property;
using CavityMachineSettingManagement.Property;
using CavityMachineSettingManagement.Services;
using System.Collections.Generic;

namespace CavityMachineSettingManagement.Models
{
    public class CvSystemSpecificPurchasePowerOutputModel
    {

        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvSystemSpecificPurchasePowerOutputService _service = new CvSystemSpecificPurchasePowerOutputService();


        public OutputOnDbProperty InsertAndUpdateInuse(List<CvSystemSpecificPurchasePowerOutputProperty> dataItem)
        {
            _resultData = _service.InsertAndUpdateInuse(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchBySystemIdAndPurchaseIdAndProcessId(CvSystemSpecificPurchasePowerOutputProperty dataItem)
        {
            _resultData = _service.SearchBySystemIdAndPurchaseIdAndProcessId(dataItem);
            return _resultData;
        }

    }
}