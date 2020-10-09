using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCaminhosMarte
{
    class ArvoreCidades : ArvoreBinaria<Cidade>
    {
        public void DesenharCidades(PictureBox pb)
        {
            desenharCidadesRec(base.raiz, pb);
        }

        private void desenharCidadesRec(NoArvore<Cidade> atual, PictureBox pb)
        {
            if(atual != null)
            {
                SolidBrush preenchimento = new SolidBrush(Color.Red);
                int x = atual.Info.Coord.X / (4096/pb.Width);
                int y = atual.Info.Coord.Y / (2048 / pb.Height);

                Graphics g = pb.CreateGraphics();

                g.FillEllipse(preenchimento, x - 7, y - 7, 15, 15);
                g.DrawString(atual.Info.Nome, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(x + -4, y + 7));              
                desenharCidadesRec(atual.Esq, pb);
                desenharCidadesRec(atual.Dir, pb);
            }
        }

        public void DesenharArvore(Graphics g)
        {
            desenharArvoreRec(true, base.raiz, 660, 5, (Math.PI / 180) * 90, 1.20, 250, g);
        }

        private void desenharArvoreRec(bool primeiraVez, NoArvore<Cidade> raiz,
                                    int x, int y, double angulo, double incremento,
                                    double comprimento, Graphics g)
        {
            int xf, yf;
            if (raiz != null)
            {
                Pen caneta = new Pen(Color.Red);
                //g.DrawLine(caneta, new Point(10, 10), new Point(20, 20));*/
                xf = (int)Math.Round(x + Math.Cos(angulo) * comprimento);
                yf = (int)Math.Round(y + Math.Sin(angulo) * comprimento);
                double a = (180 * angulo) / Math.PI;
                if (a < 0)
                    a = 3;
                if (primeiraVez)
                    yf = 25;
                g.DrawLine(caneta, x, y, xf, yf);
                desenharArvoreRec(false, raiz.Esq, xf, yf, Math.PI / 2 + incremento,
                incremento * 0.60, comprimento * 0.8, g);
                desenharArvoreRec(false, raiz.Dir, xf, yf, Math.PI / 2 - incremento,
                incremento * 0.60, comprimento * 0.8, g);
                SolidBrush preenchimento = new SolidBrush(Color.Blue);
                g.FillEllipse(preenchimento, xf - 25, yf - 15, 42, 30);
                g.DrawString(Convert.ToString(raiz.Info.ToString()), new Font("Comic Sans", 10),
                new SolidBrush(Color.Yellow), xf - 23, yf - 7);
            }
        }

        public Cidade BuscarCidade(int id)
        {
            return base.BuscaDado(new Cidade(id, "", null));
        }
    }
}
