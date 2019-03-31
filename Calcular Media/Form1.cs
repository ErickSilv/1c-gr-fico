using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Media
{
    public partial class Calcula2Notas : Form
    {
        public Calcula2Notas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double media;
            media = (double.Parse(ctxNota1.Text) + double.Parse(ctxNota2.Text)) / 2;
            resultado.Text = media.ToString();
            situacao.Text = media >= 6 ? "Aprovado":"Reprovado";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ctxNota1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctxNota1.Text = " ";
            ctxNota2.Text = " ";
            resultado.Text = " ";
            situacao.Text = " ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            
        }
    }
}
