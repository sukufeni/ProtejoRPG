using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Troll : Inumano
    {
        Intoxicacao intoxicacao;
        Porrete porrete;
        Cajado cajado;
        private void atributos()
        {
            Vida = 2800;
            Mana = 20;
            forcaFisica = 100;
            forcaMagica = 20;
            resistArmadura = 100;
            resistMagica = 20;
            agilidade = 20;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/troll.jpg";
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

        public Troll()
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
            this.armas.Add(cajado);
            this.armas.Add(porrete);
            this.magias.Add(intoxicacao);
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            this.defesas.Add(resistArmadura);
        }

        public override void constroiMagia()
        {
             intoxicacao = new Intoxicacao();
        }

        public override void constroiArmas()
        {
            porrete = new Porrete();
            cajado = new Cajado();
        }        
    }
}
