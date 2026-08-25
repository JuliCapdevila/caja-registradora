using System;

const string NombreComercio = "Carrefour";
const decimal PorcentajeMayor = 10m;
const decimal PorcentajeMenor = 5m;

Console.WriteLine($"=== {NombreComercio} ===");
Console.Write("Nombre del Cajero: ");
string nombreCajero = Console.ReadLine();
Console.WriteLine($"Bienvenida, {nombreCajero}. Caja abierta.");

int cantProductos = 0;
decimal total = 0;
string opcion;

do
{
    Console.WriteLine("Que desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");

    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese un Producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            string precioTexto = Console.ReadLine();

            decimal precioDecimal = decimal.Parse(precioTexto);

            cantProductos++;
            total = total + precioDecimal;

            Console.WriteLine($"Producto: {nombreProducto}, precio: {precioDecimal}");
            break;

        case "2":
            break;

        default:
            Console.WriteLine("Opción Invalida, intente nuevamente.");
            break;
    }

} while (opcion != "2");

decimal plataDescontada = 0;

if (total > 50000)
{
    plataDescontada = (total * PorcentajeMayor) / 100m;
}
else if (total > 20000)
{
    plataDescontada = (total * PorcentajeMenor) / 100m;
}

decimal totalAPagar = total - plataDescontada;

Console.WriteLine("=== TICKET FINAL ===");
Console.WriteLine($"Subtotal: ${total}");
Console.WriteLine($"Descuento: ${plataDescontada}");
Console.WriteLine($"Total a cobrar: ${totalAPagar}");

Console.ReadLine();
