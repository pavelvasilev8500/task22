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
        }

        private void Herbivore_Notify(string message)
        {
            Console.WriteLine(message);
        }

        public void Search()
        {
            Notify?.Invoke("Herbnivore serch for plant");
        }

        public void Eat()
        {
            Notify?.Invoke("Herbnivore eat plant");
        }
    }
}
