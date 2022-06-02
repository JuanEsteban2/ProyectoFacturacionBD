using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class ClaseLogica
    {
        public String id_producto { get; set; }
        public String nombre_producto { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }
        public String id_proveedor1 { get; set; }

        public String id_venta { get; set; }
        public String fecha { get; set; }
        public int precio_total { get; set; }
        public String estado { get; set; }

        public String id_provedor { get; set; }
        public String nombre_proveedor { get; set; }
        public int telefono_proveedor { get; set; }

        public String id_cliente { get; set; }
        public String nombre_cliente { get; set; }
        public int telefono_cliente { get; set; }

        public String accion { get; set; }
    }
}