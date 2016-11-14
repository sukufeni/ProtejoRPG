namespace JogoRPG
{
    public abstract class Magia
    {
        protected int valorMagia;
        public int gastoMana { get; protected set; }
        public virtual int executaMagia(ref int mana, int forcaMagica, Personagem atacado)
        {
            if (mana >= gastoMana && atacado.Vida >= (valorMagia+forcaMagica))
            {
                mana -= gastoMana;
                return valorMagia + forcaMagica;
            }
            else
            {
                mana = 0;
                return atacado.Vida;
            }
        }
        public virtual int executaCura(ref int mana, int forcaMagica, Personagem vida,int vidaMaxima)
        {
            if (valorMagia + forcaMagica +vida.Vida <=vidaMaxima)
            {
                mana -= gastoMana;
                return valorMagia + forcaMagica;
            }
            else
            {
                throw new System.Exception("magia irá exceder a vida maxima!"); //criar metodo que retorna a const de vida maxima do personagem passado 
            }
        }
    }
}
