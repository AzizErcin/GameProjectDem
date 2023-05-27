using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    public interface IGameBuy
    {
        void Add(Game games);
        void Delete(Game games);
        void Uptade(Game games);
    }
}
