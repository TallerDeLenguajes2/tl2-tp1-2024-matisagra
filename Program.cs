using System;
using System.Collections.Generic;

var cadeteria=new Cadeteria("KIKO","381343454");
cadeteria.CargarDatosCadeteriaCSV("cadeteria.csv");
cadeteria.CargarDatosCadetesCSV("cadetes.csv");



bool continuar = true;

while (continuar)
{
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Dar de alta pedido");
    Console.WriteLine("2. Asignar pedido a cadete");
    Console.WriteLine("3. Cambiar estado de pedido");
    Console.WriteLine("4. Reasignar pedido a otro cadete");
    Console.WriteLine("5. Mostrar informe final");
    Console.WriteLine("6. Salir");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            cadeteria.AltaPedido();
            break;
        case "2":
            cadeteria.AsignarPedidoACadete();
            break;
        case "3":
           cadeteria.CambiarEstadoPedido();
            break;
        case "4":
           cadeteria.ReasignarPedidoACadete();
            break;
        case "5":
           //cadeteria.InformeFinal();
            break;
        case "6":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}








