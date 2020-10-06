// Gabriel Alves de Arruda 19170
// Nouani Gabriel Sanches 19194

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosMarte
{
    class Caminho : ICloneable
    {
        Cidade origem, destino;
        int distancia, tempo, custo;

        public Caminho(Cidade origem, Cidade destino, int distancia, int tempo, int custo)
        {
            this.origem = origem;
            this.destino = destino;
            this.distancia = distancia;
            this.tempo = tempo;
            this.custo = custo;
        }

        public int Distancia { get => distancia; set => distancia = value; }
        public int Tempo { get => tempo; set => tempo = value; }
        public int Custo { get => custo; set => custo = value; }
        public Cidade Origem { get => origem; set => origem = value; }
        public Cidade Destino { get => destino; set => destino = value; }

        public object Clone()
        {
            Caminho c = new Caminho(this.origem, this.destino, this.distancia, this.tempo, this.custo);
            return c;
        }
    }
}
