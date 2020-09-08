using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            Football theBall = new Football();
            Football theOtherBall = new Football();

            theBall.x = 100;
            
            System.Console.WriteLine(theOtherBall.x);

            Console.ReadLine();
        }
    }
}
