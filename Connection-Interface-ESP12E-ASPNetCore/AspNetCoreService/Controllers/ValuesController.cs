using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnCore_ESP12E_Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace AspNetCoreService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly RandomStringProvider _randomStringProvider;
        private readonly IHostedService _dataRefreshService;

        public ValuesController (RandomStringProvider randomStringProvider, IHostedService dataRefreshService)
        {
            _randomStringProvider = randomStringProvider;
            _dataRefreshService = dataRefreshService;
        }

        [HttpGet]
        public string Get ()
        {
            //System.Threading.CancellationToken clt = new System.Threading.CancellationToken();
            //_dataRefreshService.StartAsync(clt);
            return _randomStringProvider.RandomString;
        }
    }
}
