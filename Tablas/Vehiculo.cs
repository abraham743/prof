using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRecu.Tablas
{
    public class Vehiculo
    {
        public int matricula { get; set; }

        public string modelo { get; set; }

        public string marca { get; set; }

        public int CLIENTE_ID_cliente { get; set; }

        public CLIENTE CLIENTE { get; set; }

        //datos del vehiculo
    }

}
