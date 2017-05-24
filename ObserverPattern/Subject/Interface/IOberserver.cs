using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject.Interface
{
    public interface IOberserver
    {
        void Update(int temperature, int pressure, int humidity);
    }
}
