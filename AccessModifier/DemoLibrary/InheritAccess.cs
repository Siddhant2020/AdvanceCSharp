using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    internal class InheritAccess : AccessDemo
    {
        private void CallAcessDemo()
        {
            ProtectedDemo();
            InternalDemo();
            ProtectedInternalDemo();
            PublicDemo();
            PrivateProtectedDemo();
            
        }

    }
}
