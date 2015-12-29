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
        static Scene scene;
        public static void Init()
        {
           
           new Managers.ModuleManager();
        }
        public static void LoadScene(string name)
        {
            try
            {
                scene = IO.LoadFromFile.LoadFile<Scene>(name);
                
            }
            catch(Exception e)
            {
                scene = new Scene();
                scene.saveToFile(name);
            }
            scene.Start();
        }
    }
}
