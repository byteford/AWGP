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
        WindowManager winManager;
        public ModuleType GetModuleType()
        {
            return ModuleType.Graphics;
        }

        public void Init()
        {
            winManager = new WindowManager();
            Console.WriteLine("Graphics Started");
        }

        public void Update()
        {
            winManager.Update();
        }

    }
}
