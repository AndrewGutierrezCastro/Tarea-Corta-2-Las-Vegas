using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemaNReinasLasVegas.Logica
{

    public static class ProblemaNReinas
    {
        public static List<List<int>> nReinas( int numeroReinas, int isLasVegas)
        {
            List<List<int>> resultado = new List<List<int>>();
            switch (isLasVegas)
            {
                case 0:
                    resolverNReinas(numeroReinas, 0, new List<int>(), resultado);
                    break;
                case 1:
                    resolverNReinasLasVegas(numeroReinas, 0, new List<int>(), resultado);
                    break;
                case 2:
                    resolverNReinasLasVegasFix(numeroReinas, 0, new List<int>(), resultado);
                    break;
            }
            return resultado;
        }

        private static void resolverNReinas(int numeroReinas, int fila, List<int> columnasPosiciones, List<List<int>> resultado)
        {
            if(fila == numeroReinas)
            {
                resultado.Add(columnasPosiciones.ToList<int>());
            }
            else
            {
                {/*Random rnd = new Random();
                columnasPosiciones.Add(rnd.Next(0, numeroReinas));
                if (cumpleSolucion(columnasPosiciones))
                {
                    resolverNReinas(numeroReinas, fila + 1, columnasPosiciones, resultado);
                }
                columnasPosiciones.Remove(columnasPosiciones.Count - 1);*/
                }
                for (int columnas = 0; columnas < numeroReinas; columnas++)
                {
                    columnasPosiciones.Add(columnas);
                    if (cumpleSolucion(columnasPosiciones))
                    {
                        resolverNReinas(numeroReinas, fila + 1, columnasPosiciones, resultado);
                        if(resultado.Count > 0)
                        {
                            return;
                        }
                    }
                    columnasPosiciones.RemoveAt(columnasPosiciones.Count - 1);
                }
            }
        }
        private static void resolverNReinasLasVegas(int numeroReinas, int fila, List<int> columnasPosiciones, List<List<int>> resultado)
        {
            if (fila == numeroReinas)
            {
                resultado.Add(columnasPosiciones.ToList<int>());
            }
            else
            {
                while (true)
                {
                    Random rnd = new Random();
                    columnasPosiciones.Add(rnd.Next(0, numeroReinas));
                    if (cumpleSolucion(columnasPosiciones))
                    {
                        resolverNReinasLasVegas(numeroReinas, fila + 1, columnasPosiciones, resultado);
                        break;
                    }
                    else
                    {
                        columnasPosiciones.RemoveAt(columnasPosiciones.Count - 1);
                    }
                }
            }
        }
        private static void resolverNReinasLasVegasFix(int numeroReinas, int fila, List<int> columnasPosiciones, List<List<int>> resultado)
        {
            if (fila == numeroReinas)
            {
                resultado.Add(columnasPosiciones.ToList<int>());
            }
            else
            {
                while (true)
                {
                    Random rnd = new Random();
                    List<int> lista = Enumerable.Range(0, numeroReinas + 1).ToList<int>();
                    int numero = lista.Shuffle().Take(1).ToArray<int>()[0];
                    lista.Remove(numero);
                    columnasPosiciones.Add(numero);
                    if (cumpleSolucion(columnasPosiciones))
                    {
                        resolverNReinasLasVegasFix(numeroReinas, fila + 1, columnasPosiciones, resultado);
                        break;
                    }
                    else
                    {
                        columnasPosiciones.RemoveAt(columnasPosiciones.Count - 1);
                    }
                }
            }
        }
        private static Boolean cumpleSolucion(List<int> columnasPosiciones)
        {
            int filaID = columnasPosiciones.Count - 1;
            for (int i = 0; i < filaID; i++)
            {
                int diferencia = Math.Abs(columnasPosiciones[i] - columnasPosiciones[filaID]);
                if(diferencia == 0 || diferencia == filaID - i)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
