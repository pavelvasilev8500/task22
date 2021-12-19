using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wildlife
{
    class Plant
    {
        delegate void PlantLifecycle(string message);
        event PlantLifecycle Notify;

        public Plant()
        {
            Notify += Plant_Notify;
            Random rnd = new Random();
            int state = rnd.Next(2);
            if (state == 0)
                Grow();
            else if (state == 1)
                Eat();
        }

        private void Plant_Notify(string message)
        {
            Console.WriteLine(message);
        }

        private void Eat()
        {
            Notify?.Invoke("Plant eaten by herbivore");
        }

        private void Grow()
        {
            Notify?.Invoke("Palnt Grow");
        }
    }
}
