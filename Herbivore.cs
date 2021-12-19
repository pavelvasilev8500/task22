using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wildlife
{
    class Herbivore
    {
        delegate void HerbivoreLifecycle(string message);
        event HerbivoreLifecycle Notify;

        public Herbivore()
        {
            Notify += Herbivore_Notify;
            Random rnd = new Random();
            int state = rnd.Next(2);
            if (state == 0)
                Search();
            else if (state == 1)
                Eat();
        }

        private void Herbivore_Notify(string message)
        {
            Console.WriteLine(message);
        }

        public void Search()
        {
            Notify?.Invoke("Serch for plant");
        }

        public void Eat()
        {
            Notify?.Invoke("Eat plant");
        }
    }
}
