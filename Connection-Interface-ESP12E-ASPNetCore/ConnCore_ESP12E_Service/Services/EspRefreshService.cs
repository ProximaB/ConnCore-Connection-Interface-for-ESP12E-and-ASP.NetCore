using ConnCore_ESP12E_Service.Providers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConnCore_ESP12E_Service.Services
{
    public class EspRefreshService : HostedService
    {
        private readonly MockESPProvider _mockESPProvider;

        public EspRefreshService (MockESPProvider mockESPProvider)
        {
            _mockESPProvider = mockESPProvider;

        }

        protected override async Task ExecuteAsync (CancellationToken cancellationToken)
        {
            while ( !cancellationToken.IsCancellationRequested )
            {
                _mockESPProvider.GenerateRandomInput();
                await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
            }
        }

    }
}
