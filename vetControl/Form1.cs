using System;
using System.Drawing;
using System.Windows.Forms;

namespace vetControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Datos no válidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEspecie.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Datos no válidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEspecie.Focus();
                return;
            }

            if (!double.TryParse(txtEdad.Text, out double edad) || edad < 0)
            {
                MessageBox.Show("La edad debe ser un número mayor o igual a 0.", "Datos no válidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Focus();
                return;
            }

            if (!double.TryParse(txtPeso.Text, out double peso) || peso <= 0)
            {
                MessageBox.Show("El peso debe ser mayor a 0.", "Datos no válidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return;
            }

            string sexoTexto = txtSexo.Text.Trim().ToUpper();
            if (sexoTexto != "M" && sexoTexto != "H")
            {
                MessageBox.Show("El sexo debe ser M o H.", "Datos no válidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSexo.Focus();
                return;
            }
            char sexo = sexoTexto[0];

            if (lstServicios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un servicio.", "Datos no válidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal costoBase;
            string servicio = lstServicios.Text;
            switch (servicio)
            {
                case "Consulta general": costoBase = 15000m; break;
                case "Vacunación": costoBase = 20000m; break;
                case "Desparasitación": costoBase = 10000m; break;
                case "Baño": costoBase = 12000m; break;
                default: costoBase = 0m; break;
            }

            double meses = edad * 12;
            string etapa;
            decimal descuento = 0m;

            if (edad < 1)
            {
                etapa = "Cachorro";
                lblEtapa.BackColor = Color.LightGreen;
            }
            else if (edad >= 7)
            {
                etapa = "Senior";
                descuento = costoBase * 0.10m;
                lblEtapa.BackColor = Color.Khaki;
            }
            else
            {
                etapa = "Adulto";
                lblEtapa.BackColor = Color.LightBlue;
            }

            lblEtapa.Text = etapa;
            lblMeses.Text = $"Edad en meses: {meses}";

            decimal subtotal = costoBase - descuento;
            decimal impuesto = subtotal * 0.13m;
            decimal total = subtotal + impuesto;

            lblCosto.Text = $"Descuento: ₡{descuento:N0}\nSubtotal: ₡{subtotal:N0}\nImpuesto 13%: ₡{impuesto:N0}\nTOTAL: ₡{total:N0}";

            string sexoCompleto;
            switch (sexo)
            {
                case 'M': sexoCompleto = "Macho"; break;
                case 'H': sexoCompleto = "Hembra"; break;
                default: sexoCompleto = "No definido"; break;
            }

            string linea = $"{txtNombre.Text.Trim()} ({sexoCompleto}) - {txtEspecie.Text.Trim()} - {etapa} - {servicio} - ₡{total:N0}";
            lstMascotas.Items.Add(linea);
            lblTotal.Text = $"Mascotas: {lstMascotas.Items.Count}";

            string resumen = $"Nombre: {txtNombre.Text.Trim()}\nServicio: {servicio}\nEtapa: {etapa}\nTotal: ₡{total:N0}";
            MessageBox.Show(resumen, "Mascota registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblMensaje.Text = "Mascota agregada correctamente";
            lblMensaje.ForeColor = Color.Green;

            txtNombre.Clear();
            txtEspecie.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtSexo.Clear();
            lstServicios.SelectedIndex = -1;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "¿Desea limpiar también los campos de texto?",
                "Limpiar lista", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                lstMascotas.Items.Clear();
                lblTotal.Text = "Mascotas: 0";
                txtNombre.Clear(); txtEspecie.Clear(); txtEdad.Clear();
                txtPeso.Clear(); txtSexo.Clear(); lstServicios.SelectedIndex = -1;
                lblMensaje.Text = "Todo limpiado";
                lblMensaje.ForeColor = Color.Blue;
            }
            else if (r == DialogResult.No)
            {
                lstMascotas.Items.Clear();
                lblTotal.Text = "Mascotas: 0";
                lblMensaje.Text = "Lista limpiada";
                lblMensaje.ForeColor = Color.Blue;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMascotas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una mascota primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = lstMascotas.SelectedItem.ToString();
            DialogResult r = MessageBox.Show($"¿Eliminar a {nombre}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                lstMascotas.Items.RemoveAt(lstMascotas.SelectedIndex);
                lblTotal.Text = $"Mascotas: {lstMascotas.Items.Count}";
                lblMensaje.Text = "Eliminado";
                lblMensaje.ForeColor = Color.Blue;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir de VetControl?", "Confirmar salida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void limpiarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLimpiar_Click(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}