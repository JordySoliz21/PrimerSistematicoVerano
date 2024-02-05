Console.WriteLine("Calculadora de ecuaciones cuadraticas");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Ingrese los coeficientes de la siguiente ecuación cuadratica ax^2+bx+c=0");

    Console.WriteLine("Coeficiente a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Coeficiente b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Coeficiente c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    double discriminant = b * b - 4 * a * c;
    Console.WriteLine();
    Console.WriteLine("RESULTADOSSS: ");
    Console.WriteLine("-------------------------------------------");

    if (discriminant < 0)
    {
        Console.WriteLine("La ecuacíón ingresada no tiene ecuaciones reales.");
    }
    else if (discriminant == 0)
    {
        double solucion = -b / (2 * a);
        Console.WriteLine("La ecuacion tiene una solucion real: ");
        Console.WriteLine("x = " + solucion);
    }
    else
    {
        double solucionUno = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double solucionDos = (-b - Math.Sqrt(discriminant)) / (2 * a);

        Console.WriteLine("La ecuacion ingresada tiene 2 soluciones reales: ");
        Console.WriteLine("x1 = " + solucionUno);
        Console.WriteLine("x2 = " + solucionDos);
    }
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine();

    Console.WriteLine("¿Usted desea calcular otra ecuacion? (s/n)");
    string respuesta = Console.ReadLine();

    Console.WriteLine("*** FINAL DEL PROGRAMA ***");
    if (respuesta.ToLower() != "s")
    {
        break;
    }
    Console.Clear();
}