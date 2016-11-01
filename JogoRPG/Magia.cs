namespace JogoRPG
{
    public  abstract class Magia
    {
        protected int valorMagia;
        protected int gastoMana;
        public virtual void executaMagia(ref int vida,ref int mana,int forcaMagica)
        {
            vida += valorMagia * forcaMagica / 100;
            mana -= gastoMana;
        }
    }
}
