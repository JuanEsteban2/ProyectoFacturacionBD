using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Datos;
using Capa_Logica;

namespace Capa_Presentacion
{
    public class ClasePresentacion
    {
        ClaseDatos objd = new ClaseDatos(); //Aquí está el error

        //Listar:
        public DataTable P_listar_productos()
        {
            return objd.D_listar_productos();
        }

        public DataTable P_listar_ventas()
        {
            return objd.D_listar_ventas();
        }

        public DataTable P_listar_proveedores()
        {
            return objd.D_listar_proveedores();
        }

        public DataTable P_listar_clientes()
        {
            return objd.D_listar_clientes();
        }


        //Buscar:
        public DataTable P_buscar_producto(ClaseLogica objl)
        {
            return objd.D_buscar_producto(objl);
        }

        public DataTable P_buscar_venta(ClaseLogica objl)
        {
            return objd.D_buscar_venta(objl);
        }

        public DataTable P_buscar_proveedor(ClaseLogica objl)
        {
            return objd.D_buscar_proveedor(objl);
        }

        public DataTable P_buscar_cliente(ClaseLogica objl)
        {
            return objd.D_buscar_cliente(objl);
        }

        //Modificar:
        public String P_modificar_producto(ClaseLogica objl)
        {
            return objd.D_modificar_producto(objl);
        }

        public String P_modificar_venta(ClaseLogica objl)
        {
            return objd.D_modificar_venta(objl);
        }

        public String P_modificar_proveedor(ClaseLogica objl)
        {
            return objd.D_modificar_proveedor(objl);
        }

        public String P_modificar_cliente(ClaseLogica objl)
        {
            return objd.D_modificar_cliente(objl);
        }
    }
}