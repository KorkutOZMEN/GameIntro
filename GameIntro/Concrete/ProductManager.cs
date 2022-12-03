using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class ProductManager : IProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine("{0} isimli oyun {1} TL tutar ile listeye eklendi. ",product.ProductName, product.ProductPrice);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("{0} isimli oyun listeden silindi. ", product.ProductName);
        }

        public void GetAll(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine("Oyun ismi : {0} -> Oyun Tutarı : {1} ", product.ProductName, product.ProductPrice);
            }
        }

        public void Update(Product product)
        {
            Console.WriteLine("{} isimli oyun {1} TL tutar ile güncellendi. ", product.ProductName, product.ProductPrice);
        }
    }
}
