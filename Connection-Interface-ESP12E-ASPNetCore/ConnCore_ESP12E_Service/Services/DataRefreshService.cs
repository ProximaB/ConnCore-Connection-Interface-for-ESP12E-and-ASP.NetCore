using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConnCore_ESP12E_Service.Services;

namespace ConnCore_ESP12E_Service.Services
{   
    public class DataRefreshService : HostedService
    {
        private readonly RandomStringProvider _randomStringProvider;

        public DataRefreshService (RandomStringProvider randomStringProvider)
        {
            _randomStringProvider = randomStringProvider;
        }

        protected override async Task ExecuteAsync (CancellationToken cancellationToken)
        {
            while ( !cancellationToken.IsCancellationRequested )
            {
                await _randomStringProvider.UpdateString(cancellationToken);
                await Task.Delay(TimeSpan.FromSeconds(0.1), cancellationToken);
            }
        }
    }
}

