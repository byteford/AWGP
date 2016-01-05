using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.StandardPhysics
{
    public class Physics : BlinkByte.Physics.IPhysics
    {
        public Core.Module.ModuleType GetModuleType()
        {
            return Core.Module.ModuleType.Physics;
        }
        public void Init()
        {
            Console.WriteLine("Physics Started");
        }

        public virtual void Update()
        {

        }
    }
}
