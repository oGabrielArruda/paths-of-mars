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
        List<Passo> caminhoFeito;
        bool[] jaPassou;

        /**
         * Construtor recebe a matriz de adjacencias, a cidade de origem, e o destino desejado
         */
        public EncontradorDeCaminhos(Passo[,] matrizDeAdjacencias, Cidade origem, Cidade destino)
        {
            this.origem = origem;
            this.destino = destino;
            this.matrizDeAdjacencias = matrizDeAdjacencias;
            this.jaPassou = new bool[matrizDeAdjacencias.GetLength(0)];
            this.caminhoFeito = new List<Passo>();
        }   
        
        /**
         * Método público responsável por retornar a com todos os caminhos encontrados
         * Usamos a variável global "caminhos encontrados" para salvar os caminhso, pois passá-la para o método recursivo
         * usaria muita memória. Já que a cada vez que a função chamasse a si mesma, uma nova lista contendo
         * todos os caminhos seria empilhada,            
         */
        public List<List<Passo>> EncontrarCaminhos(bool recursao, bool pilha, bool dijkstra)
        {                         
            this.caminhosEncontrados = new List<List<Passo>>();
            this.jaPassou = new bool[matrizDeAdjacencias.GetLength(0)];

            if (recursao) encontrarRecursivo(this.origem);
            else if (pilha) encontrarComPilha();
            //else if (dijkstra) encontrarComDjikstra();

            if (this.caminhosEncontrados.Count() == 0)
                throw new Exception("Nenhum caminho encontrado!");
            
            return this.caminhosEncontrados;
        }

        /**
         * Método que encontra os caminhos recursivamente e os salva na lista global
         * É passado um único parâmetro: a cidade atual. A partir dela, procuraremos outras cidades para mover no grafo         
         * Poderia-se passar o vetor jaPassou e a lista de caminhoFeito como parâmetros para a recursão,
         * mas isso ocuparia muita memória. Então os deixamos globais na classe.
         */
        private void encontrarRecursivo(Cidade cidadeAtual)
        {
            for(int j = 0; j < this.matrizDeAdjacencias.GetLength(0); j++)              // percorre as possíveis ligações
            {
                Passo caminho = this.matrizDeAdjacencias[cidadeAtual.Id, j];           // ligação entre cidade atual e cidade do id 'j'
                if (caminho != null && !jaPassou[j])                                   // se existir a ligação, e se ainda não passamos pela cidade j
                {
                    this.caminhoFeito.Add(caminho);                                    // adicionamos o movimento da cidadeAtual para cidade J na nossa lista

                    if (j == this.destino.Id)                                          // se a cidade para que nos movemos for a cidade procurada
                        caminhosEncontrados.Add(caminhoFeito.Select(item => (Passo)item.Clone()).ToList());  // adicionamos o caminho na lista de caminhos possíveis
                    else
                    {                                                       // se não for o destino prucurado
                        jaPassou[caminho.Destino.Id] = true;                // marcamos que já passamos pela próxima cidade           
                        encontrarRecursivo(caminho.Destino);                // chamamos o método recursivo, para continuar a busca
                        jaPassou[caminho.Destino.Id] = false;               // ao voltar, marcamos o jaPassou da cidade destino como false
                    }                                                       
                    caminhoFeito.RemoveAt(caminhoFeito.Count - 1);          // removemos o passo realizado da lista
                                                                            // e continuamos o loop, a fim de achar novos possíveis caminhos
                }
            }
        }

        private void encontrarComPilha()
        {
            Stack<Passo> pilhaCaminho = new Stack<Passo>();
            bool temCaminhoPossivel = true;
            bool movimentou = false;
            int idAtual = this.origem.Id;
            int start = 0;

            while(temCaminhoPossivel)
            {
                jaPassou[idAtual] = true;
                movimentou = false;
                for(int j = start; j < this.matrizDeAdjacencias.GetLength(0); j++)
                {
                    if(this.matrizDeAdjacencias[idAtual, j] != null && !jaPassou[j])
                    {
                        if(j == this.destino.Id)
                        {
                            pilhaCaminho.Push(this.matrizDeAdjacencias[idAtual, j]);
                            this.caminhosEncontrados.Add(pilhaCaminho.Select(item => (Passo)item.Clone()).ToList());
                            pilhaCaminho.Pop();
                        }
                        else
                        {
                            pilhaCaminho.Push(this.matrizDeAdjacencias[idAtual, j]);
                            idAtual = j;
                            movimentou = true;
                            start = 0;
                            break;
                        }
                    }
                }

                if(!movimentou)
                {
                    if (pilhaCaminho.Count() == 0)
                        temCaminhoPossivel = false;
                    else
                    {
                        jaPassou[idAtual] = false;
                        start = idAtual + 1;
                        idAtual = pilhaCaminho.Pop().Origem.Id;                        
                    }                        
                }
            }
        }
    }
}
