using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
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
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager<BlinkByte.LewisGame.Core>();

            

            //BlinkByte.Core.IO.LoadFromFile.LoadModules("mods");

            BlinkByte.Core.Managers.ModuleManager.instance.Init();

            Scene scene = new BlinkByte.Core.Scene();

            ///GameObject text = GameObject.InstansateNew("Text");
          //  text.AddComponent<BlinkByte.SFMLGraphics.SFMLTextComp>().SetText("YAY");
          //  scene.addGameObject(text);

            GameObject go = GameObject.InstansateNew("GameObject");
            (go.AddComponent<BlinkByte.SFMLGraphics.SFMLCircle2DComp>().changeColor(new BlinkByte.Graphics.Colour(255, 0, 0)) as BlinkByte.SFMLGraphics.SFMLCircle2DComp).radius = 50;
            (go.getComponent<BlinkByte.Core.Component.Transform>() as BlinkByte.Core.Component.Transform).Position = new Vector2(250, 250);
            go.AddComponent<BlinkByte.StandardPhysics.StanBoundingBox>().SetMinMax(new Vector2(0, 0), new Vector2(100, 100));
         
            go.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>();
            go.AddComponent<BlinkByte.LewisGame.GameComp>();
            
          
            scene.addGameObject(go);

            GameObject bm = GameObject.InstansateNew("background");
            bm.AddComponent<BlinkByte.SFMLSound.SFMLSoundComp>().setFileName("Audios/toot.wav");
            (bm.AddComponent<BlinkByte.SFMLGraphics.SFMLCircle2DComp>().changeColor(new BlinkByte.Graphics.Colour(0, 255, 0)) as BlinkByte.SFMLGraphics.SFMLCircle2DComp).radius = 50;
            (bm.getComponent<BlinkByte.Core.Component.Transform>() as BlinkByte.Core.Component.Transform).Position = new Vector2(50, 50);
            bm.AddComponent<BlinkByte.StandardPhysics.StanBoundingBox>().SetMinMax(new Vector2(0, 0), new Vector2(100, 100));
            bm.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>();
            scene.addGameObject(bm);

            GameObject bc = GameObject.InstansateNew("ballcolour");
            
            (bc.AddComponent<BlinkByte.SFMLGraphics.SFMLCircle2DComp>().changeColor(new BlinkByte.Graphics.Colour(0, 125, 125)) as BlinkByte.SFMLGraphics.SFMLCircle2DComp).radius = 50;
            (bc.getComponent<BlinkByte.Core.Component.Transform>() as BlinkByte.Core.Component.Transform).Position = new Vector2(550, 50);
            bc.AddComponent<BlinkByte.StandardPhysics.StanBoundingBox>().SetMinMax(new Vector2(0, 0), new Vector2(100, 100));
            bc.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>();
         
            
            scene.addGameObject(bc);
           ;

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
