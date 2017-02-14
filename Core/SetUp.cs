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
        /// <summary>
        /// Run first to Set Everything up
        /// </summary>
        public static void Init()
        {
           
           new Managers.ModuleManager();
        }
        /// <summary>
        /// loads the scene in to the engine
        /// </summary>
        /// <param name="name"> The relitive location of the xml file</param>
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
