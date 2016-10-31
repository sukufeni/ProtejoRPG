namespace JogoRPG
{
    public  abstract class Magia
    {
        protected int valorMagia;
        protected int gastoMana;
        public virtual void executaMagia(ref int vida,ref int mana)
        {
            vida += valorMagia;
            mana -= gastoMana;
        }
    }
}
