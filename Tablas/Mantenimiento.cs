using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRecu.Tablas
{
    public class MANTENIMIENTO
    {
        public int NoMantenimiento { get; set; }
        //public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
        public int CLIENTE_ID_cliente { get; set; }

        // datos del mantenimiento
    }
}
