using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BlinkByte.Core
{
    [System.Serializable]
    public class Vector2
    {
        public float X;
        public float Y;
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }
        public Vector2()
        {
            X = 0;
            Y = 0;
        }

        public static Vector2 ZERO()
        {
            return new Vector2(0, 0);
        }


    }
}
