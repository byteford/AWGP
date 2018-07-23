using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Graphics.Componates
{
    public class Square2DComp: Shape2DComp
    {
        public int height, width;
        public Square2DComp() 
            : base()
        {
            shape = shapeType.Square;
        }
        public override void Draw()
        {
        }
    }
}
