using DataAccess.Database;

namespace DataAccess.Interface
{
    public interface ICustomerRepository
    {
        IList<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer customer);

        bool CustomerLogin(string email,string password);
    }
}
