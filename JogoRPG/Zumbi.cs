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
            this.defesas = new List<int>();
            this.ataques = new List<string>();
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
            ataques.Add(intoxicacao.ToString());
            ataques.Add(garraLetal.ToString());
            ataques.Add(porrete.ToString());
            ataques.Add(cajado.ToString());
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
                case "Intoxicacao":personagemdefesa.defesa(intoxicacao.executaMagia(ref this.Mana, this.forcaMagica, personagemdefesa), personagemdefesa);
                    break;
                case "GarraLetal":personagemdefesa.defesa(garraLetal.executaAtaque(this.forcaFisica, personagemdefesa), personagemdefesa);
                    break;
                case "Porrete":personagemdefesa.defesa(porrete.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
                case "Cajado":personagemdefesa.defesa(cajado.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
            }
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
