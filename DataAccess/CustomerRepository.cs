using DataAccess.Database;
using DataAccess.Interface;

namespace DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        private CSCST_DBContext _dbContext;

        public CustomerRepository(CSCST_DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IList<Customer> GetCustomers()
        {
            var customers = _dbContext.Customers.ToList();
            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            var customer = GetCustomers().FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                return customer;
            }
            return new Customer();
        }

        public void AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();

        }

        public bool CustomerLogin(string email,string password)
        {
            var isCustomerExist = GetCustomers().FirstOrDefault(c => c.Email == email && c.Password == password);
            if(isCustomerExist!=null)
            {
                return true;
            }
            return false;
        }
    }
}
