using System;

namespace Wildlife
{
    class Herbivore
    {
        public Herbivore()
        {
            var plant = new Plant();
            plant.Notify += Plant_Notify;
            Plant_Notify("Herbnivore serch for plant");
            Plant_Notify("Herbnivore eat plant");
        }

        private void Plant_Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
