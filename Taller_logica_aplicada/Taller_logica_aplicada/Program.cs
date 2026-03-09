using Taller_logica_aplicada.Ejercicio29;
using Taller_logica_aplicada.Ejercicio36;

while (true)
{
    Console.WriteLine("\n==================================");
    Console.WriteLine("    MENÚ DE EJERCICIOS (POO)      ");
    Console.WriteLine("==================================");
    Console.WriteLine("1. Ejercicio 29 (Puentes de Madison)");
    Console.WriteLine("2. Ejercicio 36 (Cosechando a Caballo)");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine() ?? "";

    if (opcion == "1")
    {
        Console.Write("\nIngrese el puente: ");
        string entrada = Console.ReadLine() ?? "";

        Puente miPuente = new Puente(entrada);

        if (miPuente.EsValido())
            Console.WriteLine("VALIDO");
        else
            Console.WriteLine("INVALIDO");
    }
    else if (opcion == "2")
    {
        Console.Write("\nIngrese ubicación de los frutos: ");
        string inputFrutos = Console.ReadLine() ?? "";

        Console.Write("Ingrese posición inicial del caballo: ");
        string inicial = Console.ReadLine() ?? "";

        Console.Write("Ingrese los movimientos del caballo: ");
        string inputMovs = Console.ReadLine() ?? "";

        Tablero miTablero = new Tablero();
        string[] frutos = inputFrutos.Split(',');
        foreach (var f in frutos)
        {
            miTablero.SembrarFruto(f);
        }

        Caballo miCaballo = new Caballo(inicial, miTablero);

        string[] movimientos = inputMovs.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string mov in movimientos)
        {
            miCaballo.Mover(mov);
        }

        Console.WriteLine($"Los frutos recogidos son: {miCaballo.FrutosRecogidos}");
    }
    else if (opcion == "0")
    {
        break;
    }
}