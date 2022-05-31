using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Logica;

namespace Capa_Datos
{
    public class ClaseDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        //Todos los procedimientos relacionados con listar:
        public DataTable D_listar_productos()
        {
            SqlCommand cmd = new SqlCommand("sp_ver_productos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_listar_ventas()
        {
            SqlCommand cmd = new SqlCommand("sp_ver_ventas", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_listar_proveedores()
        {
            SqlCommand cmd = new SqlCommand("sp_ver_proveedores", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_listar_clientes()
        {
            SqlCommand cmd = new SqlCommand("sp_ver_clientes", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Todos los procedimientos relacionados con buscar:
        public DataTable D_buscar_producto(ClaseLogica objl)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_producto");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objl.id_producto);
            cmd.Parameters.AddWithValue("@nombre", objl.nombre_producto);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_venta(ClaseLogica objl)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_venta");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objl.id_venta);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_proveedor(ClaseLogica objl)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_proveedor");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objl.id_provedor);
            cmd.Parameters.AddWithValue("@nombre", objl.nombre_proveedor);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_cliente(ClaseLogica objl)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_cliente");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objl.id_cliente);
            cmd.Parameters.AddWithValue("@nombre", objl.nombre_cliente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Procedimientos modificar:
        public String D_modificar_producto(ClaseLogica objl)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_modificar_producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objl.id_producto);
            cmd.Parameters.AddWithValue("@nombre", objl.nombre_producto);
            cmd.Parameters.AddWithValue("@precio", objl.precio);
            cmd.Parameters.AddWithValue("@cantidad", objl.cantidad);
            cmd.Parameters.AddWithValue("@id_proveedor", objl.id_proveedor1);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = objl.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }

        public String D_modificar_venta(ClaseLogica objl)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_modificar_ventas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objl.id_venta);
            cmd.Parameters.AddWithValue("@fecha", objl.fecha);
            cmd.Parameters.AddWithValue("@precio_total", objl.precio_total);
            cmd.Parameters.AddWithValue("@estado", objl.estado);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = objl.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }

        public String D_modificar_proveedor(ClaseLogica objl)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_modificar_proveedor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objl.id_provedor);
            cmd.Parameters.AddWithValue("@nombre", objl.nombre_proveedor);
            cmd.Parameters.AddWithValue("@telefono", objl.telefono_proveedor);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = objl.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }

        public String D_modificar_cliente(ClaseLogica objl)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_modificar_cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objl.id_cliente);
            cmd.Parameters.AddWithValue("@nombre", objl.nombre_cliente);
            cmd.Parameters.AddWithValue("@telefono", objl.telefono_cliente);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = objl.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
    }
}
