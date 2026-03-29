using CustomerOnboardingApi.Application.Interfaces;
using CustomerOnboardingApi.Application.Validators;
using CustomerOnboardingApi.Domain;
using CustomerOnboardingApi.Infrastracture;
using Microsoft.EntityFrameworkCore;

namespace CustomerOnboardingApi.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext db;
        public CustomerService(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<Customer> Create(Customer customer)
        {
            var errors = CustomerValidator.Validate(customer);
            if (errors.Any())
                throw new ArgumentException(string.Join("; ", errors));

            customer.DateCreated = DateTime.UtcNow;
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;

        }

        public async Task<IEnumerable<Customer>> GetAll() => await db.Customers.ToListAsync();
        

        public async Task<Customer?> GetById(int id) => await db.Customers.FindAsync(id);

    }
}
