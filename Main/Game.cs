using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Main
{
   
    class Game
    {
        ModuleManager moduleMan;
        public Game()
        {
            init();
        }
        public void init()
        {
            Console.WriteLine("Game SetUp");
            moduleMan = new ModuleManager();
            moduleMan.AddManager(new BlinkByte.Graphics.Graphics()); // need to more to text
            moduleMan.Init();
        }
    }
}
