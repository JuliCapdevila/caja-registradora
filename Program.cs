using System;

//const string NombreComercio = "Carrefour";
//Console.WriteLine($"--- {NombreComercio} ---");
//Console.Write("Nombre del Cajero: ");
//string NombreCajero = Console.ReadLine();
//Console.WriteLine($"Bienvenido {NombreCajero}, Caja Abierta.");

//Console.WriteLine("Ingrese un Producto: ");
//string NombreProducto = Console.ReadLine();
//Console.Write("Ingrese el precio del producto: ");
//string PrecioProducto = Console.ReadLine();
//decimal precioDecimal = Decimal.Parse(PrecioProducto);
//Console.WriteLine($"Producto: {NombreProducto}, precio: {precioDecimal}");


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

Console.WriteLine($"Cantidad de productos cargados: {cantProductos}");
Console.WriteLine($"Total: ${total}");

Console.ReadLine();

