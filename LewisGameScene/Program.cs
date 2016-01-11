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
            string gameName = "Lewis";


            SetUp.Init();
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.SFMLGraphics.Graphics>(); // need to more to text
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.SFMLInput.Input>();
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.StandardPhysics.Physics>();
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.SFMLSound.SFMLSoundManager>();
            // BlinkByte.Core.Managers.ModuleManager.instance.AddManager("SFMLGraphics.dll","BlinkByte.SFMLGraphics.Graphics");

            //BlinkByte.Core.IO.LoadFromFile.LoadModules("mods");

            BlinkByte.Core.Managers.ModuleManager.instance.Init();

            Scene scene = new BlinkByte.Core.Scene();

            GameObject text = GameObject.InstansateNew("Text");
            text.AddComponent<BlinkByte.SFMLGraphics.SFMLTextComp>().SetText("YAY");
            scene.addGameObject(text);

            GameObject go = GameObject.InstansateNew("GameObject");
            (go.AddComponent<BlinkByte.SFMLGraphics.SFMLCircle2DComp>().changeColor(new BlinkByte.Graphics.Colour(255, 0, 0)) as BlinkByte.SFMLGraphics.SFMLCircle2DComp).radius = 50;
            (go.getComponent<BlinkByte.Core.Component.Transform>() as BlinkByte.Core.Component.Transform).Position = new Vector2(250, 250);
            go.AddComponent<BlinkByte.StandardPhysics.StanBoundingBox>().SetMinMax(new Vector2(0, 0), new Vector2(100, 100));
            go.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>().SetVelocity(new Vector2(0, -0.2f));
            go.AddComponent<BlinkByte.Physics.GravityComp>();
            scene.addGameObject(go);
            go.AddComponent<BlinkByte.SFMLSound.SFMLSoundComp>().setFileName("Audios/boom.wav");
            (go.getComponent<BlinkByte.SFMLSound.SFMLSoundComp>()as BlinkByte.SFMLSound.SFMLSoundComp).loopSound(true);
           
            
            // go.AddComponent < BlinkByte.Input.Input.ButtonDown; 
                
                //GameObject sp = GameObject.InstansateNew("Sprite");
            //sp.AddComponent<BlinkByte.SFMLGraphics.SFMLSprite2DComp>().TextureName = "DinoTorq.png";
            //sp.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>();
           

            //sp.getComponent<BlinkByte.Core.Component.Transform>() as BlinkByte.Core.Component.Transform).Position = new Vector2(300, 250);
            //sp.AddComponent<BlinkByte.StandardPhysics.StanBoundingBox>();
            //scene.addGameObject(sp);

            GameObject wallTop = GameObject.InstansateNew("Top Wall");
            wallTop.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>().startCollision = false;
            wallTop.AddComponent<BlinkByte.StandardPhysics.StanBoundingBox>().SetMinMax(new Vector2(0, -10), new Vector2(800, 0));
            scene.addGameObject(wallTop);

            GameObject wallLeft = GameObject.InstansateNew("Left Wall");
            wallLeft.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>().startCollision = false;
            wallLeft.AddComponent<BlinkByte.StandardPhysics.StanBoundingBox>().SetMinMax(new Vector2(-10, 0), new Vector2(0, 600));
            scene.addGameObject(wallLeft);

            GameObject wallRight = GameObject.InstansateNew("Right Wall");
            wallRight.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>().startCollision = false;
            wallRight.AddComponent<BlinkByte.StandardPhysics.StanBoundingBox>().SetMinMax(new Vector2(800, 0), new Vector2(800, 600));
            scene.addGameObject(wallRight);

            GameObject wallBottom = GameObject.InstansateNew("Bottom Wall");
            wallBottom.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>().startCollision = false;
            wallBottom.AddComponent<BlinkByte.StandardPhysics.StanBoundingBox>().SetMinMax(new Vector2(0, 600), new Vector2(800, 600));
            scene.addGameObject(wallBottom);

            scene.saveToFile(gameName + "/Scene");
            BlinkByte.Core.IO.LoadFromFile.saveModules(gameName +"/mods");

        }
    }
}
