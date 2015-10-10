using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core.Component
{
   public class Component
    {
        public GameObject gameObject;
        public Transform transform { get { return gameObject.transform; } }
    }
}
