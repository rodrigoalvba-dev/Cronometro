using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class FrCronometro : Form
    {
        int segundos = 0;
int minutos = 0;
int horas = 0;
        int milisegundos=0;

        public FrCronometro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milisegundos++;

            if (milisegundos == 100)
            {
                milisegundos = 0;
                segundos++;
            }

            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }

            if (minutos == 60)
            {
                minutos = 0;
                horas++;
            }
            
            label1.Text = horas.ToString("00") + ":" +
                             minutos.ToString("00") + ":" +
                             segundos.ToString("00")+milisegundos.ToString("00");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrCronometro_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            milisegundos = 0;
            segundos = 0;
            minutos = 0;
            horas = 0;

            label1.Text = "00:00:00,00";

        }
    }
}
