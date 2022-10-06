namespace CalculadoraCSharp
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btn_salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_keyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Limpiar(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
        }

        private void btn_Operar(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "" || textBox2.Text == null)
            {
                textBox2.Text = "0";
            }
            if (textBox3.Text == "" || textBox3.Text == null)
            {
                textBox3.Text = "0";
            }
            if (textBox4.Text == "" || textBox4.Text == null)
            {
                textBox4.Text = "0";
            }
            double valorAdevolver = (double.Parse(textBox1.Text) + (2 * double.Parse(textBox2.Text)) + (3 * double.Parse(textBox3.Text)) + (4 * double.Parse(textBox4.Text))) / 4;
            textBox5.Text = valorAdevolver.ToString();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }
    }
}