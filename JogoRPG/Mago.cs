using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Mago : Humano , ICura
    {
        PocaoVida pocaVida;
        Bio bio;
        Cura magiacura;
        FlamaGelada gelada;
        Intoxicacao intoxicacao;
        Tempestade tempestade;
        TridenteSagrado sagrado;
        Cajado cajado;
        
        private void atributos()
        {
            Vida = 2500;
            Mana = 100;
            forcaFisica = 40;
            forcaMagica = 100;
            resistArmadura = 30;
            resistMagica = 100;
            agilidade = 40;
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/mago.jpg";
        }

        private void criaListas()
        {
            this.defesas = new List<int>();
            this.Curas = new List<Magia>();
            this.acoes = new List<string>();
        }

        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Mago()
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
            acoes.Add(sagrado.ToString());
            acoes.Add(bio.ToString());
            acoes.Add(pocaVida.ToString());
            acoes.Add(magiacura.ToString());
            acoes.Add(gelada.ToString());
            acoes.Add(intoxicacao.ToString());
            acoes.Add(tempestade.ToString());
            defesas.Add(resistArmadura);
            defesas.Add(resistMagica);
            defesas.Add(agilidade);
        }

        public override void constroiMagia()
        {
            pocaVida = new PocaoVida();
            bio = new Bio();
            magiacura = new Cura();
            gelada = new FlamaGelada();
            intoxicacao = new Intoxicacao();
            tempestade = new Tempestade();
        }

        public override void constroiArmas()
        {
            sagrado = new TridenteSagrado();
            cajado= new Cajado();
        }
        public void cura(Magia e)
        {
                this.Vida += e.executaCura(ref this.Mana, this.forcaMagica,this,getVidaMaxima());
        }

        public override void ataque(string tipoAtaque, Personagem personagemDefesa)
        {
            switch (tipoAtaque)
            {
                case "Bio":
                    personagemDefesa.defesa(bio.executaMagia(ref this.Mana, this.forcaMagica,personagemDefesa),personagemDefesa);
                    break;
                case "FlamaGelada":personagemDefesa.defesa(gelada.executaMagia(ref this.Mana, this.forcaMagica,personagemDefesa),personagemDefesa);
                    break;
                case "Intoxicacao":
                    personagemDefesa.defesa(intoxicacao.executaMagia(ref this.Mana, this.forcaMagica,personagemDefesa),personagemDefesa);
                    break;
                case "Tempestade ":personagemDefesa.defesa(tempestade.executaMagia(ref this.Mana, this.forcaMagica,personagemDefesa),personagemDefesa);
                    break;
                case "TridenteSagrado":
                    personagemDefesa.defesa(sagrado.executaAtaque(this.forcaFisica, personagemDefesa),personagemDefesa); somaManaRodada(ref this.Mana);
                    break;
                case "Cajado":
                    personagemDefesa.defesa(cajado.executaAtaque(this.forcaFisica, personagemDefesa),personagemDefesa); somaManaRodada(ref this.Mana);
                    break;
                case "Cura":cura(magiacura);
                    break;
                case "PocaoVida":
                    cura(magiacura);
                    break;
            }
        }
        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
