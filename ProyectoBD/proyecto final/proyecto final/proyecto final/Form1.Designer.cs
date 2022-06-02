namespace proyecto_final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titulo = new System.Windows.Forms.Panel();
            this.btnres = new System.Windows.Forms.PictureBox();
            this.btnmini = new System.Windows.Forms.PictureBox();
            this.btnmaxi = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnclientes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnproovedor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnventas = new System.Windows.Forms.Button();
            this.btnproducto = new System.Windows.Forms.Button();
            this.cotenedor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.menu.SuspendLayout();
            this.cotenedor.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.titulo.Controls.Add(this.btnres);
            this.titulo.Controls.Add(this.btnmini);
            this.titulo.Controls.Add(this.btnmaxi);
            this.titulo.Controls.Add(this.btncerrar);
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1300, 35);
            this.titulo.TabIndex = 0;
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            // 
            // btnres
            // 
            this.btnres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnres.Image = ((System.Drawing.Image)(resources.GetObject("btnres.Image")));
            this.btnres.Location = new System.Drawing.Point(1207, 3);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(20, 26);
            this.btnres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnres.TabIndex = 2;
            this.btnres.TabStop = false;
            this.btnres.Visible = false;
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // btnmini
            // 
            this.btnmini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmini.Image = ((System.Drawing.Image)(resources.GetObject("btnmini.Image")));
            this.btnmini.Location = new System.Drawing.Point(1181, 3);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(20, 26);
            this.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmini.TabIndex = 1;
            this.btnmini.TabStop = false;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            // 
            // btnmaxi
            // 
            this.btnmaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnmaxi.Image")));
            this.btnmaxi.Location = new System.Drawing.Point(1207, 3);
            this.btnmaxi.Name = "btnmaxi";
            this.btnmaxi.Size = new System.Drawing.Size(21, 26);
            this.btnmaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaxi.TabIndex = 1;
            this.btnmaxi.TabStop = false;
            this.btnmaxi.Click += new System.EventHandler(this.btnmaxi_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Image = global::proyecto_final.Properties.Resources.cerrar;
            this.btncerrar.Location = new System.Drawing.Point(1234, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 26);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menu.Controls.Add(this.panel6);
            this.menu.Controls.Add(this.btnclientes);
            this.menu.Controls.Add(this.panel4);
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.btnproovedor);
            this.menu.Controls.Add(this.panel1);
            this.menu.Controls.Add(this.btnventas);
            this.menu.Controls.Add(this.btnproducto);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 35);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(200, 645);
            this.menu.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(0, 269);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 31);
            this.panel6.TabIndex = 5;
            // 
            // btnclientes
            // 
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(12, 270);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(188, 30);
            this.btnclientes.TabIndex = 6;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 31);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 31);
            this.panel2.TabIndex = 3;
            // 
            // btnproovedor
            // 
            this.btnproovedor.FlatAppearance.BorderSize = 0;
            this.btnproovedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnproovedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproovedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnproovedor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnproovedor.Image = ((System.Drawing.Image)(resources.GetObject("btnproovedor.Image")));
            this.btnproovedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproovedor.Location = new System.Drawing.Point(12, 217);
            this.btnproovedor.Name = "btnproovedor";
            this.btnproovedor.Size = new System.Drawing.Size(188, 30);
            this.btnproovedor.TabIndex = 4;
            this.btnproovedor.Text = "Proovedores";
            this.btnproovedor.UseVisualStyleBackColor = true;
            this.btnproovedor.Click += new System.EventHandler(this.btnproovedor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 31);
            this.panel1.TabIndex = 0;
            // 
            // btnventas
            // 
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnventas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnventas.Image = ((System.Drawing.Image)(resources.GetObject("btnventas.Image")));
            this.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventas.Location = new System.Drawing.Point(12, 156);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(188, 30);
            this.btnventas.TabIndex = 4;
            this.btnventas.Text = "Ventas";
            this.btnventas.UseVisualStyleBackColor = true;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // btnproducto
            // 
            this.btnproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproducto.FlatAppearance.BorderSize = 0;
            this.btnproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnproducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnproducto.Image = ((System.Drawing.Image)(resources.GetObject("btnproducto.Image")));
            this.btnproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducto.Location = new System.Drawing.Point(12, 100);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(188, 30);
            this.btnproducto.TabIndex = 0;
            this.btnproducto.Text = "Productos";
            this.btnproducto.UseVisualStyleBackColor = true;
            this.btnproducto.Click += new System.EventHandler(this.btnproducto_Click);
            // 
            // cotenedor
            // 
            this.cotenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cotenedor.Controls.Add(this.panel3);
            this.cotenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cotenedor.Location = new System.Drawing.Point(200, 35);
            this.cotenedor.Name = "cotenedor";
            this.cotenedor.Size = new System.Drawing.Size(1100, 645);
            this.cotenedor.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 645);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 645);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 680);
            this.Controls.Add(this.cotenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.menu.ResumeLayout(false);
            this.cotenedor.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel titulo;
        private PictureBox btncerrar;
        private Panel menu;
        private Panel cotenedor;
        private PictureBox btnres;
        private PictureBox btnmini;
        private PictureBox btnmaxi;
        private Panel panel1;
        private Button btnproducto;
        private Panel panel6;
        private Button btnclientes;
        private Panel panel4;
        private Panel panel2;
        private Button btnproovedor;
        private Button btnventas;
        private Panel panel3;
        private Panel panel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}