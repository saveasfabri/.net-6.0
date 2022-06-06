Console.WriteLine("Ingrese cantidad de numeros primos deseados:");
var n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[] primos = new int[n];

// ACLARACION: Un número primo es un número natural mayor que 1 que tiene únicamente dos divisores positivos distintos: él mismo y el 1.

int posicion = 0;
int aux = 0; // va a sumar la cantidad de veces que se se divide un número. si es 2 es primo si es mayor no lo es.
int numero = 1;

while (posicion < n) //n = Cantidad de números primos tendrá el array y lo ingresa el usuario en la línea 2
{
  aux = 0;
  for (var i = 1; i <= numero; i++)
  {
    if (numero % i == 0)
    {
      aux++;
    }
  }
  if (aux == 2)
  {
    primos[posicion] = numero;
    posicion++;
  }
  numero++;
}
foreach (var i in primos)
{
  Console.WriteLine(i);
}
Console.ReadKey();