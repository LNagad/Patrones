using System;
using Negocio2;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine( Negocio2.Singleton.Instance.mensaje);

            Negocio2.Singleton.Instance.mensaje = "Hola Maycol";

            Console.WriteLine(Negocio2.Singleton.Instance.mensaje);

        }
    }
}
