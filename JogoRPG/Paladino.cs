
using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Paladino : Humano
    {
        PocaoVida magiaVida;
        FlamaGelada flamaGelada;
        Tempestade tempestade;
        TridenteSagrado tridenteSagrado;
        Besta besta;
        private void atributos()
        {
            vida = 3200;
            mana = 80;
            forcaFisica = 60;
            forcaMagica = 60;
            resistArmadura = 60;
            resistMagica = 60;
            agilidade = 60;
            this.defesas = new List<int>();
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            defesas.Add(resistArmadura);
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/paladin.jpg";
        }


        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Paladino()
        {
            atributos();

            constroiArmas();
            constroiMagia();
        }

      
        public override void constroiMagia()
        {
            magiaVida = new PocaoVida();
            flamaGelada = new FlamaGelada();
            tempestade = new Tempestade();
        }

        public override void constroiArmas()
        {
            tridenteSagrado = new TridenteSagrado();
            besta = new Besta();
        }
        public override void ataque(string tipoAtaque, Personagem personagemdefesa)
        {
            switch (tipoAtaque)
            {
                case "flama gelada":personagemdefesa.defesa(flamaGelada.executaMagia(ref this.mana, this.forcaMagica),personagemdefesa);
                    break;
                case "tempestade":personagemdefesa.defesa(tempestade.executaMagia(ref this.mana, this.forcaMagica),personagemdefesa);
                    break;
                case "tridente sagrado":personagemdefesa.defesa(tridenteSagrado.executaAtaque(this.forcaFisica),personagemdefesa);
                    break;
                case "besta":personagemdefesa.defesa(besta.executaAtaque(this.forcaFisica),personagemdefesa);
                    break;
            }

        }

        public override void cura()
        {
            this.vida += magiaVida.executaMagia(ref this.mana,this.forcaMagica);
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
