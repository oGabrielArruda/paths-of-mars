// Gabriel Alves de Arruda 19170
// Nouani Gabriel Sanches 19194
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosMarte
{
    class EncontradorDeCaminhos
    {
        Cidade origem, destino;
        Caminho[,] matrizDeAdjacencias;
        List<List<Caminho>> caminhosEncontrados;
        public EncontradorDeCaminhos(Caminho[,] matrizDeAdjacencias, Cidade origem, Cidade destino)
        {
            this.origem = origem;
            this.destino = destino;
            this.matrizDeAdjacencias = matrizDeAdjacencias;
        }   
        
        public List<List<Caminho>> EncontrarCaminhos()
        {
            this.caminhosEncontrados = new List<List<Caminho>>();
            encontrarRecursivo(this.origem, new List<Caminho>(), new bool[this.matrizDeAdjacencias.GetLength(0)]);
            return this.caminhosEncontrados;
        }

        private void encontrarRecursivo(Cidade cidadeAtual, List<Caminho> caminhoFeito, bool[] jaPassou)
        {
            jaPassou[cidadeAtual.Id] = true;

            for(int j = 0; j < this.matrizDeAdjacencias.GetLength(0); j++)
            {
                Caminho caminho = this.matrizDeAdjacencias[cidadeAtual.Id, j];
                if (caminho != null && !jaPassou[j])
                {
                    caminhoFeito.Add(caminho);

                    if (j == destino.Id)
                        caminhosEncontrados.Add(caminhoFeito.Select(item => (Caminho)item.Clone()).ToList());
                    else
                        encontrarRecursivo(caminho.Destino, caminhoFeito, jaPassou);
                    caminhoFeito.RemoveAt(caminhoFeito.Count - 1);
                }
            }
        }

    }
}
