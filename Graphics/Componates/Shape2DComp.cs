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
    }
    class Shape2DComp: BlinkByte.Graphics.Componates.GraphicsComp
    {
        public shapeType shape;
        public Shape2DComp()
        {

        }
    }

}
