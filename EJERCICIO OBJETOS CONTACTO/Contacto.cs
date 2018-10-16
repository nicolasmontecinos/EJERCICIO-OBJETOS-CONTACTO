using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_OBJETOS_CONTACTO
{
    class Contacto
    {
        private string nombre;
        private int telefono;
        private DateTime fechaNaci = new DateTime();


        public Contacto(string nombre, int telefono, DateTime fechaNaci)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNaci = fechaNaci;
        }
        public Contacto()
        {
       
        }

        public Contacto(string nombre, DateTime fechaNaci)
        {
            this.nombre = nombre;

            try
            {
                this.fechaNaci = fechaNaci;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("La fecha introducida no es correcta, se procedera a poner la fecha actual");
                this.fechaNaci = DateTime.Now;
            }
        }
        public Contacto(string nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNaci = DateTime.Now;
        }
        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string DevolverNombre()
        {
            return nombre;
        }
        public void CambiarTel(int telefono)
        {
            this.telefono = telefono;
        }
        public int DevolverTelefono()
        {
            return telefono;
        }
        public void CambiarFecha(DateTime fecha)
        {
            this.fechaNaci = fecha;
        }

        public int Edad()
        {
            TimeSpan dif = DateTime.Now - fechaNaci;
            int diferenciaEnDias = dif.Days;
            return diferenciaEnDias / 365;            
        }
        public void Felicitar()
        {
            Fecha fechaAhora = new Fecha();
            Fecha Cumple = new Fecha(fechaNaci);

            if (fechaAhora.devolverDia() == Cumple.devolverDia() && fechaAhora.devolverMes() == Cumple.devolverMes() && Cumple.devolverYear() != 2018)
            {
                Console.WriteLine("Feliz cumpleaños has cumplido " + Edad()+" años");
            }   
        }        
        public void MostrarDatos()
        {
            Console.WriteLine(" El contacto se llama " + nombre + " su telefono es " + telefono + " fecha de nacimiento " + fechaNaci);
            
        }
        


}
}

