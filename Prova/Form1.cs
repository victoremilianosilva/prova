using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (notaJava.Text != "" && notaCS.Text != "" && notaBD.Text != "")
            {
                decimal notacs = decimal.Parse(notaCS.Text);
                decimal notaBanco = decimal.Parse(notaBD.Text);
                decimal notaJ = decimal.Parse(notaJava.Text);

                decimal media;

                DateTime dtnascimento = DateTime.Parse(dataNasc.Text);
                DateTime hoje = DateTime.Now;

                Boolean cursof = false;
                Boolean cursoj = false;
                Boolean cursoBanco = false;
                Boolean cursoC = false;

                Boolean resultado = false;

                if(cursoBD.Text == "sim")
                {
                    cursoBanco = true;
                } 
                
                if(cursoFaculdade.Text == "sim")
                {
                    cursof = true;
                }

                if(cursoJava.Text == "sim")
                {
                    cursoj = true;
                }

                if(cursoCS.Text == "sim")
                {
                    cursoC = true;
                }

                media = notaJ + notaBanco + notacs / 3;

               double idade = (hoje - dtnascimento).TotalDays / 365;
                if (cursoj == true || cursoC == true)
                {
                    if (idade >= 17 && media >= 70 && cursoBanco == true && cursof == true)
                    {
                        resultado = true;
                    }
                }

                MessageBox.Show(resultado.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else{
                MessageBox.Show("Informe Todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
