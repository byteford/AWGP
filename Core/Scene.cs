using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core
{
    [System.Serializable]
    public class Scene
    {
        public static Scene currentScene;
        public List<GameObject> GameObjects;
        public Scene()
        {
            currentScene = this;
            GameObjects = new List<GameObject>();
        }
        /*public GameObject addGameObject(string name)
        {
            GameObject temp = GameObject.Instansate(name);
            GameObjects.Add(temp);
            return temp;
        }*/
        public GameObject addGameObject(GameObject obj)
        {
            GameObjects.Add(obj);
            return obj;
        }
        public void saveToFile()
        {
            IO.LoadFromFile.SaveFile("Scene", this);
        }
        public void Update()
        {
            foreach( GameObject go in GameObjects)
            {
                go.Update();
            }
        }

    }
}
