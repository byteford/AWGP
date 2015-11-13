using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Graphics
{
    public class ShapeManager
    {
        List<Componates.Shape2DComp> Shapes = new List<Componates.Shape2DComp>();
        public static ShapeManager inst;
        public ShapeManager()
        {
            inst = this;
        }
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
        public List<Componates.Shape2DComp> getShapes()
        {
            return Shapes;
        }
    }
}
