using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arreglo = { 4, 6, 7, 9 };
        int suma = 0;
        int promedio = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
           suma=arreglo[i]+suma;
           promedio=suma/arreglo.Length;
        }
        Console.WriteLine("La suma de la matriz es: "+ promedio);
    }
}