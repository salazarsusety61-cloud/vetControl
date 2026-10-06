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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            txtNombre = new TextBox();
            txtEspecie = new TextBox();
            txtEdad = new TextBox();
            txtPeso = new TextBox();
            txtSexo = new TextBox();
            lblEtapa = new Label();
            lblMeses = new Label();
            lblCosto = new Label();
            lblMensaje = new Label();
            lblTotal = new Label();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnColor = new Button();
            btnSalir = new Button();
            lstMascotas = new ListBox();
            cmsLista = new ContextMenuStrip(components);
            mnuEliminar = new ToolStripMenuItem();
            mnuLimpiar = new ToolStripMenuItem();
            using var _ = colorDialog1 = new ColorDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblServicios = new Label();
            lstServicios = new ListBox();
            mnuSalir = new ToolStripMenuItem();
            cmsLista.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(23, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(291, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de mascotas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 93);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(95, 142);
            txtEspecie.Margin = new Padding(3, 4, 3, 4);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(114, 27);
            txtEspecie.TabIndex = 3;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(95, 197);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(114, 27);
            txtEdad.TabIndex = 4;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(95, 247);
            txtPeso.Margin = new Padding(3, 4, 3, 4);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(114, 27);
            txtPeso.TabIndex = 5;
            // 
            // txtSexo
            // 
            txtSexo.CharacterCasing = CharacterCasing.Upper;
            txtSexo.Location = new Point(109, 313);
            txtSexo.Margin = new Padding(3, 4, 3, 4);
            txtSexo.MaxLength = 1;
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(114, 27);
            txtSexo.TabIndex = 6;
            // 
            // lblEtapa
            // 
            lblEtapa.BorderStyle = BorderStyle.FixedSingle;
            lblEtapa.Location = new Point(229, 93);
            lblEtapa.Name = "lblEtapa";
            lblEtapa.Size = new Size(205, 53);
            lblEtapa.TabIndex = 8;
            lblEtapa.Text = "-";
            lblEtapa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(229, 160);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(0, 20);
            lblMeses.TabIndex = 9;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(229, 200);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(0, 20);
            lblCosto.TabIndex = 10;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(23, 413);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 11;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(23, 787);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(86, 20);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Mascotas: 0";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(23, 467);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(137, 467);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(251, 467);
            btnColor.Margin = new Padding(3, 4, 3, 4);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(86, 31);
            btnColor.TabIndex = 14;
            btnColor.Text = "Color";            
            
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(366, 467);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            
            // 
            // lstMascotas
            // 
            lstMascotas.ContextMenuStrip = cmsLista;
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(23, 533);
            lstMascotas.Margin = new Padding(3, 4, 3, 4);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(457, 224);
            lstMascotas.TabIndex = 16;
            // 
            // cmsLista
            // 
            cmsLista.ImageScalingSize = new Size(20, 20);
            cmsLista.Items.AddRange(new ToolStripItem[] { mnuEliminar, mnuLimpiar, mnuSalir });
            cmsLista.Name = "cmsLista";
            cmsLista.Size = new Size(211, 104);
            // 
            // mnuEliminar
            // 
            mnuEliminar.Name = "mnuEliminar";
            mnuEliminar.Size = new Size(210, 24);
            mnuEliminar.Text = "Eliminar";
            mnuEliminar.Click += Eliminar_Click;
            // 
            // mnuLimpiar
            // 
            mnuLimpiar.Name = "mnuLimpiar";
            mnuLimpiar.Size = new Size(210, 24);
            mnuLimpiar.Text = "Limpiar lista";
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 18;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 19;
            label2.Text = "Especie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, 197);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 20;
            label3.Text = "Edad (años):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 250);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 21;
            label4.Text = "Peso (kg):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 313);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 22;
            label5.Text = "Sexo (M/H):";
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Location = new Point(19, 362);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(68, 20);
            lblServicios.TabIndex = 23;
            lblServicios.Text = "Servicio :";
           
            // 
            // lstServicios
            // 
            lstServicios.FormattingEnabled = true;
            lstServicios.Items.AddRange(new object[] { "Consulta general", "Vacunación", "Desparasitación", "Baño" });
            lstServicios.Location = new Point(260, 196);
            lstServicios.Name = "lstServicios";
            lstServicios.Size = new Size(150, 144);
            lstServicios.TabIndex = 25;
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(210, 24);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += Salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 867);
            Controls.Add(lstServicios);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(txtNombre);
            Controls.Add(txtEspecie);
            Controls.Add(txtEdad);
            Controls.Add(txtPeso);
            Controls.Add(txtSexo);
            Controls.Add(lblEtapa);
            Controls.Add(lblMeses);
            Controls.Add(lblCosto);
            Controls.Add(lblMensaje);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnColor);
            Controls.Add(btnSalir);
            Controls.Add(lstMascotas);
            Controls.Add(lblTotal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Load += Form1_Load;
            cmsLista.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstMascotas;
        private System.Windows.Forms.ContextMenuStrip cmsLista;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private System.Windows.Forms.ToolStripMenuItem mnuLimpiar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblServicios;
        private ListBox lstServicios;
        private ToolStripMenuItem mnuSalir;
    }
}