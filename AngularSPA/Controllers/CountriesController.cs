using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularSPA.Entities;
using AngularSPA.Services;

namespace AngularSPA.Controllers
{

    public class CountriesController : ApiBaseController
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
            : base()
        {
            _countryService = countryService;
        }

        [HttpGet]
        public IEnumerable<Country> GetAll()
        {
            return _countryService.GetAll();
        }

        [HttpGet]
        public Country Get(int id)
        {
            return _countryService.Get(id);
        }

    }
}