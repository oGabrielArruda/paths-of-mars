// Gabriel Alves de Arruda 19170
// Nouani Gabriel Sanches 19194
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosMarte
{
    class NoArvore<Dado>
    {
        Dado info;
        NoArvore<Dado> esq, dir;
        int altura;

        public Dado Info { get => info; set => info = value; }
        public NoArvore<Dado> Esq { get => esq; set => esq = value; }
        public NoArvore<Dado> Dir { get => dir; set => dir = value; }

        public int Altura { get => altura; set => altura = value; }

        public NoArvore(Dado info)
        {
            this.info = info;
            this.esq = this.dir = null;
            this.altura = 0;
        }


        public NoArvore(Dado dados, NoArvore<Dado> esquerdo, NoArvore<Dado> direito, int altura)
        {
            this.Info = dados;
            this.Esq = esquerdo;
            this.Dir = direito;
            this.Altura = altura;
        }
    }
}
