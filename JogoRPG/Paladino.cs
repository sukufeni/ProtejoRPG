
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
            this.armas = new List<Arma>();
            this.magias = new List<Magia>();
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
            this.armas.Add(tridenteSagrado);
            this.armas.Add(besta);
            this.magias.Add(flamaGelada);
            this.magias.Add(tempestade);
            this.magias.Add(pocaoVida);
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
        public void cura(Magia e)
        {
            this.Vida += e.executaCura(this.Vida, ref this.Mana, this.forcaMagica, this, getVidaMaxima());
        }
        public override void ataque(int ataque, Personagem personagemDefesa, object tipoAtaque)
        {
            if (ataque == 2) cura(Magias[ataque]);
            else base.ataque(ataque, personagemDefesa, tipoAtaque);
        }
    }
}
