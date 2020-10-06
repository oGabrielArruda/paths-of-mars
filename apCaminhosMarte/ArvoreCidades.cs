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
                SolidBrush preenchimento = new SolidBrush(Color.Blue);
                g.FillEllipse(preenchimento, atual.Info.Coord.X/4, atual.Info.Coord.Y/4, 10, 10);

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
