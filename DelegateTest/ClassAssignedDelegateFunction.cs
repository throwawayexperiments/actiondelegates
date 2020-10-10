using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace DelegateTest
{
    class ClassAssignedDelegateFunction
    {
        public ClassAssignedDelegateFunction()
        {
            this.ToBeAssigned = null;
            this.fakeHP = 100;
        }


        public System.Action ToBeAssigned;
        int fakeHP;

        /// <summary>
        ///  fake update to simulate unity? idk i don't use it. runs function that will check if it has to run the delegate function
        /// </summary>
        public void Update(int updatedHP)
        {
            fakeHP = updatedHP;
            CheckIfRunDelegateFunction();
        }

        /// <summary>
        /// Because you nested the delegate action in another function like this iirc
        /// </summary>
        protected void CheckIfRunDelegateFunction()
        {
            if(fakeHP <= 0) ToBeAssigned();
        }
    }
}