using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sell(Product product, Customer customer, Campaign campaign, Sale sale)
        {

            Console.WriteLine("Satış yapıldı");
        }

        public void Cancel(Product product, Customer customer, Campaign campaign, Sale sale)
        {
            Console.WriteLine("Satış İptal Edildi");
        }

        public void GetAll(List<Sale> saleList)
        {
            
                //if (sales.Count == 0)
                //{
                //    Console.WriteLine("Satış Yok");
                //}
                //else
                //{
                    foreach (var sale in saleList)
                    {
                Console.WriteLine("\nSipariş No: " + sale.OrderNumber.ToString() + 
                    "\n Oyuncu Kimliği :"+ sale.NickName + 
                    "\n Oyun Adı :" + sale.ProductName + 
                    "\n Kampanya Adı :" + sale.CampaignName +
                    "\n İndirim Mikarı :" + sale.DiscountRate +
                    "\n Ürün Fiyatı :" + (sale.ProductPrice - ((sale.ProductPrice*sale.DiscountRate)/100)) );
            }
                //}
                
            
        }

    }
}
