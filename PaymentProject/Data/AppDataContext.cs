using Microsoft.EntityFrameworkCore;
using PaymentProject.Domains;

namespace PaymentProject.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions options)
            : base(options)
        {
        }

        // banks
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankParameter> BankParameters { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<CreditCardPrefix> CreditCardPrefixes { get; set; }
        public DbSet<CreditCardInstallment> CreditCardInstallments { get; set; }

        // payments
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
    }
}