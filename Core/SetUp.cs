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
                //scene.addGameObject("GameObject");
                scene.addGameObject(GameObject.Instansate("GameObject")).AddComponent<Component.Transform>();
                scene.saveToFile();
            }
           // scene.GameObjects[0].AddComponent<Component.FileOutput>();
            /*   try
               {
                   IO.LoadFromFile.LoadFile("GameObject");
               }
               catch (FileNotFoundException e)
               {

                   IO.LoadFromFile.SaveFile("GameObject", new GameObject());
                   IO.LoadFromFile.LoadFile("GameObject");
               }*/
        }
    }
}
