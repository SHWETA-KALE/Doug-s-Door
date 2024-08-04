using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dougs_Dog_Doors.Models
{
    internal class DogDoor
    {
        private bool open;

        public DogDoor()
        {
            open = false;
        }

        public void Open()
        {
            Console.WriteLine("Door is open");
            open = true;
        }

        public void Close()
        {
            Console.WriteLine("Door is close");
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }

    }
}
