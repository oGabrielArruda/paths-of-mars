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

        public Dado Info { get => info; set => info = value; }
        public NoArvore<Dado> Esq { get => esq; set => esq = value; }
        public NoArvore<Dado> Dir { get => dir; set => dir = value; }

        public NoArvore(Dado info)
        {
            this.info = info;
            this.esq = this.dir = null;
        }
    }
}
