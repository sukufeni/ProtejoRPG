using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Zumbi : Inumano
    {
        Intoxicacao intoxicacao;
        GarraLetal garraLetal;
        Porrete porrete;
        Cajado cajado;
        private void atributos()
        {
            Vida = 2500;
            Mana = 20;
            forcaFisica = 40;
            forcaMagica = 20;
            resistArmadura = 80;
            resistMagica = 90;
            agilidade = 20;
            criaLista();
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/zumbi.jpg";
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

        public Zumbi()
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
            this.armas.Add(garraLetal);
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
            garraLetal = new GarraLetal();
            porrete = new Porrete();
            cajado = new Cajado();
        }

        public override void ataque(string tipoAtaque, Personagem personagemdefesa)
        {
            switch (tipoAtaque)
            {
                case "Intoxicacao":personagemdefesa.defesa(intoxicacao.executaMagia(this.Vida, ref this.Mana, this.forcaMagica, personagemdefesa), personagemdefesa);
                    break;
                case "GarraLetal":personagemdefesa.defesa(garraLetal.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa), personagemdefesa); somaManaRodada(ref this.Mana);
                    break;
                case "Porrete":personagemdefesa.defesa(porrete.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa),personagemdefesa); somaManaRodada(ref this.Mana);
                    break;
                case "Cajado":personagemdefesa.defesa(cajado.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa),personagemdefesa); somaManaRodada(ref this.Mana);
                    break;
            }
        }
    }
}
