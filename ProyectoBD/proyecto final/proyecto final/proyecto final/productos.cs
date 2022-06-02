using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Logica;
using Capa_Presentacion;

namespace proyecto_final
{
    public partial class productos : Form
    {
        ClaseLogica objlog = new ClaseLogica();
        ClasePresentacion objpre = new ClasePresentacion();
        public productos()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objlog.id_producto = txtidproducto.Text;
            objlog.nombre_producto = txtnombre.Text;
            objlog.precio = Convert.ToInt32(txtprecio.Text);
            objlog.cantidad = Convert.ToInt32(txtcantidad.Text);
            objlog.id_proveedor1 = txtidproveedor.Text;
            objlog.accion = accion;
            String men = objpre.P_modificar_producto(objlog);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar ()
        {
            txtidproducto.Text = "";
            txtnombre.Text = "";
            txtprecio.Text = "";
            txtcantidad.Text = "";
            txtidproveedor.Text = "";
            dataGridView1.DataSource = objpre.P_listar_productos();
        }

        private void productos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objpre.P_listar_productos();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            mantenimiento("1");
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mantenimiento("2");
            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mantenimiento("3");
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objlog.id_producto = txtBuscarId_Prod.Text;
            objlog.nombre_producto = txtBuscarNombre.Text;
            DataTable dt = new DataTable();
            dt = objpre.P_buscar_producto(objlog);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtidproducto.Text = dataGridView1[0, fila].Value.ToString();
            txtnombre.Text = dataGridView1[1, fila].Value.ToString();
            txtprecio.Text = dataGridView1[2, fila].Value.ToString();
            txtcantidad.Text = dataGridView1[3, fila].Value.ToString();
            txtidproveedor.Text = dataGridView1[4, fila].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
