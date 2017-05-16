using Grapevine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapevine.Service.Country
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryModel>> GetCountries();
        Task<CountryModel> GetCountryById(int countryId);
        Task<CountryModel> AddCountry(CountryModel dataModel);
        Task<CountryModel> UpdateCountry(CountryModel dataModel);
        Task<bool> DeleteCountry(int countryId);
        Task<bool> IsExitsCountry(int countryId);
    }
}
