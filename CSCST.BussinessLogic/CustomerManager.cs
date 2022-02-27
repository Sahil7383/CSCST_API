using CSCST.BusinessEntities;
using CSCST.BussinessLogic.Interface;
using CSCST.Common;
using DataAccess.Database;
using DataAccess.Interface;

namespace CSCST.BussinessLogic
{
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IList<CustomerViewModel> GetCustomers()
        {
            IList<CustomerViewModel> customerViewModels = new List<CustomerViewModel>();
            var customers = _customerRepository.GetCustomers();
            if (customers.Any())
            {
                //foreach (var customer in customers)
                //{
                //    var customerViewModel = new CustomerViewModel()
                //    {
                //        Id = customer.Id,
                //        FirstName = customer.FirstName,
                //        LastName = customer.LastName,
                //        Email = customer.Email,
                //        CustomerPassword = customer.CustomerPassword,
                //        PhoneNo = customer.PhoneNo,
                //        AlternatePhoneNo = customer.AlternatePhoneNo,
                //        CreatedBy = customer.CreatedBy,
                //        CreatedDate = customer.CreatedDate,
                //        UpdatedBy = customer.UpdatedBy,
                //        UpdatedDate = customer.UpdatedDate,
                //        IsActive = customer.IsActive
                //    };
                //    customerViewModels.Add(customerViewModel);
                //}

                customerViewModels = customers.JsonCast<IList<CustomerViewModel>>();
            }

            return customerViewModels;
        }

        public CustomerViewModel GetCustomersById(int id)
        {
            CustomerViewModel customerViewModel = new CustomerViewModel();
            var customer = _customerRepository.GetCustomerById(id);
            if (customer != null)
            {
                //customerViewModel = new CustomerViewModel()
                //{
                //    Id = customer.Id,
                //    FirstName = customer.FirstName,
                //    LastName = customer.LastName,
                //    Email = customer.Email,
                //    CustomerPassword = customer.CustomerPassword,
                //    PhoneNo = customer.PhoneNo,
                //    AlternatePhoneNo = customer.AlternatePhoneNo,
                //    CreatedBy = customer.CreatedBy,
                //    CreatedDate = customer.CreatedDate,
                //    UpdatedBy = customer.UpdatedBy,
                //    UpdatedDate = customer.UpdatedDate,
                //    IsActive = customer.IsActive
                //};

                customerViewModel = customer.JsonCast<CustomerViewModel>();
            }

            return customerViewModel;
        }

        public void AddCustomer(CustomerViewModel customerviewmodel)
        {
            
            var customer = customerviewmodel.JsonCast<Customer>();
            _customerRepository.AddCustomer(customer);
            
          
        }

        public bool CustomerLogin(string email, string password)
        {
            bool isCorrect=_customerRepository.CustomerLogin(email, password);
            return isCorrect;
        }
    }
}
