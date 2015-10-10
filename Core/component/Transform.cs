using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BlinkByte.Core.Component
{
    [System.Serializable]
    public class Transform: Component
    {
        public Vector3 Position;
        public Transform()
        {
            Position = new Vector3(); 
        }

        
    }
}
