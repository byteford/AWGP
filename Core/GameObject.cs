using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core
{
    [System.Serializable]
    public class GameObject
    {
        public List<Core.Component.Component> components;
        [System.NonSerialized]
        public Core.Component.Transform transform;
        public GameObject()
        {
            components = new List<Component.Component>();
        }
        public virtual void Update()
        {
            foreach(Component.Component comp in components)
            {
                comp.Update();
            }
        }
    }
}
