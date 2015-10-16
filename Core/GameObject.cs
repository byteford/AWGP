using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlinkByte.Core
{
    [System.Serializable]
   // [XmlInclude(typeof(Component.Transform)), XmlInclude(typeof(Component.FileOutput))]
        public class GameObject
    {
        public string name;
        public List<Core.Component.Component> components;
       // [System.NonSerialized]
       // public Core.Component.Transform transform;
        public GameObject()
        {
            if(components == null)
            {
               components =  Factory.GameObjectFactory.setUpGameObject();
            }
        }
        public virtual void Update()
        {
            foreach(Component.Component comp in components)
            {
                comp.Update();
            }
        }
        public static GameObject Instansate(string name)
        {
            return BlinkByte.Core.Factory.GameObjectFactory.makeGameObject(name);
        }
        public T AddComponent<T>()
        {
            T temp = (T)Activator.CreateInstance(typeof(T));
            if((temp as Component.Component) != null)
            {
                components.Add(temp as Component.Component);
                IO.LoadFromFile.SaveFile(name, this);
                return temp;
            }
            return default(T);
        }
    }
}
