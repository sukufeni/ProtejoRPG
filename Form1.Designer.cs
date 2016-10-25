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
            this.cbPersonagem = new System.Windows.Forms.ComboBox();
            this.btnPersonagem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imagemPersonagem = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbAtributos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPersonagem
            // 
            this.cbPersonagem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPersonagem.FormattingEnabled = true;
            this.cbPersonagem.Items.AddRange(new object[] {
            "Animal",
            "Dragao",
            "Guerreiro",
            "Ladrao",
            "Mago",
            "Paladino",
            "Troll",
            "Zumbi"});
            this.cbPersonagem.Location = new System.Drawing.Point(111, 22);
            this.cbPersonagem.Name = "cbPersonagem";
            this.cbPersonagem.Size = new System.Drawing.Size(121, 21);
            this.cbPersonagem.Sorted = true;
            this.cbPersonagem.TabIndex = 1;
            this.cbPersonagem.SelectedIndexChanged += new System.EventHandler(this.cbPersonagem_SelectedIndexChanged);
            // 
            // btnPersonagem
            // 
            this.btnPersonagem.AutoSize = true;
            this.btnPersonagem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPersonagem.Location = new System.Drawing.Point(238, 20);
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
            // imagemPersonagem
            // 
            this.imagemPersonagem.Location = new System.Drawing.Point(12, 186);
            this.imagemPersonagem.Name = "imagemPersonagem";
            this.imagemPersonagem.Size = new System.Drawing.Size(347, 187);
            this.imagemPersonagem.TabIndex = 5;
            this.imagemPersonagem.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFechar.Location = new System.Drawing.Point(12, 12);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1089, 385);
            this.Controls.Add(this.lbAtributos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.imagemPersonagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPersonagem);
            this.Controls.Add(this.cbPersonagem);
            this.Name = "Form1";
            this.Text = "JOGO-RPG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagemPersonagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPersonagem;
        private System.Windows.Forms.Button btnPersonagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imagemPersonagem;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbAtributos;
    }
}

