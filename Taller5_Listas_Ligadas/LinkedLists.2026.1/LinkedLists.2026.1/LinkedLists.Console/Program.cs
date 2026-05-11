using DoubleList;

var list = new DoubleLinkedList<String>();
var option = string.Empty;
string value;

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.Write("Ingrese un valor: ");
            value = Console.ReadLine() ?? string.Empty;
            list.InsertOrdered(value);
            Console.WriteLine($"'{value}' agregado.");
            break;
        case "2":
            Console.WriteLine(list.ToString());
            break;
        case "3":
            Console.WriteLine(list.ToStringReverse());
            break;

        case "4":
            list.Reverse();
            Console.WriteLine("Lista invertida (orden descendente):");
            Console.WriteLine(list.ToString());
            break;

        case "5":
            var modes = list.GetModes();
            if (modes.Count == 0)
            {
                Console.WriteLine("No hay moda (todos los elementos aparecen una sola vez o la lista está vacía).");
            }
            else if (modes.Count == 1)
            {
                Console.WriteLine($"La moda es: {modes[0]}");
            }
            else
            {
                Console.WriteLine($"Las modas son: {string.Join(", ", modes)}");
            }
            break;

        case "6":
            Console.WriteLine(list.GetGraph());
            break;

        case "7":
            Console.Write("Ingrese un valor: ");
            value = Console.ReadLine() ?? string.Empty;
            if (list.Contains(value))
            {
                Console.WriteLine($"Sí existe '{value}' en la lista.");
            }
            else
            {
                Console.WriteLine($"No existe '{value}' en la lista.");
            }
            break;

        case "8":
            Console.Write("Ingrese un valor: ");
            value = Console.ReadLine() ?? string.Empty;
            list.Remove(value);
            Console.WriteLine($"Se intentó eliminar una ocurrencia de '{value}'.");
            break;

        case "9":
            Console.Write("Ingrese un valor: ");
            value = Console.ReadLine() ?? string.Empty;
            var removed = list.RemoveAll(value);
            Console.WriteLine($"Se eliminaron {removed} ocurrencia(s) de '{value}'.");
            break;
        case "0":
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.");
            break;
    }
    Console.WriteLine();
} while (option != "0");


static string Menu()
{
    Console.WriteLine("===== Taller #5 - Listas Ligadas =====");
    Console.WriteLine("1. Adicionar");
    Console.WriteLine("2. Mostrar hacia adelante");
    Console.WriteLine("3. Mostrar hacia atrás");
    Console.WriteLine("4. Ordenar descendentemente");
    Console.WriteLine("5. Mostrar la(s) moda(s)");
    Console.WriteLine("6. Mostrar gráfico");
    Console.WriteLine("7. Existe");
    Console.WriteLine("8. Eliminar una ocurrencia");
    Console.WriteLine("9. Eliminar todas las ocurrencias");
    Console.WriteLine("0. Salir");
    Console.Write("Ingrese su opción: ");
    return Console.ReadLine() ?? string.Empty;
}