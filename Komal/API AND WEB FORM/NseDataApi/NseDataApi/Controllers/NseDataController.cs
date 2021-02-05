using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NseDataApi.Models;
using NseDataApi.Services;

namespace NseDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NseDataController : ControllerBase
    {
        private readonly NseDataServices _nseDataServices;

        public NseDataController(NseDataServices nseDataServices)
        {
            _nseDataServices = nseDataServices;
        }

        [HttpGet]
        public ActionResult<List<SMAT>> Get() =>
          _nseDataServices.Get();

        
        public ActionResult<SMAT> Get(string id)
        {
            var sma = _nseDataServices.Get(id);

            if (sma == null)
            {
                return NotFound();
            }

            return sma;
        }
    }
}