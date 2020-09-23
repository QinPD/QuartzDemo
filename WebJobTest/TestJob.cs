using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using log4net;

namespace WebJobTest
{
    public class TestJob : IJob
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(TestJob));
        public Task Execute(IJobExecutionContext context)
        {
            //_logger.Info("每3秒输出");
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            return Task.FromResult(true);
        }
    }
}
