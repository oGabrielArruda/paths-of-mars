// Gabriel Alves de Arruda 19170
// Nouani Gabriel Sanches 19194
using System;
using System.Collections.Generic;
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
        private Cidade[,] matrizDeAdjacencia;

        /**
         * Construtor da classe Marte
         * Recebe o path de um arquivo contendo as cidades como parâmetro
         * Responsável por insanciar a arvore binaria,
         * e por incluir os valores nela
         */
        public Marte(string nomeArq)
        {
            arvoreCidades = new ArvoreCidades();
            matrizDeAdjacencia = new Cidade[2048, 4096];

            StreamReader leitor = new StreamReader(nomeArq);
            while (!leitor.EndOfStream)
            {
                Cidade cidade = lerCidade(leitor.ReadLine());
                arvoreCidades.Incluir(cidade);
                matrizDeAdjacencia[cidade.Y, cidade.X] = cidade;
            }
        }

        private Cidade lerCidade(string linha)
        {
            int id = int.Parse(linha.Substring(0, 3));
            string nome = linha.Substring(3, 16);
            int x = int.Parse(linha.Substring(19, 5));
            int y = int.Parse(linha.Substring(24, 4));

            return new Cidade(id, nome, x, y);
        }

        public void DesenharCidades(PictureBox pb)
        {
            arvoreCidades.DesenharCidades(pb);
        }

    }
}
