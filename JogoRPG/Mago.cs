using System;
using System.Collections.Generic;

namespace JogoRPG
{
    public class Mago : Humano
    {
        PocaoVida pocaVida;
        Bio bio;
        Cura magiacura;
        FlamaGelada gelada;
        Intoxicação intoxicacao;
        Tempestade tempestade;
        TridenteSagrado sagrado;
        Cajado cajado;
        
        private void atributos()
        {
            vida = 2500;
            mana = 100;
            forcaFisica = 40;
            forcaMagica = 100;
            resistArmadura = 30;
            resistMagica = 100;
            agilidade = 40;
            this.defesas = new List<int>();
            this.Curas = new List<Magia>();
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            defesas.Add(resistArmadura);
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/mago.jpg";
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
        }
        public override void constroiMagia()
        {
            pocaVida = new PocaoVida();
            bio = new Bio();
            magiacura = new Cura();
            gelada = new FlamaGelada();
            intoxicacao = new Intoxicação();
            tempestade = new Tempestade();
        }

        public override void constroiArmas()
        {
            sagrado = new TridenteSagrado();
            cajado= new Cajado();
        }

        public override void cura()
        {
            Curas.Add(pocaVida);
            Curas.Add(magiacura);
            Curas.Sort();
            Magia atual = Curas[0];
            this.vida = atual.executaMagia(ref this.mana, this.forcaMagica);
        }

        public override void ataque(string tipoAtaque, Personagem personagemDefesa)
        {
            switch (tipoAtaque)
            {
                case "bio":
                    personagemDefesa.defesa(bio.executaMagia(ref this.mana, this.forcaMagica),personagemDefesa);
                    break;
                case "flama gelada":personagemDefesa.defesa(gelada.executaMagia(ref this.mana, this.forcaMagica),personagemDefesa);
                    break;
                case "intoxicação":
                    personagemDefesa.defesa(intoxicacao.executaMagia(ref this.mana, this.forcaMagica),personagemDefesa);
                    break;
                case "tempestade ":personagemDefesa.defesa(tempestade.executaMagia(ref this.mana, this.forcaMagica),personagemDefesa);
                    break;
                case "tridente sagrado":
                    personagemDefesa.defesa(sagrado.executaAtaque(this.forcaFisica),personagemDefesa);
                    break;
                case "cajado":
                    personagemDefesa.defesa(cajado.executaAtaque(this.forcaFisica),personagemDefesa);
                    break;
            }
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
