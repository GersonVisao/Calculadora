using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        // Variaveis Globais:
        int a, b;
        string resultado, ultimoOp;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void numeroPressionado(object sender, EventArgs e)
        {
            Button numero = (Button)sender;
            txbTela.Text += numero.Text;
            DataTable dt = new DataTable();
            var e = txbTela.Text("3 * (2+4)", "");

        }
        
        


        private void operacao(object sender, EventArgs e)
        {

            Button operador = (Button)sender;

            // Salvar o numero atual:
            this.a = int.Parse(txbTela.Text);
            this.ultimoOp = operador.Text;

            // Mover as operacoes:
            txbAux.Text = txbTela.Text + " " + operador.Text;

            // Limpar o txtTela:

            return;
            
        }
                   
        

                    
          

             


        }
    }          

