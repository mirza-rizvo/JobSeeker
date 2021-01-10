using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Database.Model;
using PlatformForJobSeeking.Request.CustomerSeeker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Services
{
    public class CustomerSeekerService
    {
        private readonly PlatformDbContext platformDbContext;
        public CustomerSeekerService(PlatformDbContext _platformDbContext)
        {
            platformDbContext = _platformDbContext;
        }

        public CustomerSeeker CreateCustomerSeeker(CreateCustomerSeeker createCustomerSeeker) 
        {
            CustomerSeeker customerSeeker = new CustomerSeeker();
            customerSeeker.Id = Guid.NewGuid().ToString();
            customerSeeker.LastName = createCustomerSeeker.LastName;
            customerSeeker.Name = createCustomerSeeker.Name;
            customerSeeker.Password = createCustomerSeeker.Password;
            customerSeeker.PhoneNumber = createCustomerSeeker.PhoneNumber;
            customerSeeker.UserName = createCustomerSeeker.UserName;
            customerSeeker.YearsOfExperience = createCustomerSeeker.YearsOfExperience;
            customerSeeker.Biography = createCustomerSeeker.Biography;
            customerSeeker.DateOfBirth = createCustomerSeeker.DateOfBirth;
            customerSeeker.Email = createCustomerSeeker.Email;
            
            platformDbContext.CustomerSeekers.Add(customerSeeker);
            platformDbContext.SaveChanges();
            
            return customerSeeker;
        }

        public CustomerSeeker GetCustomerSeekerById(string id)
        {
            CustomerSeeker customerSeeker = platformDbContext.CustomerSeekers.Where(e => e.Id == id).FirstOrDefault();
            return customerSeeker;
        }
        public void UpdateCustomerSeeker(string id, UpdateCustomerSeeker updateCustomerSeeker)
        {
            CustomerSeeker customerSeeker = GetCustomerSeekerById(id);
            customerSeeker.Biography = updateCustomerSeeker.Biography;
            customerSeeker.DateOfBirth = updateCustomerSeeker.DateOfBirth;
            customerSeeker.Email = updateCustomerSeeker.Email;
            customerSeeker.LastName = updateCustomerSeeker.LastName;
            customerSeeker.Name = updateCustomerSeeker.Name;
            customerSeeker.Password = updateCustomerSeeker.Password;
            customerSeeker.PhoneNumber = updateCustomerSeeker.PhoneNumber;
            customerSeeker.UserName = updateCustomerSeeker.UserName;
            customerSeeker.YearsOfExperience = updateCustomerSeeker.YearsOfExperience;

            platformDbContext.CustomerSeekers.Update(customerSeeker);
            platformDbContext.SaveChanges();
        }
        public void DeleteUserById(string id)
        {
            CustomerSeeker customer = GetCustomerSeekerById(id);
            platformDbContext.CustomerSeekers.Remove(customer);
            platformDbContext.SaveChanges();
        }
    }
}
