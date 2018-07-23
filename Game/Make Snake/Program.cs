using System;
using BlinkByte.Core;
using BlinkByte.Core.Managers;
using BlinkByte.Core.IO;
using BlinkByte.SFMLGraphics;
using BlinkByte.Snake;
using BlinkByte.SFMLInput;
namespace Make_Sanke
{
    class Program
    {
        static void Main(string[] args)
        {
            string gameName = "Test";
            //runs core setUp code
            SetUp.Init();
            //adds the needed modules
            ModuleManager.instance.AddManager<Graphics>(); //graphics module
            ModuleManager.instance.AddManager<BlinkByte.Snake.Core>();
            ModuleManager.instance.AddManager<Input>();
            //set up the modules
            ModuleManager.instance.Init();

            //create a new scene
            Scene scene = new Scene();

            //set up a text object
            GameObject text = GameObject.InstansateNew("Text");
            text.AddComponent<SFMLTextComp>().SetText("YAY");
            scene.addGameObject(text);
            GameObject snake = GameObject.InstansateNew("Snake");
            snake.AddComponent<SFMLSquare2DComp>().setSize(20, 20);
            snake.AddComponent<SnakeComp>();
            scene.addGameObject(snake);
            //saves the scene
            scene.saveToFile("snake/Scene");
            //saves the mods
            LoadFromFile.saveModules("snake/mods");

        }
    }
}