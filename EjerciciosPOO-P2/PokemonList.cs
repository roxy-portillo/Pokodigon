using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_P2
{
    class PokemonList
    {
        Electric e1 = new Electric("Pikachu");
        Electric e2 = new Electric("Jolteon");
        Water w1 = new Water("Squirtle");
        Water w2 = new Water("Vaporeon");
        Fire f1 = new Fire("Charizard");
        Fire f2 = new Fire("Flareon");
        Grass g1 = new Grass("Bulbasaur");
        Grass g2 = new Grass("Oddish");
        Rock r1 = new Rock("Onix");
        Rock r2 = new Rock("Geodude");
        Ground gr1 = new Ground("Cubone");
        Ground gr2 = new Ground("Sandshrew");
        Flying fl1 = new Flying("Pidgey");
        Flying fl2 = new Flying("Spearow");
        Ghost gh1 = new Ghost("Hunter");
        Ghost gh2 = new Ghost("Gengar");
        Psychic p1 = new Psychic("Psyduck");
        Psychic p2 = new Psychic("Hypno");
        Normal n1 = new Normal("Rattata");
        Normal n2 = new Normal("Eevee");

        public List<Pokemon> AddPokemon()
        {
            List<Pokemon> list = new List<Pokemon>();
            list.Add(e1);
            list.Add(e2);
            list.Add(w1);
            list.Add(w2);
            list.Add(f1);
            list.Add(f2);
            list.Add(g1);
            list.Add(g2);
            list.Add(r1);
            list.Add(r2);
            list.Add(gr1);
            list.Add(gr2);
            list.Add(fl1);
            list.Add(fl2);
            list.Add(gh1);
            list.Add(gh2);
            list.Add(p1);
            list.Add(p2);
            list.Add(n1);
            list.Add(n2);
            return list;
        }

        public List<Pokemon> randomPokemon(List<Pokemon> list)
        {
            Random RNG = new Random();
            int rand;
            List<Pokemon> fightingPokemons = new List<Pokemon>();
            for (int i = 0; i < 6; i++)
            {
                rand = RNG.Next(0, list.Count - 1);
                fightingPokemons.Add(list[rand]);
                list.Remove(list[rand]);
            }

            return fightingPokemons;
        }
        public void PrintPokemonList(List<Pokemon> list)
        {
            foreach (Pokemon p in list)
            {
                Console.WriteLine(p);
                Console.Write("\n");
            }
        }
    }
}

