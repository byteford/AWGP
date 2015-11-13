using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Graphics.Componates
{
    public enum shapeType
    {
        Circle,
        Square,
    }
    public class Shape2DComp: BlinkByte.Graphics.Componates.GraphicsComp
    {
        public shapeType shape;
        public Shape2DComp()
        {
            ShapeManager.inst.RegisterComp(this);
        }
        public virtual void Draw() { }
    }

}
