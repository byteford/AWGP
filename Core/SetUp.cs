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
            Scene scene;
            try
            {
                scene = IO.LoadFromFile.LoadFile<Scene>("Scene");
            }
            catch
            {

                scene = new Scene();
                //scene.addGameObject("GameObject");
                scene.addGameObject(GameObject.Instansate("GameObject")).AddComponent<Component.Transform>();
                scene.saveToFile();
            }

         /*   try
            {
                IO.LoadFromFile.LoadFile("GameObject");
            }
            catch (FileNotFoundException e)
            {
                
                IO.LoadFromFile.SaveFile("GameObject", new GameObject());
                IO.LoadFromFile.LoadFile("GameObject");
            }*/
           new Managers.ModuleManager();
        }
    }
}
