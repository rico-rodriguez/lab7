using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Carrier : Boat
    {
        public Carrier(bool inIsDocked, bool inIsEmbarked, int inCapacity) : base(inIsDocked, inIsEmbarked, inCapacity)
        {
            
        }

    }
}
