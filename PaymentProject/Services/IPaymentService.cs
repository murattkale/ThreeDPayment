using System;
using System.Threading.Tasks;
using PaymentProject.Domains;

namespace PaymentProject.Services
{
    public interface IPaymentService
    {
        Task<PaymentTransaction> GetById(int id,
            bool includeBank = false);
        Task<PaymentTransaction> GetByOrderNumber(string orderNumber,
            bool includeBank = false);
        Task Insert(PaymentTransaction paymentTransaction);
        Task Update(PaymentTransaction paymentTransaction);
    }
}