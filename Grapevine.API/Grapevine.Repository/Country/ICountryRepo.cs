using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapevine.Repository.Country
{
    public interface ICountryRepo
    {

        Task<IQueryable<tbl_Countries>> GetCountries();
        Task<tbl_Countries> GetCountryById(int countryId);
        Task<tbl_Countries> AddCountry(tbl_Countries dataModel);
        Task<tbl_Countries> UpdateCountry(tbl_Countries dataModel);
        Task<bool> DeleteCountry(int countryId);
        Task<bool> IsExitsCountry(int countryId);

    }
}
