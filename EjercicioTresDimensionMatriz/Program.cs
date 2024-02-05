Console.WriteLine("**** BIENVENIDO AL PROGRAMA ****");
Console.WriteLine("Ingrese la dimension de la matriz: ");
Console.Write("Filas: ");
int filas = int.Parse(Console.ReadLine());
Console.Write("Columnas: ");
int columnas = int.Parse(Console.ReadLine());

int [,] matriz = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write("Ingrese el valor para la posicion [{i},{j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("La segunda columna de la tercera fila es: ");
for (int i = 0; i < filas; i++)
{
    Console.WriteLine(matriz[2,1]);
}
Console.WriteLine("FIN DEL PROGRAMA :)");