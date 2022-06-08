// Tarea Clase 9 - Ejercicio 1 26/05/22

// Resolución: 

/*Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

1)  Pedir al usuario la longitud de un vector
2)  Crear el vector del tamaño ingresado.
3)  Llenar el mismo con datos aleatorios
4)  Mostrar el vector por pantalla
5)  Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el segundo  y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe     quedar así: 50, 40, 30, 20, 10.
    Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones. Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
6)  Mostrar el vector nuevamente.*/

/************************************************************************************************************************/

Console.WriteLine();
int n = 0;

Console.WriteLine("Hola, ingresa cuantos números aleatorios quieres ver en pantalla");

while (true)
{
  n = int.Parse(Console.ReadLine()); // 1)  Pedir al usuario la longitud de un vector
  if (n < 2)
  {
    Console.WriteLine("Vamos, hagamoslo más diverido! Elige 2 o mas números");
  }
  else
  {
    break;
  }
}
Console.WriteLine();


int[] tamanioArray = new int[n]; // 2)  Crear el vector del tamaño ingresado.

Random numeroAleatorio = new Random();

for (
  int i = 0; i < tamanioArray.Length; i++)
{
  tamanioArray[i] = numeroAleatorio.Next(50); // 3) Llenar el mismo con datos aleatorios
}

Console.WriteLine($"Y los {n} numeros aleatorios son: ");
Console.WriteLine();

int cont = 0;
foreach (var i in tamanioArray)
{
  cont++;
  Console.WriteLine($"{cont}) {i}"); // 4)  Mostrar el vector por pantalla
}

int temporal;
int posicion = n;
for (int x = 0; x < posicion / 2; x++) // 5)  Invertir el vector
{
  // Guardamos el valor de números en x
  temporal = tamanioArray[x];
  // A números en x le asignamos lo que haya en la
  // otra mitad, restando 1 porque recuerda que los índices
  // comienzan en 0
  tamanioArray[x] = tamanioArray[posicion - x - 1];
  // Y a números en longitud - x - 1 le ponemos el temporal
  tamanioArray[posicion - x - 1] = temporal;
}

Console.WriteLine("Imprimiendo arreglo Después de invertir");
Console.WriteLine();

Console.WriteLine($"Y los {n} numeros aleatorios en posición inversa son:");

int contInvertido = 0;
foreach (var x in tamanioArray)
{
  cont++;
  Console.WriteLine($"{contInvertido}) {x}"); // 6) Mostrar el vector nuevamente.

}

//Y...termina el programa!!!
//by Fabricio Hang
