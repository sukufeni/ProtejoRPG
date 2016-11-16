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
            this.btnJogador1Atk = new System.Windows.Forms.Button();
            this.imagemPersonagem2 = new System.Windows.Forms.PictureBox();
            this.btnJogador2Atk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersonagemJogador2 = new System.Windows.Forms.ComboBox();
            this.lbAtributos2 = new System.Windows.Forms.Label();
            this.cbAcoesJogador1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAcoesJogador2 = new System.Windows.Forms.ComboBox();
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
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lbAtributos.Location = new System.Drawing.Point(12, 83);
            this.lbAtributos.Name = "lbAtributos";
            this.lbAtributos.Size = new System.Drawing.Size(35, 13);
            this.lbAtributos.TabIndex = 7;
            this.lbAtributos.Text = "label3";
            // 
            // btnJogador1Atk
            // 
            this.btnJogador1Atk.Location = new System.Drawing.Point(12, 49);
            this.btnJogador1Atk.Name = "btnJogador1Atk";
            this.btnJogador1Atk.Size = new System.Drawing.Size(75, 23);
            this.btnJogador1Atk.TabIndex = 9;
            this.btnJogador1Atk.Text = "Ação";
            this.btnJogador1Atk.UseVisualStyleBackColor = true;
            this.btnJogador1Atk.Click += new System.EventHandler(this.btnAtaque_Click);
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
            // btnJogador2Atk
            // 
            this.btnJogador2Atk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogador2Atk.Location = new System.Drawing.Point(730, 49);
            this.btnJogador2Atk.Name = "btnJogador2Atk";
            this.btnJogador2Atk.Size = new System.Drawing.Size(75, 23);
            this.btnJogador2Atk.TabIndex = 13;
            this.btnJogador2Atk.Text = "Ação";
            this.btnJogador2Atk.UseVisualStyleBackColor = true;
            this.btnJogador2Atk.Click += new System.EventHandler(this.btnJogador2Atk_Click);
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
            this.lbAtributos2.Location = new System.Drawing.Point(736, 83);
            this.lbAtributos2.Name = "lbAtributos2";
            this.lbAtributos2.Size = new System.Drawing.Size(62, 13);
            this.lbAtributos2.TabIndex = 14;
            this.lbAtributos2.Text = "lbAtributos2";
            // 
            // cbAcoesJogador1
            // 
            this.cbAcoesJogador1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcoesJogador1.FormattingEnabled = true;
            this.cbAcoesJogador1.Location = new System.Drawing.Point(139, 22);
            this.cbAcoesJogador1.Name = "cbAcoesJogador1";
            this.cbAcoesJogador1.Size = new System.Drawing.Size(121, 21);
            this.cbAcoesJogador1.TabIndex = 15;
            this.cbAcoesJogador1.SelectedIndexChanged += new System.EventHandler(this.cbAcoesJogador1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ações";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(854, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ações";
            // 
            // cbAcoesJogador2
            // 
            this.cbAcoesJogador2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAcoesJogador2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcoesJogador2.FormattingEnabled = true;
            this.cbAcoesJogador2.Location = new System.Drawing.Point(857, 22);
            this.cbAcoesJogador2.Name = "cbAcoesJogador2";
            this.cbAcoesJogador2.Size = new System.Drawing.Size(121, 21);
            this.cbAcoesJogador2.TabIndex = 17;
            this.cbAcoesJogador2.SelectedIndexChanged += new System.EventHandler(this.cbAcoesJogador2_SelectedIndexChanged);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAcoesJogador2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAcoesJogador1);
            this.Controls.Add(this.lbAtributos2);
            this.Controls.Add(this.btnJogador2Atk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPersonagemJogador2);
            this.Controls.Add(this.imagemPersonagem2);
            this.Controls.Add(this.btnJogador1Atk);
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
        private System.Windows.Forms.Button btnJogador1Atk;
        private System.Windows.Forms.PictureBox imagemPersonagem2;
        private System.Windows.Forms.Button btnJogador2Atk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPersonagemJogador2;
        private System.Windows.Forms.Label lbAtributos2;
        private System.Windows.Forms.ComboBox cbAcoesJogador1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAcoesJogador2;
        private System.Windows.Forms.BindingSource jogadorBindingSource;
    }
}

