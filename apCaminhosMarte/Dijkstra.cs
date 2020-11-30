using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosMarte
{
    class Dijkstra
    {
        private class Vertice
        {
            public Cidade cidade;
            public bool foiVisitado;
            public bool estaAtivo;
            public Vertice(Cidade cidade)
            {
                this.cidade = cidade;
                this.foiVisitado = false;
                this.estaAtivo = false;
            }
        }

        private class DistOriginal
        {
            public int distancia;
            public int verticePai;
            public DistOriginal(int vp, int d)
            {
                distancia = d;
                verticePai = vp;
            }
        }

        private Vertice[] vertices;
        private int[,] matriz;
        private int totalDeVertices;
        ArvoreCidades arvoreCidades;

        // djikstra
        DistOriginal[] trajeto;
        int infinity = 1000000;
        int verticeAtual;
        int doInicioAteAtual;
        int nTree;
        public Dijkstra(ArvoreCidades arvoreCidades, Passo[,] matrizAdj, bool distancia, bool custo, bool tempo)
        {
            // verificação se foi passado apenas um boolean true
            int qtsTrues = 0;
            if (distancia == true) qtsTrues++;
            if (custo == true) qtsTrues++;
            if (tempo == true) qtsTrues++;
            if (qtsTrues != 1)
                throw new Exception("Passe apenas um critério de peso!");

            // inicialização de variáveis
            this.totalDeVertices = matrizAdj.GetLength(0);
            this.vertices = new Vertice[this.totalDeVertices];
            this.matriz = new int[this.totalDeVertices, this.totalDeVertices];
            this.nTree = 0;

            // inserindo valores na matriz
            for (int i = 0; i < this.totalDeVertices; i++)
                for (int j = 0; j < this.totalDeVertices; j++)
                {
                    if (matrizAdj[i, j] == null)
                        this.matriz[i, j] = infinity;
                    else
                    {
                        if (distancia) this.matriz[i, j] = matrizAdj[i, j].Distancia;
                        else if (custo) this.matriz[i, j] = matrizAdj[i, j].Custo;
                        else if (tempo) this.matriz[i, j] = matrizAdj[i, j].Tempo;
                    }
                }

            trajeto = new DistOriginal[this.totalDeVertices];

            for (int i = 0; i < this.totalDeVertices; i++)
                this.vertices[i] = new Vertice(arvoreCidades.BuscarDado(new Cidade(i, "", null)));            
                
        }

        public Stack<int> Caminho(int inicioDoPercurso, int finalDoPercurso)
        {
            for (int j = 0; j < this.totalDeVertices; j++)
                vertices[j].foiVisitado = false;

            vertices[inicioDoPercurso].foiVisitado = true;
            for (int j = 0; j < this.totalDeVertices; j++)
            {
                // anotamos no vetor percurso a distância entre o inicioDoPercurso e cada vértice
                // se não há ligação direta, o valor da distância será infinity
                int tempDist = this.matriz[inicioDoPercurso, j];
                this.trajeto[j] = new DistOriginal(inicioDoPercurso, tempDist);
            }

            for (int nTree = 0; nTree < this.totalDeVertices; nTree++)
            {
                // Procuramos a saída não visitada do vértice inicioDoPercurso com a menor distância
                int indiceDoMenor = ObterMenor();
                // e anotamos essa menor distância
                int distanciaMinima = this.trajeto[indiceDoMenor].distancia;
                // o vértice com a menor distância passa a ser o vértice atual
                // para compararmos com a distância calculada em AjustarMenorCaminho()
                verticeAtual = indiceDoMenor;
                doInicioAteAtual = this.trajeto[indiceDoMenor].distancia;

                vertices[verticeAtual].foiVisitado = true;
                AjustarMenorCaminho();
            }
            return ExibirPercursos(inicioDoPercurso, finalDoPercurso);
        }

        public void AjustarMenorCaminho()
        {
            for (int coluna = 0; coluna < this.totalDeVertices; coluna++)
                if (!vertices[coluna].foiVisitado) // para cada vértice ainda não visitado
                {
                    // acessamos a distância desde o vértice atual (pode ser infinity)
                    int atualAteMargem = this.matriz[verticeAtual, coluna];
                    // calculamos a distância desde inicioDoPercurso passando por vertice atual até
                    // esta saída
                    int doInicioAteMargem = doInicioAteAtual + atualAteMargem;
                    // quando encontra uma distância menor, marca o vértice a partir do
                    // qual chegamos no vértice de índice coluna, e a soma da distância
                    // percorrida para nele chegar
                    int distanciaDoCaminho = this.trajeto[coluna].distancia;
                    if (doInicioAteMargem < distanciaDoCaminho)
                    {
                        this.trajeto[coluna].verticePai = verticeAtual;
                        this.trajeto[coluna].distancia = doInicioAteMargem;
                    }
                }
        }

        public int ObterMenor()
        {
            int distanciaMinima = infinity;
            int indiceDaMinima = 0;
            for (int j = 0; j < this.totalDeVertices; j++)
                if (!(vertices[j].foiVisitado) && (this.trajeto[j].distancia < distanciaMinima))
                {
                    distanciaMinima = this.trajeto[j].distancia;
                    indiceDaMinima = j;
                }
            return indiceDaMinima;
        }

        public Stack<int> ExibirPercursos(int inicioDoPercurso, int finalDoPercurso)
        {
            int onde = finalDoPercurso;
            Stack<int> pilha = new Stack<int>();          
            while (onde != inicioDoPercurso)
            {
                onde = this.trajeto[onde].verticePai;
                pilha.Push(vertices[onde].cidade.Id);            
            }
            return pilha;
        }
    }
}
