using System;

namespace Wildlife
{
    class Plant
    {
        public delegate void Lifecycle();
        public event Lifecycle Notify;

        public Plant()
        {
            Notify += OnGrow;
        }

        private void OnGrow()
        {
            var herbnivore = new Herbivore();
            herbnivore.Eat();
        }

        public void Grow()
        {
            Console.WriteLine("Plant Grow");
            Notify?.Invoke();
        }
    }
}
