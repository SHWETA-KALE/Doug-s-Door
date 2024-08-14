using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Dougs_Dog_Doors.Models
{
    internal class Remote
    {
        private DogDoor _door;
        private Timer _timer;
        public Remote(DogDoor door)
        {
            this._door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote btn.....");
            if (_door.IsOpen())
                _door.Close();
            else
                _door.Open();
           
            StartTimer();
        }

        public void StartTimer()
        {
             _timer = new Timer(5000);
            _timer.Elapsed += TimerEvent;
            _timer.AutoReset = false;  //timer will not reset until remote btn is pressed
            _timer.Enabled = true;  //start the timer

        }

        public void TimerEvent(object source, EventArgs e) {
            _door.Close();
            _timer.Dispose();
        }

       
    }
}
