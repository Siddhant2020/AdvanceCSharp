using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {
        private int test;
        private void Demo()
        {
            PrivateDemo();
        }

        private void PrivateDemo()  // Can be Called within the Class only
        {
            
        }

        private protected void PrivateProtectedDemo()   // Can be Called by the derived class within the same assembly
        {

        }

        protected void ProtectedDemo()  // Can be called by derived classes (same / different assemblies)
        {

        }

        protected internal void ProtectedInternalDemo() // can be called by derived/non-derived classes within the same assembly and by derived classes from different assembly
        {

        }

        internal void InternalDemo()    // can be called within an assembly (derived / non-derived both)
        {

        }

        public void PublicDemo()    // can be called by anywhere
        {
            

        }
    }
}
