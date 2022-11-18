using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioTemperaturas
{
    class Temperatura
    {
       
        public float temp { get; set; }
        public int mes { get; set; }
        
        public Temperatura()
        {
            
            temp = 0f;
            mes = 0;
        }

        public Temperatura(float temp, int mes)
        {
            this.temp = temp;
            this.mes=  mes;
        }

        public void listaTemp()
        {

        }
    }
}
