using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    public interface IPlayerService
    {
        void Add(Players player);
        void Delete(Players player);
        void Update(Players player);
    }
}
