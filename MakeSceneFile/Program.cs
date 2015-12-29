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
            GameObject go = GameObject.InstansateNew("GameObject");
            go.AddComponent<BlinkByte.SFMLGraphics.SFMLCircle2DComp>().changeColor(new BlinkByte.Graphics.Colour(255, 0, 0));
            (go.getComponent<BlinkByte.Core.Component.Transform>() as BlinkByte.Core.Component.Transform).Position = new Vector2(100, 0);
            scene.addGameObject(go);

            GameObject sp = GameObject.InstansateNew("Sprite");
            sp.AddComponent<BlinkByte.SFMLGraphics.SFMLSprite2DComp>().TextureName = "DinoTorq.png";
            scene.addGameObject(sp);
            scene.saveToFile();
        }
    }
}
