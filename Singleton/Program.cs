using System;
using Negocio;


namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SINGLETON
            
            Console.WriteLine( Negocio.Singleton.Instance.mensaje);

            Negocio.Singleton.Instance.mensaje = "Hola Maycol";

            Console.WriteLine(Negocio.Singleton.Instance.mensaje);


            //PROTOTYPE
            PrototypeAnimal oAnimal = new PrototypeAnimal() { Nombre = "Wilson el gato", Patas = 4};
            PrototypeAnimal oAnimalClonado = oAnimal.Clone() as PrototypeAnimal;
            oAnimalClonado.Patas = 5;

            Console.WriteLine("Animal original "+ oAnimal.Patas +" patas");
            Console.WriteLine("Animal clonado "+oAnimalClonado.Patas + " patas");
        }
    }
}
