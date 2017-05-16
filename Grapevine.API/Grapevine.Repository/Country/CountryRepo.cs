using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapevine.Repository.Country
{
    public class CountryRepo : BaseRepository, ICountryRepo
    {
        #region ICountry Members

        public async Task<IQueryable<tbl_Countries>> GetCountries()
        {
            return await Task.Run(() =>
            {
                return Context.tbl_Countries;
            });
        }

        public async Task<tbl_Countries> AddCountry(tbl_Countries dataModel)
        {
            Context.tbl_Countries.Add(dataModel);
            Context.SaveChanges();
            return await GetCountryById(dataModel.iCountryId);

        }

        public Task<tbl_Countries> UpdateCountry(tbl_Countries dataModel)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCountry(int countryId)
        {
            return await Task.Run(() =>
            {
                var data = Context.tbl_Countries.Find(countryId);
                Context.tbl_Countries.Remove(data);
                Context.SaveChanges();
                return true;
            });            
        }

        public async Task<bool> IsExitsCountry(int countryId)
        {
            return await Task.Run(() =>
             {
                 var data = GetCountryById(countryId);
                 if (data != null)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             });
        }

        #endregion

        #region ICountry Members
        public async Task<tbl_Countries> GetCountryById(int countryId)
        {
            return await Task.Run(() =>
            {
                return Context.tbl_Countries.Find(countryId);
            });
        }
        #endregion
    }
}
