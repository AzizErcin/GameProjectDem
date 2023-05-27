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
    public class PlayerManager:IPlayerService
    {
        public void Add(Players player)
        {
            Console.WriteLine(player.FirstName + "The player has been added.");
        }

        public void Delete(Players player)
        {
            Console.WriteLine(player.FirstName + "The player has been deleted.");
        }

        public void Update(Players player)
        {
            Console.WriteLine(player.FirstName + "The player has been uptaded.");
        }
    }
}
