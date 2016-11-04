using System;

namespace JogoRPG
{
   public  class Ladrao : Humano
    {
        Intoxicação intoxicacao;
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
        }

        public override void constroiMagia()
        {
            intoxicacao = new Intoxicação();
            tempestade = new Tempestade();
        }

        public override void constroiArmas()
        {
            porrete = new Porrete();
            cajado = new Cajado();
            besta = new Besta();
            esfera = new EsferaAtaque();
        }
        public override void ataque(string tipoAtaque, Personagem personagemdefesa)
        {
            switch (tipoAtaque)
            {
                case "intoxicação":personagemdefesa.defesa(intoxicacao.executaMagia(ref this.Mana, this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "tempestade":personagemdefesa.defesa(tempestade.executaMagia(ref this.Mana,this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "porrete":personagemdefesa.defesa(porrete.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
                case "cajado":personagemdefesa.defesa(cajado.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
                case "besta":personagemdefesa.defesa(besta.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
                case "esfera":personagemdefesa.defesa(esfera.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
            }
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
