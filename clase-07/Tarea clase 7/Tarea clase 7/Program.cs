//Tarea clase 07

//Escribe un programa que:

//1) Pida 10 números al usuario.
//2) Obtener la suma de todos los números ingresados.
//3) Obtener cual es el mayor de todos los números.
//4) Obtener cual es el menor de todos los números.
//5) Obtener el promedio de todos los números.
//6) Mostrar todos los números ingresados por pantalla.
//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

//****************************************************************************


Console.WriteLine("Hola... ¡Bienvenido a este coso!");
Console.WriteLine();
Thread.Sleep(2000);

int[] numero = new int[10];
Console.WriteLine($"A continuación deberá ingresar {numero.Length} números.");
Console.WriteLine();

int sumaNumeros = 0;

for (int i = 0; i < numero.Length; i++)
{
  Console.Write($"Ingrese el número en la posicion {i+1}: ");
  numero[i] = int.Parse(Console.ReadLine()); //1) Pida 10 números al usuario.

  sumaNumeros = sumaNumeros + numero[i]; //2) Obtener la suma de todos los números ingresados.

}

// Manual
int mayor = numero[0];  //3) Obtener cual es el mayor de todos los números.
for (int i = 1; i > numero.Length; i++)
{
  if (numero[i] > mayor)
  {
    mayor = numero[i];
  }
}
/*Automático
Console.WriteLine($"El número de valor mas alto que ingresó fué el: {numero.Max()}"); 
*/


// Manual
int menor = numero[0];  //4) Obtener cual es el menor de todos los números.
for (int i = 1; i < numero.Length; i++)
{
  if (numero[i] < menor)
  {
    menor = numero[i];
  }
}
/*Automático
Console.WriteLine($"El número de valor mas alto que ingresó fué el: {numero.Min()}"); 
*/



//Manual
int promedio = sumaNumeros / numero.Length; //5) Obtener el promedio de todos los números.
/* Automático
Console.WriteLine($"El promedio de los números que ingresó fué de: {numero.Average()}"); 
*/


Console.WriteLine();
Console.WriteLine("¡Gracias!... estos son los datos que recopilamos...");
Thread.Sleep(3000);


Console.WriteLine();
Console.Write("Usted ha ingresado los siguientes números: ");  //6) Mostrar todos los números ingresados por pantalla.
for (int i = 0; i < numero.Length; i++)
{
  Console.Write(numero[i] + " ");

}

//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine($"Los números ingresados suman: {sumaNumeros}");

Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine($"El número de valor mas alto que ingresó fué el: {mayor}");

Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine($"El número de valor mas bajo que ingresó fué el: {menor}");

Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine($"El promedio de los números que ingresó fué de: {promedio}");


Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("Nos vemos en la próxima...");
Console.WriteLine();



Console.WriteLine("Presione una tecla para salir.");
Console.ReadKey();

//Y...Fin del programa!!!
//by Fabricio Hang


