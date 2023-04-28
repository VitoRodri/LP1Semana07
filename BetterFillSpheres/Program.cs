using System;

namespace BetterFillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color c=new Color(43,43,54);
            Sphere s=new Sphere(c,4.5f);
            
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
