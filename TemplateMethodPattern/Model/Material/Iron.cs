using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Material
{
    public class Iron : IMaterial
    {
        public string Describe { get { return "鐵"; } }

        public int Price { get { return 50; } }
    }
}
