using System;
using FuncionesLambda;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Expresión Lambda como función");

        var numeros = new List<int> { 3, 4, 5, 8, 9 };

        Func<int, bool> ObtenerPares = (num) => num % 2 == 0;
        var pares = numeros.Where(ObtenerPares);

        Console.WriteLine("hola");



        //Func<int, int, int> suma=(a,b)=> a + b;
        //int resultado = suma(4, 6);
        //Console.WriteLine("El resultado es:" + resultado);


        //Func<int, int, int> mayor = (a, b) =>
        //{
        //    if (a > b) return a;
        //    else return b;

        //};

        //int resultado = mayor(45, 20);
        //Console.WriteLine("El numero mayor es" + resultado);




        //        Func<int, int> bb = (aa) => aa*2;

        //        int resultado = bb(4);

        //        Console.WriteLine("El resultado es:"+ resultado);
        //;















        //Persona pers = new Persona();
        //int edad=18;
        //edad++;
        //dad++;
        //Console.WriteLine("El valor de la varible edad es: " + edad);
        //Console.WriteLine("La direccion de memoria es: " +);















        Console.ReadKey();
    }
}