using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ValidandoEmail
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            string codigo = Convert.ToString(aleatorio.Next());

            textBox1.Text = codigo;

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("TESTANDO QUEBRA DE LINHA POIS ESQUECI \nQuebra 1 \nQuebra 2 \nQuebra 3 \nQuebra 4 \nQuebra 5 (ultima rsrs...)");
        }
    }
}
