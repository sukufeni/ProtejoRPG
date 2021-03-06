﻿using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Mago : Humano , ICura
    {
        PocaoVida pocaVida;
        Bio bio;
        Cura magiacura;
        FlamaGelada gelada;
        Intoxicacao intoxicacao;
        Tempestade tempestade;
        TridenteSagrado sagrado;
        Cajado cajado;
        
        private void atributos()
        {
            Vida = 2500;
            Mana = 100;
            forcaFisica = 40;
            forcaMagica = 100;
            resistArmadura = 30;
            resistMagica = 100;
            agilidade = 40;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/mago.jpg";
        }

        private void criaListas()
        {
            this.defesas = new List<int>();
            this.Curas = new List<Magia>();
            this.armas = new List<Arma>();
            this.magias = new List<Magia>();
        }

        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Mago()
        {
            atributos();
            constroiArmas();
            constroiMagia();
            criaListas();
            incluiLista();
            setVidaManaMaxima();
        }

        private void incluiLista()
        {
            armas.Add(cajado);
            armas.Add(sagrado);
            magias.Add(bio);
            magias.Add(pocaVida);
            magias.Add(magiacura);
            magias.Add(gelada);
            magias.Add(intoxicacao);
            magias.Add(tempestade);
            defesas.Add(resistArmadura);
            defesas.Add(resistMagica);
            defesas.Add(agilidade);
        }

        public override void constroiMagia()
        {
            pocaVida = new PocaoVida();
            bio = new Bio();
            magiacura = new Cura();
            gelada = new FlamaGelada();
            intoxicacao = new Intoxicacao();
            tempestade = new Tempestade();
        }

        public override void constroiArmas()
        {
            sagrado = new TridenteSagrado();
            cajado= new Cajado();
        }
        public void cura(Magia e)
        {
                this.Vida += e.executaCura(this.Vida,ref this.Mana, this.forcaMagica,this,getVidaMaxima());
        }
        public override void ataque(int ataque, Personagem personagemDefesa, object tipoAtaque)
        {
            if (ataque == 1 || ataque == 2) cura(Magias[ataque]);
            else base.ataque(ataque, personagemDefesa, tipoAtaque);
        }
    }
}
