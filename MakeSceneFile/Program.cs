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
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.SFMLInput.Input>();
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.StandardPhysics.Physics>();
            // BlinkByte.Core.Managers.ModuleManager.instance.AddManager("SFMLGraphics.dll","BlinkByte.SFMLGraphics.Graphics");

            //BlinkByte.Core.IO.LoadFromFile.LoadModules("mods");

            BlinkByte.Core.Managers.ModuleManager.instance.Init();

            Scene scene = new BlinkByte.Core.Scene();
            GameObject go = GameObject.InstansateNew("GameObject");
            (go.AddComponent<BlinkByte.SFMLGraphics.SFMLCircle2DComp>().changeColor(new BlinkByte.Graphics.Colour(255, 0, 0)) as BlinkByte.SFMLGraphics.SFMLCircle2DComp).radius = 50;
            (go.getComponent<BlinkByte.Core.Component.Transform>() as BlinkByte.Core.Component.Transform).Position = new Vector2(100, 0);
            go.AddComponent<BlinkByte.StandardPhysics.StanCircleBounding>().radius= 30;
            go.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>();
            scene.addGameObject(go);
        

            GameObject sp = GameObject.InstansateNew("Sprite");
            sp.AddComponent<BlinkByte.SFMLGraphics.SFMLSprite2DComp>().TextureName = "DinoTorq.png";
            sp.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>();
            sp.AddComponent<BlinkByte.StandardPhysics.StanCircleBounding>().radius = 60;
            scene.addGameObject(sp);
            scene.saveToFile("Scene");
            BlinkByte.Core.IO.LoadFromFile.saveModules("mods");

        }
    }
}
