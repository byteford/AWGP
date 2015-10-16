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
            ModuleManager.instance.AddManager <Graphics.Graphics> (); // need to more to text
            ModuleManager.instance.Init();
            Core.SetUp.LoadScene("Scene");
            //Core.Scene.currentScene.GameObjects[0].AddComponent<Core.Component.FileOutputOnUpdate>();

            while (true)
            {
                Core.Scene.currentScene.Update();
            }
        }
    }
}
