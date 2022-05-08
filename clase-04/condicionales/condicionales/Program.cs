/* Ejemplos de condicionales */

//Console.WriteLine("Compra de entradas para el Partido de Colon");
//Console.WriteLine();

//Console.Write("Ingrese su edad: "); // Solicitamos ingresar la edad
//int edad = int.Parse(Console.ReadLine()); // Obtenemos edad por consola

//Console.Write("Ingrese su club: "); // Solicitamos ingresar el club
//string club = Console.ReadLine(); // Obtenemos club por consola

//Console.WriteLine(); // Para hacer un salto de linea en blanco
//Console.WriteLine("Su edad ingresada es: " + edad);
//Console.WriteLine("Y es hincha de: " + club);

// Ejemplo if y else ******************************************************************

//Ejemplo 1 ********
// !!! Para que funcione primero descomente desde la líne 3 a la 14 y comente todo lo demás


////Console.WriteLine(); // Para hacer un salto de linea en blanco
//
//if (edad < 18) // Evaluamos si es mayor de edad
//{
//    Console.WriteLine("Es menor de edad"); //  Resultado en caso de que sea verdadero
//}
//else
//{
//    Console.WriteLine("Es mayor de edad"); // Resultado en caso de que sea falso
//}


// Ejemplo 2 ********
// !!! Para que funcione primero descomente desde la líne 3 a la 14 y comente todo lo demás


//Console.WriteLine(); // Para hacer un salto de linea en blanco

//bool datos = edad >= 18 && club == "Colon";

//if (datos) // Evaluamos si es mayor de edad
//{
//    Console.WriteLine("Tiene una estrella y es mayor de edad, puede entrar al Cementerio de Elefantes"); //  Resultado en caso de que sea verdadero

//}
//else
//{
//    Console.WriteLine("O es menor de edad o es pecho frío, no puede ingresar al Cementerio de Elefantes"); // Resultado en caso de que sea falso
//}


// Ejemplo if, else if y else ******************************************************************
// !!!Para que funcione primero descomente desde la líne 3 a la 14 y comente todo lo demás


//Console.WriteLine(); // Para hacer un salto de linea en blanco

//if (edad >= 18 && club == "Colon" )
//{
//    Console.WriteLine("Tiene una estrella y es mayor de edad, puede entrar al Cementerio de Elefantes.");
//}
//else if (edad < 18 && club == "Colon")
//{
//    Console.WriteLine("Tiene una estrella pero es menor de edad, puede entrar al Cementerio de Elefantes pero en compañia de un mayor.");
//}
//else if (edad >= 18 && club != "Colon")
//{
//    Console.WriteLine("Es mayor de edad pero es pecho frío...no le da vergüenza? Valla a su cancha.");
//}
//else
//{
//    Console.WriteLine("Es menor de edad y ensima pecho frío...? Valla a su casa y preguntele al que lo hizo hincha si de verdad lo quiere...");
//}


// Ejemplo switch ******************************************************************
// Para que funcione comente todo desde la línea 74 a la 0 y empiece desde acá

Console.WriteLine("Simulación de calculadora básica");

Console.WriteLine(); // Para hacer un salto de linea en blanco

Console.Write("Ingrese el primer número: ");
double numero1 = double.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine(); // Para hacer un salto de linea en blanco
Console.WriteLine("1 = Sumar");
Console.WriteLine("2 = Restar");
Console.WriteLine("3 = Multiplicar");
Console.WriteLine("4 = Dividir");

Console.WriteLine(); // Para hacer un salto de linea en blanco

Console.Write("Escriba el número de la operacion que desea realizar: ");
string tipoOperacion = Console.ReadLine();

Console.WriteLine(); // Para hacer un salto de linea en blanco

double resultado = 0;

switch (tipoOperacion)
{
    case "1":
        resultado = numero1 + numero2;
        break;
    case "2":
        resultado = numero1 - numero2;
        break;
    case "3":
        resultado = numero1 * numero2;
        break;
    case "4" when numero2!= 0:
        resultado = numero1 / numero2;
        break;
    default:
        Console.WriteLine("Ingreso una opción no válida...");
        break;
}


if (tipoOperacion == "4" && numero2 == 0) // En el caso que quieran dividir por 0...
{
    Console.WriteLine("No se puede definir por 0"); 

}
else
{
    Console.WriteLine("El resultado es: " + resultado);
}


