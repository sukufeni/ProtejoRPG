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
            this.defesas = new List<int>();
            this.Curas = new List<Magia>();
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            this.ataques = new List<string>();
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
            incluiLista();
        }

        private void incluiLista()
        {
            ataques.Add(bio.ToString());
            ataques.Add(pocaVida.ToString());
            ataques.Add(magiacura.ToString());
            ataques.Add(gelada.ToString());
            ataques.Add(intoxicacao.ToString());
            ataques.Add(tempestade.ToString());
            ataques.Add(sagrado.ToString());
            ataques.Add(cajado.ToString());
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

        public void cura()
        {
            Curas.Add(pocaVida);
            Curas.Add(magiacura);
            Curas.Sort();
            Magia atual = Curas[0];
            this.Vida = atual.executaCura(ref this.Mana, this.forcaMagica);
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
                case "Intoxicação":
                    personagemDefesa.defesa(intoxicacao.executaMagia(ref this.Mana, this.forcaMagica,personagemDefesa),personagemDefesa);
                    break;
                case "Tempestade ":personagemDefesa.defesa(tempestade.executaMagia(ref this.Mana, this.forcaMagica,personagemDefesa),personagemDefesa);
                    break;
                case "TridenteSagrado":
                    personagemDefesa.defesa(sagrado.executaAtaque(this.forcaFisica, personagemDefesa),personagemDefesa);
                    break;
                case "Cajado":
                    personagemDefesa.defesa(cajado.executaAtaque(this.forcaFisica, personagemDefesa),personagemDefesa);
                    break;
            }
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
