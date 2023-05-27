using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;

namespace GameProjectDemo.Entities
{
    public class Players
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public (int, int, int) DateOfBirth { get; set; }
        public string NationalityID { get; set; }

     }
}
