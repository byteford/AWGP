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
        public static SFML.System.Vector2f convert(this Vector2 vect)
        {
            return new SFML.System.Vector2f(vect.X,vect.Y);
        }

    }
}
