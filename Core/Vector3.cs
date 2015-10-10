using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BlinkByte.Core
{
    [System.Serializable]
    public class Vector3
    {
        public float X;
        public float Y;
        public float Z;
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Vector3()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Vector3 (float x, float y)
        {
            X = x;
            Y = y;
            Z = 0;
        }

        public static Vector3 ZERO()
        {
            return new Vector3(0, 0, 0);
        }


    }
}
