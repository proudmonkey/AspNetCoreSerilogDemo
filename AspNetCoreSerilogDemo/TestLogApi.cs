using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AspNetCoreSerilogDemo
{
    public class TestLogApi
    {
        private readonly ILogger<TestLogApi> _logger;
        public TestLogApi(ILogger<TestLogApi> logger)
        {
            _logger = logger;
        }

        public async Task DumpLogs(HttpContext context)
        {
            _logger.LogInformation("This is a log with INFORMATION severity level.");
            _logger.LogWarning("This is a log with WARNING severity level.");
            _logger.LogError("This is a log with ERROR severity level.");
            _logger.LogCritical("This is a log with CRITICAL severity level.");

            await context.Response.WriteAsync("Events has been logged.");
        }
    }
}
