using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arreglos
{
    class Program
    {

        int[] calif = new int[5];
        int acum = 0, prom = 0;
        int mayor;
        public void promedio()
        {

            Console.WriteLine("Ingrese 5 calificaciones");
            for (int i = 0; i < 5; i++)
            {
                calif[i] = Convert.ToInt32(Console.ReadLine());

                acum = acum + calif[i];
                prom = acum / 5;

                mayor = calif[0];
                if (mayor < calif[i])
                {
                    mayor = calif[i];
                }

            }

            Console.WriteLine("Promedio: " + prom);
            Console.WriteLine("La mayor calificacion es: " + mayor);



        }


        static void Main(string[] args)
        {


            Program promedios = new Program();
            promedios.promedio();

            Console.ReadLine();






        }
    }
}
