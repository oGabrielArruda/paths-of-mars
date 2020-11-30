// Gabriel Alves de Arruda 19170
// Nouani Gabriel Sanches 19194
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCaminhosMarte
{
    class Marte
    {
        private ArvoreCidades arvoreCidades;
        private Passo[,] matrizAdjacencias;

        /**
         * Construtor da classe Marte
         * Recebe o path de um arquivo contendo as cidades como parâmetro
         * Responsável por insanciar a arvore binaria,
         * e por incluir os valores nela
         */
        public Marte(string nomeArqCidades, string nomeArqCaminhos)
        {
            arvoreCidades = new ArvoreCidades();

            int qtdCidades = 0;
            lerCidades(nomeArqCidades, ref qtdCidades);

            this.matrizAdjacencias = gerarMatriz(nomeArqCaminhos, qtdCidades);
        }

        private void lerCidades(string nomeArq, ref int qtdCidades)
        {
            StreamReader leitor = new StreamReader(nomeArq);
            while (!leitor.EndOfStream)
            {
                Cidade cidade = LerCidade(leitor.ReadLine());
                arvoreCidades.Incluir(cidade);
                qtdCidades++;
            }
        }
        private Cidade LerCidade(string linha)
        {
            int id = int.Parse(linha.Substring(0, 3));
            string nome = linha.Substring(3, 16);
            int x = int.Parse(linha.Substring(19, 5));
            int y = int.Parse(linha.Substring(24, 4));

            return new Cidade(id, nome, new Coordenada(x, y));
        }

        private Passo[,] gerarMatriz(string nomeArq, int qtdCidades)
        {
            Passo[,] matrizAdjacencias = new Passo[qtdCidades, qtdCidades];
            StreamReader leitorDeCaminhosCidades = new StreamReader(nomeArq);

            while (!leitorDeCaminhosCidades.EndOfStream)
            {
                string linha = leitorDeCaminhosCidades.ReadLine();
                int idOrigem = int.Parse(linha.Substring(0, 3));
                int idDestino = int.Parse(linha.Substring(3, 3));
                int distancia = int.Parse(linha.Substring(6, 5));
                int tempo = int.Parse(linha.Substring(11, 4));
                int custo = int.Parse(linha.Substring(15, 5));


                Passo c = new Passo(arvoreCidades.BuscarDado(new Cidade(idOrigem)), arvoreCidades.BuscarDado(new Cidade(idDestino)), distancia, tempo, custo);
                matrizAdjacencias[idOrigem, idDestino] = c;
            }

            return matrizAdjacencias;
        }

        public void DesenharCidades(PictureBox pb, int imgWidth, int imgHeight)
        {
            arvoreCidades.DesenharCidades(pb, imgWidth, imgHeight);
        }

        public void DesenharArvore(Graphics g)
        {
            arvoreCidades.DesenharArvore(g);
        }

        public List<List<Passo>> AcharCaminhos(int idOrigem, int idDestino, bool recursivo = false, bool pilha = false, bool dijkstra = false, bool distancia = false, bool custo = false, bool tempo = false)
        {
            Cidade origem = this.arvoreCidades.BuscarDado(new Cidade(idOrigem));
            Cidade destino = this.arvoreCidades.BuscarDado(new Cidade(idDestino));
            EncontradorDeCaminhos encontrador = new EncontradorDeCaminhos(arvoreCidades, this.matrizAdjacencias, origem, destino);
            return encontrador.EncontrarCaminhos(recursivo, pilha, dijkstra, distancia, custo, tempo);
        }
    }
}
