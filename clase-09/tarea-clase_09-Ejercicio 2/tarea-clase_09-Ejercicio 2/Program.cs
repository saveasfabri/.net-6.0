/*Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla*/

/*********************************************************************************************************************************/

Random randon = new Random();



int s, op = 1, y, m, l = 0, cartones = 0;
int[] linea1 = new int[5];
int[] linea2 = new int[5];
int[] linea3 = new int[5];
int[] linea4 = new int[5];
int[] linea5 = new int[5];
int[] cartone = new int[100];
Console.WriteLine("\tBIENVENIDO AL BINGO !THE BIG BINGO¡");


do
{


  linea1[0] = 0; linea1[1] = 0; linea1[2] = 0; linea1[3] = 0; linea1[4] = 0;
  linea2[0] = 0; linea2[1] = 0; linea2[2] = 0; linea2[3] = 0; linea2[4] = 0;
  linea3[0] = 0; linea3[1] = 0; linea3[2] = 0; linea3[3] = 0; linea3[4] = 0;
  linea4[0] = 0; linea4[1] = 0; linea4[2] = 0; linea4[3] = 0; linea4[4] = 0;
  linea5[0] = 0; linea5[1] = 0; linea5[2] = 0; linea5[3] = 0; linea5[4] = 0;

  //recorro cada array para generar los numeros de cada arreglo
  for (int f = 0; f < 5; f++)
  {
    int l3 = randon.Next(1,
        15); linea1[f] += l3;
  }
  for (int f = 0; f < 5; f++)
  {
    int l1 = randon.Next(16,
        30); linea2[f] += l1;
  }
  for (int f = 0; f < 5; f++)
  {
    int l2 = randon.Next(31,
        45); linea3[f] += l2;
  }
  for (int f = 0; f < 5; f++)
  {
    int l4 = randon.Next(46,
        60); linea4[f] += l4;
  }
  for (int f = 0; f < 5; f++)
  {
    int l5 = randon.Next(61,
        75); linea5[f] += l5;
  }

  Console.WriteLine("\n\t");
  Console.Write("\tB \t I\tN\tG\tO");
  Console.WriteLine("\n\t");
  //ordeno los arreglos para formar el carton
  Console.Write(("\n\t" + linea1[0]) + ("\t" + linea2[0]) + ("\t" + linea3[0]) + ("\t" + linea4[0]) + ("\t" + linea5[0]) + "\n"
                 + ("\n\t" + linea1[1]) + ("\t" + linea2[1]) + ("\t" + linea3[1]) + ("\t" + linea4[1]) + ("\t" + linea5[1]) + "\n" +
                 ("\n\t" + linea1[2]) + ("\t" + linea2[2]) + ("\t" + linea3[2]) + ("\t" + linea4[2]) + ("\t" + linea5[2]) + "\n" +
                 ("\n\t" + linea1[3]) + ("\t" + linea2[3]) + ("\t" + linea3[3]) + ("\t" + linea4[3]) + ("\t" + linea5[3]) + "\n" +
                 ("\n\t" + linea1[4]) + ("\t" + linea2[4]) + ("\t" + linea3[4]) + ("\t" + linea4[4]) + ("\t" + linea5[4]));

  Console.WriteLine("\n");
  l++;
  //para contar el numeros o numero del carton generado
  Console.Write("N° de Carton:" + l);

  Console.WriteLine("\n");
  Console.WriteLine("Desea otro carton precione 0 si no precione 1");
  s = int.Parse(Console.ReadLine());
} while (s != 1);


Console.ReadKey();
    