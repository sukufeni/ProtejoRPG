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
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/goblin.jpg";
        }

        private void criaListas()
        {
            this.acoes = new System.Collections.Generic.List<string>();
            this.defesas = new System.Collections.Generic.List<int>();
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
            criaListas();
            incluiLista();
            setVidaManaMaxima();
        }

        private void incluiLista()
        {
            acoes.Add(cajado.ToString());
            acoes.Add(intoxicacao.ToString());
            acoes.Add(tempestade.ToString());
            acoes.Add(porrete.ToString());
            acoes.Add(besta.ToString());
            acoes.Add(esfera.ToString());
            defesas.Add(resistArmadura);
            defesas.Add(resistMagica);
            defesas.Add(agilidade);
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
        public override void ataque(string tipoAtaque, Personagem personagemdefesa) // nao esta polimorfico!!!
        {
            switch (tipoAtaque)
            {
                case "Intoxicacao":personagemdefesa.defesa(intoxicacao.executaMagia(this.Vida, ref this.Mana, this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "Tempestade":personagemdefesa.defesa(tempestade.executaMagia(this.Vida, ref this.Mana,this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "Porrete":personagemdefesa.defesa(porrete.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa),personagemdefesa); somaManaRodada(ref this.Mana);
                    break;
                case "Cajado":personagemdefesa.defesa(cajado.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa),personagemdefesa); somaManaRodada(ref this.Mana);
                    break;
                case "Besta":personagemdefesa.defesa(besta.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa),personagemdefesa); somaManaRodada(ref this.Mana);
                    break;
                case "EsferaAtaque":personagemdefesa.defesa(esfera.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa),personagemdefesa); somaManaRodada(ref this.Mana);
                    break;
            }
        }
    }
}
