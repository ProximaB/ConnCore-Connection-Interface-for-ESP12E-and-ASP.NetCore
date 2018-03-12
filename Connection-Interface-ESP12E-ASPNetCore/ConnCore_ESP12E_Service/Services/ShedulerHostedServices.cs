using AspNetCoreService;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ConnCore_ESP12E_Service.Services
{
    public class SchedulerHostedService : HostedService
    {
        // ...

        public SchedulerHostedService (IEnumerable<IScheduledTask> scheduledTasks)
        {
            var referenceTime = DateTime.UtcNow;

            //foreach ( var scheduledTask in scheduledTasks )
            //{
            //    _scheduledTasks.Add(new SchedulerTaskWrapper
            //    {
            //        Schedule = CrontabSchedule.Parse(scheduledTask.Schedule),
            //        Task = scheduledTask,
            //        NextRunTime = referenceTime
            //    });
            //}
        }

        protected override Task ExecuteAsync (CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        // ...
    }
}
