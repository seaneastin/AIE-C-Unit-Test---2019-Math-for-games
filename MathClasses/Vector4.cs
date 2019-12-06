using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x, y, z, w;

        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public override string ToString()
        {
            return "{ " + x + ", " + y + "," + z + "," + w + "}";
        }
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        }
        public static Vector4 operator /(float number, Vector4 rhs)
        {
            return new Vector4(number / rhs.x, number / rhs.y, number / rhs.z, number / rhs.w);
        }
        public static Vector4 operator /(Vector4 lhs, float number)
        {
            return new Vector4(lhs.x / number, lhs.y / number, lhs.z / number, lhs.w / number);
        }
        public static Vector4 operator *(float number, Vector4 rhs)
        {
            return new Vector4(number * rhs.x, number * rhs.y, number * rhs.z, number + rhs.w);
        }
        public static Vector4 operator *(Vector4 lhs, float number)
        {
            return new Vector4(lhs.x * number, lhs.y * number, lhs.z * number, lhs.w + number);
        }


        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z * w);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }

        public float Distance(Vector4 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
        }

        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
            this.w /= m;
        }

        public Vector4 GetNormalised()
        {
            return (this / Magnitude());
        }
        public float Dot(Vector4 other)
        {
            return ((x * other.x) + (y * other.y) + (z * other.z) + (w * other.w));
        }
        public Vector4 Cross(Vector4 other)
        {
            return new Vector4(y * other.z - z * other.y, z * other.x - x * other.z, x * other.y - y * other.x, 0);
        }

    }
}
