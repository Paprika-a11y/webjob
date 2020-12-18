using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TimerWebJob2
{
    public class Functions
    {
        public static void ProcessTimerTrigger([TimerTrigger("0 * * * * *")] TimerInfo myTimer, ILogger logger)
        {
            logger.LogInformation("Message from Class1.");
        }
        
    }
}
