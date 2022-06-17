// Tarea Clase 13  - Billetera 07/06/22

/*Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)*/

using Tarea_clase13_billetera.Modelo;



Billetera billetera1 = new Billetera(5, 3, 10, 3, 6, 2, 1);
Billetera billetera2 = new Billetera(3, 6, 4, 6, 1, 3, 2);

Console.WriteLine("La billetera N°1 tiene: ");
Console.WriteLine($"- {billetera1.BilletesDe10} billetes de 10");
Console.WriteLine($"- {billetera1.BilletesDe20} billetes de 20");
Console.WriteLine($"- {billetera1.BilletesDe50} billetes de 50");
Console.WriteLine($"- {billetera1.BilletesDe100} billetes de 100");
Console.WriteLine($"- {billetera1.BilletesDe200} billetes de 200");
Console.WriteLine($"- {billetera1.BilletesDe500} billetes de 500");
Console.WriteLine($"- {billetera1.BilletesDe1000} billetes de 1000");
Console.WriteLine($"* Con un total de {billetera1.Total()} billetes *");
Console.WriteLine();

Console.WriteLine("La billetera N°2 tiene: ");
Console.WriteLine($"- {billetera2.BilletesDe10} billetes de 10");
Console.WriteLine($"- {billetera2.BilletesDe20} billetes de 20");
Console.WriteLine($"- {billetera2.BilletesDe50} billetes de 50");
Console.WriteLine($"- {billetera2.BilletesDe100} billetes de 100");
Console.WriteLine($"- {billetera2.BilletesDe200} billetes de 200");
Console.WriteLine($"- {billetera2.BilletesDe500} billetes de 500");
Console.WriteLine($"- {billetera2.BilletesDe1000} billetes de 1000");
Console.WriteLine($"* Con un total de {billetera2.Total()} billetes *");
Console.WriteLine();

Console.WriteLine("Pasamos todos los billetes de las billeteras N°1 y N°2 a la billetera N°3");
Console.WriteLine();

Billetera billetera3 = billetera1.Combinar(billetera2);

Console.WriteLine("Entonces la billetera N°3 tiene: ");
Console.WriteLine($"- {billetera3.BilletesDe10} billetes de 10");
Console.WriteLine($"- {billetera3.BilletesDe20} billetes de 20");
Console.WriteLine($"- {billetera3.BilletesDe50} billetes de 50");
Console.WriteLine($"- {billetera3.BilletesDe100} billetes de 100");
Console.WriteLine($"- {billetera3.BilletesDe200} billetes de 200");
Console.WriteLine($"- {billetera3.BilletesDe500} billetes de 500");
Console.WriteLine($"- {billetera3.BilletesDe1000} billetes de 1000");
Console.WriteLine($"* Con un total de {billetera3.Total()} billetes*");
Console.WriteLine();
Console.WriteLine($"Luego de pasar todos los billetes a la billetera N°3...");
Console.WriteLine($"- La billetera N°1 tiene: {billetera1.Total()} billetes");
Console.WriteLine($"- La billetera N°2 tiene: {billetera2.Total()} billetes");

//Y...fin del programa
//By Fabricio Hang