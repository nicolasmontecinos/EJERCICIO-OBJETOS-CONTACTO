using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_OBJETOS_CONTACTO
{
    class Fecha
    {
        private DateTime fecha = new DateTime();
        public Fecha (DateTime fecha)
        {
            this.fecha = fecha;
        }
        public Fecha()
        {
            this.fecha = DateTime.Now;
        }
        public int devolverDia()
        {
            return Int32.Parse(fecha.ToString("dd"));
        }
        public int devolverMes()
        {
            return Int32.Parse(fecha.ToString("MM"));
        }
        public int devolverYear()
        {
            return Int32.Parse(fecha.ToString("yyyy"));
        }


    }

}
