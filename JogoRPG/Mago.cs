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
        List<Magia> magiaCura;
        private void atributos()
        {
            vida = 2500;
            mana = 100;
            forcaFisica = 40;
            forcaMagica = 100;
            resistArmadura = 30;
            resistMagica = 100;
            agilidade = 40;
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

        public override void ataque(ref int vidaAtacado, string tipoAtaque)
        {

            switch (tipoAtaque)
            {
                case "bio":bio.executaMagia(ref vidaAtacado, ref this.mana, this.forcaMagica);
                    break;
               case "flama gelada":gelada.executaMagia(ref vidaAtacado, ref this.mana, this.forcaMagica);
                    break;
               case "intoxicação":intoxicacao.executaMagia(ref vidaAtacado, ref this.mana, this.forcaMagica);
                    break;
               case "tempestade ":tempestade.executaMagia(ref vidaAtacado, ref this.mana, this.forcaMagica);
                    break;
               case "tridente sagrado":sagrado.executaAtaque(ref vidaAtacado, this.forcaFisica);
                    break;
               case "cajado":  cajado.executaAtaque(ref vidaAtacado, this.forcaFisica);
                    break;
            }
        }

        public override void cura()
        {
            
            magiaCura.Add(pocaVida);
            magiaCura.Add(magiacura);
            magiaCura.Sort();
            Magia atual = magiaCura[0];
            atual.executaMagia(ref this.vida, ref this.mana, this.forcaMagica);
        }
    }
}
