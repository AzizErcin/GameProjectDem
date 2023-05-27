using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class CampaingService:ICampaingService
    {
        public void Add(ICampaingService campaingService)
        {
            Console.WriteLine("Camping has been added");
        }

        public void Delete(ICampaingService campaingService)
        {
            Console.WriteLine("Camping has been deleted");
        }

        public void Uptade(ICampaingService service)
        {
            Console.WriteLine("Campaing has been uptaded.");
        }
    }
}
