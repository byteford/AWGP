using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core.Component
{
    [System.Serializable]
   public class Component
    {
        [System.NonSerialized]
        public GameObject gameObject;
        public Transform transform { get { return gameObject.transform; } }
        public virtual void Update() { }
    }
}
