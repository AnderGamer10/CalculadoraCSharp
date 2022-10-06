using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public partial class Ejercicio3P2 : Form
    {
        public Ejercicio3P2()
        {
            InitializeComponent();
        }

        private void Ejercicio3P2_Load(object sender, EventArgs e)
        {
            Ejercicio3 formPrincipal = new Ejercicio3();
            double data = (formPrincipal.num1 + (formPrincipal.num1 * formPrincipal.num2) + (formPrincipal.num2 * formPrincipal.num3) + (formPrincipal.num3 * formPrincipal.num4)) / 4;
            //double data = formPrincipal.num1 * 2;
            textBox1.Text = data.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
