
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_clase13_billetera.Modelo
{
  class Billetera //Crear una clase Billetera
  {
    public int BilletesDe10 { get; set; }
    public int BilletesDe20 { get; set; }
    public int BilletesDe50 { get; set; }
    public int BilletesDe100 { get; set; }
    public int BilletesDe200 { get; set; }
    public int BilletesDe500 { get; set; }
    public int BilletesDe1000 { get; set; }

    public Billetera(int cantB10, int cantB20, int cantB50, int cantB100, int cantB200, int cantB500, int cantB1000)
    {
      BilletesDe10 = cantB10;
      BilletesDe20 = cantB20;
      BilletesDe50 = cantB50;
      BilletesDe100 = cantB100;
      BilletesDe200 = cantB200;
      BilletesDe500 = cantB500;
      BilletesDe1000 = cantB1000;
    }
    
    public decimal Total() //Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.
    {
      decimal totalBilletesDe10 = BilletesDe10;
      decimal totalBilletesDe20 = BilletesDe20;
      decimal totalBilletesDe50 = BilletesDe50;
      decimal totalBilletesDe100 = BilletesDe100;
      decimal totalBilletesDe200 = BilletesDe200;
      decimal totalBilletesDe500 = BilletesDe500;
      decimal totalBilletesDe1000 = BilletesDe1000;

      decimal totalDeBilletes = totalBilletesDe10 + totalBilletesDe20 + totalBilletesDe50 + totalBilletesDe100 + totalBilletesDe200 + totalBilletesDe500 + totalBilletesDe1000;

           return  totalDeBilletes;
    }
    
    public Billetera Combinar(Billetera billetera2) //Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.
    {
      int sumaB10 = BilletesDe10 + billetera2.BilletesDe10;
      int sumaB20 = BilletesDe20 + billetera2.BilletesDe20;
      int sumaB50 = BilletesDe50 + billetera2.BilletesDe50;
      int sumaB100 = BilletesDe100 + billetera2.BilletesDe100;
      int sumaB200 = BilletesDe200 + billetera2.BilletesDe200;
      int sumaB500 = BilletesDe500 + billetera2.BilletesDe500;
      int sumaB1000 = BilletesDe1000 + billetera2.BilletesDe1000;

      Billetera billetera3 = new Billetera(sumaB10, sumaB20, sumaB50, sumaB100, sumaB200, sumaB500, sumaB1000);

      //Una vez combinadas las 2 billeteras(y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
      BilletesDe10 =  0;
      BilletesDe20 = 0;
      BilletesDe50 = 0;
      BilletesDe100 = 0;
      BilletesDe200 = 0;
      BilletesDe500 = 0;
      BilletesDe1000 = 0;
      billetera2.BilletesDe10 = 0;
      billetera2.BilletesDe20 = 0;
      billetera2.BilletesDe50 = 0;
      billetera2.BilletesDe100 = 0;
      billetera2.BilletesDe200 = 0;
      billetera2.BilletesDe500 = 0;
      billetera2.BilletesDe1000 = 0;

      return billetera3;
    }
  }
} 


