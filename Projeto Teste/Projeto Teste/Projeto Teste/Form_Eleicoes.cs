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
    public partial class Form_Eleicoes : Form
    {

        int Idade_do_Eleitor; // Variável para receber a Idade do Eleitor
        public Form_Eleicoes()
        {
            InitializeComponent();
        }

        private void pictureBox_Voltar_Click(object sender, EventArgs e)
        {
            //  Botão Voltar Clicado
           
            Form Principal = new Form_Abertura(); //Instanciando o Formulário Principal
            Principal.ShowDialog();
            Close();
        }

        private void txt_Idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Keypress txt_Idade

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ','))

            {
                //Verificando se o valor digitado é válido
                e.Handled = true;

                MessageBox.Show("Caractere inválido !!! \r\n Permitido Somente Números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }//if
            if (e.KeyChar == 13) //tecla enter Pressionada

            {
                if (txt_Idade_do_Eleitor.Text =="") //Veificando se a Idade foi digitada
                    {
                    //se a idade não for digitada
                    MessageBox.Show("Digite a Idade!!! Por Favor!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Idade_do_Eleitor.Focus();
                    return;
                    } //if
               
                else
                {
                    //se a idade Foi Digitada
                    Idade_do_Eleitor = Convert.ToInt32(txt_Idade_do_Eleitor.Text);//atribuido e convertendo o valor digitado para a variavel idade

                }//else Idade Digitada

                //Testando a Idade do Eleitor 


                if(Idade_do_Eleitor <=15) //Verificando se a Idade é menor que 15 anos
                {
                    //A Idade é menor ou igual à 15 anos

                    MessageBox.Show("Voce não tem Idade para Votar !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);//Exibindo a Mensagem 
                    txt_Idade_do_Eleitor.Clear();//Limpando a Idade digitada
                    txt_Idade_do_Eleitor.Focus();
                    return;
                }//if

                else if((Idade_do_Eleitor >=18) && (Idade_do_Eleitor<=70)) //Verificando se a idade está entre 18 e 70 anos
                {
                    //A idade está entre 18 e 70 anos
                    MessageBox.Show("Voto Obrigatório !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Idade_do_Eleitor.Clear();
                    txt_Idade_do_Eleitor.Focus();
                    
                }//If

                else
                {

                    MessageBox.Show("O Voto é Facultativo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Idade_do_Eleitor.Clear();
                    txt_Idade_do_Eleitor.Focus();

                }//Else Verificação das Idades





            }//if Enter

        }
    }
}

    

