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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbAtributos.Text = "";

        }
        private void btnPersonagem_Click(object sender, EventArgs e) // chamar a classe jogador a qual ira tratar os tipos de personagens. 
        {
            Jogador Jogador1 = new Jogador(1);
            Jogador jogador2 = new Jogador(1);
            Jogador[] array = new Jogador[2];
            jogadores.Add(Jogador1);
            jogadores.Add(jogador2);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            jogadores[0].ataque(jogadores[0].animal, "bio", jogadores[1].animal); // FALTA DEFESA DE TODOS OS PERSONAGENS
            imagemAtacante(jogadores[0].animal.CaminhoImagem,jogadores[0].animal.atributosPersonagem());
            imagemAtacado(jogadores[1].animal.CaminhoImagem, jogadores[1].animal.atributosPersonagem());
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
