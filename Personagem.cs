using System;

namespace JogoRPG
{
   abstract class Personagem : Jogador,IEmetodos
    {
        protected int vida;
        protected int dano;
        protected int mana;
        protected int forcaFisica;
        protected int forcaMagica;
        protected int resistArmadura;
        protected int resistMagica;
        protected int agilidade;
        protected int fraqueza;
        protected Magia magia;
        protected Arma arma;
        protected string caminhoImagem;
        protected bool ataqueEspecial;

        public Personagem(int jogadores) : base(jogadores)
        {

        }
        public virtual string atributosPersonagem()
        {
            return "vida:" + vida + " - " + "mana: " + mana + "\n" + "força-fisica: " + forcaFisica + " - " + "força-magica: " + forcaMagica + "\n" + "resistencia-armadura: " + resistArmadura + " - " + "resistencia-magica: " + resistMagica;
        }
        public abstract void constroiMagia();
        public abstract void constroiArmas();// mudar para inicializar a arma mais fraca
        public abstract void ataque(int vidaAtacado, string tipoAtaque); // switch para cada ataque utilizando os botoes

        public abstract void cura();// tipos de cura

        Magia IEmetodos.constroiMagia()
        {
            throw new NotImplementedException();
        }

        Arma IEmetodos.constroiArmas()
        {
            throw new NotImplementedException();
        }

        public void rodada(bool magia, ref int mana)
        {
            if (magia!= false) mana += 10;  //limite maximo, receber a propria classe?
        }

        void IEmetodos.ataqueEspecial(int vidaAtacado, string tipoAtaque)//configurar o ataque especial
        {
            /* ira usar a variavel de rodada interna de cada classe,
             * so habilitará o botao a cada 10 rodadas
             */
        }
    }
}
