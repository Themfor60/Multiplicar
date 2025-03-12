namespace Multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
            {
                int resultado = Multiplicar(num1, num2);
                label5.Text = $"Resultado: {resultado}";
            }
            else
            {
                MessageBox.Show("Ingrese números válidos.");
            }


        }
        private int Multiplicar(int a, int b)
        {
            int resultado = 0;
            bool negativo = false;

            if (a < 0)
            {
                a = -a;
                negativo = !negativo;
            }

            if (b < 0)
            {
                b = -b;
                negativo = !negativo;
            }

            for (int i = 0; i < b; i++)
            {
                resultado += a;
            }

            return negativo ? -resultado : resultado;
        }
    }
}
