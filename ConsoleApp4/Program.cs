using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ichingMPRG2122

{
    class Moneda
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MPRG2122");
            JuegoMonedas j = new JuegoMonedas();
            j.Consultar();
        }
        private int valor;
        private static Random azar; /*declaro static valor = all objetos d sta clase*/
                                    /* la clase random genera nºs pseudo-aleatorios*/
                                    /*NO HAGO CAMBIO PERO TRABAJO C DAW1920PRG2*/

        public Moneda()
        {
            azar = new Random();
        }

        public void Tirar()
        {
            valor = azar.Next(1, 6); /* .Next devuelve entero aleatorio no -*/
        }

        public void Mostrar()
        {
            if ((valor % 2) == 0)
            {
                Console.WriteLine("La moneda ha salido cruz");
            }
            else
            {
                Console.WriteLine("La moneda ha salido cara");
            }
            Console.WriteLine("La moneda ha salido" + valor);
        }

        public int DevolverValor()
        {
            return valor;
        }
    }

    class JuegoMonedas
    {
        private Moneda moneda1, moneda2, moneda3;

        public JuegoMonedas()
            {
            moneda1 = new Moneda();
            moneda2 = new Moneda();
            moneda3 = new Moneda();
        }

        public void Consultar()
        {
            moneda1.Tirar();
            moneda1.Mostrar();
            moneda2.Tirar();
            moneda2.Mostrar();
            moneda3.Tirar();
            moneda3.Mostrar();
        }

    }
}
