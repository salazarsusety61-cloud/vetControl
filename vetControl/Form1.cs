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

        // ========== 1. EVENTO LOAD ==========
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "VetControl - Registro de mascotas";
            lblTotal.Text = "Mascotas: 0";
            lblEtapa.Text = "-";
            lblEtapa.BackColor = Color.White;
            lblMensaje.Text = "";
        }

        // ========== MÉTODOS AUXILIARES (los agregamos aquí) ==========
        private void MostrarMensaje(string texto, Color color)
        {
            lblMensaje.Text = texto;
            lblMensaje.ForeColor = color;
        }

        private void ActualizarTotal()
        {
            lblTotal.Text = $"Mascotas: {lstMascotas.Items.Count}";
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEspecie.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtSexo.Clear();
            txtCosto.Clear();
            txtNombre.Focus();
        }

        // ========== 2. BOTÓN AGREGAR ==========
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEspecie.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtPeso.Text) ||
                string.IsNullOrWhiteSpace(txtSexo.Text) ||
                string.IsNullOrWhiteSpace(txtCosto.Text))
            {
                MostrarMensaje("Complete todos los campos.", Color.Red);
                return;
            }

            // Validar edad
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MostrarMensaje("La edad debe ser un número entero.", Color.Red);
                return;
            }
            if (edad < 0 || edad > 30)
            {
                MostrarMensaje("La edad debe estar entre 0 y 30 años.", Color.Red);
                return;
            }

            // Validar peso
            if (!double.TryParse(txtPeso.Text, out double peso))
            {
                MostrarMensaje("El peso debe ser un número.", Color.Red);
                return;
            }
            if (peso <= 0)
            {
                MostrarMensaje("El peso debe ser mayor que 0.", Color.Red);
                return;
            }

            // Validar sexo
            char sexo = char.Parse(txtSexo.Text);
            if (sexo != 'M' && sexo != 'H')
            {
                MostrarMensaje("El sexo debe ser M o H.", Color.Red);
                return;
            }

            // Validar costo
            if (!decimal.TryParse(txtCosto.Text, out decimal costoBase))
            {
                MostrarMensaje("El costo debe ser un número.", Color.Red);
                return;
            }
            if (costoBase <= 0)
            {
                MostrarMensaje("El costo debe ser mayor que 0.", Color.Red);
                return;
            }

            // Edad en meses
            int edadMeses = edad * 12;
            lblMeses.Text = $"Edad en meses: {edadMeses}";

            // Etapa de vida con color
            string etapa;
            if (edad < 1)
            {
                etapa = "Cachorro";
                lblEtapa.BackColor = Color.LightSkyBlue;
            }
            else if (edad <= 7)
            {
                etapa = "Adulto";
                lblEtapa.BackColor = Color.LightGreen;
            }
            else
            {
                etapa = "Senior";
                lblEtapa.BackColor = Color.Khaki;
            }
            lblEtapa.Text = etapa;

            // Cálculo de costo
            decimal descuento = 0m;
            if (edad < 1 || edad >= 8)
            {
                descuento = costoBase * 0.10m;
            }
            decimal subtotal = costoBase - descuento;
            decimal impuesto = subtotal * 0.13m;
            decimal total = subtotal + impuesto;

            lblCosto.Text =
                $"Descuento: ₡{descuento:N0}\n" +
                $"Subtotal: ₡{subtotal:N0}\n" +
                $"Impuesto 13%: ₡{impuesto:N0}\n" +
                $"TOTAL A PAGAR: ₡{total:N0}";

            // Agregar a la lista
            lstMascotas.Items.Add(
                $"{txtNombre.Text} ({sexo}) - {txtEspecie.Text} - {etapa} - ₡{total:N0}"
            );

            // Actualizar y limpiar
            ActualizarTotal();
            MostrarMensaje($"Mascota agregada: {txtNombre.Text}", Color.Green);
            LimpiarCampos();
        }

        // ========== 3. BOTÓN LIMPIAR ==========
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            lblEtapa.Text = "-";
            lblEtapa.BackColor = Color.White;
            lblMeses.Text = "";
            lblCosto.Text = "";
            lblMensaje.Text = "";
        }

        // ========== 4. BOTÓN COLOR ==========
        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        // ========== 5. BOTÓN SALIR ==========
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ========== 6. MENÚ: ELIMINAR ==========
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMascotas.SelectedIndex == -1)
            {
                MostrarMensaje("Primero seleccione una mascota de la lista.", Color.Red);
                return;
            }
            lstMascotas.Items.RemoveAt(lstMascotas.SelectedIndex);
            ActualizarTotal();
        }

        // ========== 7. MENÚ: LIMPIAR LISTA ==========
        private void limpiarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstMascotas.Items.Clear();
            ActualizarTotal();
        }
    }
}