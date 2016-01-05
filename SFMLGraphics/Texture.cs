using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Graphics;

namespace BlinkByte.SFMLGraphics
{
    class Texture : ITexture
    {
        SFML.Graphics.Texture texture;
        public object getFile()
        {
            return texture;
        }

        public void loadTexture(string filename)
        {
            texture = new SFML.Graphics.Texture(filename);
        }
    }
}
