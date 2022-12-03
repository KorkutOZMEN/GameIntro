using GameIntro.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Entities
{
    public class Sale : IEntity
    {
        public int OrderNumber { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string NickName { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }
        
    }
}
