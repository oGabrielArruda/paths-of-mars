// Gabriel Alves de Arruda 19170
// Nouani Gabriel Sanches 19194

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCaminhosMarte
{
    /**
     * Classe que herda da Arvore de Busca Genérica.
     * Ela foi feita com o intuíto de acessar os dados da árvore para podermos desenha-la,
     * sem afetar o conceito de classe genérica na árvore de busca.
     */
    class ArvoreCidades : ArvoreBinaria<Cidade>
    {
        /**
         * Método que chama o método recursivo, responsável por desenhar as cidades
         */
        public void DesenharCidades(PictureBox pb, int imgWidht, int imgHeight)
        {
            desenharCidadesRec(base.raiz, pb, imgWidht, imgHeight);
        }


        /**
         * Método que desenha as cidades no picturebox recebido (mapa)
         */
        private void desenharCidadesRec(NoArvore<Cidade> atual, PictureBox pb, int imgWidth, int imgHeight)
        {
            if(atual != null)
            {
                SolidBrush preenchimento = new SolidBrush(Color.Red);
                int x = atual.Info.Coord.X / (imgWidth/pb.Width);
                int y = atual.Info.Coord.Y / (imgHeight / pb.Height);

                Graphics g = pb.CreateGraphics();

                g.FillEllipse(preenchimento, x - 7, y - 7, 15, 15);
                g.DrawString(atual.Info.Nome, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(x + -4, y + 7));              
                desenharCidadesRec(atual.Esq, pb, imgWidth, imgHeight);
                desenharCidadesRec(atual.Dir, pb, imgWidth, imgHeight);
            }
        }

        /**
         * Método que chama a função recursiva responsável por desenhar a árvore
         */
        public void DesenharArvore(Graphics g)
        {
            desenharArvoreRec(true, base.raiz, 660, 5, (Math.PI / 180) * 90, 1.4, 400, g);
        }

        /**
         * Método recursivo responsável por desenhar a árvore
         */
        private void desenharArvoreRec(bool primeiraVez, NoArvore<Cidade> raiz,
                                    int x, int y, double angulo, double incremento,
                                    double comprimento, Graphics g)
        {
            int xf, yf;
            if (raiz != null)
            {
                Pen caneta = new Pen(Color.Red);
                xf = (int)Math.Round(x + Math.Cos(angulo) * comprimento);
                yf = (int)Math.Round(y + Math.Sin(angulo) * comprimento);
                if (primeiraVez)
                    yf = 25;
                g.DrawLine(caneta, x, y, xf, yf);
                desenharArvoreRec(false, raiz.Esq, xf, yf, Math.PI / 2 + incremento,
                incremento * 0.6, comprimento * 0.7, g);
                desenharArvoreRec(false, raiz.Dir, xf, yf, Math.PI / 2 - incremento,
                incremento * 0.6, comprimento * 0.7, g);
                SolidBrush preenchimento = new SolidBrush(Color.LightGreen);
                g.FillEllipse(preenchimento, xf - 25, yf - 15, 100, 30);
                g.DrawString(Convert.ToString(raiz.Info.ToString()), new Font("Comic Sans", 10, FontStyle.Bold),
                new SolidBrush(Color.Black), xf - 23, yf - 7);
            }
        }

        /**
         * Método que busca a cidade pelo id passado,
         * chamando o método busca dado na classe pai
         */
        public Cidade BuscarCidade(int id)
        {
            return base.BuscaDado(new Cidade(id, "", null));
        }
    }
}
