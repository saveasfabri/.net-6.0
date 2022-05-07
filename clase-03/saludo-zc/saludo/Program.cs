// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();// Borra lo anterior en la pantalla ( En este caso el Hello, World)

Console.WriteLine("Hola, ingrese su nombre"); // Pedimos al usuario que ingrese su nombre

string nombre = Console.ReadLine();// Leemos el nombre y lo asignamos a la variable;

Console.WriteLine("Ahora por favor, ingrese su apellido"); // Pedimos al usuario que ingrese su apellido

string apellido = Console.ReadLine(); // Leemos el apellido y lo asignamos a la variable;

// Mostramos el saludo
Console.Write("Hola " + nombre + " " + apellido); // Concatenamos al string las variables
Console.WriteLine(", este es su segundo programa.");
// En este caso usamos Console.write para que no haga el salto de linea y quede concatenado con el segundo string
// El resultado es: Hola Fabricio Hang, este es su segundo programa. 

Console.WriteLine("Pulse una tecla para finalizar...");
Console.ReadKey(); // ReadyKey() hace que el programa no se cierre automáticamente, tenemos que apretar una tecla