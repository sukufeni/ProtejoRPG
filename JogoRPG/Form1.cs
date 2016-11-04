﻿using System;
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
            for (int x = 0; x <= jogadores[0].Personagens.Count - 1; x++)
            {
                cbJogador1.Items.Add(jogadores[0].Personagens[x]);
            }
            for (int x = 0; x <= jogadores[1].Personagens.Count - 1; x++)
            {
                cbJogador2.Items.Add(jogadores[1].Personagens[x]);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnAtaque_Click(object sender, EventArgs e)
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
                catch (NullReferenceException)
                {
                    MessageBox.Show("preencha as opções corretamente!");
                cbAtkJ1.SelectedItem = 1;
                }   
        }
        private void cbAtk1()
        {
            foreach (Personagem a in jogadores[0].Personagens)
            {
                Personagem teste = (Personagem)cbJogador1.SelectedItem;
                if (teste == a)
                {
                    jogadores[0].personagemAtacante = teste;
                }
            }

            foreach (Personagem a in jogadores[1].Personagens)
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
            foreach (Personagem a in jogadores[1].Personagens)
            {
                Personagem teste = (Personagem)cbJogador2.SelectedItem;
                if (teste == a)
                {
                    jogadores[1].personagemAtacante = teste;
                }
            }

            foreach (Personagem a in jogadores[0].Personagens)
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
            try{
                    cbAtk2();
                    jogadores[1].ataque(jogadores[1].personagemAtacante, jogadores[0].personagemAtacado, "bio");
                    string atributos1 = "", atributos2 = "";
                    a = jogadores[1].caminhoatacante(out atributos2, jogadores[1].personagemAtacante);
                    b = jogadores[0].caminhoatacado(out atributos1, jogadores[0].personagemAtacado);
                    imagemAtacante(b, atributos2);
                    imagemAtacado(a, atributos1);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("preencha as opções corretamente!");
                    cbAtkJ2.SelectedItem = 1;
                }
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
