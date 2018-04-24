using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Anagramas
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "hola, que buena ola Laomir";
            string otraCadena = "OAL";

            int cantidadDeAnagramas = Solucion(cadena, otraCadena);

            Console.WriteLine("{0}", cantidadDeAnagramas);
            Console.ReadKey();
        }

        static int Solucion(string A, string B)
        {
            string cadenaA = (A.ToLower()).Replace(" ", string.Empty).Replace(",", string.Empty).Replace("!", string.Empty).Replace("¡", string.Empty).Replace("?", string.Empty).Replace("¿", string.Empty);
            string cadenaB = (B.ToLower()).Replace(" ", string.Empty).Replace(",", string.Empty).Replace("!", string.Empty).Replace("¡", string.Empty).Replace("?", string.Empty).Replace("¿", string.Empty);
            string subcadena;
            int cantAnagramas = 0;

            char [] caracteresOrdenados = cadenaB.ToArray();
            char[] subcadenaOrdenada;
            Array.Sort(caracteresOrdenados);

            cadenaB = new string (caracteresOrdenados);

            for (int i = 0; i < (cadenaA.Length - cadenaB.Length); i++)
            {
                subcadena = cadenaA.Substring(i, cadenaB.Length);
                subcadenaOrdenada = subcadena.ToArray();
                Array.Sort(subcadenaOrdenada);
                subcadena = new string(subcadenaOrdenada);

                if (cadenaB == subcadena) {
                    cantAnagramas++;
                    i += 2;
                }
            }

            return cantAnagramas;
        }
    }
}
