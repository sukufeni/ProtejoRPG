
namespace JogoRPG
{
    public class Arma
    {
        protected int dano;

        public void executaAtaque(ref int vidaAtacado, int forcaFisica)
        {
            vidaAtacado -= this.dano*(forcaFisica/100);
        }
    }
}
