using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soFifaRobo.Models
{
    public class Jogador
    {
        public int IdadeMin { get; set; }
        public int OveralMin { get; set; }
        public int PotencialMin { get; set; }
        public string AlturaMin { get; set; }

        public int IdadeMax { get; set; }
        public int OveralMax { get; set; }
        public int PotencialMax { get; set; }
        public string PosicaoMax { get; set; }
        public string AlturaMax { get; set; }

        public string Posicao { get; set; }
        public string Pe { get; set; }
        public int Habilidades { get; set; }


    }
}
