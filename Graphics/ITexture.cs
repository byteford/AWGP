using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Graphics
{
    public interface ITexture
    {
        void loadTexture(string filename);
        object getFile();

    }
}
