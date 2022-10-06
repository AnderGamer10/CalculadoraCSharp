using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CalculadoraCSharp
{
    public partial class Ejercicio3 : Form
    {
        public double num1, num2, num3, num4;

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            switch (lblNumero.Text)
            {
                case "Numero 1":
                    num1 = double.Parse(textBox1.Text);
                    System.Diagnostics.Debug.WriteLine (num1);
                    textBox1.Text = "";
                    textBox1.Focus();
                    lblNumero.Text = "Numero 2";
                    break;
                case "Numero 2":
                    num2 = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                    lblNumero.Text = "Numero 3";
                    break;
                case "Numero 3":
                    num3 = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                    lblNumero.Text = "Numero 4";
                    break;
                case "Numero 4":
                    num4 = double.Parse(textBox1.Text);
                    this.Hide();
                    new Ejercicio3P2().Show();
                    break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            lblNumero.Text = "Numero 1";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
