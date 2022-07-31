using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase13
{
    public class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }


        public decimal Total()
        {
            decimal importeTotal = BilletesDe10*10 + BilletesDe20*20 + BilletesDe50*50 + BilletesDe100*100 + BilletesDe200*200 + BilletesDe500*500 + BilletesDe1000*1000;
            return importeTotal;
        }

        public Billetera Combinar(Billetera primeraBilletera, Billetera segundaBilletera)
        {
            Billetera nuevaBilletera = new Billetera();
            
            nuevaBilletera.BilletesDe10 = primeraBilletera.BilletesDe10 + segundaBilletera.BilletesDe10;
            nuevaBilletera.BilletesDe20 = primeraBilletera.BilletesDe20 + segundaBilletera.BilletesDe20;
            nuevaBilletera.BilletesDe50 = primeraBilletera.BilletesDe50 + segundaBilletera.BilletesDe50;
            nuevaBilletera.BilletesDe100 = primeraBilletera.BilletesDe100 + segundaBilletera.BilletesDe100;
            nuevaBilletera.BilletesDe200 = primeraBilletera.BilletesDe200 + segundaBilletera.BilletesDe200;
            nuevaBilletera.BilletesDe500 = primeraBilletera.BilletesDe500 + segundaBilletera.BilletesDe500;
            nuevaBilletera.BilletesDe1000 = primeraBilletera.BilletesDe1000 + segundaBilletera.BilletesDe1000;

            primeraBilletera.BilletesDe10 = 0;
            primeraBilletera.BilletesDe20 = 0;
            primeraBilletera.BilletesDe50 = 0;
            primeraBilletera.BilletesDe100 = 0;
            primeraBilletera.BilletesDe200 = 0;
            primeraBilletera.BilletesDe500 = 0;
            primeraBilletera.BilletesDe1000 = 0;

            segundaBilletera.BilletesDe10 = 0;
            segundaBilletera.BilletesDe20 = 0;
            segundaBilletera.BilletesDe50 = 0;
            segundaBilletera.BilletesDe100 = 0;
            segundaBilletera.BilletesDe200 = 0;
            segundaBilletera.BilletesDe500 = 0;
            segundaBilletera.BilletesDe1000 = 0;

            return nuevaBilletera;
        }
    }
}
