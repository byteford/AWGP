using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            BlinkByte.Core.SetUp.Init();
            BlinkByte.Core.Managers.ModuleManager.instance.AddManager(new BlinkByte.Graphics.Graphics()); // need to more to text
            BlinkByte.Core.Managers.ModuleManager.instance.Init();
        }
    }
}
