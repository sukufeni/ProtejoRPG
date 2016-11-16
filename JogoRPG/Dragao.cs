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
            this.acoes = new List<string>();
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
            this.acoes.Add(garraLetal.ToString());
            this.acoes.Add(halitoFogo.ToString());
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
        public override void ataque(string tipoAtaque, Personagem personagemdefesa)
        {
            if (tipoAtaque == "HalitoFogo") personagemdefesa.defesa(halitoFogo.executaMagia(this.Vida, ref this.Mana, this.forcaMagica, personagemdefesa), personagemdefesa);
            else
            {
                personagemdefesa.defesa(garraLetal.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa), personagemdefesa);
                somaManaRodada(ref this.Mana);
            }
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
