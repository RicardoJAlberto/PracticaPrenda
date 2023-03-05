using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPrendas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camisa camisa1 = new Camisa()
            {
                Nombre = "Camisa cuello v",
                Marca = "Nike",
                Precio = 25.00,
                CantidadDisponible = 10,
                Material = "Polyester",
                Color = "Roja"
            };

            Pantalon pantalon1 = new Pantalon()
            {
                Nombre = "Pantalón bluejean",
                Marca = "Adidas",
                Precio = 50.00,
                CantidadDisponible = 20,
                Material = "Algodon",
                Color = "Verde"
            };

            Vestido vestido1 = new Vestido()
            {
                Nombre = "Vestido de fiesta",
                Marca = "Zara",
                Precio = 100.00,
                CantidadDisponible = 5,
                Material = "Seda",
                Color = "Rojo",
                Tipo = "Largo"
            };

            Zapatos zapato1 = new Zapatos()
            {
                Nombre = "Hyper x",
                Marca = "New Balance",
                Precio = 70.00,
                CantidadDisponible = 15,
                Material = "Cuero",
                Color = "Negro",
                Tipo = "Botas"
            };

            Console.WriteLine("Catálogo de prendas de vestir por calidad:");

            Console.WriteLine("\nPrendas de alta calidad:");
            vestido1.MostrarDetalles();
            vestido1.MostrarTallas();
            vestido1.MostrarStock();

            Console.WriteLine("\nPrendas de media calidad:");
            camisa1.MostrarDetalles();
            camisa1.MostrarTallas();
            camisa1.MostrarStock();
            zapato1.MostrarDetalles();
            zapato1.MostrarTallas();
            zapato1.MostrarStock();

            Console.WriteLine("\nPrendas de baja calidad:");
            pantalon1.MostrarDetalles();
            pantalon1.MostrarTallas();
            pantalon1.MostrarStock();

            Console.ReadLine();
        }
    }
}

public abstract class Prenda
{
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public double Precio { get; set; }
    public int CantidadDisponible { get; set; }

    public abstract void MostrarDetalles();
    public abstract void MostrarTallas();
    public abstract void MostrarStock();

}

public class Camisa : Prenda
{
    public string Material { get; set; }  
    public string Color { get; set; }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Camisa {Nombre} de la marca {Marca}, hecho con {Material} de color {Color} por un precio de {Precio}");
    }

    public override void MostrarTallas()
    {
        Console.WriteLine("Tallas disponibles para esta camisa: S, M, L, XL, XXL");
    }

    public override void MostrarStock()
    {
        Console.WriteLine("Hay 10 camisas en existencia");
    }
}

public class Pantalon : Prenda
{
    public string Material { get; set; }
    public string Color { get; set; }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Pantalón {Nombre} de la marca {Marca}, hecho con {Material} de color {Color} por un precio de {Precio}");
    }

    public override void MostrarTallas()
    {
        Console.WriteLine("Tallas disponibles para este pantalón: 28, 30, 32, 34, 36, 37, 39, 41");
    }

    public override void MostrarStock()
    {
        Console.WriteLine("Hay 20 pantalones en stock");
    }
}

public class Vestido : Prenda
{
    public string Material { get; set; }
    public string Color { get; set; }
    public string Tipo { get; set; }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Vestido {Nombre} de la marca {Marca}, hecho con {Material}, de color {Color} y tipo {Tipo} por un precio de {Precio}");
    }

    public override void MostrarTallas()
    {
        Console.WriteLine("Tallas disponibles para este vestido: XS, S, M, L, XL, XXL");
    }

    public override void MostrarStock()
    {
        Console.WriteLine("Actualmente existen 5 vestidos en stock");
    }
}

public class Zapatos : Prenda
{
    public string Material { get; set; }
    public string Color { get; set; }
    public string Tipo { get; set; }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Zapatos {Nombre} de la marca {Marca}, hecho con {Material}, de color {Color} y tipo {Tipo} por un precio de {Precio}");
    }

    public override void MostrarTallas()
    {
        Console.WriteLine("Tallas disponibles para este zapato: 4, 7, 8, 8/5, 9, 10");
    }

    public override void MostrarStock()
    {
        Console.WriteLine("Hay una cantidad de 15 zapatos de este estilo en stock");
    }
}
