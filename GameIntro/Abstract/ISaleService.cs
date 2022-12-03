using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    public interface ISaleService
    {
        void Sell(Product product, Customer customer, Campaign campaign, Sale sale);
        void Cancel(Product product, Customer customer, Campaign campaign, Sale sale);
        void GetAll(List<Sale> saleList);
    }
}
