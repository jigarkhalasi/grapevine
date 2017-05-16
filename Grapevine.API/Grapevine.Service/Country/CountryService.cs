using Grapevine.Model;
using Grapevine.Repository.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapevine.Service.Country
{
    public class CountryService : ICountryService
    {

       // private readonly ICountryRepo _countryRepo;
        private readonly CountryRepo _countryRepo;
        private readonly CountryMapper _countryMapper;

        public CountryService()
        {
            _countryRepo = new CountryRepo();
            _countryMapper = new CountryMapper();
        }        


        #region ICountryService Members

        public async Task<IEnumerable<CountryModel>> GetCountries()
        {
            var countryList = await _countryRepo.GetCountries();
            return countryList.ToList().Select(c => _countryMapper.ConvertToModel(c));
        }

        public async Task<CountryModel> GetCountryById(int countryId)
        {
            var country = _countryMapper.ConvertToModel(await _countryRepo.GetCountryById(countryId));            
            return country;
        }

        public async Task<CountryModel> AddCountry(CountryModel dataModel)
        {
            var country = await _countryRepo.AddCountry(_countryMapper.ConvertToDataModel(dataModel));
            return _countryMapper.ConvertToModel(country);
        }

        public async Task<CountryModel> UpdateCountry(CountryModel dataModel)
        {
            var country = await _countryRepo.UpdateCountry(_countryMapper.ConvertToDataModel(dataModel));
            return _countryMapper.ConvertToModel(country);
        }

        public async Task<bool> DeleteCountry(int countryId)
        {
            var country = await _countryRepo.DeleteCountry(countryId);
            return country;
        }

        public Task<bool> IsExitsCountry(int countryId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
