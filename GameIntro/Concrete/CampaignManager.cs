using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntro.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            if (campaign.CampaingSituation == true)
            {
                Console.WriteLine("{0} isimli kampanya %{1} indirim oradnıyla listeye aklendi. Kampanya durumu : AKTİF "
                    ,campaign.CampaignName, campaign.DiscountRate);
            }
            else
            {
                Console.WriteLine("{0} isimli kampanya %{1} indirim oradnıyla listeye aklendi. Kampanya durumu : PASİF "
                    , campaign.CampaignName, campaign.DiscountRate);
            }
            
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Listeden silindi");
        }

        public void GetAll(List<Campaign> campaigns)
        {
            foreach (var campaign in campaigns)
            {
                if (campaign.CampaingSituation == true)
                {
                    Console.WriteLine("        ********\n" + "- Kampanya ismi : " + campaign.CampaignName + "\n- Kampanya Oranı : ½" + campaign.DiscountRate + "\n- Kampanya Durumu : AKTİF ");
                }
                else
                {
                    Console.WriteLine("        ********\n" + "- Kampanya ismi : " + campaign.CampaignName + "\n- Kampanya Oranı : ½" + campaign.DiscountRate + "\n- Kampanya Durumu : PASİF ");
                }
                
            }
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya bilgileri güncelledi !");
        }
    }
}
