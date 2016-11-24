using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace JogoRPG
{
    public class Animal : Inumano
    {
        Bio bio;
        GarraLetal garraLetal;

        private void atributos()
        {
            Vida = 3200;
            Mana = 30;
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
            criaListas();
            incluiListas();
            setVidaManaMaxima();
        }
        private void criaListas()
        {
            this.defesas = new List<int>();
            this.armas = new List<Arma>();
            this.magias = new List<Magia>();
        }

        private void incluiListas()
        {
            this.Armas.Add(garraLetal);
            this.magias.Add(bio);
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            this.defesas.Add(resistArmadura);
        }

        public override void constroiMagia()
        {
            bio = new Bio();
        }

        public override void constroiArmas()
        {
            garraLetal = new GarraLetal();
        }
    }
}
