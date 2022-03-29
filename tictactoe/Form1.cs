using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public bool turning, button_disable;
        int ovitoria = 0, xvitoria = 0, empates = 0, rodadas = 0;

        // O método ira procurar por uma forma de vencer a partida.
        void Ofensive()
        {
            // Verificar possibilidades de vitória para a IA.
            // Campo 1 - Linha 1
            if (button3.Text == "O" && button2.Text == "O" && button1.Text == "" || button9.Text == "O" && button5.Text == "O" && button1.Text == "" || button7.Text == "O" && button4.Text == "O" && button1.Text == "")
            {
                button1.Text = "O";
                rodadas++;
                turning = false;
            }

            // Campo 2
            if (button1.Text == "O" && button2.Text == "" && button3.Text == "O" || button8.Text == "O" && button5.Text == "O" && button2.Text == "")
            {
                button2.Text = "O";
                rodadas++;
                turning = false;
            }

            // Campo 3
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" || button7.Text == "O" && button5.Text == "O" && button3.Text == "" || button9.Text == "O" && button6.Text == "O" && button3.Text == "")
            {
                button3.Text = "O";
                rodadas++;
                turning = false;
            }

            // Campo 4
            if (button1.Text == "O" && button4.Text == "" && button7.Text == "O" || button6.Text == "O" && button5.Text == "O" && button4.Text == "")
            {
                button4.Text = "O";
                rodadas++;
                turning = false;
            }

            // Campo 5
            if (button4.Text == "O" && button5.Text == "" && button6.Text == "O" || button2.Text == "O" && button5.Text == "" && button8.Text == "O" || button1.Text == "O" && button5.Text == "" && button9.Text == "O" || button3.Text == "O" && button5.Text == "" && button7.Text == "O")
            {
                button5.Text = "O";
                rodadas++;
                turning = false;
            }

            // Campo 6
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" || button3.Text == "O" && button6.Text == "" && button9.Text == "O")
            {
                button6.Text = "O";
                rodadas++;
                turning = false;
            }

            // Campo 7
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "" || button3.Text == "O" && button5.Text == "O" && button7.Text == "" || button7.Text == "" && button8.Text == "O" && button9.Text == "O")
            {
                button7.Text = "O";
                rodadas++;
                turning = false;
            }

            // Campo 8
            if (button7.Text == "O" && button8.Text == "" && button9.Text == "O" || button2.Text == "O" && button5.Text == "O" && button8.Text == "")
            {
                button8.Text = "O";
                rodadas++;
                turning = false;
            }

            // Campo 9
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "" || button1.Text == "O" && button5.Text == "O" && button9.Text == "" || button3.Text == "O" && button6.Text == "O" && button9.Text == "")
            {
                button9.Text = "O";
                rodadas++;
                turning = false;
            }
        }

        // O método após tentar uma ofensiva, tentará se defender caso não tenha conseguido uma vitória.
        void Defensive()
        {

        }

        // Caso não tenha risco de perda, o método irá definir sua marcação em qualquer local.
        void Random()
        {

        }

        void ChecarVencedor()
        {
            // Player 1
            // Player 2
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turning == false && button_disable == false && button2.Text == "")
            {
                button2.Text = "X";
                rodadas++;
                turning = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turning == false && button_disable == false && button3.Text == "")
            {
                button3.Text = "X";
                rodadas++;
                turning = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turning == false && button_disable == false && button4.Text == "")
            {
                button4.Text = "X";
                rodadas++;
                turning = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turning == false && button_disable == false && button5.Text == "")
            {
                button5.Text = "X";
                rodadas++;
                turning = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turning == false && button_disable == false && button6.Text == "")
            {
                button6.Text = "X";
                rodadas++;
                turning = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turning == false && button_disable == false && button7.Text == "")
            {
                button7.Text = "X";
                rodadas++;
                turning = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turning == false && button_disable == false && button8.Text == "")
            {
                button8.Text = "X";
                rodadas++;
                turning = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turning == false && button_disable == false && button9.Text == "")
            {
                button9.Text = "X";
                rodadas++;
                turning = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turning == false && button_disable == false && button1.Text == "")
            {
                button1.Text = "X";
                rodadas++;
                turning = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }


    }
}
