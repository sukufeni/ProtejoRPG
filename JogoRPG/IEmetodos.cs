
namespace JogoRPG
{
    interface IEmetodos
    {
        void ataque(ref int vidaAtacado,string tipoAtaque);
        void ataqueEspecial(ref int vidaAtacado, string tipoAtaque);
        void cura();
        void rodada(bool magia,ref int mana);
         Magia constroiMagia();
         Arma constroiArmas();
    }
}
