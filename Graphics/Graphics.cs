using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core.Module;

namespace BlinkByte.Graphics
{
    public class Graphics : BlinkByte.Core.Module.IModule
    {
        public ModuleType GetModuleType()
        {
            return ModuleType.Graphics;
        }

        public void Init()
        {
            
            Console.WriteLine("Graphics Started");
        }
    }
}
