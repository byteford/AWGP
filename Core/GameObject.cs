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
        public virtual void Start()
        {
                foreach (Component.Component comp in components)
                            {
                                comp.Start(this);
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

        public static GameObject InstansateNew(string name)
        {
            return BlinkByte.Core.Factory.GameObjectFactory.MakeNewGameObject(name);
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
        public List<BlinkByte.Core.Component.Component> getComponents<T>()
        {
           //List<BlinkByte.Core.Component.Component> temp = components.Where(x => x.GetType() == typeof(T)).ToList();
            List<BlinkByte.Core.Component.Component> temp = components.Where(x => typeof(T).IsAssignableFrom(x.GetType())).ToList();
            return temp;
        }
        public BlinkByte.Core.Component.Component getComponent<T>()
        {
            if(getComponents<T>() == null || getComponents<T>().Count ==0)
            {
                return null;
            }
            return getComponents<T>().First();
        }
        public BlinkByte.Core.Component.Transform GetTransform()
        {
            return getComponent<BlinkByte.Core.Component.Transform>() as BlinkByte.Core.Component.Transform;
        }
    }
}
