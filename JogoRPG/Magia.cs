namespace JogoRPG
{
    public  abstract class Magia
    {
        protected int valorMagia;
        protected int gastoMana;
        public virtual int executaMagia(ref int mana,int forcaMagica)
        {
            mana -= gastoMana;
            return valorMagia * forcaMagica / 100;
        }
    }
}
