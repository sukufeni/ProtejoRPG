
using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Paladino : Humano , ICura
    {
        PocaoVida pocaoVida;
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
            criaLista();
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/paladin.jpg";
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

        public Paladino()
        {
            setVidaManaMaxima();
            atributos();
            constroiArmas();
            constroiMagia();
            criaLista();
            incluiLista();
        }

        private void incluiLista()
        {
            this.acoes.Add(tridenteSagrado.ToString());
            this.acoes.Add(besta.ToString());
            this.acoes.Add(flamaGelada.ToString());
            this.acoes.Add(tempestade.ToString());
            this.acoes.Add(pocaoVida.ToString());
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            this.defesas.Add(resistArmadura);
        }

        public override void constroiMagia()
        {
            pocaoVida = new PocaoVida();
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
                case "FlamaGelada":personagemdefesa.defesa(flamaGelada.executaMagia(this.Vida, ref this.Mana, this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "Tempestade":personagemdefesa.defesa(tempestade.executaMagia(this.Vida, ref this.Mana, this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "TridenteSagrado":personagemdefesa.defesa(tridenteSagrado.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa),personagemdefesa); somaManaRodada(ref this.Mana);
                    break;
                case "Besta":personagemdefesa.defesa(besta.executaAtaque(this.Vida, this.forcaFisica, personagemdefesa),personagemdefesa); somaManaRodada(ref this.Mana);
                    break;
                case "PocaoVida":
                    cura(pocaoVida);
                    break;
            }
        }
        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }

        public void cura(Magia e)
        {
            this.Vida += e.executaCura(this.Vida, ref this.Mana, this.forcaMagica, this, getVidaMaxima());
        }
    }
}
