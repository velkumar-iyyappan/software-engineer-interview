using Microsoft.AspNetCore.Mvc;
using Zip.InstallmentsService.Contracts;

namespace Zip.InstallmentsServiceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstallmentPaymentController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<InstallmentPaymentController> _logger;
        private readonly IPaymentPlanFactory paymentPlanFactory;

        public InstallmentPaymentController(ILogger<InstallmentPaymentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetInstallmentPaymentPlan")]
        public IEnumerable<PaymentPlan> Get()
        {

            return new List<PaymentPlan>();
            //return Enumerable.Range(1, 5).Select(index => new PaymentPlan
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}