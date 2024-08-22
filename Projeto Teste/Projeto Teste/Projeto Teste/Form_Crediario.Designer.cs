
namespace Projeto_Teste
{
    partial class Form_Crediario
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
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_alterar_Nome = new System.Windows.Forms.Button();
            this.btn_Alterar_Renda = new System.Windows.Forms.Button();
            this.txt_Renda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Alterar_valor_Compra = new System.Windows.Forms.Button();
            this.txt_Valor_Compra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Voltar
            // 
            this.pictureBox_Voltar.Image = global::Projeto_Teste.Properties.Resources.botao_voltar;
            this.pictureBox_Voltar.Location = new System.Drawing.Point(751, 0);
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
            this.lbl_Titulo.Location = new System.Drawing.Point(322, 32);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(133, 31);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Crediário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(242, 106);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(263, 32);
            this.txt_Nome.TabIndex = 6;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // btn_alterar_Nome
            // 
            this.btn_alterar_Nome.BackColor = System.Drawing.Color.Transparent;
            this.btn_alterar_Nome.Enabled = false;
            this.btn_alterar_Nome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar_Nome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar_Nome.Location = new System.Drawing.Point(545, 106);
            this.btn_alterar_Nome.Name = "btn_alterar_Nome";
            this.btn_alterar_Nome.Size = new System.Drawing.Size(113, 36);
            this.btn_alterar_Nome.TabIndex = 7;
            this.btn_alterar_Nome.Text = "Alterar";
            this.btn_alterar_Nome.UseVisualStyleBackColor = false;
            this.btn_alterar_Nome.Click += new System.EventHandler(this.btn_alterar_Nome_Click);
            // 
            // btn_Alterar_Renda
            // 
            this.btn_Alterar_Renda.BackColor = System.Drawing.Color.Transparent;
            this.btn_Alterar_Renda.Enabled = false;
            this.btn_Alterar_Renda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar_Renda.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar_Renda.Location = new System.Drawing.Point(545, 174);
            this.btn_Alterar_Renda.Name = "btn_Alterar_Renda";
            this.btn_Alterar_Renda.Size = new System.Drawing.Size(113, 36);
            this.btn_Alterar_Renda.TabIndex = 10;
            this.btn_Alterar_Renda.Text = "Alterar";
            this.btn_Alterar_Renda.UseVisualStyleBackColor = false;
            this.btn_Alterar_Renda.Click += new System.EventHandler(this.btn_Alterar_Renda_Click);
            // 
            // txt_Renda
            // 
            this.txt_Renda.Enabled = false;
            this.txt_Renda.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Renda.Location = new System.Drawing.Point(242, 174);
            this.txt_Renda.Name = "txt_Renda";
            this.txt_Renda.Size = new System.Drawing.Size(263, 32);
            this.txt_Renda.TabIndex = 9;
            this.txt_Renda.TextChanged += new System.EventHandler(this.txt_Renda_TextChanged);
            this.txt_Renda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Renda_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Renda";
            // 
            // btn_Alterar_valor_Compra
            // 
            this.btn_Alterar_valor_Compra.BackColor = System.Drawing.Color.Transparent;
            this.btn_Alterar_valor_Compra.Enabled = false;
            this.btn_Alterar_valor_Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar_valor_Compra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar_valor_Compra.Location = new System.Drawing.Point(545, 251);
            this.btn_Alterar_valor_Compra.Name = "btn_Alterar_valor_Compra";
            this.btn_Alterar_valor_Compra.Size = new System.Drawing.Size(113, 36);
            this.btn_Alterar_valor_Compra.TabIndex = 13;
            this.btn_Alterar_valor_Compra.Text = "Alterar";
            this.btn_Alterar_valor_Compra.UseVisualStyleBackColor = false;
            this.btn_Alterar_valor_Compra.Click += new System.EventHandler(this.btn_Alterar_valor_Compra_Click);
            // 
            // txt_Valor_Compra
            // 
            this.txt_Valor_Compra.Enabled = false;
            this.txt_Valor_Compra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor_Compra.Location = new System.Drawing.Point(246, 254);
            this.txt_Valor_Compra.Name = "txt_Valor_Compra";
            this.txt_Valor_Compra.Size = new System.Drawing.Size(263, 32);
            this.txt_Valor_Compra.TabIndex = 12;
            this.txt_Valor_Compra.TextChanged += new System.EventHandler(this.txt_Valor_Compra_TextChanged);
            this.txt_Valor_Compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valor_Compra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor da Compra";
            // 
            // Form_Crediario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Teste.Properties.Resources.pexels_photo_7352058;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Alterar_valor_Compra);
            this.Controls.Add(this.txt_Valor_Compra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Alterar_Renda);
            this.Controls.Add(this.txt_Renda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_alterar_Nome);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pictureBox_Voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Crediario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patr";
            this.Load += new System.EventHandler(this.Form_Crediario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Voltar;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_alterar_Nome;
        private System.Windows.Forms.Button btn_Alterar_Renda;
        private System.Windows.Forms.TextBox txt_Renda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Alterar_valor_Compra;
        private System.Windows.Forms.TextBox txt_Valor_Compra;
        private System.Windows.Forms.Label label3;
    }
}