
namespace Projeto_Teste
{
    partial class Form_Futebol
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Voltar
            // 
            this.pictureBox_Voltar.Image = global::Projeto_Teste.Properties.Resources.botao_voltar;
            this.pictureBox_Voltar.Location = new System.Drawing.Point(751, 2);
            this.pictureBox_Voltar.Name = "pictureBox_Voltar";
            this.pictureBox_Voltar.Size = new System.Drawing.Size(50, 30);
            this.pictureBox_Voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Voltar.TabIndex = 1;
            this.pictureBox_Voltar.TabStop = false;
            this.pictureBox_Voltar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(255, 2);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(253, 33);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Clube de Futebol";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(396, 106);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(82, 24);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome :";
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Idade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idade.Location = new System.Drawing.Point(543, 207);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(79, 24);
            this.lbl_Idade.TabIndex = 4;
            this.lbl_Idade.Text = "Idade :";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(502, 103);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(245, 32);
            this.txt_Nome.TabIndex = 5;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // txt_Idade
            // 
            this.txt_Idade.Enabled = false;
            this.txt_Idade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Idade.Location = new System.Drawing.Point(647, 199);
            this.txt_Idade.MaxLength = 2;
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(100, 32);
            this.txt_Idade.TabIndex = 6;
            this.txt_Idade.TextChanged += new System.EventHandler(this.txt_Idade_TextChanged);
            this.txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Idade_KeyPress);
            // 
            // Form_Futebol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Teste.Properties.Resources.the_ball_stadion_football_the_pitch_47730;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pictureBox_Voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Futebol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Futebol";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Voltar;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Idade;
    }
}