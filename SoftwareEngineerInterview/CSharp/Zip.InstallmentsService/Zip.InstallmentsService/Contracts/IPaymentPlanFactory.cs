﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip.InstallmentsService.Contracts
{
    public  interface IPaymentPlanFactory
    {
        public PaymentPlan CreatePaymentPlan(PaymentPlanRequest paymentPlanRequest);
    }
}
