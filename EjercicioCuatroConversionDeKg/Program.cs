Console.Write("*** CONVERSOR DE LIBRAS A KILOGRAMOS ***");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Menú:");
    Console.WriteLine("1. Convertir kg a libras");
    Console.WriteLine("1. Convertir kg a onzas");
    Console.WriteLine("1. Convertir kg a toneladas");
    Console.WriteLine("4. Salir");
    Console.WriteLine("Ingrese su opción por favor: ");
    string op = Console.ReadLine();

    if (op == "1")
    {
        Console.WriteLine("Ingrese el valor en kg: ");
        double kg = double.Parse(Console.ReadLine());
        double lbs = kg * 2.2;
        Console.WriteLine($"{kg} kg equivale a {lbs} lbs");
    }
    else if (op == "2")
    {
        Console.WriteLine("Ingrese el valor en kg: ");
        double kg = double.Parse(Console.ReadLine());
        double onzas = kg * 35.27;
        Console.WriteLine($"{kg} kg equivale a {onzas} onzas");
    }
    else if (op == "3")
    {
        Console.WriteLine("Ingrese el valor en kg: ");
        double kg = double.Parse(Console.ReadLine());
        double toneladas = kg / 1000;
        Console.WriteLine($"{kg} kg equivale a {toneladas} toneladas");
    }
    else if (op == "4")
    {
        Console.WriteLine("Saliendo del programa :)");
        break;
    }
    else
    {
        Console.WriteLine("Opcion valida intente de nuevo :(");
    }
    Console.WriteLine();
}

