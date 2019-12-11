using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Color
    {
        public UInt32 color;

        public Color(byte r, byte g, byte b, byte a)
        {
            color += (UInt32)r << 24; //color red
            color += (UInt32)g << 16; //color green
            color += (UInt32)b << 8; //color blue
            color += (UInt32)a;
        }

        public Color()
        {
            color = 0;
        }

        public void SetRed(byte r)
        {
            color = (UInt32)r << 24;
        }

        public void SetGreen(byte g)
        {
            color = (UInt32)g << 16;
        }


        public byte GetAlpha()
        {
            return (byte)color;
        }

        public byte GetBlue()
        {
            UInt32 othercolor = color >> 8;

            return (byte)othercolor;
        }


        public byte GetGreen()
        {
            UInt32 othercolor = color >> 16;

            return (byte)othercolor;
        }

        public byte GetRed()
        {
            UInt32 othercolor = color >> 24;

            return (byte)othercolor;
        }

        public void SetAlpha(byte a)
        {
            color = (UInt32)a;
        }

        public void SetBlue(byte b)
        {
            color += (UInt32)b << 8;
        }






    }
}
