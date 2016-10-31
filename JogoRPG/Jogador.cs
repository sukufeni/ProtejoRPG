﻿
using System.Collections.Generic;

namespace JogoRPG
{
    //new personagem passando o numero de jogadores
    // a cada new personagem um vetor vai ser criado com todos os personagens, separados por jogador ex: 2 jogadores Personagem[]1 = new personagem
    public class Jogador
    {

        Animal animal;
        Dragao dragao;
        Zumbi zumbi;
        Troll troll;
        Ladrao ladrao;
        Guerreiro guerreiro;
        Paladino paladino;
        Mago mago;
        List<Personagem> personagens;
        public int vida;

        public Jogador(int jogadores)
        {
            criaPersonagens();
        }

        private void criaPersonagens()
        {
            this.animal = new Animal();
            this.dragao = new Dragao(2);
            this.zumbi = new Zumbi();
            this.troll = new Troll();
            this.ladrao = new Ladrao();
            this.guerreiro = new Guerreiro();
            this.paladino = new Paladino();
            this.mago = new Mago();
            this.personagens = new List<Personagem>();
            personagens.Add(animal);
            personagens.Add(dragao);
            personagens.Add(zumbi);
            personagens.Add(troll);
            personagens.Add(ladrao);
            personagens.Add(guerreiro);
            personagens.Add(paladino);
            personagens.Add(mago);
        }

        public void ataque(string tipo)
        {
            this.animal.ataque(ref this.guerreiro.vida, "magia");
            vida = this.guerreiro.vida;
        }
        private static void executaRodada()
        {
            
        }
        
    }
}
