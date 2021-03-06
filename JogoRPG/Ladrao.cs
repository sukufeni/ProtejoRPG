﻿using System;

namespace JogoRPG
{
   public  class Ladrao : Humano
    {
        Intoxicacao intoxicacao;
        Tempestade tempestade;
        EsferaAtaque esfera;
        Porrete porrete;
        Cajado cajado;
        Besta besta;
        
        private void atributos()
        {
            Vida = 2800;
            Mana = 50;
            forcaFisica = 50;
            forcaMagica = 30;
            resistArmadura = 40;
            resistMagica = 50;
            agilidade = 100;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/goblin.jpg";
        }

        private void criaListas()
        {
            this.armas = new System.Collections.Generic.List<Arma>();
            this.defesas = new System.Collections.Generic.List<int>();
            this.magias = new System.Collections.Generic.List<Magia>();
        }

        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Ladrao()
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
            magias.Add(intoxicacao);
            magias.Add(tempestade);
            armas.Add(porrete);
            armas.Add(besta);
            armas.Add(esfera);
            defesas.Add(resistArmadura);
            defesas.Add(resistMagica);
            defesas.Add(agilidade);
        }

        public override void constroiMagia()
        {
            intoxicacao = new Intoxicacao();
            tempestade = new Tempestade();
        }
        public override void constroiArmas()
        {
            porrete = new Porrete();
            cajado = new Cajado();
            besta = new Besta();
            esfera = new EsferaAtaque();
        }
    }
}
