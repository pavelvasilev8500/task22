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

        private bool Access { get; set; } = true;

        public Plant()
        {
            Notify += Plant_Notify;
        }

        private void Plant_Notify(string message)
        {
            Console.WriteLine(message);
        }

        public void Grow()
        {
            Notify?.Invoke("Palnt Grow");
        }
    }
}
