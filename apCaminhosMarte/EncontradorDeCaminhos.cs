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

        /**
         * Construtor recebe a matriz de adjacencias, a cidade de origem, e o destino desejado
         */
        public EncontradorDeCaminhos(Passo[,] matrizDeAdjacencias, Cidade origem, Cidade destino)
        {
            this.origem = origem;
            this.destino = destino;
            this.matrizDeAdjacencias = matrizDeAdjacencias;
        }   
        
        /**
         * Método público responsável por retornar a com todos os caminhos encontrados
         * Usamos a variável global "caminhos encontrados" para salvar os caminhso, pois passá-la para o método recursivo
         * usaria muita memória. Já que a cada vez que a função chamasse a si mesma, uma nova lista contendo
         * todos os caminhos seria empilhada,            
         */
        public List<List<Passo>> EncontrarCaminhos()
        {                         
            this.caminhosEncontrados = new List<List<Passo>>();

            // chama-se o método de encontrar caminhos recursivamente, passando a origem como local atual, 
            // uma instância de lista para salvar o caminho feito, e uma matriz booleana pra verificar os locais já visitados
            encontrarRecursivo(this.origem, new List<Passo>(), new bool[this.matrizDeAdjacencias.GetLength(0)]);

            if (this.caminhosEncontrados.Count() == 0)
                throw new Exception("Nenhum caminho encontrado!");

            return this.caminhosEncontrados;
        }

        /**
         * Método que encontra os caminhos recursivamente e os salva na lista global
         * São passados três parâmetros: a cidade atual, a lista com os passos já feitos, e a matriz de locais visitados
         * Primeiramente marcamos que passamos pelo local atual na matriz.
         * Depois, percorremos a linha do local atual no grafo procurando um novo destino (coluna).
         * Caso a coluna não é nula, e ainda não passamos por ela, nos movimentamos, adiconando o passo na lista do caminho feito
         * e trocando a linha atual pela coluna encontrada.
         * Ao chegar em uma coluna igual ao destino, salvamos o caminho clonado na lista global da classe
         */
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
