using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
   public  class Adaptador : Itarget
    {
        //esta es la clase adaptador, usa la interfaz Itarget la cual es conocida
        //por el cliente
        //el adaptador comunica al cliente con la clase adaptada
        CcalcuArray CcalcuArray = new CcalcuArray();
        //hacemos la adaptacion de la operacion
        public int Suma(int a, int b)
        {
            double r = 0;
            //creamos el array que necesita el adaptado
            int[] operadores = { a, b };
            //realizamos la operacion del adaptado
            r = CcalcuArray.Sumar(operadores);
            //adaptamos el resultado
            return (int)r;
        }
    }
}
