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
    public partial class Form_Contratacao : Form
    {
        string Nome_Candidato,Bairro;
        int Idade, Tempo_Experiencia;

        public Form_Contratacao()
        {
            InitializeComponent();
            txt_Nome.Focus();
            cbo_Bairro.DropDownStyle = ComboBoxStyle.DropDownList;//Para ?Impedir a digitação dentro da combobox
        }

        private void pictureBox_Voltar_Click(object sender, EventArgs e)
        {
            //  Botão Voltar Clicado

            Form Principal = new Form_Abertura(); //Instanciando o Formulário Principal
            Principal.ShowDialog();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Veeriificando o Status do Checkbox Experiencia
            if (chk_Experiencia.Checked == true)//Esperiencia Marcada
            {

                nud_Anos.Enabled = true;
                nud_Anos.Focus();
            }

            else
            {
                //Experiencia Não Marcada
                btn_Confirmar.Focus();
            }

            if (chk_Experiencia.Checked == false)
            {

                nud_Anos.Value = 0;
                nud_Anos.Enabled = false;

            }



            else
            {

                btn_Confirmar.Focus();
            }


        }

            private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Key Press

            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space) && !(e.KeyChar == (char)Keys.Enter))//Verificando se as Informações Digitadas São Válidas
            {

                //Caso não tenha digitado um válor válido
                e.Handled = true;
                MessageBox.Show("Caractere Inválido! - Este campo só aceita letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }//if

            if (e.KeyChar == 13) //Tecla Enter Digitada
            {
                if (txt_Nome.Text == "")//Verificando se o campo nome esta vazio
                {
                    //Campo vazio
                    MessageBox.Show("Digite o Nome do Candidato!!! Por Favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Nome.Focus();
                    
                }//if

                else
                {
                    //O Nome foi Digitado
                    Nome_Candidato = (txt_Nome.Text);//Recebendo O nome do Candidato
                    
                    txt_Nome.Enabled = false; //desabilitando o campo nome
                    txt_Idade.Enabled = true;
                    txt_Idade.Focus();
                }

            }//If tecla Enter campo Nome Digitada digitada

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
                if (txt_Idade.Text == "") //Veificando se a Idade foi digitada
                {
                    //se a idade não for digitada
                    MessageBox.Show("Digite a Idade!!! Por Favor!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Idade.Focus();
                    return;
                } //if

                else
                {
                    //se a idade Foi Digitada
                    Idade = Convert.ToInt32(txt_Idade.Text);//atribuido e convertendo o valor digitado para a variavel idade

                }//else Idade Digitada

                //Testando a Idade do Candidato

             

                if ((Idade >= 18) && (Idade <= 50)) //Verificando se a idade está entre 18 e 50 anos
                {
                    //A idade está entre 18 e 70 anos
               
                    txt_Idade.Enabled = false;

                    cbo_Bairro.Enabled = true;
                    cbo_Bairro.Focus();

                }//If

                else
                {

                    MessageBox.Show("O Candidato  não deve  ter a Idade inferior a 18 anos ou Superior a 50 Anos \r\n  - Digte uma Idade Válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Idade.Clear();
                    txt_Idade.Focus();

                }//Else Verificação das Idades





            }//if Enter
            
        }

        private void cbo_Bairro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Bairro.Text !="")

            {
                btn_Confirmar.Enabled = true;
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //Botão Confirmar Clicado
            Tempo_Experiencia = Convert.ToInt32(nud_Anos.Value);

            if((chk_Experiencia.Checked == true) && (Tempo_Experiencia == 0))
                {
                MessageBox.Show("Selecione o Tempo de Experiência !!! \r\n  - Para Continuar o Cadastro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud_Anos.Focus();
                return;
            }//if

            if (((cbo_Bairro.Text == "Itaquera") || (cbo_Bairro.Text == "Guaianazes") || (cbo_Bairro.Text == "Cidade Tiradentes") || (cbo_Bairro.Text == "São Miguel")) && Tempo_Experiencia > 0)
            {
                //Verificando O bairro escolhido
                //Bairro Escolhido e tempo de experiencia atende aos requisitos

                MessageBox.Show("Parabéns !!! " + Nome_Candidato +  " \r\n  - Você está Contratado(a) ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                //Bairro Escolhido e tempo de experiencia não atende aos requisitos
                MessageBox.Show(Nome_Candidato + " \r\n  - Você não está dentro do Perfil da Vaga", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Controls.Clear();
            InitializeComponent();
            txt_Nome.Focus();
            
            



        }
        
        
        

        private void nud_Anos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_Contratacao_Load(object sender, EventArgs e)
        {

        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void nud_Anos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Key Press NumericUP

            if (e.KeyChar == 13)
            {

                Tempo_Experiencia = Convert.ToInt32(nud_Anos.Value);
                if (Tempo_Experiencia == 0)
                {
                    MessageBox.Show("Selecione o Tempo de Experiência !!! \r\n  - Para Continuar o Cadastro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nud_Anos.Focus();
                }//If

                else

                {
                    btn_Confirmar.Focus();
                }
            }//if
        }

        private void cbo_Bairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Key Press Combo box

            if(cbo_Bairro.Text == "")
                //Bairro Não escolhido
            {
                MessageBox.Show("Selecione um Bairro !!! \r\n  - Para Continuar o Cadastro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //Bairro Escolhido
                Bairro = (cbo_Bairro.Text);

                chk_Experiencia.Enabled = true;
                chk_Experiencia.Focus();

                btn_Confirmar.Enabled = true;
                btn_Confirmar.ForeColor = Color.DarkBlue;

            }

        }
    }
    }

