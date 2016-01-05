using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using BlinkByte.Utilitys;
namespace BlinkByte.Core.Component
{
    [System.Serializable]
    
    public class Transform: Component
    {
        public Vector2 Position;
        public Vector2 Scale = new Vector2(1,1);
        public float Rotation;
        public Transform()
        {
            Position = new Vector2(); 
        }

        
    }
}
