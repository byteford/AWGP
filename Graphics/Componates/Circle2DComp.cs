using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Graphics.Componates
{
    public class Circle2DComp: Shape2DComp
    {
        public float radius;
        public Circle2DComp()
            : base()
        {
            shape = shapeType.Circle;
        }
        public override void Draw() { }
    }
}
