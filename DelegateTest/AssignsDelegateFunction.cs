using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTest
{
    class AssignsDelegateFunction
    {
        //constructors because I wanted to check if action delegates could print a var i could change or if it had to be hard coded
        public AssignsDelegateFunction()
        {
            this.aThing = "something";
        }
        public AssignsDelegateFunction(string thingToPrint)
        {
            this.aThing = thingToPrint;
        }




        private string aThing;

        /// <summary>
        /// the thing that will get passed as the value to the action delegate in ClassAssignedDelegateFunction
        /// </summary>
        public void PrintAThing()
        {
            Console.WriteLine(aThing);
        }
    }
}
