using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Graphics.Componates;
using BlinkByte.Utilitys;
namespace BlinkByte.SFMLGraphics
{
    public class Graphics: BlinkByte.Graphics.IGraphics
    {
        WindowManager winManager;
        BlinkByte.Graphics.ShapeManager shapeManager;
        public Core.Module.ModuleType GetModuleType()
        {
            return Core.Module.ModuleType.Graphics;
        }

        public void Init()
        {
            winManager = new WindowManager();
            shapeManager = new BlinkByte.Graphics.ShapeManager();
            Console.WriteLine("Graphics Started");
        }

        public void Update()
        {
            winManager.UpdateEvents();
            winManager.ClearWindow();
           foreach(var shape in shapeManager.getShapes())
            {
                shape.Draw();
            }
            winManager.displayWindow();
        }

    }
}
