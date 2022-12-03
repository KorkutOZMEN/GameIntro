using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("{0} {1} isimli oyuncu {2} kullanıcı adı ile sisteme kaydedildi.",
                customer.FirstName, customer.LastName, customer.NickName);
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine("{0} İsimli oyuncu bilgileri güncellendi.");
        }
    }
}

