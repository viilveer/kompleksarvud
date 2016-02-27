using System;
using System.Numerics;

namespace kompleksarvud
{
    class Sisend
    {
        public static Complex KompleksArv()
        {
            Console.WriteLine("Sisesta reaalarv.");
            double reaalarv = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sisesta imaginaarArv.");
            double imaginaarArv = Convert.ToDouble(Console.ReadLine());

            return new Complex(reaalarv, imaginaarArv);
        }

        public static Complex Tehe(Complex a, Complex b)
        {
            Console.WriteLine("liida või lahuta.");
            string tehe = Console.ReadLine();
            Tehted tehted = new Tehted();
            
            switch (tehe.ToLower())
            {
                case "liida":
                    return tehted.add(a, b);
                    break;
                case "lahuta":
                    return tehted.substract(a, b);
                    break;
                default:
                    throw  new Exception("pole sellist tehet");
            }
        }
    }
}
