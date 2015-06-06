using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erick;

//Vazquez Gonzalez Erick 8CV11

namespace Poligono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 55);
            int i, n;
            VolumenPrisma[] Calculos;

            Erick.Libreria.Portada();
       CIN: Console.WriteLine("\nInserte el numero de poligonos:");
            string entry = Console.ReadLine();
            int.TryParse(entry, out n);                 
            if(n > 0){
                Calculos = new VolumenPrisma[n];
                for (i = 0; i < n; i++)                     
                {
                    Calculos[i] = new VolumenPrisma();      
                    VolumenPrisma.Registro(Calculos[i]);    
                }
                for (i = 0; i < n; i++)                     
                {
                    VolumenPrisma.Imprimir(Calculos[i]);    
                }
            }
            else { Console.WriteLine(" - Introdusca un valor entero valido - "); goto CIN; };
            System.Threading.Thread.Sleep(50000);
        }
    }
}