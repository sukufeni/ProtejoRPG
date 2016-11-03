using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoRPG
{
   
    public partial class Form1 : Form
    {
        List<Jogador> jogadores = new List<Jogador>();
        Image imagem;
        string a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbAtributos.Text = "";
            lbAtributos2.Text = "";
            Jogador Jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();
            jogadores.Add(Jogador1);
            jogadores.Add(jogador2);
            criaComboBox();
        }
        private void criaComboBox()
        {
            for (int x = 0; x <= jogadores[0].personagens.Count - 1; x++)
            {
                cbJogador1.Items.Add(jogadores[0].personagens[x]);
            }
            for (int x = 0; x <= jogadores[1].personagens.Count - 1; x++)
            {
                cbJogador2.Items.Add(jogadores[1].personagens[x]);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {
                    cbAtk1();
                    jogadores[0].ataque(jogadores[0].personagemAtacante, jogadores[1].personagemAtacado, "bio");
                    string atributos1 = "", atributos2 = "";
                    a = jogadores[0].caminhoatacante(out atributos2, jogadores[0].personagemAtacante);
                    b = jogadores[1].caminhoatacado(out atributos1, jogadores[1].personagemAtacado);
                    imagemAtacante(a, atributos1);
                    imagemAtacado(b, atributos2);
                }
                catch (TypeInitializationException erro)
                {
                    MessageBox.Show("preencha as opções corretamente!" + erro.ToString());
                    cbAtkJ1.SelectedIndex = 1;
                }
            } while (cbJogador1.SelectedItem.ToString() == null || cbJogador2.SelectedItem.ToString() == null /*|| cbAtkJ1.SelectedItem.ToString() == null*/);
            
            
        }

        private void cbAtk1()
        {
            foreach (Personagem a in jogadores[0].personagens)
            {
                Personagem teste = (Personagem)cbJogador1.SelectedItem;
                if (teste == a)
                {
                    jogadores[0].personagemAtacante = teste;
                }
            }

            foreach (Personagem a in jogadores[1].personagens)
            {
                Personagem teste = (Personagem)cbJogador2.SelectedItem;
                if (teste == a)
                {
                    jogadores[1].personagemAtacado = teste;
                }
            }
        }
        private void cbAtk2()
        {
            foreach (Personagem a in jogadores[1].personagens)
            {
                Personagem teste = (Personagem)cbJogador2.SelectedItem;
                if (teste == a)
                {
                    jogadores[1].personagemAtacante = teste;
                }
            }

            foreach (Personagem a in jogadores[0].personagens)
            {
                Personagem teste = (Personagem)cbJogador1.SelectedItem;
                if (teste == a)
                {
                    jogadores[0].personagemAtacado = teste;
                }
            }
        }

        private void imagemAtacado(string caminho, string v)
        {
            imagem = Image.FromFile(caminho);
            imagemPersonagem2.Image = imagem;
            imagemPersonagem2.Width = imagem.Width;
            imagemPersonagem2.Height = imagem.Height;
            lbAtributos.Text = v;
        }

        private void btnJogador2Atk_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {
                    cbAtk2();
                    jogadores[1].ataque(jogadores[1].personagemAtacante, jogadores[0].personagemAtacado, "bio");
                    string atributos1 = "", atributos2 = "";
                    a = jogadores[1].caminhoatacante(out atributos2, jogadores[1].personagemAtacante);
                    b = jogadores[0].caminhoatacado(out atributos1, jogadores[0].personagemAtacado);
                    imagemAtacante(b, atributos2);
                    imagemAtacado(a, atributos1);
                }
                catch (TypeInitializationException erro)
                {
                    MessageBox.Show("preencha as opções corretamente!" + erro.ToString());
                    cbAtkJ1.SelectedIndex = 1;
                }
            } while (cbJogador1.SelectedItem.ToString() == "" || cbJogador2.SelectedItem.ToString() == "" /*|| cbAtkJ1.SelectedItem.ToString() == ""*/);

        }

        private void imagemAtacante(string caminho,string atributosPersonagem)
        {
            imagem = Image.FromFile(caminho);
            imagemPersonagem1.Image = imagem;
            imagemPersonagem1.Width = imagem.Width;
            imagemPersonagem1.Height = imagem.Height;
            lbAtributos2.Text = atributosPersonagem;
        }
    }
}
