using System;
using System.Collections.Generic;


namespace EjerciciosPOO_P2
{
    class Machine : Pokemon
    {
        int option;
        public override void Fight(Pokemon user, Pokemon enemy)
        {
            if (user.Life > 0)
            {
                option = RNG.Next(1, 3);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nMaquina Usando: {0} Valor:{1}", user.Attack1, user.A1Value);
                        enemy.Life -= user.A1Value;
                        Console.WriteLine("Vida restante de {0}: {1}", enemy.Name, enemy.Life);
                        break;
                    case 2:
                        Console.WriteLine("\nMaquina Usando: {0} Valor:{1}", user.Attack2, user.A2Value);
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
                return true;
            }
        }
    }
}
