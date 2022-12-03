using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        void GetAll(List<Product> products);

    }
}
