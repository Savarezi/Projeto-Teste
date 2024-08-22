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
    public partial class Form_Futebol : Form
    {
        public Form_Futebol()
        {
            InitializeComponent();
        }
        string Nome_do_Atleta; //Variável para receber o Nome do Atleta
        int Idade_do_Atleta; // Variável para receber a Idade do Atleta
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Botão Voltar Clicado

            Form Principal = new Form_Abertura(); //Instanciando o Formulário Principal
            Principal.ShowDialog();
            Close();
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento Keypress;

            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space) && !(e.KeyChar == (char)Keys.Enter))//Verificando se os Caracteres Digitados são Válidos

            {
                //Caso não tenha digitado um válor válido
                e.Handled = true;
                MessageBox.Show("Caractere Inválido! - Este campo só aceita letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (e.KeyChar == 13) //Tecla Enter Pressionada
            {
                if (txt_Nome.Text == "") //Verificando se o campo esta vazio

                {
                    //Campo vazio
                    MessageBox.Show("Digite o Nome !!! Por Favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Nome.Focus();
                    return;
                }//If

                else
                {
                    //O Campo não está vazio
                    Nome_do_Atleta = (txt_Nome.Text);

                    txt_Nome.Text = Nome_do_Atleta;
                    txt_Nome.Enabled = false; //Desabilitando o text box Nome
                    txt_Idade.Enabled = true; //Habvilitando o textbox Nome
                    txt_Idade.Focus(); //Posicionando o cursor no Campo de Idade 
                } //else
            }


        }//if

        private void txt_Idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KeyPress Idade

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //Verificando se o valor digitado é válido
            {

                e.Handled = true; //verificando se o que foi digitado condiz com a proposta
                MessageBox.Show("Caractere Inválido Digitado !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }//if

            if (e.KeyChar == 13)//Tecla enter Digitada
            {
                if (txt_Idade.Text != "")//Verificando se a didae foi digitada
                {

                    Idade_do_Atleta = int.Parse(txt_Idade.Text);





                    if ((Idade_do_Atleta >= 5) && (Idade_do_Atleta <= 10))

                    {
                        MessageBox.Show("Parabens !!! " + Nome_do_Atleta + "\r\n" + "Você esta na Categoria Infantil", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //return;//para encerrar a execução    
                    }//if (Infantil)    



                    if ((Idade_do_Atleta >= 11) && (Idade_do_Atleta <= 15))

                    {
                        MessageBox.Show("Parabens !!! " + Nome_do_Atleta + "\r\n" + "Você esta na Categoria Juvenil", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //return;//para encerrar a execução 
                    }//if (Juvenil)


                    else if ((Idade_do_Atleta >= 16) && (Idade_do_Atleta <= 20))
                    {
                        MessageBox.Show("Parabens !!! " + Nome_do_Atleta + "\r\n" + "Você esta na Categoria Junior", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //return;//para encerrar a execução 
                    }//if (Junior)

                    else if ((Idade_do_Atleta >= 21) && (Idade_do_Atleta <= 25))

                    {
                        MessageBox.Show("Parabens !!! " + Nome_do_Atleta + "\r\n" + "Você esta na Categoria Profissional", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //return;//para encerrar a execução 
                    }//If Profissional

                    else
                    {
                        MessageBox.Show("Atenção !!! " + Nome_do_Atleta + "\r\n" + "Você não está Qualificado em nenhuma Categoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //return;//para encerrar a execução 
                    }
                    txt_Nome.Clear();
                    txt_Nome.Focus();
                    txt_Idade.Clear();
                    txt_Nome.Enabled = true;
                    txt_Nome.Focus();


                    




                }//if
                else
                {
                    MessageBox.Show("Por favor Digite a Idade do Atleta !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Idade.Focus();
                
                }//else
                //txt_Nome.Clear();



            }//if
           
            





        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Idade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

