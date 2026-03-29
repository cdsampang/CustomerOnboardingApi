using CustomerOnboardingApi.Domain;

namespace CustomerOnboardingApi.Application.Interfaces
{
    public interface ICustomerService
    {
        Task<Customer> Create(Customer customer);
        Task<Customer?> GetById(int id);
        Task<IEnumerable<Customer>> GetAll();
    }
}
