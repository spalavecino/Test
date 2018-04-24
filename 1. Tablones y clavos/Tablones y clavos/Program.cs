using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablones_y_clavos
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int Solution(int[] A, int[] B, int N, int[] C, int M)
        {
            int clavosNecesarios = 0;
            bool sePuedeClavar;

            for (int k = 0; k < N; k++)
            {
                sePuedeClavar = false;

                for (int i = 0; i < M; i++)
                {
                    if (clavosNecesarios == i)
                    {
                        clavosNecesarios++;
                    }

                    if (A[k] <= C[i] && C[i] <= B[k])
                    {
                        sePuedeClavar = true;
                        break;
                    }
                }

                if (!sePuedeClavar)
                {
                    clavosNecesarios = -1;
                    break;
                }
            }

            return clavosNecesarios;
        }

    }
}
