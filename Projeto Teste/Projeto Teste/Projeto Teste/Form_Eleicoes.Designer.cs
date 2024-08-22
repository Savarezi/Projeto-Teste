
namespace Projeto_Teste
{
    partial class Form_Eleicoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Idade_do_Eleitor = new System.Windows.Forms.TextBox();
            this.lbl_Texto_Idade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Voltar
            // 
            this.pictureBox_Voltar.Image = global::Projeto_Teste.Properties.Resources.botao_voltar;
            this.pictureBox_Voltar.Location = new System.Drawing.Point(747, 2);
            this.pictureBox_Voltar.Name = "pictureBox_Voltar";
            this.pictureBox_Voltar.Size = new System.Drawing.Size(50, 30);
            this.pictureBox_Voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Voltar.TabIndex = 2;
            this.pictureBox_Voltar.TabStop = false;
            this.pictureBox_Voltar.Click += new System.EventHandler(this.pictureBox_Voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(156, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eleições";
            // 
            // txt_Idade_do_Eleitor
            // 
            this.txt_Idade_do_Eleitor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Idade_do_Eleitor.Location = new System.Drawing.Point(468, 122);
            this.txt_Idade_do_Eleitor.MaxLength = 2;
            this.txt_Idade_do_Eleitor.Name = "txt_Idade_do_Eleitor";
            this.txt_Idade_do_Eleitor.Size = new System.Drawing.Size(100, 29);
            this.txt_Idade_do_Eleitor.TabIndex = 4;
            this.txt_Idade_do_Eleitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Idade_KeyPress);
            // 
            // lbl_Texto_Idade
            // 
            this.lbl_Texto_Idade.AutoSize = true;
            this.lbl_Texto_Idade.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Texto_Idade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto_Idade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Texto_Idade.Location = new System.Drawing.Point(377, 122);
            this.lbl_Texto_Idade.Name = "lbl_Texto_Idade";
            this.lbl_Texto_Idade.Size = new System.Drawing.Size(72, 24);
            this.lbl_Texto_Idade.TabIndex = 5;
            this.lbl_Texto_Idade.Text = "Idade:";
            // 
            // Form_Eleicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Teste.Properties.Resources.pexels_photo_8846632;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Texto_Idade);
            this.Controls.Add(this.txt_Idade_do_Eleitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Voltar);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Eleicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Eleicoes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Idade_do_Eleitor;
        private System.Windows.Forms.Label lbl_Texto_Idade;
    }
}