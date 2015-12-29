using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core.Factory
{
    public class GameObjectFactory: IFactory
    {
        public static GameObject makeGameObject(string name)
        {
            GameObject tempGO;
            try {
                tempGO = IO.LoadFromFile.LoadFile<GameObject>(name);
            }
            catch
            {
                tempGO = new GameObject();
                tempGO.name = name;
                tempGO.AddComponent<BlinkByte.Core.Component.Transform>();
                IO.LoadFromFile.SaveFile(name, tempGO);
            }

            return tempGO;
        }
        public static List<Component.Component> setUpGameObject()
        {
            List<Component.Component> comp = new List<Component.Component>();
            
            return comp;
        }
    }
}
