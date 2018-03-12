using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCoreService
{

    public class DataRefreshService : HostedService
    {
        private readonly RandomStringProvider _randomStringProvider;
        private int co = 0;

        public DataRefreshService (RandomStringProvider randomStringProvider)
        {
            _randomStringProvider = randomStringProvider;
        }

        protected override async Task ExecuteAsync (CancellationToken cancellationToken)
        {
            while ( !cancellationToken.IsCancellationRequested )
            {
                //while(co > 100) return; co++;
                await _randomStringProvider.UpdateString(cancellationToken);
                await Task.Delay(TimeSpan.FromSeconds(0.1), cancellationToken);
            }
        }
    }
}