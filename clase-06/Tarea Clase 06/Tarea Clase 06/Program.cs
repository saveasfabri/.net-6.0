//Clase 6

//Tarea Clase 06

// 1) Generar un número secreto aleatorio con la siguiente instruccion:
//// Genera un numero entero aleatorio de 1 a 20
//int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

//2) Pedir al usuario que ingrese un número y que intente adivinar el número que eligió la computadora.

//3) Si el numero ingresado por el usuario es mayor al número secreto, avisarle que es muy grande y que intente de nuevo y que vuelva al paso 2.

//4) Si el numero ingresado es menor al número secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

//5) Si el número ingresado coincide con el número secreto, sacar el siguiente mensaje:

//"Felicitaciones, has adivinado el número secreto que era:  [numeroSecreto] "
//"Lo has logrado en [n] intentos!!"

//Y finalizar el programa.

//*********************************************************************************

int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
int contador = 0;

// Nota al Profesor: Descomentar la linea de abajo para facilitar el testeo de la tarea
//Console.WriteLine($"El número secreto es {numeroSecreto}");

Console.WriteLine();

Console.WriteLine("¡Bienvenido al juego Adivine el número secreto!");
Console.WriteLine("(Si quiere salir de programa antes de adivinar, ingrese el número: 0 )");

Console.WriteLine();

int numeroIngresado;
do {
    Console.Write("Ingrese un número de 1 a 20: ");
    numeroIngresado = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (numeroIngresado == numeroSecreto)
    {
        Console.WriteLine($"¡Felicitaciones! Has adivinado el número secreto que era: {numeroSecreto}");
        if (contador == 0)
        {
            Console.WriteLine($"¿Magia o suerte?¡Lo has logrado en el primer intento!");
        }
        else if (contador == 1)
        {
            Console.WriteLine($"¡Lo has logrado en el segundo intento!");
        }
        else {
            Console.WriteLine($"Lo has logrado luego de {contador} intentos");
        }
    }
    else if(numeroIngresado > numeroSecreto && numeroIngresado < 21)
    {
        Console.WriteLine("¡El número ingresado es muy grande! Intentálo de nuevo...");
        contador++;
    }
    else if (numeroIngresado < numeroSecreto && numeroIngresado != 0)
    {
        Console.WriteLine("¡El número ingresado es muy chico! Intentálo de nuevo...");
        contador++;
    }
    else if (numeroIngresado < 0 || numeroIngresado > 20)
    {
        Console.WriteLine("Wuow, era entre 1 y 20!! Intentálo de nuevo...");
        contador++;
    }
    else if (numeroIngresado == 0)
    {
        if (contador == 0)
        {
            Console.WriteLine($"¡Que poca paciencia! Ni siquiera lo intentaste.Vuelve pronto...");
        }
        else if(contador==1) {
            Console.WriteLine($"¡Que poca paciencia! Solo lo intentaste 1 vez.Vuelve pronto...");

        }
        else { Console.WriteLine($"¡Que poca paciencia! Solo lo intentaste {contador} veces.Vuelve pronto...");

        }
    }
} 
while (numeroIngresado != numeroSecreto && numeroIngresado != 0);

// Y...Fin del programaaa
//by Fabricio Hang
