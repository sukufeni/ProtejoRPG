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
        string jogador0caminhoFoto, jogador1caminhoFoto, atributos1 = "", atributos2 = "";
        const string excecao = "preencha os campos de personagem/Ação corretamente!";
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
            habilitaCb();
        }
        private void criaComboBox()
        {
            for (int x = 0; x <= jogadores[0].Personagens.Count - 1; x++)
            {
                cbPersonagemJogador1.Items.Add(jogadores[0].Personagens[x]);
            }
            for (int x = 0; x <= jogadores[1].Personagens.Count - 1; x++)
            {
                cbPersonagemJogador2.Items.Add(jogadores[1].Personagens[x]);
            }
        }
        private string ataque(string entrada)
        {
            return entrada.Remove(0, 8);
        }
        private void habilitaCb()
        {
            if (!Jogador.rodadaAtual())
            {
                btnJogador1Atk.Enabled = true;
                btnJogador2Atk.Enabled = false;
            }
            else
            {
                btnJogador1Atk.Enabled = false;
                btnJogador2Atk.Enabled = true;
            }
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
           try
           {
                selecionaPersonagem1();
                    jogadores[0].ataque(jogadores[0].personagemAtacante, jogadores[1].personagemAtacado, ataque(cbAcoesJogador1.SelectedItem.ToString()));
                    jogador0caminhoFoto = jogadores[0].caminhoatacante(out atributos2, jogadores[0].personagemAtacante);
                    jogador1caminhoFoto = jogadores[1].caminhoatacado(out atributos1, jogadores[1].personagemAtacado);
                    imagemAtacante(jogador0caminhoFoto, atributos1);
                    imagemAtacado(jogador1caminhoFoto, atributos2);
           }
           catch (NullReferenceException)
           {
                throw new NullReferenceException(excecao);
           }
           finally
           {
                habilitaCb();
           }
        }
        private void btnJogador2Atk_Click(object sender, EventArgs e)
        {
            try
            {
                selecionaPersonagem2();
                    jogadores[1].ataque(jogadores[1].personagemAtacante, jogadores[0].personagemAtacado, ataque(cbAcoesJogador2.SelectedItem.ToString()));
                    jogador0caminhoFoto = jogadores[1].caminhoatacante(out atributos2, jogadores[1].personagemAtacante);
                    jogador1caminhoFoto = jogadores[0].caminhoatacado(out atributos1, jogadores[0].personagemAtacado);
                    imagemAtacante(jogador1caminhoFoto, atributos2);
                    imagemAtacado(jogador0caminhoFoto, atributos1);
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException(excecao);
            }
            finally
            {
                habilitaCb();
            }
        }
        private void selecionaPersonagem1()
        {
            foreach (Personagem a in jogadores[0].Personagens)
            {
                Personagem teste = (Personagem)cbPersonagemJogador1.SelectedItem;
                if (teste == a)
                {
                    jogadores[0].personagemAtacante = teste;
                }
            }
            foreach (Personagem a in jogadores[1].Personagens)
            {
                Personagem teste = (Personagem)cbPersonagemJogador2.SelectedItem;
                if (teste == a)
                {
                    jogadores[1].personagemAtacado = teste;
                }
            }
            cbPersonagemJogador1.Enabled = false;
        }
        private void selecionaPersonagem2()
        {
            foreach (Personagem a in jogadores[1].Personagens)
            {
                Personagem teste = (Personagem)cbPersonagemJogador2.SelectedItem;
                if (teste == a)
                {
                    jogadores[1].personagemAtacante = teste;
                }
            }

            foreach (Personagem a in jogadores[0].Personagens)
            {
                Personagem teste = (Personagem)cbPersonagemJogador1.SelectedItem;
                if (teste == a)
                {
                    jogadores[0].personagemAtacado = teste;
                }
            }
            cbPersonagemJogador2.Enabled = false;
        }
        private void imagemAtacado(string caminho, string v)
        {
            imagem = Image.FromFile(caminho);
            imagemPersonagem2.Image = imagem;
            imagemPersonagem2.Width = imagem.Width;
            imagemPersonagem2.Height = imagem.Height;
            lbAtributos.Text = v;
        }
        private void cbJogador1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionaPersonagem1();
            adicionaListaAcoesJogador1();
            habilitaCb();

        }

        private void adicionaListaAcoesJogador1()
        {
            cbAcoesJogador1.Items.Clear();
            for (int x = 0; x < jogadores[0].personagemAtacante.Acoes.Count; x++)
            {
                cbAcoesJogador1.Items.Add(jogadores[0].personagemAtacante.Acoes[x]);
            }
            cbAcoesJogador1.SelectedIndex = 0;
        }

        private void cbJogador2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionaPersonagem2();
            adicionaAcoesListaJogador2();
            habilitaCb();
        }

        private void adicionaAcoesListaJogador2()
        {
            cbAcoesJogador2.Items.Clear();
            for (int x = 0; x < jogadores[1].personagemAtacante.Acoes.Count; x++)
            {
                cbAcoesJogador2.Items.Add(jogadores[1].personagemAtacante.Acoes[x]);
            }
            cbAcoesJogador2.SelectedIndex = 0;
        }

        private void cbAcoesJogador1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnJogador1Atk.Enabled = false;
            btnJogador2Atk.Enabled = true;
            Jogador.somaRodada();
        }

        private void cbAcoesJogador2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnJogador1Atk.Enabled = true;
            btnJogador2Atk.Enabled = false;
            Jogador.somaRodada();
        }
        private void imagemAtacante(string caminho,string atributosPersonagem)
        {
            imagem = Image.FromFile(caminho);
            imagemPersonagem1.Image = imagem;
            imagemPersonagem1.Width = imagem.Width;
            imagemPersonagem1.Height = imagem.Height;
            lbAtributos2.Text = atributosPersonagem;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
