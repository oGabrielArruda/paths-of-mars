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
                this.raiz = InserirBalanceado(info, this.raiz);
        }


        public NoArvore<Dado> InserirBalanceado(Dado item, NoArvore<Dado> noAtual)
        {
            if (noAtual == null)
                noAtual = new NoArvore<Dado>(item);
            else
            {
                if (item.CompareTo(noAtual.Info) < 0)
                {
                    noAtual.Esq = InserirBalanceado(item, noAtual.Esq);
                    if (getAltura(noAtual.Esq) - getAltura(noAtual.Dir) == 2) // getAltura testa nulo
                        if (item.CompareTo(noAtual.Esq.Info) < 0)
                            noAtual = RotacaoSimplesComFilhoEsquerdo(noAtual);
                        else
                            noAtual = RotacaoDuplaComFilhoEsquerdo(noAtual);
                }
                else
                    if (item.CompareTo(noAtual.Info) > 0)
                    {
                        noAtual.Dir = InserirBalanceado(item, noAtual.Dir);
                        if (getAltura(noAtual.Dir) - getAltura(noAtual.Esq) == 2)
                            if (item.CompareTo(noAtual.Dir.Info) > 0)
                                noAtual = RotacaoSimplesComFilhoDireito(noAtual);
                            else
                                noAtual = RotacaoDuplaComFilhoDireito(noAtual);
                    }
                    noAtual.Altura = Math.Max(getAltura(noAtual.Esq), getAltura(noAtual.Dir)) + 1;
            }
            return noAtual;
        }

        private NoArvore<Dado> RotacaoSimplesComFilhoEsquerdo(NoArvore<Dado> no)
        {
            NoArvore<Dado> temp = no.Esq;
            no.Esq = temp.Dir;
            temp.Dir = no;
            no.Altura = Math.Max(getAltura(no.Esq), getAltura(no.Dir)) + 1;
            temp.Altura = Math.Max(getAltura(temp.Esq), getAltura(no)) + 1;
            return temp;
        }
        private NoArvore<Dado> RotacaoSimplesComFilhoDireito(NoArvore<Dado> no)
        {
            NoArvore<Dado> temp = no.Dir;
            no.Dir = temp.Esq;
            temp.Esq = no;
            no.Altura = Math.Max(getAltura(no.Esq), getAltura(no.Dir)) + 1;
            temp.Altura = Math.Max(getAltura(temp.Dir), getAltura(no)) + 1;
            return temp;
        }
        private NoArvore<Dado> RotacaoDuplaComFilhoEsquerdo(NoArvore<Dado> no)
        {
            no.Esq = RotacaoSimplesComFilhoDireito(no.Esq);
            return RotacaoSimplesComFilhoEsquerdo(no);
        }
        private NoArvore<Dado> RotacaoDuplaComFilhoDireito(NoArvore<Dado> no)
        {
            no.Dir = RotacaoSimplesComFilhoEsquerdo(no.Dir);
            return RotacaoSimplesComFilhoDireito(no);
        }
        public int getAltura(NoArvore<Dado> no)
        {
            if (no != null)
                return no.Altura;
            else
                return -1;
        }

        public Dado BuscarDado(Dado dadoBuscado)
        {
            return acharDado(dadoBuscado, this.raiz);
        }

        private Dado acharDado(Dado dadoBuscado, NoArvore<Dado> atual)
        {
            if (atual == null)
                throw new Exception("Dado inexistente!");

            int comp = dadoBuscado.CompareTo(atual.Info);
            if (comp == 0)
                return atual.Info;
            if (comp < 0)
                return acharDado(dadoBuscado, atual.Esq);
            else
                return acharDado(dadoBuscado, atual.Dir);
        }
    }
}
