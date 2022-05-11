// See https://aka.ms/new-console-template for more information
Console.WriteLine("cuantas vueltas quiere dar?");

var respuesta = "S";
var contador = 0;

while (respuesta.ToUpper() != "N")
{
    contador++; //contador = contador + 1;
    Console.WriteLine("seguimos dando vueltas, vuelta numero: " + contador);

    Console.WriteLine("seguimos? (S/N)");
    respuesta = Console.ReadLine();
}



//   decl.             cond.          paso
//for (var cantCara = 0; cantCara <= 12; cantCara += 2)
//{
//    Console.WriteLine($"Mi bolsita tiene {cantCara} caramelos");
//    //RECORDAR !!!! el paso lo hace al finalizar la ejecución
//}
