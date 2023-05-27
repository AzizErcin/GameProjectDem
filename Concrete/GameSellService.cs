using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class GameSellService:IGameBuy
    {
        public void Add(Game games)
        {
            Console.WriteLine(games.GameName + "The game has been added");
        }

        public void Delete(Game games)
        {
            Console.WriteLine(games.GameName + "The game has been deleted");
        }

        public void Uptade(Game games)
        {
            Console.WriteLine(games.GameName + "The game has been uptaded");
        }
    }
}
