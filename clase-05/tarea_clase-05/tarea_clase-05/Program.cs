// Tarea clase n°5 - Introducción a .net 6.0

// Escribir un programa que haga lo siguiente:

// 1) Borrar la pantalla.
// 2) Pedir el nombre de una persona.
// 3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
// 4) Preguntar si se quiere continuar.
// 5) Si la respuesta es "S" repetir desde el punto 1.
// 6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
// 7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".
//**************************************************************************************************************************


var respuesta = "S";    

while (respuesta.ToUpper() == "S") // 5) Si la respuesta es "S" repetir desde el punto 1.
{
    Console.Clear(); // 1) Borra Pantalla.

    Console.Write("Buenos días, por favor ingrese su nombre a continuación: ");
    var nombreIngresado = Console.ReadLine(); // 2) Pedir el nombre de una persona.


    Console.WriteLine();
    Console.WriteLine($"¡Hola {nombreIngresado}!");  // 3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"

    Console.WriteLine();
    Console.Write("Deseas continuar? S/N: ");
    respuesta = Console.ReadLine(); // 4) Preguntar si se quiere continuar.
}

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine();
    Console.WriteLine("Programa finalizado correctamente."); // 6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
}
else
{
    Console.WriteLine();
    Console.WriteLine("Opción no válida. Fin del programa."); // 7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".
}


//// by Fabricio Hang

