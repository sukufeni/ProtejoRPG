﻿using System;

namespace JogoRPG
{
    public class Animal : Inumano
    {
        Bio bio;
        GarraLetal garraLetal;


        private void atributos()
        {
            vida = 3200;
            mana = 30;
            forcaFisica = 80;
            forcaMagica = 20;
            resistArmadura = 90;
            agilidade = 50;
            resistMagica = 20;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/animal.png";
        }
        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }
        public Animal()
        {
            atributos();
            constroiArmas();
            constroiMagia();
        }

        public override void constroiMagia()
        {
            bio = new Bio();
        }

        public override void constroiArmas()
        {
            garraLetal = new GarraLetal();
        }
        public override void ataque(ref int vidaAtacado,string tipoAtaque)
        {
            if (tipoAtaque == "bio") bio.executaMagia(ref vidaAtacado, ref this.mana,this.forcaMagica);
            else garraLetal.executaAtaque(ref vidaAtacado,this.forcaFisica);
        }
        public override void cura()
        {
            throw new NotImplementedException();
        }
    }
}
