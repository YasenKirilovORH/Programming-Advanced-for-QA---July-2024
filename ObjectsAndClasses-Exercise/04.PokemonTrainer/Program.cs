namespace _04.PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                string[] traineerAndPokemonInformation = input.Split(" ").ToArray();

                string traineerName = traineerAndPokemonInformation[0];

                Pokemon currentPokemon = new Pokemon(traineerAndPokemonInformation[1], traineerAndPokemonInformation[2], int.Parse(traineerAndPokemonInformation[3]));

                bool trainerExist = false;
                Trainer existingTrainer = new Trainer();


                foreach (Trainer trainer in trainers)
                {
                    if (traineerName == trainer.Name)
                    {
                        trainerExist = true;
                        existingTrainer = trainer;
                    }
                }

                if (trainerExist)
                {
                    existingTrainer.Pokemons.Add(currentPokemon);
                }
                else
                {
                    Trainer currentTrainer = new Trainer(traineerName);
                    currentTrainer.Pokemons.Add(currentPokemon);
                    trainers.Add(currentTrainer);
                }


                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    bool hasPokemon = false;

                    foreach (Pokemon pokemon in trainers[i].Pokemons)
                    {
                        if (command == pokemon.Element) 
                        {
                            hasPokemon = true;
                        } 
                    }

                    if (hasPokemon)
                    {
                        trainers[i].NumberOfBadges++;
                    }
                    else
                    {
                        trainers[i].Pokemons.ForEach(p => { p.Health -= 10; });
                    }

                    trainers[i].Pokemons.RemoveAll(x => x.Health <= 0);
                }


                command = Console.ReadLine();
            }

            List<Trainer> sortedList = trainers.OrderByDescending(x => x.NumberOfBadges).ToList();
            foreach (Trainer trainer in sortedList)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
