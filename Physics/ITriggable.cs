using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Physics
{
    public interface ITriggable
    {
        void OnTrigger(object[] objs);
    }
}
