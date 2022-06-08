// Tarea Clase 08 - 20/05

// Resolucion: https://www.youtube.com/watch?v=WR7ANihIHG4

//1) Crear una matriz de dos dimensiones de tipo int llamada números,
//2) Determinar el tamaño de cada dimensión (fila, columnas) mediante valores ingresados por pantalla
//3) Declarar un vector de tipo double llamado promedios
//4) Recorrer la matriz para su carga con elementos de tipo int
//5) Recorrer la matriz para mostrar cada valor de la matriz
//6) Calcular el promedio de cada columna y asignarlo a la posición correspondiente dentro del vector promedios
//7) Mostrar los promedios recorriendo el vector promedios

//********************************************************************************************************


Console.WriteLine();
Console.WriteLine();
string title = " Bienvenido al Festival de Críticos de Cine 2022 (FCC) ";
string lineStars = "***************************************************** ";
// Bloque de código para centrar titulo en la salida de consola (Puramente estético)*********
Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
Console.WriteLine(title);
Console.SetCursorPosition((Console.WindowWidth - lineStars.Length) / 2, Console.CursorTop);
Console.WriteLine(lineStars);
//*******************************************************************************************

Thread.Sleep(3000);
Console.WriteLine();
Console.Write("Ingrese la cantidad de películas que participarán en el Festival: ");
int cantPeliculas = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Ingrese el numero de Criticos que calificarán en el Festival: ");
int cantCriticos = int.Parse(Console.ReadLine());// 2) Determinar el tamaño de cada dimensión (fila, columnas) mediante valores ingresados por pantalla

int[,] numeros = new int[cantPeliculas, cantCriticos]; // 1) Crear una matriz de dos dimensiones de tipo int llamada numeros

int lengthPeliculas = numeros.GetUpperBound(0) + 1;
int lengthCriticos = numeros.GetUpperBound(1) + 1;

Thread.Sleep(2000);
Console.WriteLine();
for (int pelicula = 0; pelicula < lengthPeliculas; pelicula++) //4) Recorrer la matriz para su carga con elementos de tipo int
{
  Console.WriteLine();
  Console.WriteLine($"Calificación de la película N° {pelicula + 1}: ");

  for (int critico = 0; critico < lengthCriticos; critico++)
  {
    Console.Write($"Ingrese la calificación del Crítico de Cine N° {critico + 1}: ");
    numeros[pelicula, critico] = int.Parse(Console.ReadLine());
  }
}
Console.WriteLine();
Console.WriteLine();
Thread.Sleep(2000);

Console.WriteLine("Éstos son los resultados de las Calificaciones: ");
Console.WriteLine("************************************************");
Thread.Sleep(3000);

for (int pelicula = 0; pelicula < lengthPeliculas; pelicula++) //5) Recorrer la matriz para mostrar cada valor de la matriz
{
  Console.WriteLine();
  Console.WriteLine($"* Calificaciones de la película N° {pelicula + 1}: ");

  for (int critico = 0; critico < lengthCriticos; critico++)
  {
    Console.Write($"   Crítico N°{critico + 1}: ");
    Console.WriteLine(numeros[pelicula, critico]);
  }
}
Thread.Sleep(4000);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("La Calificación Final de cada película es...");
Console.WriteLine("********************************************");
Console.WriteLine();
Thread.Sleep(3000);

double[] promedios = new double[cantPeliculas]; //3) Declarar un vector de tipo double llamado promedios

for (int pelicula = 0; pelicula < lengthPeliculas; pelicula++)
{
  Console.Write($" Calificación Pelicula N°{pelicula + 1}: ");

  double suma = 0;
  for (int critico = 0; critico < lengthCriticos; critico++)
  {
    suma = suma + numeros[pelicula, critico];
  }
  promedios[pelicula] = suma / lengthCriticos;  //6) Calcular el promedio de cada columna y asignarlo a la posición correspondiente dentro del vector promedios

  Thread.Sleep(2000);
  Console.WriteLine(promedios[pelicula]); //7) Mostrar los promedios recorriendo el vector promedios
}
Thread.Sleep(3000);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Y La película Ganadora del Festival de Críticos de Cine 2022 es...");

Thread.Sleep(3000);


//!!!!! No pude resolver como poner el número de la película ganadora en la línea 109. Busqué info, pero la verdad no pude entenderla (todavía, porque recién arranco). La idea sería que tome el mayor de los promedios, pero no le encuentro la vuelta para que ese promedio mayor también esté asociado, en este caso, al n° de película correspondiente. Así que por ahora... El premio del FCC 2022 queda pendiente de entregar... como dije, por ahora. 

Console.WriteLine();
Console.WriteLine();
string congratulations = ($"*** LA PELICULA N° , FELICITACIONES!!!! ***");
// Bloque de código para centrar texto en la salida de consola (Puramente estético)****************
Console.SetCursorPosition((Console.WindowWidth - congratulations.Length) / 2, Console.CursorTop);
Console.WriteLine(congratulations);
//************************************************************************************************

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Presione una tecla para finalizar...");


//Y...termina el programa!!!
//by Fabricio Hang

