using System;
using System.Collections.Generic;


namespace EjerciciosPOO_P2
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Pokodigon");
            Random RNG = new Random();
            PokemonList pl = new PokemonList();
            List<Pokemon> list = pl.AddPokemon();
            List<Pokemon> listOfPokemons = pl.randomPokemon(list);
            Pokemon userPokemon = listOfPokemons[5];
            listOfPokemons.RemoveAt(5);
            Pokemon machine = listOfPokemons[RNG.Next(listOfPokemons.Count)];
            //pl.PrintPokemonList(listOfPokemons);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Tu pokemon es:\n");
            Console.WriteLine(userPokemon);
            Console.WriteLine(".............................");

            List<Pokemon> userPokemons = new List<Pokemon>();
            userPokemons.Add(userPokemon);
            Game game = new Game();
            User player = new User();
            Machine PC = new Machine();
            int turn1;
            Boolean battleFinished = false;
            Boolean gameOver = false;

            while (gameOver != true)
            {
                while (battleFinished != true)
                {
                    turn1 = game.Turn();
                    if (turn1 == 0)
                    {
                        if (userPokemon.Life > 0)
                        {   //Primer turno usuario
                            if (userPokemons.Count > 1)
                            {
                                Console.WriteLine("Elige tu Pokemon para luchar");
                                foreach (Pokemon p in userPokemons)
                                {
                                    Console.WriteLine("{0}. {1}\n", userPokemons.IndexOf(p) + 1, p.Name);
                                }
                                string pc = Console.ReadLine();
                                userPokemon = userPokemons[(int.Parse(pc) - 1)];
                            }
                            Console.WriteLine("\nEs tu turno: {0}\nNivel de vida: {1}", userPokemon.Name, userPokemon.Life);
                            player.Fight(userPokemon, machine);
                            if (machine.Life > 0)
                            {
                                PC.Fight(machine, userPokemon);
                                if (userPokemon.Life <= 0)
                                {
                                    Console.WriteLine("\nFuiste derrotado\nIntentando atrapar {0}...", userPokemon.Name);
                                    bool catched = PC.Catch(userPokemon, listOfPokemons, userPokemons);
                                    battleFinished = true;
                                    if (catched == true)
                                    {
                                        gameOver = true;
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Juego Terminado\n");
                                        Console.WriteLine("Presiona cualquier tecla para volver a jugar");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Main();
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nHas derrotado a tu adversario\nIntentando atraparlo...");
                                bool catched = player.Catch(machine, userPokemons, listOfPokemons);
                                battleFinished = true;
                                if (userPokemons.Count == 6)
                                {
                                    Console.WriteLine("Felicitaciones! Has atrapado todos los Pokemon\n");
                                    gameOver = true;
                                    Main();
                                }
                                break;
                            }
                        }
                        Console.WriteLine("****************************************");
                    }
                    else
                    {
                        if (machine.Life > 0)
                        { //Primer turno maquina
                            Console.WriteLine("\nEs el turno de: {0}\nNivel de vida: {1}", machine.Name, machine.Life);
                            PC.Fight(machine, userPokemon);
                            if (userPokemon.Life > 0)
                            {
                                Console.Write("\n{0}", userPokemon.Name);
                                player.Fight(userPokemon, machine);
                                if (machine.Life <= 0)
                                {
                                    Console.WriteLine("\nHas derrotado a tu adversario\nIntentando atraparlo...");
                                    bool catched = player.Catch(machine, userPokemons, listOfPokemons);
                                    battleFinished = true;
                                    if (userPokemons.Count == 6)
                                    {
                                        Console.WriteLine("Felicitaciones! Has atrapado todos los Pokemon\n");
                                        gameOver = true;
                                        Main();
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nFuiste derrotado\nIntentando atrapar {0}...", userPokemon.Name);
                                bool catched = PC.Catch(userPokemon, listOfPokemons, userPokemons);
                                battleFinished = true;
                                if (catched == true)
                                {
                                    gameOver = true;
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Juego Terminado\n");
                                    Console.WriteLine("Presiona cualquier tecla para volver a jugar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Main();
                                }
                                break;
                            }
                        }
                        Console.WriteLine("****************************************");
                    }
                }
                string nextBattle = "";
                if (battleFinished && gameOver != true)
                {
                    if (userPokemons.Count > 0)
                    {
                        Console.WriteLine("\nSiguiente Batalla \nPresiona 1 para continuar\nPresiona 2 para volver a comenzar\nPresiona cualquier tecla para finalizar");
                        nextBattle = Console.ReadLine();
                        if (nextBattle == "2")
                        {
                            Main();
                        }
                        else if (nextBattle != "1")
                        {
                            gameOver = true;
                        }
                        machine = listOfPokemons[RNG.Next(listOfPokemons.Count)];
                        battleFinished = false;
                    }
                }
            }
            Console.WriteLine("Resultados:\n");
            Console.WriteLine("Equipo Contrincante:\n");
            pl.PrintPokemonList(listOfPokemons);
            Console.WriteLine("///////////////////////////");
            Console.WriteLine("Equipo Usuario:\n");
            pl.PrintPokemonList(userPokemons);
        }
    }
}



