using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte;
using BlinkByte.Core;
using BlinkByte.Utilitys;
namespace MakeSceneFile
{
    class Program
    {
        static void Main(string[] args)
        {

            SetUp.Init();
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.SFMLGraphics.Graphics>(); // need to more to text
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.windowsInput.Input>();
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.StandardPhysics.Physics>();
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.SFMLSound.Sound>();
            // BlinkByte.Core.Managers.ModuleManager.instance.AddManager("SFMLGraphics.dll","BlinkByte.SFMLGraphics.Graphics");

            //BlinkByte.Core.IO.LoadFromFile.LoadModules("mods");

            BlinkByte.Core.Managers.ModuleManager.instance.Init();

            Scene scene = new BlinkByte.Core.Scene();
            GameObject go = GameObject.InstansateNew("GameObject");
            go.AddComponent<BlinkByte.SFMLGraphics.SFMLCircle2DComp>().changeColor(new BlinkByte.Graphics.Colour(255, 0, 0));
            (go.getComponent<BlinkByte.Core.Component.Transform>() as BlinkByte.Core.Component.Transform).Position = new Vector2(100, 0);
            scene.addGameObject(go);

            GameObject sp = GameObject.InstansateNew("Sprite");
            sp.AddComponent<BlinkByte.SFMLGraphics.SFMLSprite2DComp>().TextureName = "DinoTorq.png";
            sp.AddComponent<BlinkByte.StandardPhysics.StanMovementComp>().SetForce(new Vector2(2, 2));
            scene.addGameObject(sp);
            scene.saveToFile("Scene");
            BlinkByte.Core.IO.LoadFromFile.saveModules("mods");

        }
    }
}
