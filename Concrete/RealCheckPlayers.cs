using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;

namespace GameProjectDemo.Concrete
{
    public class RealCheckPlayers:IRealCheckPlayers
    {
        public bool Check(PlayerManager players)
        {
            return true;
        }
    }
}
