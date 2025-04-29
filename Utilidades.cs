using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etiquetaOculta;

public static class Utilidades
{
    public static void EscribirCentrado(string texto)
    {
        int anchoConsola = Console.WindowWidth;
        int espaciosIzquierda = (anchoConsola - texto.Length) / 2;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(new string(' ', Math.Max(0, espaciosIzquierda)) + texto);
        Console.ResetColor();
    }

    public static bool LeerRespuesta()
    {
        while (true)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);
                char respuesta = char.ToUpper(tecla.KeyChar);
                switch (respuesta)
                {
                    case 'S':
                        return true;
                    case 'N':
                        return false;
                    default:
                        Console.WriteLine("Respuesta no válida. Por favor, ingrese 's' o 'n'.");
                        break;
                }
            }
    }
}