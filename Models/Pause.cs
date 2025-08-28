using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoCodProprio.Models
{
    public static class Pause
    {
        public static void Wait()
        {
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}