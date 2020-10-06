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
        Passo[,] matrizDeAdjacencias;
        List<List<Passo>> caminhosEncontrados;
        public EncontradorDeCaminhos(Passo[,] matrizDeAdjacencias, Cidade origem, Cidade destino)
        {
            this.origem = origem;
            this.destino = destino;
            this.matrizDeAdjacencias = matrizDeAdjacencias;
        }   
        
        public List<List<Passo>> EncontrarCaminhos()
        {
            this.caminhosEncontrados = new List<List<Passo>>();
            encontrarRecursivo(this.origem, new List<Passo>(), new bool[this.matrizDeAdjacencias.GetLength(0)]);

            if (this.caminhosEncontrados.Count() == 0)
                throw new Exception("Nenhum caminho encontrado!");

            return this.caminhosEncontrados;
        }

        private void encontrarRecursivo(Cidade cidadeAtual, List<Passo> caminhoFeito, bool[] jaPassou)
        {
            jaPassou[cidadeAtual.Id] = true;

            for(int j = 0; j < this.matrizDeAdjacencias.GetLength(0); j++)
            {
                Passo caminho = this.matrizDeAdjacencias[cidadeAtual.Id, j];
                if (caminho != null && !jaPassou[j])
                {
                    caminhoFeito.Add(caminho);

                    if (j == destino.Id)
                        caminhosEncontrados.Add(caminhoFeito.Select(item => (Passo)item.Clone()).ToList());
                    else
                        encontrarRecursivo(caminho.Destino, caminhoFeito, jaPassou);
                    caminhoFeito.RemoveAt(caminhoFeito.Count - 1);
                }
            }
        }

    }
}
