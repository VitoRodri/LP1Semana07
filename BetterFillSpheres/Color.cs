using System;

namespace BetterFillSpheres
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
            this.a=a;
        }
        public Color(byte r, byte g, byte b)
        {
            this.r=r;
            this.g=g;
            this.b=b;
            a=255;
        }

        public byte R{get; set;}
        public byte G{get; set;}
        public byte B{get; set;}
        public byte A{get; set;}

        public void GetGrey()
        {
            r=255/2;
            g=255/2;
            b=255/2;
            a=255;

        }
        
    }  
}