using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BlinkByte.Utilitys
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
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            Vector2 temp = new Vector2();
            temp.X = a.X + b.X;
            temp.Y = a.Y + b.Y;

            return temp;
        }
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            Vector2 temp = new Vector2();
            temp.X = a.X - b.X;
            temp.Y = a.Y - b.Y;
            return temp;
        }

        public static Vector2 operator *(Vector2 a, float b)
        {
            return new Vector2(a.X * b, a.Y * b);
        }
        public static Vector2 operator *(float b, Vector2 a)
        {
            return new Vector2(a.X * b, a.X * b);
        }
        public static float operator *(Vector2 a,Vector2 b)
        {
            return DotProduct(a, b);
        }
        public static Vector2 operator /(Vector2 a, float b)
        {
            return new Vector2(a.X / b, a.Y / b);
        }
        public static float DotProduct(Vector2 a, Vector2 b)
        {
            float dotProduct = (a.X * b.X) + (a.Y * b.Y);
            return dotProduct;
        }

        public float DotProduct(Vector2 b)
        {
            return DotProduct(this, b);
        }

        public Vector2 Normalise()
        {
            float temp = Length();
            return new Vector2(X / Length(), Y / Length());
        }
        public float Length()
        {            
            return (float)Math.Sqrt(X * X + Y * Y);
        }
    }
}
