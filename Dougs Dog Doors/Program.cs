////using Dougs_Dog_Doors.Models;
//using System;
//using System.Linq.Expressions;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Dougs_Dog_Doors
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            DogDoor door = new DogDoor();
//            Remote remote = new Remote(door);

//            Console.WriteLine("Fido barks to go outside...........");
//            remote.PressButton();  //door opens

//            Console.WriteLine("Fido has gone Outside.......");

//            bool fidoReturned = false;

//            Thread fidoReturnThread = new Thread(() =>
//            {
//                try
//                {
//                    Thread.Sleep(5000); // Simulate Fido returning in 3 seconds
//                    fidoReturned = true;
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("An error occurred while simulating Fido's return: " + ex.Message);
//                }
//            });
//            fidoReturnThread.Start();

//            // Wait for the door to automatically close
//            //Thread.Sleep(5000);

//            fidoReturnThread.Join();


//            if (fidoReturned)
//            {
//                Console.WriteLine("Fido's all done");
//                Console.WriteLine("Fido's back inside");
//            }

//            else
//            {
//                Console.WriteLine("....but he is stuck outside!");
//                Console.WriteLine("Fido barks again or Fido scratches at the door......");
//                remote.PressButton();
//                //Console.WriteLine("DOor opens again......");
//                Console.WriteLine("Fido's all done");
//                Console.WriteLine("Fido's back inside");
//            }
//        }

//            //// bool fidoIsReturned = false;

//            //try
//            //{
//            //    await Task.Delay(10000);

//            //   // if (fidoIsReturned)
//            //    //{
//            //        //Console.WriteLine("....but he is stuck outside!");
//            //        //Console.WriteLine("Fido barks again or Fido scratches at the door......");
//            //        //remote.PressButton();
//            //        //Console.WriteLine("DOor opens again......");
//            //        Console.WriteLine("Fido's all done");
//            //        Console.WriteLine("Fido's back inside");
//            //    //}
//            //    //else
//            //    //{
//            //        //Console.WriteLine("Fido's all done");
//            //        //Console.WriteLine("Fido's back inside");
//            //   // }

//            //}
//            //catch (Exception ex)
//            //{
//            //    //Console.WriteLine("An error occured while operating the door");
//            //    //Console.WriteLine(ex.Message);
//            //    Console.WriteLine("....but he is stuck outside!");
//            //    Console.WriteLine("Fido barks again or Fido scratches at the door......");
//            //    remote.PressButton();
//            //    //Console.WriteLine("DOor opens again......");
//            //    Console.WriteLine("Fido's all done");
//            //    Console.WriteLine("Fido's back inside");
//            //}


//        }
//    }
//}

using Dougs_Dog_Doors.Models;

Remote remote = new Remote(new DogDoor());
Console.WriteLine("\nFido barks to go outside...");
remote.PressButton();
Console.WriteLine("\nFido has gone outside...");
//p1  remote.PressButton();
Console.WriteLine("\nFido's all done...");
//remote.PressButton();
try
{
    Thread.Sleep(10000);
}
catch (Exception ex) { }
Console.WriteLine("\n...But he's stuck outside!");
Console.WriteLine("\nFido barks to go inside...");
Console.WriteLine("\n...So Gina grabs the remote control.");
remote.PressButton();
Console.WriteLine("\nFido's back inside...");
remote.PressButton();

