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
    public partial class proovedores : Form
    {
        ClaseLogica objlog = new ClaseLogica();
        ClasePresentacion objpre = new ClasePresentacion();

        public proovedores()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objlog.id_provedor = txtidprov.Text;
            objlog.nombre_proveedor = txtNombre.Text;
            objlog.telefono_proveedor = Convert.ToInt32(txttelefono.Text);
            objlog.accion = accion;
            String men = objpre.P_modificar_proveedor(objlog);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            txtidprov.Text = "";
            txtNombre.Text = "";
            txttelefono.Text = "";
            dataGridView1.DataSource = objpre.P_listar_proveedores();
        }

        private void proovedores_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objpre.P_listar_proveedores();
        }

        private void Nuevo_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mantenimiento("1");
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mantenimiento("2");
            limpiar();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            mantenimiento("3");
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objlog.id_provedor = txtbuscaridprov.Text;
            objlog.nombre_proveedor = txtBuscarNombre.Text;
            DataTable dt = new DataTable();
            dt = objpre.P_buscar_proveedor(objlog);
            dataGridView1.DataSource = dt;
        }

        private void txtbuscaridprov_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtidprov.Text = dataGridView1[0, fila].Value.ToString();
            txtNombre.Text = dataGridView1[1, fila].Value.ToString();
            txttelefono.Text = dataGridView1[2, fila].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
