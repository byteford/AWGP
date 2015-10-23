using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.SFMLGraphics
{
    public class Graphics: BlinkByte.Graphics.IGraphics
    {
        WindowManager winManager;
        public Core.Module.ModuleType GetModuleType()
        {
            return Core.Module.ModuleType.Graphics;
        }

        public void Init()
        {
            winManager = new WindowManager();
            Console.WriteLine("Graphics Started");
        }

        public void Update()
        {
            winManager.UpdateEvents();
            winManager.ClearWindow();
           
            winManager.displayWindow();
        }
    }
}
