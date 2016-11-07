﻿using System;
using System.Collections.Generic;

namespace JogoRPG
{
   public class Guerreiro : Humano
    {
        Tempestade tempestade;
        EspadaBarroca espada;
        Porrete porrete;

        private void atributos()
        {

            Vida = 4000;
            Mana = 30;
            forcaFisica = 100;
            forcaMagica = 20;
            resistArmadura = 80;
            resistMagica = 20;
            agilidade = 50;
            this.defesas = new List<int>();
            this.defesas.Add(agilidade);
            this.defesas.Add(resistMagica);
            this.ataques = new List<string>();
            defesas.Add(resistArmadura);
            caminhoImagem = "C:/Users/bruno/Google Drive/PUC/22016/POO/TI-RPG/guerreiro.jpg";
        }

        public string CaminhoImagem
        {
            get
            {
                return caminhoImagem;
            }
        }

        public Guerreiro()
        {
            atributos();
            constroiArmas();
            constroiMagia();
            ataques.Add(tempestade.ToString());
            ataques.Add(espada.ToString());
            ataques.Add(porrete.ToString());
        }

        public override void constroiMagia()
        {
            tempestade = new Tempestade();
        }

        public override void constroiArmas()
        {
            espada = new EspadaBarroca();
            porrete= new Porrete();
        }

        public  override void ataque(string tipoAtaque, Personagem personagemdefesa)
        {
            switch (tipoAtaque)
            {
                case "Tempestade":personagemdefesa.defesa(tempestade.executaMagia(ref this.Mana, this.forcaMagica, personagemdefesa),personagemdefesa);
                    break;
                case "EspadaBarroca":personagemdefesa.defesa(espada.executaAtaque(this.forcaFisica,personagemdefesa),personagemdefesa);
                    break;
                case "Porrete":personagemdefesa.defesa(porrete.executaAtaque(this.forcaFisica, personagemdefesa),personagemdefesa);
                    break;
            }
        }

        public override int ataqueEspecial(ref int vidaAtacado, string tipoAtaque)
        {
            throw new NotImplementedException();
        }
    }
}
