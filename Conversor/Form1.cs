using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form   
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double[] longitud = { 1000, 1, 0.01, 0.001, 0.000001, 0.000000001, 1609.34, 0.9144, 0.3048, 0.0254, 0.835905 };
                double Cantidad = double.Parse(txtValor.Text);
                double resultadoFinal;
                int ValorDE = cboLongitudDE.SelectedIndex, ValorA = cboLongitudA.SelectedIndex;
                resultadoFinal = (((longitud[ValorDE]) / (longitud[ValorA])) * (Cantidad));
                lblLongitud.Text = resultadoFinal.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                double[] peso = { 1000, 1, 0.001, 1e-6, 1e-9, 1016.05, 907, 6.35029, 0.453592142840941, 0.0283495 };
                double resultadoFinal;
                double Cantidad = double.Parse(txtpeso.Text);
                int ValorDe = cboPesoDe.SelectedIndex, ValorA = cboPesoA.SelectedIndex;
            resultadoFinal = (((peso[ValorDe])/ (peso[ValorA]))*(Cantidad));
            lblPeso.Text = resultadoFinal.ToString();
            }catch (Exception )
            {
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double[] volumen = {1, 3.78541, 0.946353 , 0.473176 , 0.24 , 0.0295735 , 0.0147868 , 0.00492892 , 1000 , 0.001 , 4.54609 , 1.13652 , 0.568259999995728 , 0.284131 , 0.0284131 , 0.0177582 , 0.00591939 , 28.3168 , 0.0163871 };
                double resultadoFinal;
                double Cantidad = double.Parse(txtVolumen.Text);
                int ValorDe = cboVolumenDe.SelectedIndex, ValorA = cboVolumenA.SelectedIndex;
                resultadoFinal = (((volumen[ValorDe]) / (volumen[ValorA])) * (Cantidad));
                lblVolumen.Text = resultadoFinal.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double[] almacenamiento = {1, 1000, 1024, 1e+6, 1.049e+6, 1e+9, 1.074e+9, 1e+12, 1.1e+12, 1e+15, 1.126e+15, 8, 8000, 8192, 8e+6, 8.389e+6, 8e+9, 8.59e+9, 8e+12, 8.796e+12, 8e+15, 9.007e+15 };
                double resultadoFinal;
                double Cantidad = double.Parse(txtAlmacenamiento.Text);
                int ValorDe = cboAlmacenamientoDe.SelectedIndex, ValorA = cboAlmacenamientoA.SelectedIndex;
                resultadoFinal = (((almacenamiento[ValorDe]) / (almacenamiento[ValorA])) * (Cantidad));
                lblAlmacenamiento.Text = resultadoFinal.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboLongitudDE.SelectedIndex = 0;
            cboLongitudA.SelectedIndex = 1;

            cboPesoDe.SelectedIndex = 0;
            cboPesoA.SelectedIndex = 1;

            cboVolumenDe.SelectedIndex = 0;
            cboVolumenA.SelectedIndex = 1;

            cboAlmacenamientoDe.SelectedIndex = 0;
            cboAlmacenamientoA.SelectedIndex = 1;

            cboDivisasDe.SelectedIndex = 0;
            cboDivisasA.SelectedIndex = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double[] divisas = {1, 1, 10028.90, 419.03, 0.14, 0.0018, 0.11, 0.029, 0.27, 0.10, 0.75, 0.13, 0.72, 0.0071, 0.64, 1.08, 1.02, 0.00015, 0.040, 0.064, 1.30, 0.016, 0.0013, 0.00029, 0.019, 0.020, 0.054, 0.026, 0.13, 0.23, 2.60, 0.016, 0.014, 0.0091, 0.000014, 1.00, 0.30, 0.14 };
                double resultadoFinal;
                double Cantidad = double.Parse(txtDivisas.Text);
                int ValorDe = cboDivisasDe.SelectedIndex, ValorA = cboDivisasA.SelectedIndex;
                resultadoFinal = (((divisas[ValorDe]) / (divisas[ValorA])) * (Cantidad));
                lblDivisas.Text = resultadoFinal.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
