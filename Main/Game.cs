using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core.Managers;
namespace BlinkByte.Main
{
   
    class Game
    {
        public Game()
        {
            init();
        }
        public void init()
        {
            Console.WriteLine("Game SetUp");
            Core.SetUp.Init();

            Console.WriteLine("what game so you want to run?");
            string input = Console.ReadLine();

            BlinkByte.Core.IO.LoadFromFile.LoadModules(input + "/mods");
            
            ModuleManager.instance.Init();
            Core.SetUp.LoadScene(input + "/Scene");

            while (true)
            {
                ModuleManager.instance.Update();
                Core.Scene.currentScene.Update();
            }
        }
    }
}
