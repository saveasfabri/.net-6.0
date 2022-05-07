// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

const string constanteTexto = "Bienvenidos";

// Datos Numéricos
byte numeroByte = 0;
int numeroInteger = 1234;
long numeroLong = 0;
double numeroDouble = 0;
float numeroFloat = 0;

Console.WriteLine(numeroInteger);

// Datos Lógicos
bool datoBoolFalso = false; // Pueder ser 0 también.
bool datoBoolVerdadero = true;  // Pueder ser 1 también.

// Datos de texto
string datoString = "texto";

// Instrucción de salida - Output
Console.WriteLine(datoString);

Console.WriteLine("Ingrese un texto:");
// Instrucción de entrada - Input
datoString = Console.ReadLine(); /* En la Consola pide ingresar un texto
para asignarle a la variable datoString*/  

//Se ingresa por consola: Texto ingresado por consola
Console.WriteLine(datoString);
// Ahora datoString = "Texto ingresado por consola"

//******************************************************************************

Console.WriteLine("Ingrese un número entero");  // Se pide que se ingrese un numero por consola
string numeroString = Console.ReadLine();       // Se ingresa

int numeroInteger2 = Convert.ToInt32(numeroString); // Se usa Conver.ToInt32 para convertir el texto ingresado a número,
                                                    // ya que lo que se ingresa por ReadLine() es un string

Console.WriteLine(numeroInteger2); // Muestra el valor asignado por consola a numeroInteger2
