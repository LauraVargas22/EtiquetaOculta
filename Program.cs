using etiquetaOculta;
using etiquetaOculta.Producto;


internal class Program
{
   private static void Main(string[] args)
   {
        //Booleano para continuar
        bool continuar = true;
       //Lista de Productos
       List<Producto> productos = new List<Producto>
       {
           new Producto { Id = 1, Nombre = "Laptop HP", Categoria = "Electrónica", Precio = 3500, Stock = 10},
           new Producto { Id = 2, Nombre = "Mouse Logitech", Categoria = "Electrónica", Precio = 150, Stock = 50},
           new Producto { Id = 3, Nombre = "Silla de Oficina", Categoria = "Muebles", Precio = 800, Stock = 5},
           new Producto { Id = 4, Nombre = "Cafetera Oster", Categoria = "Electrodomésticos", Precio = 600, Stock = 0},
           new Producto { Id = 5, Nombre = "Escritorio Moderno", Categoria = "Muebles", Precio = 1200, Stock = 7},
           new Producto { Id = 6, Nombre = "Monitor Samsung", Categoria = "Electrónica", Precio = 2500, Stock = 8},
           new Producto { Id = 7, Nombre = "Teclado Mecánico", Categoria = "Electrónica", Precio = 400, Stock = 15},
           new Producto { Id = 8, Nombre = "Aspiradora LG", Categoria = "Electrodomésticos", Precio = 1100, Stock = 2}
       };


       var productosConEtiquetas = new List<(string Producto, List<string> Etiquetas)>
       {
           ("Laptop HP", new List<string> {"Electrónica", "Computadores", "Trabajo"}),
           ("Mouse Logitech", new List<string> {"Electrónica", "Tecnología", "Oficina"}),
           ("Silla de Oficina", new List<string> {"Muebles", "Confort", "Oficina"}),
           ("Cafetera Oster", new List<string> {"Cocina", "Electrodomésticos", "Café"}),
           ("Escritorio Moderno", new List<string> {"Muebles", "Confort", "Oficina"}),
           ("Monitor Samsung", new List<string> {"Electrónica", "Computadores", "Trabajo"}),
           ("Teclado Mecánico", new List<string> {"Electrónica", "Tecnología", "Oficina"}),
           ("Aspiradora LG", new List<string> {"", "Electrodomésticos", "Café"})
       };

    do
    {
        Utilidades.EscribirCentrado("ADIVINA LA ETIQUETA");
        
        //Etiquetas disponibles
        Console.WriteLine("\nEtiquetas Disponibles: ");
        var etiqueta = productosConEtiquetas.SelectMany(p => p.Etiquetas).Distinct().ToList();
        foreach (var e in etiqueta)
            Console.WriteLine(e);

        //Etiqueta Aleatoria
        Random etiquetaRandom = new Random();

        //Obtener index aleatorio
        int index = etiquetaRandom.Next(etiqueta.Count);
        string aleatoria = etiqueta[index]; //Convierte el index a string para ser comparado

        //Pedir al usuario la etiqueta
        Console.WriteLine("Por favor, escoga una de las etiquetas: ");
        string input = Console.ReadLine(); //Variable que almacena la entrada

        //Validar la entrada sin importar mayúscula o minúscula
        if (etiqueta.Contains(input, StringComparer.OrdinalIgnoreCase))
        {
            //Valida acertó en la selección
            if (input == aleatoria)
            {
            Console.WriteLine($" 🎉 Felicidades, ha adivinado la etiqueta {input}");
            }
            else
            {
                Console.WriteLine($" ❌ Lo siento, no ha adivinado la etiqueta {aleatoria}");
            }
        }
        else
        {
            Console.WriteLine($"La etiqueta escrita no corresponde");
            Console.Beep();
        }

        Console.WriteLine("¿Desea jugar nuevamente (S/N)");
        continuar = Utilidades.LeerRespuesta();
    } while (continuar);

   }
}
