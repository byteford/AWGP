using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Graphics.Shapes
{
    class Circle: Shape
    {
        float radius;
        public Circle(Core.Vector2 pos, float radius)
            : base(pos)
        {
            this.radius = radius;
        }
    }
}
