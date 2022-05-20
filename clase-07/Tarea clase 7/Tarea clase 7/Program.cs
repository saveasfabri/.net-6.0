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

//Console.WriteLine("Hola... ¡bienvenido a este coso!");
//Console.WriteLine();
//Thread.Sleep(2000);

//int[] numero = new int[10]; 
//Console.WriteLine($"A continuación deberá ingresar {numero.Length} números.");
//Console.WriteLine();

//int sumaNumeros = 0;

//for (int i = 0; i < numero.Length; i++)
//{
//  Console.Write((i + 1) + ") Ingrese un número: ");
//  numero[i] = int.Parse(Console.ReadLine()); //1) Pida 10 números al usuario.

//  sumaNumeros = sumaNumeros + numero[i]; //2) Obtener la suma de todos los números ingresados.

//}

//Console.WriteLine();
//Console.WriteLine("¡Gracias!... estos son los datos que recopilamos...");
//Thread.Sleep(2000);

//Console.WriteLine();
//Console.Write("Usted ha ingresado los siguientes números: ");
//for (int i = 0; i < numero.Length; i++)
//{
//   Console.Write(numero[i] + " "); //6) Mostrar todos los números ingresados por pantalla.

//}

//Thread.Sleep(4000);
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine($"Los números ingresados suman: {sumaNumeros}");

//Thread.Sleep(4000);
//Console.WriteLine();
//Console.WriteLine($"El número de valor mas alto que ingresó fué el: {numero.Max()}"); //3) Obtener cual es el mayor de todos los números.

//Thread.Sleep(4000);
//Console.WriteLine();
//Console.WriteLine($"El número de menor valor que ingresó fué el: {numero.Min()}"); //4) Obtener cual es el menor de todos los números.

//Thread.Sleep(4000);
//Console.WriteLine();
//Console.WriteLine($"El promedio de los números que ingresó fué de: {numero.Average()}"); //5) Obtener el promedio de todos los números.

//Thread.Sleep(4000);
//Console.WriteLine();
//Console.WriteLine("Nos vemos en la próxima...");
//Console.WriteLine();


Console.WriteLine("Hola... ¡Bienvenido a este coso!");
Console.WriteLine();
Thread.Sleep(2000);

int[] numero = new int[10];
Console.WriteLine($"A continuación deberá ingresar {numero.Length} números.");
Console.WriteLine();

int sumaNumeros = 0;

for (int i = 0; i < numero.Length; i++)
{
  Console.Write((i + 1) + ") Ingrese un número: ");
  numero[i] = int.Parse(Console.ReadLine()); //1) Pida 10 números al usuario.

  sumaNumeros = sumaNumeros + numero[i]; //2) Obtener la suma de todos los números ingresados.

}

Console.WriteLine();
Console.WriteLine("¡Gracias!... estos son los datos que recopilamos...");
Thread.Sleep(2000);

Console.WriteLine();
Console.Write("Usted ha ingresado los siguientes números: ");
for (int i = 0; i < numero.Length; i++)
{
  Console.Write(numero[i] + " "); //6) Mostrar todos los números ingresados por pantalla.

}

Thread.Sleep(3000);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Los números ingresados suman: {sumaNumeros}");

Thread.Sleep(4000);
Console.WriteLine();
Console.WriteLine($"El número de valor mas alto que ingresó fué el: {numero.Max()}"); //3) Obtener cual es el mayor de todos los números.

Thread.Sleep(4000);
Console.WriteLine();
Console.WriteLine($"El número de menor valor que ingresó fué el: {numero.Min()}"); //4) Obtener cual es el menor de todos los números.

Thread.Sleep(4000);
Console.WriteLine();
Console.WriteLine($"El promedio de los números que ingresó fué de: {numero.Average()}"); //5) Obtener el promedio de todos los números.

Thread.Sleep(4000);
Console.WriteLine();
Console.WriteLine("Nos vemos en la próxima...");
Console.WriteLine();

//Y...Fin del programa!!!
//by Fabricio Hang