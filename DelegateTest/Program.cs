using System;
using System.Data;

namespace DelegateTest
{
    class Program
    {/// <summary>
    /// put number less than 0 to simulate death.
    /// put -999 to exit the loop
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            int simulatedHP = 999;
            AssignsDelegateFunction assignFromHere = new AssignsDelegateFunction("yamete kudasai");
            ClassAssignedDelegateFunction getAssignedHere = new ClassAssignedDelegateFunction();
            while (simulatedHP != -999) {
                Int32.TryParse(Console.ReadLine(), out simulatedHP);
                getAssignedHere.ToBeAssigned += assignFromHere.PrintAThing;
                getAssignedHere.Update(simulatedHP);
                // logic for resetting for next "update"
                simulatedHP = 999; // "spawn" another thing that will "die" when HP is 0 or lower
                getAssignedHere.ToBeAssigned -= assignFromHere.PrintAThing; // removing because the way you have it it will infinitely tag on more actions if you did get it working
                //comment out above line and put in a number less than 1 a bunch of times and you'll see what i mean
            }
            Console.WriteLine("Goodbye, World!");
        }
    }
}
