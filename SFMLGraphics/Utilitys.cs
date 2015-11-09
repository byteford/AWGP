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
        
    }
}
