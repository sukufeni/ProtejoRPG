namespace JogoRPG
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbJogador1 = new System.Windows.Forms.ComboBox();
            this.btnPersonagem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imagemPersonagem1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbAtributos = new System.Windows.Forms.Label();
            this.btnJogador1Atk = new System.Windows.Forms.Button();
            this.imagemPersonagem2 = new System.Windows.Forms.PictureBox();
            this.btnJogador2Atk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbJogador2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPersonagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPersonagem2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbJogador1
            // 
            this.cbJogador1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbJogador1.FormattingEnabled = true;
            this.cbJogador1.Items.AddRange(new object[] {
            "Animal",
            "Dragao",
            "Guerreiro",
            "Ladrao",
            "Mago",
            "Paladino",
            "Troll",
            "Zumbi"});
            this.cbJogador1.Location = new System.Drawing.Point(111, 22);
            this.cbJogador1.Name = "cbJogador1";
            this.cbJogador1.Size = new System.Drawing.Size(121, 21);
            this.cbJogador1.Sorted = true;
            this.cbJogador1.TabIndex = 1;
            // 
            // btnPersonagem
            // 
            this.btnPersonagem.AutoSize = true;
            this.btnPersonagem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPersonagem.Location = new System.Drawing.Point(490, 12);
            this.btnPersonagem.Name = "btnPersonagem";
            this.btnPersonagem.Size = new System.Drawing.Size(100, 23);
            this.btnPersonagem.TabIndex = 2;
            this.btnPersonagem.Text = "Criar Personagem";
            this.btnPersonagem.UseVisualStyleBackColor = true;
            this.btnPersonagem.Click += new System.EventHandler(this.btnPersonagem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personagem";
            // 
            // imagemPersonagem1
            // 
            this.imagemPersonagem1.Location = new System.Drawing.Point(12, 186);
            this.imagemPersonagem1.Name = "imagemPersonagem1";
            this.imagemPersonagem1.Size = new System.Drawing.Size(347, 187);
            this.imagemPersonagem1.TabIndex = 5;
            this.imagemPersonagem1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFechar.Location = new System.Drawing.Point(515, 41);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lbAtributos
            // 
            this.lbAtributos.AutoSize = true;
            this.lbAtributos.Location = new System.Drawing.Point(12, 46);
            this.lbAtributos.Name = "lbAtributos";
            this.lbAtributos.Size = new System.Drawing.Size(35, 13);
            this.lbAtributos.TabIndex = 7;
            this.lbAtributos.Text = "label3";
            // 
            // btnJogador1Atk
            // 
            this.btnJogador1Atk.Location = new System.Drawing.Point(111, 49);
            this.btnJogador1Atk.Name = "btnJogador1Atk";
            this.btnJogador1Atk.Size = new System.Drawing.Size(75, 23);
            this.btnJogador1Atk.TabIndex = 9;
            this.btnJogador1Atk.Text = "Atacar";
            this.btnJogador1Atk.UseVisualStyleBackColor = true;
            this.btnJogador1Atk.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // imagemPersonagem2
            // 
            this.imagemPersonagem2.Location = new System.Drawing.Point(730, 186);
            this.imagemPersonagem2.Name = "imagemPersonagem2";
            this.imagemPersonagem2.Size = new System.Drawing.Size(347, 187);
            this.imagemPersonagem2.TabIndex = 10;
            this.imagemPersonagem2.TabStop = false;
            // 
            // btnJogador2Atk
            // 
            this.btnJogador2Atk.Location = new System.Drawing.Point(730, 49);
            this.btnJogador2Atk.Name = "btnJogador2Atk";
            this.btnJogador2Atk.Size = new System.Drawing.Size(75, 23);
            this.btnJogador2Atk.TabIndex = 13;
            this.btnJogador2Atk.Text = "Atacar";
            this.btnJogador2Atk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Personagem";
            // 
            // cbJogador2
            // 
            this.cbJogador2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbJogador2.FormattingEnabled = true;
            this.cbJogador2.Items.AddRange(new object[] {
            "Animal",
            "Dragao",
            "Guerreiro",
            "Ladrao",
            "Mago",
            "Paladino",
            "Troll",
            "Zumbi"});
            this.cbJogador2.Location = new System.Drawing.Point(730, 22);
            this.cbJogador2.Name = "cbJogador2";
            this.cbJogador2.Size = new System.Drawing.Size(121, 21);
            this.cbJogador2.Sorted = true;
            this.cbJogador2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1089, 385);
            this.Controls.Add(this.btnJogador2Atk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJogador2);
            this.Controls.Add(this.imagemPersonagem2);
            this.Controls.Add(this.btnJogador1Atk);
            this.Controls.Add(this.lbAtributos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.imagemPersonagem1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPersonagem);
            this.Controls.Add(this.cbJogador1);
            this.Name = "Form1";
            this.Text = "JOGO-RPG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagemPersonagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPersonagem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJogador1;
        private System.Windows.Forms.Button btnPersonagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imagemPersonagem1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbAtributos;
        private System.Windows.Forms.Button btnJogador1Atk;
        private System.Windows.Forms.PictureBox imagemPersonagem2;
        private System.Windows.Forms.Button btnJogador2Atk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbJogador2;
    }
}

