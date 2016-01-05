using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinkbyte.Sound
{
    public interface ISoundsManager
    {
        void loadSound(string filename);
        object getFile();
    }
}
