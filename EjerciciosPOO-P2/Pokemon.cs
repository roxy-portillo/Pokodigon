using System;
using System.Collections.Generic;

namespace EjerciciosPOO_P2
{
    class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public int Life = 150;
        public string Attack1 { get; set; }
        public int A1Value { get; set; }
        public string Attack2 { get; set; }
        public int A2Value { get; set; }

        public static Random RNG = new Random();

        public virtual Boolean Catch(Pokemon enemy, List<Pokemon> myPokemons, List<Pokemon> enemyPokemons)
        {
            return true;
        }

        public virtual void Fight(Pokemon user, Pokemon enemy)
        {

        }
    }
}
