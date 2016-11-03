using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Troll : Inumano
    {
        Intoxicação intoxicacao;
        Porrete porrete;
        Cajado cajado;
        private void atributos()
        {
            vida = 2800;
            mana = 20;
            forcaFisica = 100;
            forcaMagica = 20;
            resistArmadura = 100;
            resistMagica = 20;
            agilidade = 20;
            this.defesas = new List<int>();
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
        }


        public override void constroiMagia()
        {
             intoxicacao = new Intoxicação();
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
                case "intoxicação":personagemdefesa.defesa(intoxicacao.executaMagia(ref this.mana, this.forcaMagica),personagemdefesa);
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
