using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Model
{
    // The Subject interface declares common operations for both RealSubject and the Proxy. 
    internal interface ISharedFolder
    {
        void PerformRWOperations();
    }
}
