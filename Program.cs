using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,r;
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            r = n1 + n2;
            Console.WriteLine("El resultado es " + r );
            


        }
    }
}
