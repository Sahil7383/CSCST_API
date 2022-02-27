using CSCST.BusinessEntities;

namespace CSCST.BussinessLogic.Interface
{
    public interface ICustomerManager
    {
        IList<CustomerViewModel> GetCustomers();
        CustomerViewModel GetCustomersById(int id);
        public void AddCustomer(CustomerViewModel customerviewmodel);

        bool CustomerLogin(string email, string password);
    }
}
