using System;

namespace FillSpheres
{  
    class Program
    {
        static void Main(string[] args)
        {
            
            Color c=new Color(43,43,54);
            Sphere s=new Sphere(c,4.5f);
            Console.WriteLine($"Color:{c.GetRed()},{c.GetGreen()},{c.GetBlue()}");
            Console.WriteLine($"TimesThrown:{s.GetTimesThrown()}");
            s.Throw();
            s.Throw();
            Console.WriteLine($"TimesThrown:{s.GetTimesThrown()}");
            s.Pop();
            s.Throw();
            Console.WriteLine($"TimesThrown:{s.GetTimesThrown()}");

              
            
        }
    }

}
