using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            double horastrabajadas = double.Parse(txtHorasTrabajadas.Text);
            double valorhora = double.Parse(txtValorHora.Text);
            double total = horastrabajadas * valorhora;

            if (total > 750000) {
                MessageBox.Show("El empleado gana mas del minimo");
                lblTotalSalario.Text = total.ToString();
                lblTotalSalario.Visible = true;
            } else {
                total = (total * 0.20) + total;
                lblTotalSalario.Text = total.ToString();
                lblTotalSalario.Visible = true;
            }
        }
    }
}
