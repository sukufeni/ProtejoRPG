
namespace JogoRPG
{
    interface IEmetodos
    {
        void ataque(string tipoAtaque, Personagem personagemDefesa);
        void ataqueEspecial(Personagem defesa);
        void defesa(int danoAtaque, Personagem personagemDefesa);
        void somaManaRodada(ref int mana);
         Magia constroiMagia();
         Arma constroiArmas();
    }
}
