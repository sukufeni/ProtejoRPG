using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoRPG
{
    public partial class Form1 : Form
    {
        List<Jogador> jogadores = new List<Jogador>();
        Personagem instance1;
        Personagem instance2;
        Type type;
        Type type2;
        Image imagem;
        string a, b;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbAtributos.Text = "";
            Jogador Jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();
            jogadores.Add(Jogador1);
            jogadores.Add(jogador2);

        }
        private void btnPersonagem_Click(object sender, EventArgs e)
        {

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
                    type = System.Type.GetType("JogoRPG." + cbJogador1.SelectedItem.ToString());
                    instance1 = (Personagem)Activator.CreateInstance(type);
                    type2 = System.Type.GetType("JogoRPG." + cbJogador2.SelectedItem.ToString());
                    instance2 = (Personagem)Activator.CreateInstance(type2);
                    jogadores[0].ataque(instance1, instance2, "bio");
                    a = jogadores[0].caminho(instance1);
                    b = jogadores[1].caminho(instance2);
                    imagemAtacante(a, "");
                    imagemAtacado(b, "");
                }
                catch (TypeInitializationException erro)
                {
                    throw erro;
                }
            } while (cbJogador1.SelectedItem.ToString() == "" || cbJogador2.SelectedItem.ToString() == "" /*|| tipoMagia == ""*/);
            
            
        }

        private void imagemAtacado(string caminho, string v)
        {
            imagem = Image.FromFile(caminho);
            imagemPersonagem2.Image = imagem;
            imagemPersonagem2.Width = imagem.Width;
            imagemPersonagem2.Height = imagem.Height;
        }

        private void imagemAtacante(string caminho,string atributosPersonagem)
        {
            imagem = Image.FromFile(caminho);
            imagemPersonagem1.Image = imagem;
            imagemPersonagem1.Width = imagem.Width;
            imagemPersonagem1.Height = imagem.Height;
        }
    }
}
