using Microsoft.AspNetCore.Mvc;
using Otpravka.Models;

namespace Otpravka.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailReportController : ControllerBase
    {
        private static List<EmailReport> reports = new();

        [HttpGet]
        public IEnumerable<EmailReport> Get()
        {
            return reports;
        }

        [HttpPost]
        public IActionResult Post([FromBody] EmailReport report)
        {
            report.Id = reports.Count + 1;
            reports.Add(report);
            return Ok(report);
        }
    }
}
