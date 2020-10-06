using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosMarte
{
    class CaminhoEntreCidades
    {
        int distancia, tempo, custo;

        public CaminhoEntreCidades(int distancia, int tempo, int custo)
        {
            this.distancia = distancia;
            this.tempo = tempo;
            this.custo = custo;
        }

        public int Distancia { get => distancia; set => distancia = value; }
        public int Tempo { get => tempo; set => tempo = value; }
        public int Custo { get => custo; set => custo = value; }
    }
}
