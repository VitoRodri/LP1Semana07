using System;

namespace BetterFillSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private float raio;
        private int number;

        public Sphere(Color color, float raio)
        {
            this.color=color;
            this.raio=raio;
            number=0;
        }

        public void Pop()
        {
            raio=0;
        }
        public void Throw()
        {
            if (raio>0)
            {
                number++;
            }
        }
        public int GetTimesThrown()
        {
            return number;
        }



    }
}