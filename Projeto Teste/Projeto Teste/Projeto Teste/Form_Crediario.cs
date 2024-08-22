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
    public partial class Form_Crediario : Form
    {
        public Form_Crediario()
        {
            InitializeComponent();
        }

        string Nome_do_Cliente;
        double Renda,Valor_da_Compra;
        private void Form_Crediario_Load(object sender, EventArgs e)
        {
            txt_Nome.Focus();
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento Key Press

            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space) && !(e.KeyChar == (char)Keys.Enter))//Verificando se as Informações Digitadas São Válidas
            {

                //Caso não tenha digitado um válor válido
                e.Handled = true;
                MessageBox.Show("Caractere Inválido! - Este campo só aceita letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }//if
            
            if(e.KeyChar == 13) //Tecla Enter Digitada
            {
                if(txt_Nome.Text == "")//Verificando se o campo nome esta vazio
                {
                    //Campo vazio
                    MessageBox.Show("Digite o Nome !!! Por Favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Nome.Focus();
                    return;
                }//if

                else 
                {
                    //O Nome foi Digitado
                    Nome_do_Cliente = (txt_Nome.Text);//Recebendo O nome do Cliente
                    btn_alterar_Nome.Enabled = true;//Botão Alterar Nome Ativo
                    txt_Nome.Enabled = false; //desabilitando o campo nome
                    txt_Renda.Enabled = true;
                    txt_Renda.Focus();
                }

            }//If tecla Enter campo Nome Digitada digitada

        }

        private void btn_alterar_Nome_Click(object sender, EventArgs e)
        {
            //Botão Altera nome Clicado
            txt_Nome.Enabled = true;//Caixa de texto nome ativa
           
            txt_Renda.Enabled = false;
            btn_Alterar_Renda.Enabled = false;
           
            txt_Valor_Compra.Enabled = false;
            btn_Alterar_valor_Compra.Enabled = false;

            txt_Nome.Focus();
            
            if(txt_Renda.Text !="")//Verificando se exite alguma renda Digitada
            {
                txt_Renda.Text = Renda.ToString("c2");//o C2 Representa a unidade monetária Brasileira
            }//
            else
            {
                txt_Renda.Text = string.Empty;
            }




        }

        private void txt_Renda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Key Press da Renda
            

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ','))//Verificanndo se foi digitado uma informação válida

            {
                e.Handled = true; //verificando se o que foi digitado condiz com a proposta
                MessageBox.Show("Caractere Inválido Digitado ! - Este campo só aceita Números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }//if Keypress

            if(e.KeyChar == 13)//tecla enter Digitado
            {
                if(txt_Renda.Text !="")//Verificando se o campo renda está vazio
                {
                    // txt_Renda.Text = Convert.ToString(Renda);

                   Renda = Convert.ToDouble (txt_Renda.Text.Replace("R$", "").Replace(".", ""));

                  //  Renda = Convert.ToDouble(txt_Renda.Text);//Recebendo o valor da Renda

                                  
                    txt_Renda.Text = Renda.ToString("c2");//o C2 Representa a unidade monetária Brasileira
                    
                   

                    txt_Valor_Compra.Enabled = true;
                    txt_Valor_Compra.Focus();

                    txt_Renda.Enabled = false;
                    btn_Alterar_Renda.Enabled = true;


                }//if
                else
                {
                    MessageBox.Show("Por favor, Informe a Renda do Cliente !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txt_Renda.Focus();
                }//else





            }//If Enter



        }

        private void btn_Alterar_Renda_Click(object sender, EventArgs e)
        {
            //Botão Alterar renda Clicado
            txt_Renda.Text = Convert.ToString(Renda); //Mostrando a Renda sem o R$
            txt_Renda.Enabled = true;//Ativando o campo Renda
            txt_Valor_Compra.Enabled = false;//Desativando o campo Valor da Compra
            btn_Alterar_Renda.Enabled = false;//Desativando o campo alterar renda
           txt_Renda.Focus(); //cursor no campo renda
        }

        private void txt_Renda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Valor_Compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evento Keypress



            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ','))//Verificanndo se foi digitado uma informação válida

            {
                e.Handled = true; //verificando se o que foi digitado condiz com a proposta
                MessageBox.Show("Caractere Inválido Digitado ! - Este campo só aceita Números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }//if Keypress

            if (e.KeyChar == 13)//tecla enter Digitado
            {
                if (txt_Valor_Compra.Text != "")//Verificando se o campo Valor da Compra está vazio
                {
                    

                  Valor_da_Compra = Convert.ToDouble(txt_Valor_Compra.Text.Replace("R$", "").Replace(".", ""));

                    


                   txt_Valor_Compra.Text = Valor_da_Compra.ToString("c2");//o C2 Representa a unidade monetária Brasileira



                    txt_Valor_Compra.Enabled = false;
                    


                    if(Valor_da_Compra>Renda) //Verificando se a compra é maior que a renda
                    {
                        //Compra maior que a renda
                        MessageBox.Show("Bloqueado(a)!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        MessageBox.Show(Nome_do_Cliente + " - Sua Compra está acima da sua Renda !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Avisando que a compra não foi aprovada

                        btn_alterar_Nome.Enabled = true; //Ativando O botão Alterar Nome
                        btn_Alterar_Renda.Enabled = true; //Ativando o Botão Alterar Renda
                        btn_Alterar_valor_Compra.Enabled = true;//Ativando o Botão Alterar Valor da Compra

                     }//if

                    else
                    {
                        //a compra foi aprovada

                        //Compra maior que a renda
                        MessageBox.Show("Liberado(a)!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        MessageBox.Show("Parabens !!! " + Nome_do_Cliente + " - Boas Compras!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Avisando que a compra  foi aprovada

                        //Limpando todas as informações e preparando o Formulário para o Proximo Cliente

                        txt_Nome.Clear();//Limpando a Caixa de texto nome
                        txt_Nome.Focus();//Posicionando o cursor na caixa de texto nome
                        btn_alterar_Nome.Enabled = false;//Desabilitando o botão alterar nome

                        txt_Renda.Clear();//Limpando a caixa de texto Renda
                        txt_Renda.Enabled = false;  //desabilitando a caixa de texto renda
                        btn_Alterar_Renda.Enabled = false; //Desabilitando o botão alterar Renda

                        txt_Valor_Compra.Clear();//Limpando a caixa de texto valor da compra
                        txt_Valor_Compra.Enabled = false; // Desabilitando a caixa de texto valor da compra
                        btn_Alterar_valor_Compra.Enabled = false;//Desabilitando o botão Valor da compra

                    }//else verificação da compra
                    txt_Nome.Enabled = true;
                    txt_Nome.Focus();



                }//if
                else
                {
                    MessageBox.Show("Por favor, Informe o Valor da Compra do Cliente !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                   txt_Valor_Compra.Focus();
                }//else
                
                







            }//If Enter
           
            






        }




        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Alterar_valor_Compra_Click(object sender, EventArgs e)
        {

        }

        private void txt_Valor_Compra_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Voltar_Click(object sender, EventArgs e)
        {
            //  Botão Voltar Clicado

            Form Principal = new Form_Abertura(); //Instanciando o Formulário Principal
            Principal.ShowDialog();
            Close();
        }
    }
}
