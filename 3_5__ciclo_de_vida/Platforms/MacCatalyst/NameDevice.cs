using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5__ciclo_de_vida
{
    public partial class NameDevice
    {
        public partial string GetName()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
