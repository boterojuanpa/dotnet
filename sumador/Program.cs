using System;

namespace sumador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora!");
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Ingrese el primero numero");
            int primerNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es " + calculadora.sumar(primerNumero, segundoNumero));

            Console.Read();
        }
    }
}
