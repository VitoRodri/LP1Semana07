using System;

namespace FillSpheres
{

    public class Color
    {
        private byte r;
        private byte g;
        private byte b;
        private byte a;

        public Color(byte r, byte g, byte b, byte a)
        {
            this.r=r;
            this.g=g;
            this.b=b;
            this.a=a,

        }
        public Color(byte r, byte g, byte b)
        {
            this.r=r;
            this.g=g;
            this.b=b;
            a=255;
        }

        public byte GetRed()
        {
            return r;
        }
        public byte GetGreen()
        {
            return g;
        }
        public byte GetBlue()
        {
            return b;
        }
        public byte GetAlpha()
        {
            return a;
        }
        public void SetRed(byte r)
        {
            this.r=r;
        }
        public void SetGreen(byte g)
        {
            this.g=g;
        }
        public void SetBlue(byte b)
        {
            this.b=b;
        }
        public void SetAlpha(byte a)
        {
            this.a=a;
        }

        public void GetGrey()
        {
            r=255/2;
            g=255/2;
            b=255/2;
            a=255;

        }
        
    }  
}