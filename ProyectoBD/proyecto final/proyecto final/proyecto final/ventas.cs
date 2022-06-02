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
    public partial class ventas : Form
    {
        ClaseLogica objlog = new ClaseLogica();
        ClasePresentacion objpre = new ClasePresentacion();

        public ventas()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objlog.id_venta = txtidventa.Text;
            objlog.fecha = txtfecha.Text;
            objlog.precio_total = Convert.ToInt32(txtpreciototal.Text);
            objlog.estado = txtestado.Text;
            objlog.accion = accion;
            String men = objpre.P_modificar_venta(objlog);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            txtidventa.Text = "";
            txtfecha.Text = "";
            txtpreciototal.Text = "";
            txtestado.Text = "";
            dataGridView1.DataSource = objpre.P_listar_ventas();
        }

        private void ventas_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objpre.P_listar_ventas();
        }

        private void Nuevo_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void buttonRegistrar_Click_1(object sender, EventArgs e)
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
            objlog.id_venta = textBuscarIdven.Text;
            DataTable dt = new DataTable();
            dt = objpre.P_buscar_venta(objlog);
            dataGridView1.DataSource = dt;
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtidventa.Text = dataGridView1[0, fila].Value.ToString();
            txtfecha.Text = dataGridView1[1, fila].Value.ToString();
            txtpreciototal.Text = dataGridView1[2, fila].Value.ToString();
            txtestado.Text = dataGridView1[3, fila].Value.ToString();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void txtidventa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
