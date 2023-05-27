using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            Players player = new Players();
            player.FirstName = "Aziz";
            player.LastName = "Erçin";
            player.DateOfBirth = (1994, 09, 29);
            player.NationalityID = "11111111111";

            Game games = new Game();
            games.GameName = "World of Warcraft";
            games.GamePrice = 10;

            Campaing campaing = new Campaing();
            campaing.CampaingName = "Discount Games";
            campaing.CampaingId = 1;
            campaing.DiscountRate = 50;

            Console.ReadLine();
            

        }
        

      
    }
}
