using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_OBJETOS_CONTACTO
{
    class Contacto2
    {
        private string nombre,tipoContacto;
        private int telefono; 
        private static int numerofamiliares, numeroAmigos, compañerosTrabajo, compañerosEstudio, numeroContactosCreado;
        private DateTime fechaNaci = new DateTime();


        public Contacto2(string nombre, int telefono, DateTime fechaNaci,string tipoContacto)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNaci = fechaNaci;
            this.tipoContacto = tipoContacto;

        }
        public Contacto2()
        {
            this.tipoContacto = "Amigo";
            numeroAmigos++;
            numeroContactosCreado++;
        }

        public Contacto2(string nombre, DateTime fechaNaci)
        {
            this.nombre = nombre;
            this.tipoContacto = "Amigo";
            numeroAmigos++;
            numeroContactosCreado++;
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
        public Contacto2(string nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNaci = DateTime.Now;
            this.tipoContacto = "Amigo";
            numeroAmigos++;
            numeroContactosCreado++;
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
                Console.WriteLine("Feliz cumpleaños has cumplido " + Edad() + " años");
            }
        }
        public void MostrarDatos()
        {
            Console.WriteLine(" El contacto se llama " + nombre + " su telefono es " + telefono + " fecha de nacimiento " + fechaNaci);

        }
        public void CambiarTipo(string tipoContacto)
        {
            this.tipoContacto = tipoContacto;
        }
        public string ObtenerTipo()
        {
            return tipoContacto;
        }
    }
}