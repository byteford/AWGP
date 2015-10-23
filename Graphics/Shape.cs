using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Graphics
{
    public class Shape
    {
        Core.Vector2 position;
        Colour Colour;
        public Shape(Core.Vector2 pos, Colour col)
        {
            position = pos;
            Colour = col;
        }
    }
}
