
namespace Projeto_Teste
{
    partial class Form_Meses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_Voltar = new System.Windows.Forms.PictureBox();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txt_Mes_Digitado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Voltar
            // 
            this.pictureBox_Voltar.Image = global::Projeto_Teste.Properties.Resources.botao_voltar;
            this.pictureBox_Voltar.Location = new System.Drawing.Point(751, 1);
            this.pictureBox_Voltar.Name = "pictureBox_Voltar";
            this.pictureBox_Voltar.Size = new System.Drawing.Size(50, 30);
            this.pictureBox_Voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Voltar.TabIndex = 0;
            this.pictureBox_Voltar.TabStop = false;
            this.pictureBox_Voltar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Texto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.Location = new System.Drawing.Point(50, 30);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(263, 24);
            this.lbl_Texto.TabIndex = 1;
            this.lbl_Texto.Text = "Digite o Número do Mês :\r\n";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Resultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(79, 176);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(140, 55);
            this.lbl_Resultado.TabIndex = 2;
            this.lbl_Resultado.Text = "2023";
            // 
            // txt_Mes_Digitado
            // 
            this.txt_Mes_Digitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mes_Digitado.Location = new System.Drawing.Point(325, 27);
            this.txt_Mes_Digitado.MaxLength = 2;
            this.txt_Mes_Digitado.Name = "txt_Mes_Digitado";
            this.txt_Mes_Digitado.Size = new System.Drawing.Size(101, 29);
            this.txt_Mes_Digitado.TabIndex = 3;
            this.txt_Mes_Digitado.Text = "4";
            this.txt_Mes_Digitado.TextChanged += new System.EventHandler(this.txt_Mes_Digitado_TextChanged);
            this.txt_Mes_Digitado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mes_Digitado_KeyPress);
            // 
            // Form_Meses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Teste.Properties.Resources.pexels_photo_13088177;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.txt_Mes_Digitado);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.pictureBox_Voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Meses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Meses";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_Meses_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Voltar;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txt_Mes_Digitado;
    }
}