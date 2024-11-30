using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado;
        private int operacion;

        private double saveResult(double result)
        {
            string connectionString = "Server=DESKTOP-G3VTDU2; Database=CalculadoraDB; Integrated Security=True;";

            string query = "INSERT INTO Results (Result) OUTPUT INSERTED.Result VALUES (@result);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@result", result);
                connection.Open();
                var insertedResult = command.ExecuteScalar(); 

                return Convert.ToDouble(insertedResult);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            //Numero 0
            textBox1.Text = textBox1.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Numero 1
            textBox1.Text = textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Numero 2
            textBox1.Text = textBox1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Numero 3
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Numero 4
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Numero 5
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Numero 6
            textBox1.Text = textBox1.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Numero 7
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Numero 8
            textBox1.Text = textBox1.Text + "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Numero 9
            textBox1.Text = textBox1.Text + "9";
        }


        private void button20_Click(object sender, EventArgs e)
        {
            //Boton de Limpiar un numero de 1 a 1
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Boton de Limpiar pantalla
            textBox1.Text = " ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Boton de Igual
            valor2 = Convert.ToDouble(textBox1.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;

                    break;

                case 2:
                    resultado = valor1 - valor2;

                    break;

                case 3:
                    resultado = valor1 * valor2;

                    break;

                case 4:
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    break;

            }

            textBox1.Text = resultado.ToString();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Boton de Sumar
            operacion = 1;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Boton de Restar
            operacion = 2;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Boton de Multiplicar
            operacion = 3;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Boton de Dividir
            operacion = 4;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Boton de Potencia 
            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = valor1;
            resultado = valor1 * valor2;
          

            textBox1.Text = resultado.ToString();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Boton de Raiz cuadrada
            valor1 = Convert.ToDouble(textBox1.Text);
            resultado = Math.Sqrt(valor1);

            textBox1.Text = resultado.ToString();
        }
    }
}
