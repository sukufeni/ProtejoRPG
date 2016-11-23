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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbPersonagemJogador1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imagemPersonagem1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbAtributos = new System.Windows.Forms.Label();
            this.btnJogador1AtkArma = new System.Windows.Forms.Button();
            this.imagemPersonagem2 = new System.Windows.Forms.PictureBox();
            this.btnJogador2AtkArma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersonagemJogador2 = new System.Windows.Forms.ComboBox();
            this.lbAtributos2 = new System.Windows.Forms.Label();
            this.cbArmasJogador1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbArmasJogador2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRodadaJogador1 = new System.Windows.Forms.Label();
            this.lbRodadaJogador2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnJogador1AtkMagia = new System.Windows.Forms.Button();
            this.btnJogador2AtkMagia = new System.Windows.Forms.Button();
            this.cbMagiasJogador1 = new System.Windows.Forms.ComboBox();
            this.cbMagiasJogador2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.jogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagemPersonagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPersonagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPersonagemJogador1
            // 
            this.cbPersonagemJogador1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonagemJogador1.FormattingEnabled = true;
            this.cbPersonagemJogador1.Location = new System.Drawing.Point(12, 22);
            this.cbPersonagemJogador1.Name = "cbPersonagemJogador1";
            this.cbPersonagemJogador1.Size = new System.Drawing.Size(121, 21);
            this.cbPersonagemJogador1.Sorted = true;
            this.cbPersonagemJogador1.TabIndex = 1;
            this.cbPersonagemJogador1.SelectedIndexChanged += new System.EventHandler(this.cbJogador1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jogador-1";
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
            this.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFechar.Location = new System.Drawing.Point(513, 40);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(60, 25);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lbAtributos
            // 
            this.lbAtributos.AutoSize = true;
            this.lbAtributos.Location = new System.Drawing.Point(12, 110);
            this.lbAtributos.Name = "lbAtributos";
            this.lbAtributos.Size = new System.Drawing.Size(35, 13);
            this.lbAtributos.TabIndex = 7;
            this.lbAtributos.Text = "label3";
            // 
            // btnJogador1AtkArma
            // 
            this.btnJogador1AtkArma.AutoSize = true;
            this.btnJogador1AtkArma.Location = new System.Drawing.Point(12, 73);
            this.btnJogador1AtkArma.Name = "btnJogador1AtkArma";
            this.btnJogador1AtkArma.Size = new System.Drawing.Size(78, 23);
            this.btnJogador1AtkArma.TabIndex = 9;
            this.btnJogador1AtkArma.Text = "Ataque Arma";
            this.btnJogador1AtkArma.UseVisualStyleBackColor = true;
            this.btnJogador1AtkArma.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // imagemPersonagem2
            // 
            this.imagemPersonagem2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imagemPersonagem2.Location = new System.Drawing.Point(730, 186);
            this.imagemPersonagem2.Name = "imagemPersonagem2";
            this.imagemPersonagem2.Size = new System.Drawing.Size(347, 187);
            this.imagemPersonagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imagemPersonagem2.TabIndex = 10;
            this.imagemPersonagem2.TabStop = false;
            // 
            // btnJogador2AtkArma
            // 
            this.btnJogador2AtkArma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogador2AtkArma.AutoSize = true;
            this.btnJogador2AtkArma.Location = new System.Drawing.Point(727, 73);
            this.btnJogador2AtkArma.Name = "btnJogador2AtkArma";
            this.btnJogador2AtkArma.Size = new System.Drawing.Size(78, 23);
            this.btnJogador2AtkArma.TabIndex = 13;
            this.btnJogador2AtkArma.Text = "Ataque Arma";
            this.btnJogador2AtkArma.UseVisualStyleBackColor = true;
            this.btnJogador2AtkArma.Click += new System.EventHandler(this.btnJogador2Atk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jogador-2";
            // 
            // cbPersonagemJogador2
            // 
            this.cbPersonagemJogador2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPersonagemJogador2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonagemJogador2.FormattingEnabled = true;
            this.cbPersonagemJogador2.Location = new System.Drawing.Point(730, 22);
            this.cbPersonagemJogador2.Name = "cbPersonagemJogador2";
            this.cbPersonagemJogador2.Size = new System.Drawing.Size(121, 21);
            this.cbPersonagemJogador2.Sorted = true;
            this.cbPersonagemJogador2.TabIndex = 11;
            this.cbPersonagemJogador2.SelectedIndexChanged += new System.EventHandler(this.cbJogador2_SelectedIndexChanged);
            // 
            // lbAtributos2
            // 
            this.lbAtributos2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAtributos2.AutoSize = true;
            this.lbAtributos2.Location = new System.Drawing.Point(743, 110);
            this.lbAtributos2.Name = "lbAtributos2";
            this.lbAtributos2.Size = new System.Drawing.Size(62, 13);
            this.lbAtributos2.TabIndex = 14;
            this.lbAtributos2.Text = "lbAtributos2";
            // 
            // cbArmasJogador1
            // 
            this.cbArmasJogador1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArmasJogador1.FormattingEnabled = true;
            this.cbArmasJogador1.Location = new System.Drawing.Point(139, 22);
            this.cbArmasJogador1.Name = "cbArmasJogador1";
            this.cbArmasJogador1.Size = new System.Drawing.Size(121, 21);
            this.cbArmasJogador1.TabIndex = 15;
            this.cbArmasJogador1.SelectedIndexChanged += new System.EventHandler(this.cbAcoesJogador1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Armas";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(854, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Armas";
            // 
            // cbArmasJogador2
            // 
            this.cbArmasJogador2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbArmasJogador2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArmasJogador2.FormattingEnabled = true;
            this.cbArmasJogador2.Location = new System.Drawing.Point(857, 22);
            this.cbArmasJogador2.Name = "cbArmasJogador2";
            this.cbArmasJogador2.Size = new System.Drawing.Size(121, 21);
            this.cbArmasJogador2.TabIndex = 17;
            this.cbArmasJogador2.SelectedIndexChanged += new System.EventHandler(this.cbAcoesJogador2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rodada";
            // 
            // lblRodadaJogador1
            // 
            this.lblRodadaJogador1.AutoSize = true;
            this.lblRodadaJogador1.Location = new System.Drawing.Point(136, 59);
            this.lblRodadaJogador1.Name = "lblRodadaJogador1";
            this.lblRodadaJogador1.Size = new System.Drawing.Size(0, 13);
            this.lblRodadaJogador1.TabIndex = 20;
            // 
            // lbRodadaJogador2
            // 
            this.lbRodadaJogador2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRodadaJogador2.AutoSize = true;
            this.lbRodadaJogador2.Location = new System.Drawing.Point(854, 59);
            this.lbRodadaJogador2.Name = "lbRodadaJogador2";
            this.lbRodadaJogador2.Size = new System.Drawing.Size(0, 13);
            this.lbRodadaJogador2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(854, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Rodada";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReiniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReiniciar.Location = new System.Drawing.Point(513, 12);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(60, 23);
            this.btnReiniciar.TabIndex = 23;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnJogador1AtkMagia
            // 
            this.btnJogador1AtkMagia.AutoSize = true;
            this.btnJogador1AtkMagia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJogador1AtkMagia.Location = new System.Drawing.Point(139, 73);
            this.btnJogador1AtkMagia.Name = "btnJogador1AtkMagia";
            this.btnJogador1AtkMagia.Size = new System.Drawing.Size(83, 23);
            this.btnJogador1AtkMagia.TabIndex = 24;
            this.btnJogador1AtkMagia.Text = "Ataque Magia";
            this.btnJogador1AtkMagia.UseVisualStyleBackColor = true;
            this.btnJogador1AtkMagia.Click += new System.EventHandler(this.btnJogador1AtkMagia_Click);
            // 
            // btnJogador2AtkMagia
            // 
            this.btnJogador2AtkMagia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogador2AtkMagia.AutoSize = true;
            this.btnJogador2AtkMagia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJogador2AtkMagia.Location = new System.Drawing.Point(857, 73);
            this.btnJogador2AtkMagia.Name = "btnJogador2AtkMagia";
            this.btnJogador2AtkMagia.Size = new System.Drawing.Size(83, 23);
            this.btnJogador2AtkMagia.TabIndex = 25;
            this.btnJogador2AtkMagia.Text = "Ataque Magia";
            this.btnJogador2AtkMagia.UseVisualStyleBackColor = true;
            this.btnJogador2AtkMagia.Click += new System.EventHandler(this.btnJogador2AtkMagia_Click);
            // 
            // cbMagiasJogador1
            // 
            this.cbMagiasJogador1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMagiasJogador1.FormattingEnabled = true;
            this.cbMagiasJogador1.Location = new System.Drawing.Point(266, 22);
            this.cbMagiasJogador1.Name = "cbMagiasJogador1";
            this.cbMagiasJogador1.Size = new System.Drawing.Size(121, 21);
            this.cbMagiasJogador1.TabIndex = 26;
            // 
            // cbMagiasJogador2
            // 
            this.cbMagiasJogador2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMagiasJogador2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMagiasJogador2.FormattingEnabled = true;
            this.cbMagiasJogador2.Location = new System.Drawing.Point(985, 21);
            this.cbMagiasJogador2.Name = "cbMagiasJogador2";
            this.cbMagiasJogador2.Size = new System.Drawing.Size(121, 21);
            this.cbMagiasJogador2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Magias";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(982, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Magias";
            // 
            // jogadorBindingSource
            // 
            this.jogadorBindingSource.DataSource = typeof(JogoRPG.Jogador);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1089, 385);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMagiasJogador2);
            this.Controls.Add(this.cbMagiasJogador1);
            this.Controls.Add(this.btnJogador2AtkMagia);
            this.Controls.Add(this.btnJogador1AtkMagia);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lbRodadaJogador2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblRodadaJogador1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbArmasJogador2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbArmasJogador1);
            this.Controls.Add(this.lbAtributos2);
            this.Controls.Add(this.btnJogador2AtkArma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPersonagemJogador2);
            this.Controls.Add(this.imagemPersonagem2);
            this.Controls.Add(this.btnJogador1AtkArma);
            this.Controls.Add(this.lbAtributos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.imagemPersonagem1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPersonagemJogador1);
            this.Name = "Form1";
            this.Text = "JOGO-RPG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagemPersonagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPersonagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPersonagemJogador1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imagemPersonagem1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbAtributos;
        private System.Windows.Forms.Button btnJogador1AtkArma;
        private System.Windows.Forms.PictureBox imagemPersonagem2;
        private System.Windows.Forms.Button btnJogador2AtkArma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPersonagemJogador2;
        private System.Windows.Forms.Label lbAtributos2;
        private System.Windows.Forms.ComboBox cbArmasJogador1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbArmasJogador2;
        private System.Windows.Forms.BindingSource jogadorBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRodadaJogador1;
        private System.Windows.Forms.Label lbRodadaJogador2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnJogador1AtkMagia;
        private System.Windows.Forms.Button btnJogador2AtkMagia;
        private System.Windows.Forms.ComboBox cbMagiasJogador1;
        private System.Windows.Forms.ComboBox cbMagiasJogador2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

