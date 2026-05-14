using System;

public class Program
{
    public static void Main()
    {
        string nombre, nombreArticulo;
        double ahorroDelDia, totalAhorrado = 0;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese el nombre del artículo: ");
        nombreArticulo = Console.ReadLine();

        for (int dia = 1; dia <= 5; dia++)
        {
            Console.Write($"Día {dia} - ¿Cuánto ahorraste hoy?: ");
            ahorroDelDia = double.Parse(Console.ReadLine());

            totalAhorrado += ahorroDelDia;
        }

        Console.WriteLine("\n----------");
        Console.WriteLine($"Hola {nombre}, para tu {nombreArticulo}:");
        Console.WriteLine($"Ahorraste un total de: ${totalAhorrado}");

        if (totalAhorrado >= 15000)
        {
            Console.WriteLine("Felicidades! Ya tienes suficiente");
        }
        else
        {
            double falta = 15000 - totalAhorrado;
            Console.WriteLine($"Aún no es suficiente, faltan ${falta}");
            Console.WriteLine("Sigue ahorrando");
        }
        Console.WriteLine("----------");
    }
}