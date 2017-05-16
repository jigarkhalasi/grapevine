using Grapevine.Model;
using Grapevine.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapevine.Service.Country
{
    public class CountryMapper
    {
        public CountryModel ConvertToModel(tbl_Countries dataModel)
        {
            CountryModel model  = new CountryModel();

            if (dataModel == null)
            {
                return null;
            }

            model.iCountryId = dataModel.iCountryId;
            model.vCountryName = dataModel.vCountryName;
            return model;            
        }

        public tbl_Countries ConvertToDataModel(CountryModel model)
        {
            tbl_Countries dataModel = new tbl_Countries();

            if (model == null)
            {
                return null;
            }

            dataModel.iCountryId = model.iCountryId;
            dataModel.vCountryName = model.vCountryName;
            return dataModel; 
        }
    }
}
