using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioTemperaturas
{
    class Pais
    {
        public string pais { get; set; }
        
        public List<Temperatura> tempProm;
        public float primerTrimestre { get; set; }
        public float segundoTrimestre { get; set; }
        public float tercerTrimestre { get; set; }
        public float cuartoTrimestre { get; set; }
        public float trimestralMayor { get; set; }

        public Pais()
        {
            pais = "";
            
            tempProm = new List<Temperatura>();
            primerTrimestre = 0f;
            segundoTrimestre = 0f;
            tercerTrimestre = 0f;
            cuartoTrimestre = 0f;
        }
        public Pais(string pais, List<Temperatura> tempProm)
        {
            this.pais = pais;
            this.tempProm = tempProm;
        }

      
        public void cargaPaises()
        {
            Console.WriteLine("Cargar el nombre del país");
            pais = Console.ReadLine();
            float[] t = new float[12];
            for (int i = 1; i < 13; )
            {
                
                Temperatura cargaDatos = new Temperatura();
                cargaDatos.mes = i;
                Console.WriteLine("Ingrese la temperatuda promedio del mes {0}", i);
                cargaDatos.temp = float.Parse(Console.ReadLine());
                if(cargaDatos.temp < 50 && cargaDatos.temp > -50)
                {
                    tempProm.Add(cargaDatos);
                    t[i - 1] = cargaDatos.temp;
                    i++;
                }
                else
                {
                    Console.WriteLine("la temperatura es inválida, por favor vuelva a cargar este mes completo");
                }
                
            }
            primerTrimestre = (t[0] + t[1] + t[2]) / 3;
            segundoTrimestre = (t[3] + t[4] + t[5]) / 3;
            tercerTrimestre = (t[6] + t[7] + t[8]) / 3;
            cuartoTrimestre = (t[9] + t[10] + t[11]) / 3;
            float primerSem = Math.Max(primerTrimestre, segundoTrimestre);
            float segundoSem = Math.Max(tercerTrimestre, cuartoTrimestre);
            trimestralMayor = Math.Max(primerSem, segundoSem);
        }


        public void mostrarTempProm()
        {
            
            Temperatura carga = new Temperatura();
            
            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine("para el mes {0}, la temperatura promedio es: {1}", carga.mes, carga.temp);
                
            }
            
        }

        public string mostrarPaises(string nombre)
        {
            pais = nombre;
            return pais;
        }
        public void calculoTempTrim()
        {
            
            Temperatura prom = new Temperatura();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("El promedio del primer trimestre es: " + primerTrimestre);
            Console.WriteLine("El promedio del segundo trimestre es: " + segundoTrimestre);
            Console.WriteLine("El promedio del tercer trimestre es: " + tercerTrimestre);
            Console.WriteLine("El promedio del cuarto trimestre es: " + cuartoTrimestre);
            Console.WriteLine("La temperatura promedio mayor por trimestre es: " + trimestralMayor);
        }
       


    }
}
