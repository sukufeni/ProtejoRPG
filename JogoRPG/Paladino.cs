
using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Paladino : Humano , ICura
    {
        PocaoVida magiaVida;
        FlamaGelada flamaGelada;
        Tempestade tempestade;
        TridenteSagrado tridenteSagrado;
        Besta besta;
        private void atributos()
        {
            Vida = 3200;
            Mana = 80;
            forcaFisica = 60;
            forcaMagica = 60;
            resistArmadura = 60;
            resistMagica = 60;
            agilidade = 60;
            this.defesas = new List<int>();
            this.ataques = new List<string>();
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
            incluiLista();
        }

        private void incluiLista()
        {
            Ataques.Add(flamaGelada.ToString());
            ataques.Add(tridenteSagrado.ToString());
            ataques.Add(tempestade.ToString());
            ataques.Add(besta.ToString());
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
                case "FlamaGelada":personagemdefesa.defesa(flamaGelada.executaMagia(ref this.Mana, this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "Tempestade":personagemdefesa.defesa(tempestade.executaMagia(ref this.Mana, this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "TridenteSagrado":personagemdefesa.defesa(tridenteSagrado.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
                case "Besta":personagemdefesa.defesa(besta.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
            }

        }

        public void cura()
        {
            this.Vida += magiaVida.executaCura(ref this.Mana,this.forcaMagica);
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
