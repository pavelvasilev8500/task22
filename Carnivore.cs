using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wildlife
{
    class Carnivore
    {
        delegate void CarnivoreLifecycle(string message);
        event CarnivoreLifecycle Notify;

        public Carnivore()
        {
            Notify += Carnivore_Notify;
            Random rnd = new Random();
            int state = rnd.Next(2);
            if (state == 0)
                Hunt();
            else if (state == 1)
                Eat();
        }

        private void Carnivore_Notify(string message)
        {
            Console.WriteLine(message);
        }


        public void Hunt()
        {
            Notify?.Invoke("Hunt on herbnivore");
        }

        public void Eat()
        {
            Notify?.Invoke("Eat herbnivore");
        }
    }
}
