using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class CustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Add(customer);
            }
            else
            {
                Console.WriteLine("Kullanıcı bilgileri yanlış , kayıt geçersiz.");
            }
        }
        public void Update(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Update(customer);
            }
            else
            {
                Console.WriteLine("Kullanıcı bilgileri yanlış , güncelleme başarısız oldu.");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("{0} isimli kullanıcı silindi. " + customer.FirstName);
        }

        public void Get(Customer customer)
        {
            Console.WriteLine("Kullanıcı adı :{0}  olan oyuncunun Adı Soyadı : {1} {2}", customer.NickName, customer.FirstName, customer.LastName);
        }

        public void GetAll(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Kullanıcı adı :{0}  olan oyuncunun Adı Soyadı : {1} {2}", customer.NickName, customer.FirstName, customer.LastName);
            }
        }


    }
}
