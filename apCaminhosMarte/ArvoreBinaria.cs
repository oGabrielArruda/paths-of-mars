// Gabriel Alves de Arruda 19170
// Nouani Gabriel Sanches 19194
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosMarte
{
    class ArvoreBinaria<Dado> where Dado : IComparable<Dado>
    {
        protected NoArvore<Dado> raiz;

        public void Incluir(Dado info)
        {
            if (this.raiz == null)
                this.raiz = new NoArvore<Dado>(info);
            else
                incluirRecursivamente(raiz, info);
        }

        private void incluirRecursivamente(NoArvore<Dado> atual, Dado info)
        {
            int comp = info.CompareTo(atual.Info);

            if (comp == 0) throw new Exception("Item já existente!");

            if(comp < 0)
            {
                if (atual.Esq == null)
                    atual.Esq = new NoArvore<Dado>(info);
                else
                    incluirRecursivamente(atual.Esq, info);
            }
            else // comp > 0
            {
                if (atual.Dir == null)
                    atual.Dir = new NoArvore<Dado>(info);
                else
                    incluirRecursivamente(atual.Dir, info);
            }
        }
    }
}
