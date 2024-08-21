using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PokemonTrainer
{
    public class Trainer
    {
        public Trainer()
        {

        }
        public Trainer(string name)
        {
            Name = name;
            this.NumberOfBadges = 0;
            Pokemons = new List<Pokemon>();
        }

        public string Name {  get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
