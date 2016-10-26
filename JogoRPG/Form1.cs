using JogoRPG;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoRPG
{
    public partial class Form1 : Form
    {
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
            Type type = Type.GetType("JogoRPG."+cbPersonagem.SelectedItem.ToString());
            if (type != null)
                 Activator.CreateInstance(type,2);
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType("JogoRPG." + cbPersonagem.SelectedItem.ToString());
                if (type != null)
                     Activator.CreateInstance(type,2);
            }

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
                    animal = new Animal(2);
                    imagem = Image.FromFile(animal.CaminhoImagem);
                    lbAtributos.Text = animal.atributosPersonagem();
                    break;
                case "Dragao":
                    dragao = new Dragao(2);
                    imagem = Image.FromFile(dragao.CaminhoImagem);
                    lbAtributos.Text = dragao.atributosPersonagem();
                    break;
                case "Zumbi":
                    zumbi = new Zumbi(2);
                    imagem = Image.FromFile(zumbi.CaminhoImagem);
                    lbAtributos.Text = zumbi.atributosPersonagem();
                    break;
                case "Troll":
                    troll = new Troll(2);
                    imagem = Image.FromFile(troll.CaminhoImagem);
                    lbAtributos.Text = troll.atributosPersonagem();
                    break;
                case "Ladrao":
                    ladrao = new Ladrao(2);
                    imagem = Image.FromFile(ladrao.CaminhoImagem);
                    lbAtributos.Text = ladrao.atributosPersonagem();
                    break;
                case "Guerreiro":
                    guerreiro = new Guerreiro(2);
                    imagem = Image.FromFile(guerreiro.CaminhoImagem);
                    lbAtributos.Text = guerreiro.atributosPersonagem();
                    break;
                case "Paladino":
                    paladino = new Paladino(2);
                    imagem = Image.FromFile(paladino.CaminhoImagem);
                    lbAtributos.Text = paladino.atributosPersonagem();
                    break;
                case "Mago":
                    mago = new Mago(2);
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
