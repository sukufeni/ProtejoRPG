using System.Collections.Generic;

namespace JogoRPG
{
    public class Jogador
    {
        public Animal animal;
        public Dragao dragao;
        public Zumbi zumbi;
        public Troll troll;
        public Ladrao ladrao;
        public Guerreiro guerreiro;
        public Paladino paladino;
        public Mago mago;
        public List<Personagem> personagens;
        public int vida;
        public Personagem personagemAtacante;
        public Personagem personagemAtacado;
        public Jogador()
        {
            criaPersonagens();
        }

        private void criaPersonagens()
        {
            this.animal = new Animal();
            this.dragao = new Dragao();
            this.zumbi = new Zumbi();
            this.troll = new Troll();
            this.ladrao = new Ladrao();
            this.guerreiro = new Guerreiro();
            this.paladino = new Paladino();
            this.mago = new Mago();
            this.personagens = new List<Personagem>();
            personagens.Add(animal);
            personagens.Add(dragao);
            personagens.Add(zumbi);
            personagens.Add(troll);
            personagens.Add(ladrao);
            personagens.Add(guerreiro);
            personagens.Add(paladino);
            personagens.Add(mago);
        }

        public void ataque(Personagem atacante, Personagem atacado, string tipoMagia)
        {
            atacante.ataque("bio", atacado);
            
        }
        private static void executaRodada()
        {
            
        }
        public string caminhoatacante(out string atributos,Personagem atacante)
        {
            atributos = atacante.atributosPersonagem();
            return atacante.caminhoImagem;
        }
        public string caminhoatacado(out string atributos, Personagem atacado)
        {
            atributos = atacado.atributosPersonagem();
            return atacado.caminhoImagem;
        }
    }
}
