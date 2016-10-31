using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoRPG
{
    public partial class Form1 : Form
    {
        List<Jogador> jogadores = new List<Jogador>();
        Animal animal;
        Dragao dragao;
        Zumbi zumbi;
        Troll troll;
        Ladrao ladrao;
        Guerreiro guerreiro;
        Paladino paladino;
        Mago mago;
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
            jogadores[0].ataque(this.guerreiro.ToString());
            MessageBox.Show("ataque normal:"+jogadores[0].vida);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbPersonagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPersonagem.SelectedItem.ToString())
            {
                case "Animal":
                    animal = new Animal();
                    imagem = Image.FromFile(animal.CaminhoImagem);
                    lbAtributos.Text = animal.atributosPersonagem();
                    break;
                case "Dragao":
                    dragao = new Dragao(2);
                    imagem = Image.FromFile(dragao.CaminhoImagem);
                    lbAtributos.Text = dragao.atributosPersonagem();
                    break;
                case "Zumbi":
                    zumbi = new Zumbi();
                    imagem = Image.FromFile(zumbi.CaminhoImagem);
                    lbAtributos.Text = zumbi.atributosPersonagem();
                    break;
                case "Troll":
                    troll = new Troll();
                    imagem = Image.FromFile(troll.CaminhoImagem);
                    lbAtributos.Text = troll.atributosPersonagem();
                    break;
                case "Ladrao":
                    ladrao = new Ladrao();
                    imagem = Image.FromFile(ladrao.CaminhoImagem);
                    lbAtributos.Text = ladrao.atributosPersonagem();
                    break;
                case "Guerreiro":
                    guerreiro = new Guerreiro();
                    imagem = Image.FromFile(guerreiro.CaminhoImagem);
                    lbAtributos.Text = guerreiro.atributosPersonagem();
                    break;
                case "Paladino":
                    paladino = new Paladino();
                    imagem = Image.FromFile(paladino.CaminhoImagem);
                    lbAtributos.Text = paladino.atributosPersonagem();
                    break;
                case "Mago":
                    mago = new Mago();
                    imagem = Image.FromFile(mago.CaminhoImagem);
                    lbAtributos.Text = mago.atributosPersonagem();
                    break;
            }
            imagemPersonagem.Image = imagem;
            imagemPersonagem.Width = imagem.Width;
            imagemPersonagem.Height = imagem.Height;

        }
    }
}
