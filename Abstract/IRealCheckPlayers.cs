using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Concrete;

namespace GameProjectDemo.Abstract
{
    public interface IRealCheckPlayers
    {
        bool Check(PlayerManager players);
        

        
    }
}
