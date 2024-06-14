using ExamenEX_ConversorDivisa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        conversor miconversor;

        public Form1()
        {
            InitializeComponent();
            miconversor = new conversor();
        }


        private void btDolaresAEuros_Click(object sender, EventArgs e)
        {
            double euros;

            euros = miconversor.conv1(tImporte.Text);

            tResultado.Text = euros.ToString();
        }

        private void btEurosADolares_Click(object sender, EventArgs e)
        {
            double dolares;

            dolares = miconversor.conv2(tImporte.Text);

            tResultado.Text = dolares.ToString();
        }

        private void btLibrasAEuros_Click(object sender, EventArgs e)
        {
            double euros;

            euros = miconversor.conv3(tImporte.Text);

            tResultado.Text = euros.ToString();
        }

        private void btEurosALibras_Click(object sender, EventArgs e)
        {
            double libras;

            libras = miconversor.conv4(tImporte.Text);

            tResultado.Text = libras.ToString();
        }
    }
}
