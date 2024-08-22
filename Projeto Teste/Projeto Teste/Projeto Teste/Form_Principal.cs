using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Teste
{
    public partial class Form_Abertura : Form
    {
        public Form_Abertura()
        {
            InitializeComponent();
        }

      

        private void btn_Meses_Click(object sender, EventArgs e)
        {
            //Botão meses Clicado
          
            MessageBox.Show("Voce é Capaz de Alcançar Tudo que Deseja!!! \r\n Direcionando para o Formulário de Meses!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibindo uma mensagem
 
            Form Form_Meses = new Form_Meses();//Instanciando o Formulário de Meses
            Form_Meses.ShowDialog();//Abrindo o formulário de meses
              Close();

        }

        private void btn_Futebol_Click(object sender, EventArgs e)
        {
            //Botão Futebol Clicado

            MessageBox.Show("Dedique-se, treine com paixão e nunca desista. !!! \r\n Direcionando para o Formulário de Futebol !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibindo uma mensagem


            Form Futebol = new Form_Futebol();
            Futebol.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Botao Eleições Clicado

            MessageBox.Show("Vote com consciencia e faça a diferença!!! \r\n Direcionando para o Formulário de Eleições !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibindo uma mensagem


            Form Eleicoes = new Form_Eleicoes();
            Eleicoes.ShowDialog();
            Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //botão Sair Clicado 

          

            this.Close(); //fechando o Formulário
           
        }

        private void Form_Abertura_Load(object sender, EventArgs e)
        {

        }

        private void btn_Crediario_Click(object sender, EventArgs e)
        {
            //Botão Crediário Clicado

            MessageBox.Show(" Planeje suas finanças.Mantenha o controle e evite dividas desnecessárias !!!  \r\n Direcionando para o Formulário de Crediário!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibindo uma mensagem
        
            Form Crediario = new Form_Crediario();//Instanciando o formulário de Crediário
            Crediario.ShowDialog();//Abreindo o formulário de crediário
            Close();//fechando o formulário atual
        }

        private void btn_Contratacao_Click(object sender, EventArgs e)
        {
            //Botão Contratação Clicado

            MessageBox.Show(" De o seu melhor seja proativo e mostre seu potencial !!!  \r\n Direcionando para o Formulário de Contratação!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); //exibindo uma mensagem

            Form Contratacao = new Form_Contratacao();//Instanciando o formulário de Contrataçao
            Contratacao.ShowDialog();//Abreindo o formulário de contratação
            Close();//fechando o formulário atual
        }
    }
}
