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
    public partial class Form_Meses : Form
    {
        public Form_Meses()
        {
            InitializeComponent();
        }
        int mes;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Botão Voltar Clicado
            
            Form Principal = new Form_Abertura(); //Instanciando o Formulário Principal
            Principal.ShowDialog();
            Close();
        }

        private void Form_Meses_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_Mes_Digitado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento Keypress TextBox
            lbl_Resultado.Text = "2023";

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar ==','))
              {
                e.Handled = true; //Verificando se o que foi digitado condiz com a proposta
                MessageBox.Show("Caracter Inválido !!!", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error); //exibindo uma mesnasgem de erro

             }//if

            if (e.KeyChar == 13) //Tecla Enter Pressionada
            {
                if (txt_Mes_Digitado.Text != "") //Verificando se algo foi digitado
                {
                    mes = int.Parse(txt_Mes_Digitado.Text);//Recebendo o mês Digitado
                   
                    if ((mes>12) ||(mes ==0)) //Verificando se o mês digitado é um Mês Válido
                    {
                        MessageBox.Show("Digite um Valor de Mês entre 1 e 12 !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); //exibindo uma mesnasgem de erro
                        txt_Mes_Digitado.Text = string.Empty;//Limpando a textbox
                        txt_Mes_Digitado.Focus();//Posicionando cursor na textbox

                        
                        return;
                    }//if
                    
                    else if(mes ==1)

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Janeiro";

                    }

                    else if (mes == 2)

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Fevereiro";

                    }

                    else if (mes == 3)

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Março";

                    }

                    else if (mes == 4)

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Abril";

                    }

                    else if (mes == 5)

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Maio";

                    }

                    else if (mes == 6)

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Junho";

                    }

                    else if (mes == 7)

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Julho";

                    }

                    else if (mes == 8)

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Agosto";

                    }

                    else if (mes == 9)

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Setembro";

                    }

                    else if (mes == 10)

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Outubro";

                    }

                    else if (mes == 11)

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Novembro";

                    }

                    else 

                    {
                        lbl_Resultado.Visible = true;
                        lbl_Resultado.Text = "Dezembro";

                    }




                }//if


                else
                {
                    //nada foi digitado
                    MessageBox.Show("Digite um Número !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); //exibindo uma mesnasgem de erro


                }//else

            }//if







        }

        private void txt_Mes_Digitado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
