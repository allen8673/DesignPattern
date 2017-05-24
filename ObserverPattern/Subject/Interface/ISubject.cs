using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject.Interface
{
    public interface ISubject
    {
        void RegisterObserver(IOberserver o);
        void RemoveObserver(IOberserver o);
        void NotifyObserver();
    }
}
