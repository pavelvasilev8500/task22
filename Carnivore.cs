using System;

namespace Wildlife
{
    class Carnivore
    {

        public Carnivore()
        {
            var plant = new Plant();
            plant.Notify += Carnivore_Notify;
            Carnivore_Notify("Carnivore");
        }

        private void Carnivore_Notify(string message)
        {
            Console.WriteLine(message);
            Hunt();
            Eat();
        }

        public void Hunt()
        {
            Console.WriteLine("Hunt on herbnivore");
        }

        public void Eat()
        {
            Console.WriteLine("Eat herbnivore");
        }
    }
}
