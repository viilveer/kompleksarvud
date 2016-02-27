using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace kompleksarvud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esimene");
            Complex esimene = Sisend.KompleksArv();
            Console.WriteLine("Teine");
            Complex teine = Sisend.KompleksArv();

            Console.WriteLine(Sisend.Tehe(esimene, teine).ToString());
        }
    }
}
