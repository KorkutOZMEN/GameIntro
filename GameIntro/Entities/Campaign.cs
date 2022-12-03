using GameIntro.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Entities
{
    public class Campaign : IEntity
    {
        public int CampaignId { get; set; }
        public bool CampaingSituation { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }
    }
}
