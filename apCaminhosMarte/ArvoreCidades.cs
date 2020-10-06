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
        public void DesenharCidades(Graphics g)
        {
            desenharCidadesRec(base.raiz, g);
        }

        private void desenharCidadesRec(NoArvore<Cidade> atual, Graphics g)
        {
            if(atual != null)
            {
                SolidBrush preenchimento = new SolidBrush(Color.Red);
                int x = atual.Info.Coord.X / 4;
                int y = atual.Info.Coord.Y / 4;
                g.FillEllipse(preenchimento, x - 7, y - 7, 15, 15);
                g.DrawString(atual.Info.Nome, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(x + -4, y + 7));              
                desenharCidadesRec(atual.Esq, g);
                desenharCidadesRec(atual.Dir, g);
            }
        }

        public Cidade BuscarCidade(int id)
        {
            return base.BuscaDado(new Cidade(id, "", null));
        }
    }
}
