using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip.InstallmentsService
{
    public  class PaymentPlanRequest
    {
        public decimal PurchaseAmount { get; set; }
        public int Installments { get; set; }
        public int FrequencyDays { get; set; }
       
    }
}
