using Dougs_Dog_Doors.Models;

namespace Dougs_Dog_Doors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...........");
            remote.PressButton();
            Console.WriteLine("\n Fido has gone Outside.......");
            remote.PressButton();
            Console.WriteLine("\n Fido's all done");
            remote.PressButton();
            Console.WriteLine("\n Fido's back inside");
            remote.PressButton();
        }
    }
}
