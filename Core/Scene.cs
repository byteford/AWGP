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

        public List<GameObject> GameObjects;
        public Scene()
        {
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

    }
}
