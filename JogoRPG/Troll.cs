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
            this.defesas = new List<int>();
            this.ataques = new List<string>();
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            defesas.Add(resistArmadura);
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/troll.jpg";
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
            incluiLista();
        }

        private void incluiLista()
        {
            ataques.Add(intoxicacao.ToString());
            ataques.Add(porrete.ToString());
            ataques.Add(cajado.ToString());
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
                case "Intoxicacao":personagemdefesa.defesa(intoxicacao.executaMagia(ref this.Mana, this.forcaMagica, personagemdefesa),personagemdefesa);
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
