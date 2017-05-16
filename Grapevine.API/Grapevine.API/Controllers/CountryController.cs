using Grapevine.Model;
using Grapevine.Service.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Grapevine.API.Controllers
{
    public class CountryController : ApiController
    {
        //private readonly ICountryService _countryService;
        private readonly CountryService _countryService;

        public CountryController()
        {
            _countryService = new CountryService();
        }

        //public CountryController(ICountryService countryService)
        //{
        //    _countryService = countryService;
        //}

        // GET api/<controller>
        [HttpGet]
        public async Task<HttpResponseMessage> Get()
        {
            var country = await _countryService.GetCountries();
            return Request.CreateResponse(HttpStatusCode.OK, country);
        }

        // GET api/<controller>/5
        [HttpGet]
        public async Task<HttpResponseMessage> Get(int id)
        {
            var country = await _countryService.GetCountryById(id);
            return Request.CreateResponse(HttpStatusCode.OK, country);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<HttpResponseMessage> Post([FromBody]CountryModel model)
        {
            var country = await _countryService.AddCountry(model);
            return Request.CreateResponse(HttpStatusCode.OK, country);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public async Task<HttpResponseMessage> Put(int id, [FromBody]CountryModel model)
        {
            var country = await _countryService.UpdateCountry(model);
            return Request.CreateResponse(HttpStatusCode.OK, country);
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public async Task<HttpResponseMessage> Delete(int id)
        {
            var country = await _countryService.DeleteCountry(id);
            return Request.CreateResponse(HttpStatusCode.OK, country);
        }
    }
}