﻿using System.Collections.Generic;

namespace JogoRPG
{
    public class Jogador
    {
        private Animal animal { get; set; }
        private Dragao dragao { get; set; }
        private Zumbi zumbi { get; set; }
        private Troll troll { get; set; }
        private Ladrao ladrao { get; set; }
        private Guerreiro guerreiro { get; set; }
        private Paladino paladino { get; set; }
        private Mago mago { get; set; }
        private static int contRodada = 0;
        private int rodadaEspecial = 0;
        private List<Personagem> personagens;
        public int vida;
        public Personagem personagemAtacante;
        public Personagem personagemAtacado;

        public List<Personagem> Personagens
        {
            get
            {
                return personagens;
            }
        }

        public int RodadaEspecial
        {
            get
            {
                return rodadaEspecial;
            }
        }

        public Jogador()
        {
            criaPersonagens();
            adicionaPersonagens();
        }
        private void criaPersonagens()
        {
            this.animal = new Animal();
            this.dragao = new Dragao();
            this.zumbi = new Zumbi();
            this.troll = new Troll();
            this.ladrao = new Ladrao();
            this.guerreiro = new Guerreiro();
            this.paladino = new Paladino();
            this.mago = new Mago();
            this.personagens = new List<Personagem>();
        }

        private void adicionaPersonagens()
        {
            Personagens.Add(animal);
            Personagens.Add(dragao);
            Personagens.Add(zumbi);
            Personagens.Add(troll);
            Personagens.Add(ladrao);
            Personagens.Add(guerreiro);
            Personagens.Add(paladino);
            Personagens.Add(mago);
        }
        public void ataque(Personagem atacado, int ataque,object tipoAtaque)
        {
            if ((int)this.rodadaEspecial / (int)10 >= 1) this.personagemAtacante.ataqueEspecial(atacado);
            else this.personagemAtacante.ataque(ataque, atacado,tipoAtaque);
            somaRodada();
        }
        public string caminhoatacante(out string atributos, Personagem atacante)
        {
            atributos = atacante.atributosPersonagem();
            return atacante.caminhoImagem;
        }
        public string caminhoatacado(out string atributos, Personagem atacado)
        {
            atributos = atacado.atributosPersonagem();
            return atacado.caminhoImagem;
        }

        public static void somaRodada()
        {
            contRodada++;
        }
        public void somaRodadaEspecial()
        {
            this.rodadaEspecial++;
        }
        public static bool rodadaAtual()
        {
            if (contRodada % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
    }
}
