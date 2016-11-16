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
            this.acoes = new List<string>();
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
            this.acoes.Add(cajado.ToString());
            this.acoes.Add(porrete.ToString());
            this.acoes.Add(intoxicacao.ToString());
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

        public override void ataque(string tipoAtaque, Personagem personagemdefesa)
        {
            switch (tipoAtaque)
            {
                case "Intoxicacao":personagemdefesa.defesa(intoxicacao.executaMagia(this.Vida, ref this.Mana, this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "Porrete":personagemdefesa.defesa(porrete.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa),personagemdefesa); somaManaRodada(ref this.Mana);
                    break;
                case "Cajado":personagemdefesa.defesa(cajado.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa),personagemdefesa); somaManaRodada(ref this.Mana);
                    break;
            }
            
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
