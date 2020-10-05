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
            desenharCidadesRec(base.raiz, Graphics.FromImage(pb.Image));
        }

        private void desenharCidadesRec(NoArvore<Cidade> atual, Graphics g)
        {
            if(atual != null)
            {
                /*Point pontoCidade = new Point(atual.Info.X, atual.Info.Y); // instancia um novo ponto
                Pen p = new Pen(Color.Black);                              // seta a cor da caneta como preta
                g.DrawLine(p, pontoCidade, pontoCidade);                   // desenha o ponto */

                SolidBrush preenchimento = new SolidBrush(Color.Blue);
                g.FillEllipse(preenchimento, atual.Info.X/4, atual.Info.Y/4, 10, 10);

                desenharCidadesRec(atual.Esq, g);
                desenharCidadesRec(atual.Dir, g);
            }
        }
    }
}
