using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Model
{
    //The RealSubject contains some core business logic.
    internal class SharedFolder : ISharedFolder
    {
        public void PerformRWOperations()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }

    }
}
