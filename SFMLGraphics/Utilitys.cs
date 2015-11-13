using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Utilitys
{
    public static class Utilitys
    {
        public static SFML.Graphics.Color convert(this BlinkByte.Graphics.Colour col)
        {
            return new SFML.Graphics.Color(col.R, col.G, col.B, col.A);
        }
        public static void Draw(this BlinkByte.Graphics.Componates.Shape2DComp comp, SFML.Graphics.RenderWindow wind)
        {
            if(comp.shape == Graphics.Componates.shapeType.Circle)
            {
                SFML.Graphics.CircleShape shape = new SFML.Graphics.CircleShape(50);
                wind.Draw(shape);
            }
        }
        
    }
}
