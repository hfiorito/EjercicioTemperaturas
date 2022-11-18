using System;

namespace EjercicioTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais pais1 = new Pais();
            Pais pais2 = new Pais();
            Pais pais3 = new Pais();
            pais1.cargaPaises();
            pais2.cargaPaises();
            pais3.cargaPaises();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("El nombre del pais 1 es " + pais1.mostrarPaises(pais1.pais));
            Console.WriteLine("Mes           Temperatura Promedio");
            foreach (Temperatura paises in pais1.tempProm)
            {
                Console.WriteLine("{0}                     {1}",paises.mes, paises.temp);
            }
            pais1.calculoTempTrim();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("El nombre del pais 2 es " + pais2.mostrarPaises(pais2.pais));
            Console.WriteLine("Mes           Temperatura Promedio");
            foreach (Temperatura paises in pais2.tempProm)
            {
                Console.WriteLine("{0}                     {1}", paises.mes, paises.temp);
            }
            pais2.calculoTempTrim();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("El nombre del pais 3 es " + pais3.mostrarPaises(pais3.pais));
            Console.WriteLine("Mes           Temperatura Promedio");
            foreach (Temperatura paises in pais3.tempProm)
            {
                Console.WriteLine("{0}                     {1}", paises.mes, paises.temp);
            }
            pais3.calculoTempTrim();

        }
    }
}
