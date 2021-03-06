﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_P2
{
    class Water : Pokemon
    {
        public Water(string name)
        {
            Name = name;
            Type = "Water";
            Attack1 = "Water Gun";
            Attack2 = "Surf";
            A1Value = RNG.Next(15, 66);
            A2Value = RNG.Next(15, 66);
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3}\n{4}: {5}\nLife: {6}", Name, Type, Attack1, A1Value, Attack2, A2Value, Life);
        }

    }
}
