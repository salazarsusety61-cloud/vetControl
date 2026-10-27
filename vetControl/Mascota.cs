using System;

namespace vetControl
{
    internal class Mascota
    {
        // Datos de la mascota
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public double Edad { get; set; }
        public double Peso { get; set; }
        public string Sexo { get; set; }
        public string Servicio { get; set; }

        // Constructor
        public Mascota(string nombre, string especie, double edad, double peso, string sexo, string servicio)
        {
            Nombre = nombre;
            Especie = especie;
            Edad = edad;
            Peso = peso;
            Sexo = sexo;
            Servicio = servicio;
        }

        // Calcular edad en meses
        public int CalcularEdadEnMeses()
        {
            return (int)(Edad * 12);
        }

        // Obtener etapa de vida
        public string ObtenerEtapa()
        {
            if (Edad < 1)
                return "Cachorro";
            else if (Edad < 7)
                return "Adulto";
            else
                return "Senior";
        }

        // Obtener nombre completo del sexo
        public string ObtenerSexoCompleto()
        {
            return Sexo.ToUpper() == "M" ? "Macho" : "Hembra";
        }

        // Obtener costo base del servicio
        public double ObtenerCostoBase()
        {
            switch (Servicio)
            {
                case "Consulta general": return 15000;
                case "Vacunación": return 20000;
                case "Desparasitación": return 10000;
                case "Baño": return 12000;
                default: return 0;
            }
        }

        // Calcular descuento
        public double CalcularDescuento()
        {
            if (ObtenerEtapa() == "Senior")
                return ObtenerCostoBase() * 0.10;
            return 0;
        }

        // Calcular impuesto 13%
        public double CalcularImpuesto()
        {
            double subtotal = ObtenerCostoBase() - CalcularDescuento();
            return subtotal * 0.13;
        }

        // Calcular total a pagar
        public double CalcularTotal()
        {
            double subtotal = ObtenerCostoBase() - CalcularDescuento();
            return subtotal + CalcularImpuesto();
        }

        // Texto para mostrar en la lista
        public string ObtenerResumen()
        {
            return $"{Nombre} ({ObtenerSexoCompleto()}) - {Especie} - {ObtenerEtapa()} - {Servicio} - ₡{CalcularTotal():N0}";
        }
    }
}