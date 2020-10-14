using System;
using System.Collections.Generic;

namespace EjerciciosPOO_P2
{
    class User : Pokemon
    {
        public override void Fight(Pokemon user, Pokemon enemy)
        {

            if (user.Life > 0)
            {
                Console.WriteLine("\n Elegir ataque:\n 1. {0}: {1}\n 2. {2}: {3}", user.Attack1, user.A1Value, user.Attack2, user.A2Value);
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Usando: {0} Valor:{1}", user.Attack1, user.A1Value);
                        enemy.Life -= user.A1Value;
                        Console.WriteLine("Vida restante de {0}: {1}", enemy.Name, enemy.Life);
                        break;

                    case "2":
                        Console.WriteLine("Usando: {0} Valor:{1}", user.Attack2, user.A2Value);
                        enemy.Life -= user.A2Value;
                        Console.WriteLine("Vida restante de {0}: {1}", enemy.Name, enemy.Life);
                        break;
                }
            }
        }

        public override Boolean Catch(Pokemon enemy, List<Pokemon> myPokemons, List<Pokemon> enemyPokemons)
        {
            int rand = RNG.Next(0, 2);
            if (rand == 0)
            {
                Console.WriteLine("No se pudo atrapar");
                enemy.Life = 150;
                return false;
            }
            else
            {
                myPokemons.Add(enemy);
                enemyPokemons.Remove(enemy);
                Console.WriteLine("Se atrapo exitosamente");
                enemy.Life = 150;
                return true;
            }
        }
    }
}
