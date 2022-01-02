using System;

namespace Wildlife
{
    class Herbivore
    {
        public delegate void Lifecycle();
        public event Lifecycle Notify;

        public Herbivore()
        {
            Notify += OnEat;
        }

        private void OnEat()
        {
            var carnivore = new Carnivore();
            carnivore.Eat();
        }

        public void Eat()
        {
            Console.WriteLine("Herbnivore eat plant");
            Notify?.Invoke();
        }
    }
}
