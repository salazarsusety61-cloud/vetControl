namespace vetControl
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtEspecie = new TextBox();
            txtEdad = new TextBox();
            txtPeso = new TextBox();
            txtSexo = new TextBox();
            lstServicios = new ListBox();
            lstMascotas = new ListBox();
            lblMensaje = new Label();
            lblMeses = new Label();
            lblCosto = new Label();
            lblTotal = new Label();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnColor = new Button();
            colorDialog1 = new ColorDialog();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            limpiarListaToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblEtapa = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 37);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(114, 77);
            txtEspecie.Margin = new Padding(3, 4, 3, 4);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(228, 27);
            txtEspecie.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(114, 117);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(114, 27);
            txtEdad.TabIndex = 9;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(114, 157);
            txtPeso.Margin = new Padding(3, 4, 3, 4);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(114, 27);
            txtPeso.TabIndex = 10;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(114, 197);
            txtSexo.Margin = new Padding(3, 4, 3, 4);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(68, 27);
            txtSexo.TabIndex = 11;
            // 
            // lstServicios
            // 
            lstServicios.FormattingEnabled = true;
            lstServicios.Items.AddRange(new object[] { "Consulta general", "Vacunación", "Desparasitación", "Baño" });
            lstServicios.Location = new Point(93, 232);
            lstServicios.Margin = new Padding(3, 4, 3, 4);
            lstServicios.Name = "lstServicios";
            lstServicios.Size = new Size(228, 84);
            lstServicios.TabIndex = 12;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(0, 577);
            lstMascotas.Margin = new Padding(3, 4, 3, 4);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(378, 84);
            lstMascotas.TabIndex = 17;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(23, 689);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 18;
            // 
            // lblMeses
            // 
            lblMeses.Location = new Point(263, 536);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(200, 25);
            lblMeses.TabIndex = 20;
            lblMeses.Text = "Edad en meses:";
            // 
            // lblCosto
            // 
            lblCosto.Location = new Point(263, 415);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(300, 100);
            lblCosto.TabIndex = 21;
            lblCosto.Text = "Desglose de costo:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1, 669);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(86, 20);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "Mascotas: 0";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(23, 347);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 40);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(145, 350);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 40);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(366, 347);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 40);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(251, 347);
            btnColor.Margin = new Padding(3, 4, 3, 4);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(103, 40);
            btnColor.TabIndex = 15;
            btnColor.Text = "Color";
            btnColor.Click += btnColor_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(594, 30);
            menuStrip1.TabIndex = 23;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { limpiarListaToolStripMenuItem, eliminarToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // limpiarListaToolStripMenuItem
            // 
            limpiarListaToolStripMenuItem.Name = "limpiarListaToolStripMenuItem";
            limpiarListaToolStripMenuItem.Size = new Size(236, 26);
            limpiarListaToolStripMenuItem.Text = "Limpiar lista";
            limpiarListaToolStripMenuItem.Click += limpiarListaToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(236, 26);
            eliminarToolStripMenuItem.Text = "Eliminar seleccionada";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 40);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 80);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Especie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 120);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 160);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Peso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 200);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "Sexo (M/H):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 240);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 5;
            label6.Text = "Servicio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 541);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 6;
            label7.Text = "Mascotas:";
            label7.Click += label7_Click;
            // 
            // lblEtapa
            // 
            lblEtapa.BorderStyle = BorderStyle.FixedSingle;
            lblEtapa.Location = new Point(23, 465);
            lblEtapa.Name = "lblEtapa";
            lblEtapa.Size = new Size(180, 50);
            lblEtapa.TabIndex = 24;
            lblEtapa.Text = "Etapa:";
            lblEtapa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 707);
            Controls.Add(lblEtapa);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtNombre);
            Controls.Add(txtEspecie);
            Controls.Add(txtEdad);
            Controls.Add(txtPeso);
            Controls.Add(txtSexo);
            Controls.Add(lstServicios);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnColor);
            Controls.Add(btnSalir);
            Controls.Add(lstMascotas);
            Controls.Add(lblMensaje);
            Controls.Add(lblMeses);
            Controls.Add(lblCosto);
            Controls.Add(lblTotal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "VetControl";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.ListBox lstServicios;
        private System.Windows.Forms.ListBox lstMascotas;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Label lblEtapa;
    }
}