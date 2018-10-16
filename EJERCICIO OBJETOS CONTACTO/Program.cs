using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_OBJETOS_CONTACTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contac1 = new Contacto("Miren",944123456,new DateTime(1990,2,4));
            Contacto contac2 = new Contacto("Jon",931212123);
            Contacto contac3 = new Contacto("Ane",new DateTime(1995,5,5));
            Contacto contac4 = new Contacto("Julen",944123321,new DateTime(1992,2,4));

            contac1.MostrarDatos();
            contac2.MostrarDatos();
            contac3.MostrarDatos();
            contac4.MostrarDatos();

            contac1.Felicitar();
            contac2.Felicitar();
            contac3.Felicitar();
            contac4.Felicitar();

            Console.WriteLine(contac1.Edad());
            Console.WriteLine(contac2.Edad());
            Console.WriteLine(contac3.Edad());
            Console.WriteLine(contac4.Edad());



            Console.ReadLine();

        }
    }
}
