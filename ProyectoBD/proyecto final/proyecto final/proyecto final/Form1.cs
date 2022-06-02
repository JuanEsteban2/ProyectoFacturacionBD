using System.Runtime.InteropServices;
namespace proyecto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaxi.Enabled = false;
            btnres.Enabled = true;
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            btnres.Enabled = false;
            btnmaxi.Enabled=true;
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void abrirpestana(object hija)
        {
            if(this.cotenedor.Controls.Count > 0)
                this.cotenedor.Controls.RemoveAt(0);
            Form? fh = hija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.cotenedor.Controls.Add(fh);
            this.cotenedor.Tag = Tag = fh;
            fh.Show();
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            abrirpestana(new productos());
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            abrirpestana(new ventas());
        }

        private void btnproovedor_Click(object sender, EventArgs e)
        {
            abrirpestana(new proovedores());
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            abrirpestana(new clientes());
        }
    }
}