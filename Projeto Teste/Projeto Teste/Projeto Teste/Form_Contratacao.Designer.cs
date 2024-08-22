
namespace Projeto_Teste
{
    partial class Form_Contratacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.chk_Experiencia = new System.Windows.Forms.CheckBox();
            this.nud_Anos = new System.Windows.Forms.NumericUpDown();
            this.cbo_Bairro = new System.Windows.Forms.ComboBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Anos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Voltar
            // 
            this.pictureBox_Voltar.Image = global::Projeto_Teste.Properties.Resources.botao_voltar;
            this.pictureBox_Voltar.Location = new System.Drawing.Point(752, 1);
            this.pictureBox_Voltar.Name = "pictureBox_Voltar";
            this.pictureBox_Voltar.Size = new System.Drawing.Size(50, 30);
            this.pictureBox_Voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Voltar.TabIndex = 3;
            this.pictureBox_Voltar.TabStop = false;
            this.pictureBox_Voltar.Click += new System.EventHandler(this.pictureBox_Voltar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(310, 17);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(174, 31);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Contratação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bairro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tem Experiência ?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tempo em anos";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(292, 130);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(386, 29);
            this.txt_Nome.TabIndex = 10;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // chk_Experiencia
            // 
            this.chk_Experiencia.AutoSize = true;
            this.chk_Experiencia.BackColor = System.Drawing.Color.Transparent;
            this.chk_Experiencia.Enabled = false;
            this.chk_Experiencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Experiencia.Location = new System.Drawing.Point(330, 256);
            this.chk_Experiencia.Name = "chk_Experiencia";
            this.chk_Experiencia.Size = new System.Drawing.Size(64, 26);
            this.chk_Experiencia.TabIndex = 11;
            this.chk_Experiencia.Text = "Sim";
            this.chk_Experiencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chk_Experiencia.UseVisualStyleBackColor = false;
            this.chk_Experiencia.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nud_Anos
            // 
            this.nud_Anos.Enabled = false;
            this.nud_Anos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Anos.Location = new System.Drawing.Point(582, 250);
            this.nud_Anos.Name = "nud_Anos";
            this.nud_Anos.Size = new System.Drawing.Size(51, 29);
            this.nud_Anos.TabIndex = 12;
            this.nud_Anos.ValueChanged += new System.EventHandler(this.nud_Anos_ValueChanged);
            this.nud_Anos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_Anos_KeyPress);
            // 
            // cbo_Bairro
            // 
            this.cbo_Bairro.Enabled = false;
            this.cbo_Bairro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Bairro.FormattingEnabled = true;
            this.cbo_Bairro.Items.AddRange(new object[] {
            "Itaquera",
            "Guaianazes",
            "Itaim Paulista",
            "Cidade Tiradentes",
            "São Matheus",
            "São Miguel",
            "Guilhermina",
            "Outro"});
            this.cbo_Bairro.Location = new System.Drawing.Point(404, 210);
            this.cbo_Bairro.Name = "cbo_Bairro";
            this.cbo_Bairro.Size = new System.Drawing.Size(250, 30);
            this.cbo_Bairro.TabIndex = 13;
            this.cbo_Bairro.SelectedIndexChanged += new System.EventHandler(this.cbo_Bairro_SelectedIndexChanged);
            this.cbo_Bairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_Bairro_KeyPress);
            // 
            // txt_Idade
            // 
            this.txt_Idade.Enabled = false;
            this.txt_Idade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Idade.Location = new System.Drawing.Point(243, 211);
            this.txt_Idade.MaxLength = 2;
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(46, 29);
            this.txt_Idade.TabIndex = 14;
            this.txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Idade_KeyPress);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirmar.Enabled = false;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.Location = new System.Drawing.Point(292, 321);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(189, 35);
            this.btn_Confirmar.TabIndex = 15;
            this.btn_Confirmar.Text = "Confirmar Dados";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // Form_Contratacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Teste.Properties.Resources._34679366495_6dcf8ce33a_b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.cbo_Bairro);
            this.Controls.Add(this.nud_Anos);
            this.Controls.Add(this.chk_Experiencia);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pictureBox_Voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Contratacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Contratacao";
            this.Load += new System.EventHandler(this.Form_Contratacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Anos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Voltar;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.CheckBox chk_Experiencia;
        private System.Windows.Forms.NumericUpDown nud_Anos;
        private System.Windows.Forms.ComboBox cbo_Bairro;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.Button btn_Confirmar;
    }
}