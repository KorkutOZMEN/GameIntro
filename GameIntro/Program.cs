using GameIntro.Abstract;
using GameIntro.Adapters;
using GameIntro.Concrete;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            ProductManager productManager = new ProductManager();
            CampaignManager campaignManager = new CampaignManager();
            SaleManager saleManager = new SaleManager();

            //(Başarılı kyıt işlemini görebilmek için customer1 veya customer2
            //için doğru kimlik bilgilerinizi giriniz.)
            //(Enter the correct credentials for customer1 or customer2 to
            //see the successful registration process.)

            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.NickName = "Yapay Zaka";
            customer1.FirstName = "Deneme";
            customer1.LastName = "Yanılma";
            customer1.DateOfBirth = new DateTime(2012, 12, 12);
            customer1.NationalityId = "0123456789";



            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.NickName = "Korkut";
            customer2.FirstName = "Resul";
            customer2.LastName = "ÖZMEN";
            customer2.DateOfBirth = new DateTime(1991, 09, 24);
            customer2.NationalityId = "00000000000";

            //-------------------------------------------------------------

            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "FİFA 2022";
            product1.ProductPrice = 350;

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Counter Strike";
            product2.ProductPrice = 100;

            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductName = "PUBG";
            product3.ProductPrice = 350;

            //-------------------------------------------------------------

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Black Friday";
            campaign1.DiscountRate = 20;
            campaign1.CampaingSituation = false;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 2;
            campaign2.CampaignName = "Kazançlı Günler";
            campaign2.DiscountRate = 10;
            campaign2.CampaingSituation = false;

            Campaign campaign3 = new Campaign();
            campaign3.CampaignId = 3;
            campaign3.CampaignName = "Yeni Yıl İndirimi";
            campaign3.DiscountRate = 15;
            campaign3.CampaingSituation = true;

            //-------------------------------------------------------------

            Console.WriteLine("\n---- Operasyonlar ----\n");


            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.WriteLine("\n-----------------------------\n");

            productManager.Add(product1);
            productManager.Add(product2);
            productManager.Add(product3);

            Console.WriteLine("\n-----------------------------\n");

            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            Console.WriteLine("\n-------------------------------------------------------------\n \n-------------------------------------------------------------");

            Console.WriteLine("\n---- Oyuncu Listesi ----\n");

            List < Customer> customers = new List<Customer> {customer1, customer2};

            customerManager.GetAll(customers);


            Console.WriteLine("\n---- Oyun Listesi ----\n");

            List<Product> products = new List<Product> {product1, product2, product3};

            productManager.GetAll(products);

            Console.WriteLine("\n---- Kampanya Listesi ----\n");

            List<Campaign> campaigns = new List<Campaign> {campaign1, campaign2, campaign3};

            campaignManager.GetAll(campaigns);


            //------------------------------


            Sale sale1 = new Sale();
            sale1.OrderNumber = 12;
            sale1.ProductName = product2.ProductName;
            sale1.ProductPrice = product2.ProductPrice;
            sale1.NickName = customer2.NickName;

            if (campaign2.CampaingSituation == false)
            {
                sale1.CampaignName = "Geçerli Kampanya yok";
                sale1.DiscountRate = 0;
            }
            else if(campaign2.CampaingSituation == true)
            {
                sale1.CampaignName = campaign2.CampaignName;
                sale1.DiscountRate = campaign2.DiscountRate;
            }


            Sale sale2 = new Sale();
            sale2.OrderNumber = 13;
            sale2.ProductName = product3.ProductName;
            sale2.ProductPrice = product3.ProductPrice;
            sale2.NickName = customer2.NickName;

            if (campaign3.CampaingSituation == false)
            {
                sale2.CampaignName = "Geçerli Kampanya yok";
                sale2.DiscountRate = 0;
            }
            else if(campaign3.CampaingSituation == true)
            {
                sale2.CampaignName = campaign3.CampaignName;
                sale2.DiscountRate = campaign3.DiscountRate;
            }


            Console.WriteLine("\n---- Satış Listesi ----\n");

            List<Sale> saleList= new List<Sale> ();

            saleList.Add(sale1);
            saleList.Add(sale2);

            saleManager.GetAll(saleList);

            Console.ReadLine();

        }
    }
}
