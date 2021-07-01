using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.AbstractClases 
{
    public abstract class GeeksForGeeks : ICloneable
    {
        /*public object Clone()
        {
            throw new NotImplementedException();
        }*/

        // abstract method 'gfgf()'
        public abstract void gfg();
        public abstract object Clone();
        public virtual string VirtualMethod()
        {
            return "we are in VirtualMethod";
        }


    }
}
