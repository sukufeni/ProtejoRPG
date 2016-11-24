using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Dragao : Inumano
    {
        HalitoFogo halitoFogo;
        GarraLetal garraLetal;
        private void atributos()
        {
            Vida = 3000;
            Mana = 40;
            forcaFisica = 100;
            forcaMagica = 20;
            resistArmadura = 100;
            resistMagica = 50;
            agilidade = 80;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/dragao.jpeg";
        }

        private void criaLista()
        {
            this.defesas = new List<int>();
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

        public Dragao()
        {
            atributos();
            constroiArmas();
            constroiMagia();
            criaLista();
            incluiLista();
            setVidaManaMaxima();
        }

        private void incluiLista()
        {
            this.armas.Add(garraLetal);
            this.magias.Add(halitoFogo);
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            this.defesas.Add(resistArmadura);
        }

        public override void constroiMagia()
        {
            halitoFogo = new HalitoFogo();
        }

        public override void constroiArmas()
        {
            garraLetal = new GarraLetal();
        }
    }
}
