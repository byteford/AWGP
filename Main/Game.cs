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
            ModuleManager.instance.AddManager <BlinkByte.SFMLGraphics.Graphics> (); // need to move to text
            ModuleManager.instance.Init();
            Core.SetUp.LoadScene("Scene");

            while (true)
            {
                ModuleManager.instance.Update();
                Core.Scene.currentScene.Update();
            }
        }
    }
}
