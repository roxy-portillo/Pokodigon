using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_P2
{
    class Game
    {

        public Random RNG = new Random();

        public int Turn()
        {
            return RNG.Next(2);
        }

    }
}
