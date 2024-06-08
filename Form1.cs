using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsForms_Sueldo_Neto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los cuadros de texto
            textBoxSueldoBase.Clear();
            
            txt_sueldo_bruto.Clear();
            txt_descuento_afp.Clear();
            txt_descuento_sfs.Clear();
            txt_total_descuento.Clear();
            txt_sueldo_neto.Clear();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            // Obtener el sueldo base y el número de hijos
            decimal sueldoBase = 0;
            int numeroHijos = 0;

            // Validar y obtener el sueldo base
            if (!decimal.TryParse(textBoxSueldoBase.Text, out sueldoBase))
            {
                MessageBox.Show("Ingrese un sueldo base válido.");
                return;
            }

            // Obtener el número de hijos desde el NumericUpDown
            numeroHijos = (int)numericUpDownHijos.Value;

            // Calcular incentivos
            decimal incentivoPorHijo = 500m;
            decimal totalIncentivos = numeroHijos * incentivoPorHijo;

            // Calcular sueldo bruto
            decimal sueldoBruto = sueldoBase + totalIncentivos;

            // Calcular descuentos
            decimal descuentoAFP = sueldoBruto * 0.0287m; // 2.87% de AFP
            decimal descuentoSFS = sueldoBruto * 0.0304m; // 3.04% de SFS

            // Calcular total de descuentos
            decimal totalDescuentos = descuentoAFP + descuentoSFS;

            // Calcular sueldo neto
            decimal sueldoNeto = sueldoBruto - totalDescuentos;

            // Mostrar resultados
            txt_sueldo_bruto.Text = sueldoBruto.ToString();
            txt_descuento_afp.Text = descuentoAFP.ToString();
            txt_descuento_sfs.Text = descuentoSFS.ToString();
            txt_total_descuento.Text = totalDescuentos.ToString();
            txt_sueldo_neto.Text =sueldoNeto.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelSueldoBruto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
