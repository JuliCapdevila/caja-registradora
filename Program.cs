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
            Console.WriteLine("Opcion Invalida, intente nuevamente.");
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

string opcionPago;
decimal ajustePago = 0;

do
{
    Console.WriteLine("Medio de pago:");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Debito");
    Console.WriteLine("3 - Credito");

    opcionPago = Console.ReadLine();

    switch (opcionPago)
    {
        case "1":
            ajustePago = -(totalAPagar * 10m / 100m);
            break;
        case "2":
            ajustePago = 0;
            break;
        case "3":
            ajustePago = (totalAPagar * 15m / 100m);
            break;
        default:
            Console.WriteLine("Opcion invalida, intente nuevamente.");
            break;
    }

} while (opcionPago != "1" && opcionPago != "2" && opcionPago != "3");

totalAPagar = totalAPagar + ajustePago;

Console.WriteLine("=== TICKET FINAL ===");
Console.WriteLine($"Subtotal: ${total}");
Console.WriteLine($"Descuento por monto: ${plataDescontada}");

if (opcionPago == "1")
{
    Console.WriteLine($"Descuento adicional por efectivo: ${ajustePago}");
}
else if (opcionPago == "3")
{
    Console.WriteLine($"Recargo por credito: ${ajustePago}");
}

Console.WriteLine($"Total a cobrar: ${totalAPagar}");

Console.ReadLine();