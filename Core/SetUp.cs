using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core
{
    public class SetUp
    {
        public static void Init()
        {
            Scene scene = new Scene();
            scene.addGameObject("GameObject");
            scene.saveToFile();
            
             //IO.LoadFromFile.LoadFile("GameObject");
            //IO.LoadFromFile.SaveFile("GameObject");
            try
            {
                IO.LoadFromFile.LoadFile("GameObject");
            }
            catch (FileNotFoundException e)
            {
                IO.LoadFromFile.SaveFile("GameObject");
                IO.LoadFromFile.LoadFile("GameObject");
            }
           new Managers.ModuleManager();
        }
    }
}
