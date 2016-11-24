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
                btnJogador1AtkArma.Enabled = true;
                btnJogador1AtkMagia.Enabled = true;
                btnJogador2AtkArma.Enabled = false;
                btnJogador2AtkMagia.Enabled = false;
            }
            else
            {
                btnJogador1AtkArma.Enabled = false;
                btnJogador1AtkMagia.Enabled = false;
                btnJogador2AtkMagia.Enabled = true;
                btnJogador2AtkArma.Enabled = true;
            }
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
           try
            {
                jogadores[0].ataque(jogadores[1].personagemAtacante, cbArmasJogador1.SelectedIndex,"arma");
                jogador0caminhoFoto = jogadores[0].caminhoatacante(out atributos2, jogadores[0].personagemAtacante);
                jogador1caminhoFoto = jogadores[1].caminhoatacante(out atributos1, jogadores[1].personagemAtacante);
                imagemAtacante(jogador0caminhoFoto, atributos1);
                imagemAtacado(jogador1caminhoFoto, atributos2);
                jogador0Rodada();
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
                jogadores[1].ataque(jogadores[0].personagemAtacante, cbArmasJogador2.SelectedIndex,"arma");
                jogador0caminhoFoto = jogadores[1].caminhoatacante(out atributos2, jogadores[1].personagemAtacante);
                jogador1caminhoFoto = jogadores[0].caminhoatacado(out atributos1, jogadores[0].personagemAtacante);
                imagemAtacante(jogador1caminhoFoto, atributos2);
                imagemAtacado(jogador0caminhoFoto, atributos1);
                jogador1Rodada();
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
        private void btnJogador1AtkMagia_Click(object sender, EventArgs e)
        {
            try
            {
                jogadores[0].ataque(jogadores[1].personagemAtacante, cbMagiasJogador1.SelectedIndex,"magia");
                jogador0caminhoFoto = jogadores[0].caminhoatacante(out atributos2, jogadores[0].personagemAtacante);
                jogador1caminhoFoto = jogadores[1].caminhoatacante(out atributos1, jogadores[1].personagemAtacante);
                imagemAtacante(jogador0caminhoFoto, atributos1);
                imagemAtacado(jogador1caminhoFoto, atributos2);
                jogador0Rodada();
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
        private void btnJogador2AtkMagia_Click(object sender, EventArgs e)
        {
            try
            {
                jogadores[1].ataque(jogadores[0].personagemAtacante, cbMagiasJogador2.SelectedIndex,"magia");
                jogador0caminhoFoto = jogadores[1].caminhoatacante(out atributos2, jogadores[1].personagemAtacante);
                jogador1caminhoFoto = jogadores[0].caminhoatacado(out atributos1, jogadores[0].personagemAtacante);
                imagemAtacante(jogador1caminhoFoto, atributos2);
                imagemAtacado(jogador0caminhoFoto, atributos1);
                jogador1Rodada();
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
        private void jogador0Rodada()
        {
            jogadores[0].somaRodadaEspecial();
            lblRodadaJogador1.Text = jogadores[0].RodadaEspecial.ToString();
        }

        private void jogador1Rodada()
        {
            jogadores[1].somaRodadaEspecial();
            lbRodadaJogador2.Text = jogadores[1].RodadaEspecial.ToString();
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
        private void cbJogador1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionaPersonagem1();
            adicionaListaAcoesJogador1();
            habilitaCb();

        }

        private void adicionaListaAcoesJogador1()
        {
            cbArmasJogador1.Items.Clear();
            for (int x = 0; x < jogadores[0].personagemAtacante.Armas.Count; x++)
            {
                cbArmasJogador1.Items.Add(jogadores[0].personagemAtacante.Armas[x]);
            }
            for (int x = 0; x < jogadores[0].personagemAtacante.Magias.Count; x++)
            {
                cbMagiasJogador1.Items.Add(jogadores[0].personagemAtacante.Magias[x]);
            }
            cbArmasJogador1.SelectedIndex = 0;
            cbMagiasJogador1.SelectedIndex = 0;
        }
        private void adicionaAcoesListaJogador2()
        {
            cbArmasJogador2.Items.Clear();
            for (int x = 0; x < jogadores[1].personagemAtacante.Armas.Count; x++)
            {
                cbArmasJogador2.Items.Add(jogadores[1].personagemAtacante.Armas[x].ToString().Substring(8));
            }
            for (int x = 0; x < jogadores[1].personagemAtacante.Magias.Count; x++)
            {
                cbMagiasJogador2.Items.Add(jogadores[1].personagemAtacante.Magias[x].ToString().Substring(8));
            }
            cbArmasJogador2.SelectedIndex = 0;
            cbMagiasJogador2.SelectedIndex = 0;
        }
        private void cbJogador2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionaPersonagem2();
            adicionaAcoesListaJogador2();
            habilitaCb();
        }

        private void cbAcoesJogador1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(btnJogador1AtkArma.Enabled == true||btnJogador1AtkMagia.Enabled == true)
            {
                btnJogador1AtkArma.Enabled = false;
                Jogador.somaRodada();
            }
            btnJogador2AtkArma.Enabled = true;
        }
        private void cbAcoesJogador2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnJogador2AtkArma.Enabled == true|| btnJogador2AtkMagia.Enabled == true)
            {
                btnJogador2AtkArma.Enabled = false;
                Jogador.somaRodada();
            }
            btnJogador1AtkArma.Enabled = true;
        }
        private void imagemAtacante(string caminho,string atributosPersonagem)
        {
            imagem = Image.FromFile(caminho);
            imagemPersonagem1.Image = imagem;
            imagemPersonagem1.Width = imagem.Width;
            imagemPersonagem1.Height = imagem.Height;
            lbAtributos2.Text = atributosPersonagem;
        }

        private void imagemAtacado(string caminho, string atributosPersonagem)
        {
            imagem = Image.FromFile(caminho);
            imagemPersonagem2.Image = imagem;
            imagemPersonagem2.Width = imagem.Width;
            imagemPersonagem2.Height = imagem.Height;
            lbAtributos.Text = atributosPersonagem;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
