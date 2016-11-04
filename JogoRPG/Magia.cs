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
                return 0;
            }
        }
        public virtual int executaCura(ref int mana, int forcaMagica)
        {
            mana -= gastoMana;
            return valorMagia + forcaMagica;
        }
    }
}
