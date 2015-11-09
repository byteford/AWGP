using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Graphics
{
    class ShapeManager
    {
        List<Componates.Shape2DComp> Shapes;
        public static ShapeManager inst;
        public void RegisterComp(Componates.Shape2DComp comp)
        {
            if (!Shapes.Contains(comp))
            {
                Shapes.Add(comp);
            }
        }
        public void deRegisterComp(Componates.Shape2DComp comp)
        {
            if (Shapes.Contains(comp))
            {
                Shapes.Remove(comp);
            }

        }
    }
}
