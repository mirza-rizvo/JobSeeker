using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Database.Model;
using PlatformForJobSeeking.Request.CustomerEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Services
{
    public class CustomerEmployerService
    {
        PlatformDbContext platformDbContext;
        public CustomerEmployerService(PlatformDbContext _platformDbContext)
        {
            platformDbContext = _platformDbContext;
        }

        public CustomerEmployer CreateCustomerEmployer(CreateCustomerEmployer createCustomerEmployer)
        {
            CustomerEmployer customerEmployer = new CustomerEmployer();
            customerEmployer.Id = Guid.NewGuid().ToString();
            customerEmployer.Password = createCustomerEmployer.Password;
            customerEmployer.UserName = createCustomerEmployer.UserName;
            customerEmployer.Email = createCustomerEmployer.Email;
            customerEmployer.DateOfEstablishment = createCustomerEmployer.DateOfEstablishment;
            customerEmployer.CompanyName = createCustomerEmployer.CompanyName;
            customerEmployer.CompanyDescription = createCustomerEmployer.CompanyDescription;
            customerEmployer.CompanyActivities = createCustomerEmployer.CompanyActivities;
            customerEmployer.PhoneNumber = createCustomerEmployer.PhoneNumber;

            platformDbContext.CustomerEmployers.Add(customerEmployer);
            platformDbContext.SaveChanges();

            return customerEmployer;
        }

        public CustomerEmployer GetCustomerEmployerById(string id)
        {
            CustomerEmployer customerEmployer = platformDbContext.CustomerEmployers.Where(m => m.Id == id).FirstOrDefault();
            if (customerEmployer == null)
            {
                throw new ArgumentException();
            }
            else
            {
                return customerEmployer;
            }
        }

        public void UpdateCustomerEmployerById(string id, UpdateCustomerEmployer updateCustomerEmployer)
        {
            CustomerEmployer customerEmployer = GetCustomerEmployerById(id);
            customerEmployer.CompanyActivities = updateCustomerEmployer.CompanyActivities;
            customerEmployer.CompanyDescription = updateCustomerEmployer.CompanyDescription;
            customerEmployer.CompanyName = updateCustomerEmployer.CompanyName;
            customerEmployer.DateOfEstablishment = updateCustomerEmployer.DateOfEstablishment;
            customerEmployer.Email = updateCustomerEmployer.Email;
            customerEmployer.Password = updateCustomerEmployer.Password;
            customerEmployer.PhoneNumber = updateCustomerEmployer.PhoneNumber;
            customerEmployer.UserName = updateCustomerEmployer.UserName;

            platformDbContext.CustomerEmployers.Update(customerEmployer);
            platformDbContext.SaveChanges();
        }

        public void DeleteCustomerEmployerById(string id)
        {
            CustomerEmployer customerEmployer = GetCustomerEmployerById(id);
            platformDbContext.CustomerEmployers.Remove(customerEmployer);
            platformDbContext.SaveChanges();
        }
    }
}
