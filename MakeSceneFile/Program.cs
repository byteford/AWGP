using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte;
using BlinkByte.Core;
namespace MakeSceneFile
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUp.Init();
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.SFMLGraphics.Graphics>(); // need to more to text
            BlinkByte.Core.Managers.ModuleManager.instance.Init();

            Scene scene = new BlinkByte.Core.Scene();
            GameObject go = GameObject.Instansate("GameObject");
            go.AddComponent<BlinkByte.Core.Component.Transform>();
            go.AddComponent<BlinkByte.SFMLGraphics.SFMLCircle2DComp>();
            scene.addGameObject(go);
            scene.saveToFile();
        }
    }
}
