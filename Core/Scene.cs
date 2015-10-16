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
        List<GameObject> GameObjects;
        public Scene()
        {
            GameObjects = new List<GameObject>();
        }
        public void addGameObject(string name)
        {
            GameObjects.Add(GameObject.Instansate(name));
        }
        public void saveToFile()
        {
            IO.LoadFromFile.SaveScene("Scene", this);
        }

    }
}
