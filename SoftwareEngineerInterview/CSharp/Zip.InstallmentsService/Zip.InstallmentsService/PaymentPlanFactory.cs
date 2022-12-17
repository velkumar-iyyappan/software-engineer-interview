using System;
using System.Collections.Generic;
using Zip.InstallmentsService.Contracts;

namespace Zip.InstallmentsService
{
    /// <summary>
    /// This class is responsible for building the PaymentPlan according to the Zip product definition.
    /// </summary>
    public class PaymentPlanFactory: IPaymentPlanFactory
    {
        /// <summary>
        /// Builds the PaymentPlan instance.
        /// </summary>
        /// <param name="purchaseAmount">The total amount for the purchase that the customer is making.</param>
        /// <returns>The PaymentPlan created with all properties set.</returns>
        public PaymentPlan CreatePaymentPlan(PaymentPlanRequest paymentPlanRequest)
        {
            // TODO

            var installmentAmount = paymentPlanRequest.PurchaseAmount / paymentPlanRequest.Installments;
            var installments = new List<Installment>();            
            for (int i =1; i<= paymentPlanRequest.Installments;i++)
            {
                installments.Add(new Installment() 
                { Amount = installmentAmount , 
                    Id= new System.Guid(),
                    DueDate = DateTime.Now.AddDays(paymentPlanRequest.FrequencyDays*(i-1))});
            }

            return new PaymentPlan() { 
                Id = new Guid(), 
                Installments = installments.ToArray(), 
                PurchaseAmount = paymentPlanRequest.PurchaseAmount};
        }
    }
}
