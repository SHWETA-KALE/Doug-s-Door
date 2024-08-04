using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dougs_Dog_Doors.Models
{
    internal class Remote
    {
        private DogDoor _door;
        public Remote(DogDoor door)
        {
            this._door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the btn.....");
            if (_door.IsOpen())
                _door.Close();
            else
                _door.Open();

        }
    }
}
