using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BlinkByte.Core.Module;

namespace BlinkByte.Physics
{
    public class Physics : BlinkByte.Core.Module.IModule
    {
        public ModuleType GetModuleType()
        {
            return ModuleType.Physics;
        }
        public void Init()
        {
            Console.WriteLine("Physics Started");
        }

        public void Update()
        {
            
        }
    }
}
