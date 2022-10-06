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
    public partial class Ejercicio2 : Form
    {
        private String frase;

        private void btnFrase1_Click(object sender, EventArgs e)
        {
            frase += " " + textBox1.Text;
            textBox1.Text = "";
            textBox1.Focus();
            btnFrase1.Enabled = false;
            btnFrase2.Enabled = true;

        }
        private void btnFrase2_Click(object sender, EventArgs e)
        {
            frase += " " + textBox1.Text;
            textBox1.Text = "";
            textBox1.Focus();
            btnFrase2.Enabled = false;
            btnFrase3.Enabled = true;
        }

        private void btnFrase3_Click(object sender, EventArgs e)
        {
            frase += " " + textBox1.Text;
            textBox1.Text = "";
            textBox1.Focus();
            btnFrase3.Enabled = false;
            btnFrase4.Enabled = true;
        }

        private void btnFrase4_Click(object sender, EventArgs e)
        {
            frase += " " + textBox1.Text;
            textBox1.Text = "";
            textBox1.Focus();
            btnFrase4.Enabled = false;
            btnFrase5.Enabled = true;
        }

        private void btnFrase5_Click(object sender, EventArgs e)
        {
            frase += " " + textBox1.Text;
            textBox1.Text = "";
            textBox1.Focus();
            btnFrase5.Enabled = false;
            btnUnir.Enabled = true;
        }

        private void btnUnir_Click(object sender, EventArgs e)
        {
            textBox1.Text = frase;
        }

        

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Limpiar(object sender, EventArgs e)
        {
            textBox1.Text = "";
            btnFrase1.Enabled = true;
            btnFrase2.Enabled = false;
            btnFrase3.Enabled = false;
            btnFrase4.Enabled = false;
            btnFrase5.Enabled = false;
            btnUnir.Enabled = false;
            frase = "";
            textBox1.Focus();
        }



    }
}
