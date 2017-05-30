using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Material
{
    public class Copper : IMaterial
    {
        public string Describe { get { return "銅"; } }

        public int Price { get { return 30; } }
    }
}
