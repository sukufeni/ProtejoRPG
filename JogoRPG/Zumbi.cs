using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Zumbi : Inumano
    {
        Intoxicação intoxicacao;
        GarraLetal garraLetal;
        Porrete porrete;
        Cajado cajado;
        private void atributos()
        {
            vida = 2500;
            mana = 20;
            forcaFisica = 40;
            forcaMagica = 20;
            resistArmadura = 80;
            resistMagica = 90;
            agilidade = 20;
            this.defesas = new List<int>();
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            defesas.Add(resistArmadura);
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/zumbi.jpg";
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
        }

        public override void constroiMagia()
        {
             intoxicacao = new Intoxicação();
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
                case "intoxicação":personagemdefesa.defesa(intoxicacao.executaMagia(ref this.mana, this.forcaMagica), personagemdefesa);
                    break;
                case "garra letal":personagemdefesa.defesa(garraLetal.executaAtaque(this.forcaFisica), personagemdefesa);
                    break;
                case "porrete":personagemdefesa.defesa(porrete.executaAtaque(this.forcaFisica),personagemdefesa);
                    break;
                case "cajado":personagemdefesa.defesa(cajado.executaAtaque(this.forcaFisica),personagemdefesa);
                    break;
            }
        }

        public override void cura()
        {
            throw new NotImplementedException();
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
