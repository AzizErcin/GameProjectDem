using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public interface ICampaingService
    {
        void Add(ICampaingService campaingService);
        void Delete(ICampaingService campaingService);
        void Uptade(ICampaingService campaingService);
    }
}
