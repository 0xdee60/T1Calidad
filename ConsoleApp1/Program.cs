using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaBolos sb = new SistemaBolos();
            sb.Iniciar();
            sb.Lanzar(10, 0, 1);
            sb.Lanzar(3, 2, 1);

            List<int> result = sb.CalcularPuntosPorJuego(1);

            foreach (var i in sb.juegos)
            {
                Console.WriteLine(i.puntos);
            }
            
        }
    }
}
