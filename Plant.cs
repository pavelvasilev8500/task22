using System;

namespace Wildlife
{
    class Plant
    {
        public delegate void Lifecycle(string message);
        public event Lifecycle Notify;

        public Plant()
        {
            Notify += Plant_Lifecicle;
            Plant_Lifecicle("Grow");
        }

        private void Plant_Lifecicle(string message)
        {
            Console.WriteLine(message);
        }
    }
}
