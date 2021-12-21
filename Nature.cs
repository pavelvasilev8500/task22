using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wildlife
{
     class Nature
    {
        Plant plant = new Plant();
        Herbivore herbivore = new Herbivore();
        Carnivore carnivore = new Carnivore();

        public Nature ()
        {
            plant.Grow();
            herbivore.Search();
            herbivore.Eat();
            carnivore.Hunt();
            carnivore.Eat();
        }
    }
}
