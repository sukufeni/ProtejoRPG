using System;

namespace JogoRPG
{
   public  class Ladrao : Humano
    {
        Intoxicacao intoxicacao;
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
            this.ataques = new System.Collections.Generic.List<string>();
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
            ataques.Add(intoxicacao.ToString());
            ataques.Add(tempestade.ToString());
            ataques.Add(porrete.ToString());
            ataques.Add(cajado.ToString());
            ataques.Add(besta.ToString());
            ataques.Add(esfera.ToString());
        }

        public override void constroiMagia()
        {
            intoxicacao = new Intoxicacao();
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
                case "Intoxicacao":personagemdefesa.defesa(intoxicacao.executaMagia(ref this.Mana, this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "Tempestade":personagemdefesa.defesa(tempestade.executaMagia(ref this.Mana,this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "Porrete":personagemdefesa.defesa(porrete.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
                case "Cajado":personagemdefesa.defesa(cajado.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
                case "Besta":personagemdefesa.defesa(besta.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
                case "EsferaAtaque":personagemdefesa.defesa(esfera.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
            }
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
