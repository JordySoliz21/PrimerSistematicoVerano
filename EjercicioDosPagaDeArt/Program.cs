int cantidadArt;
int costoArt = 0;
int totalPagar = 0;

Console.Write("Ingrese la cantidad de articulos: ");
cantidadArt = Convert.ToInt32(Console.ReadLine());

if (cantidadArt >= 4)
    cantidadArt = 3;
if (cantidadArt > 5)
    cantidadArt = 5;

Console.Write("Ingrese el costo de cada articulo: ");
costoArt = Convert.ToInt32(Console.ReadLine());

totalPagar = cantidadArt * costoArt;

Console.WriteLine("El total a pagar es: " + totalPagar + " pesos");

if (totalPagar > 300)
{
    int vales = totalPagar / 100 * 10;
    Console.WriteLine("Por cada 100 de compras se te obsequiaron " + vales + " pesos en vales");
    double equivalenteCordobas = vales * 0.64;

    Console.WriteLine("Equivalente en cordobas: " + equivalenteCordobas + " cordobas");
}
Console.ReadLine();