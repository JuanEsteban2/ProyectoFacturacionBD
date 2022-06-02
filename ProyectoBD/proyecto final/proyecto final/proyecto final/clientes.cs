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
    public partial class clientes : Form
    {
        ClaseLogica objlog = new ClaseLogica();
        ClasePresentacion objpre = new ClasePresentacion();

        public clientes()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objlog.id_cliente = txtidcliente.Text;
            objlog.nombre_cliente = txtnombre.Text;
            objlog.telefono_cliente = Convert.ToInt32(txttelefono.Text);
            objlog.accion = accion;
            String men = objpre.P_modificar_cliente(objlog);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            txtidcliente.Text = "";
            txtnombre.Text = "";
            txttelefono.Text = "";
            dataGridView1.DataSource = objpre.P_listar_clientes();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objpre.P_listar_clientes();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mantenimiento("1");
            limpiar();
        }

        private void button3_Click_1(object sender, EventArgs e)
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
            objlog.id_cliente = txtbuscaridcli.Text;
            objlog.nombre_cliente = txtBuscarNombre.Text;
            DataTable dt = new DataTable();
            dt = objpre.P_buscar_cliente(objlog);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtidcliente.Text = dataGridView1[0, fila].Value.ToString();
            txtnombre.Text = dataGridView1[1, fila].Value.ToString();
            txttelefono.Text = dataGridView1[2, fila].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscaridcli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
