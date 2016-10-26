﻿using System;

namespace JogoRPG
{
    class Dragao : Inumano
    {
        HalitoFogo halitoFogo;
        GarraLetal garraLetal;
        private void atributos()
        {
            vida = 3000;
            mana = 40;
            forcaFisica = 100;
            forcaMagica = 20;
            resistArmadura = 100;
            resistMagica = 50;
            agilidade = 80;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/dragao.jpeg";
        }

        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Dragao(int jogadores) : base(jogadores)
        {
            atributos();
            constroiArmas();
            constroiMagia();
        }

        
        public override void constroiMagia()
        {
            halitoFogo = new HalitoFogo();
        }

        public override void constroiArmas()
        {
            garraLetal = new GarraLetal();
        }
        public override void ataque(int vidaAtacado, string tipoAtaque)
        {
            if (tipoAtaque == "magia") halitoFogo.executaMagia(ref vidaAtacado, ref this.mana);
            else garraLetal.executaAtaque(ref vidaAtacado);
        }

        public override void cura()
        {
            throw new NotImplementedException();
        }
    }
}