using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_32_02_iida
{
    abstract class Surface
    {
        abstract public float GetSurface();
        abstract public float GetCircumference();
        abstract public void GetBounds(out float height, out float width);
    }
}
