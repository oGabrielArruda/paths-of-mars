// Gabriel Alves de Arruda 19170
// Nouani Gabriel Sanches 19194
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCaminhosMarte
{
    public partial class Form1 : Form
    {
        Marte marte;
        public Form1()
        {
            InitializeComponent();
        }

        List<List<Passo>> caminhos;
        List<Passo> melhorCaminho;

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dgvMelhorCaminho.Rows.Clear();
            dgvCaminhos.Rows.Clear();
            try
            {
                List<List<Passo>> caminhos = marte.AcharCaminhos(lsbOrigem.SelectedIndex, lsbDestino.SelectedIndex);

                List<Passo> menorCaminho = null;
                int menorDistancia = int.MaxValue;
                int maiorDistancia = int.MinValue;

                int i = 0;
               
                dgvCaminhos.RowCount = caminhos.Count();
                foreach (List<Passo> caminho in caminhos)
                {
                    if(caminho.Count > maiorDistancia)
                    {
                        dgvCaminhos.ColumnCount = caminho.Count();
                        maiorDistancia = caminho.Count();
                    }

                    int j = 0;
                    
                    foreach (Passo passo in caminho)
                    {
                        dgvCaminhos.Rows[i].Cells[j].Value = $"{passo.Destino.Nome}";
                        j++;
                    }

                    if (j < menorDistancia)
                    {
                        menorCaminho = caminho;
                        menorDistancia = j;
                    }

                    i++;
                }

                dgvMelhorCaminho.RowCount = 1;
                dgvMelhorCaminho.ColumnCount = menorCaminho.Count();
                i = 0;
                foreach (Passo passo in menorCaminho)
                    dgvMelhorCaminho.Rows[0].Cells[i++].Value = $"{passo.Destino.Nome}";

                this.caminhos = caminhos;
                this.melhorCaminho = menorCaminho;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            marte = new Marte("CidadesMarte.txt", "CaminhosEntreCidadesMarte.txt");
            pbMapa.Image = Image.FromFile("mars_political_map_by_axiaterraartunion_d4vfxdf-pre.jpg");
            Application.DoEvents();
            marte.DesenharCidades(pbMapa);
        }

        private void dgvCaminhos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbMapa.Image = Image.FromFile("mars_political_map_by_axiaterraartunion_d4vfxdf-pre.jpg");
            Application.DoEvents();
            desenharCaminho(this.caminhos[dgvCaminhos.CurrentCell.RowIndex]);
        }

        private void dgvMelhorCaminho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbMapa.Image = Image.FromFile("mars_political_map_by_axiaterraartunion_d4vfxdf-pre.jpg");
            Application.DoEvents();
            desenharCaminho(this.melhorCaminho);
        }

        private void desenharCaminho(List<Passo> caminho)
        {
            Graphics g = pbMapa.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 3);
            int fX = 4096 / pbMapa.Width;
            int fY = 2048 / pbMapa.Height;
            foreach (Passo p in caminho)
            {
                g.DrawLine(pen, new Point(p.Origem.Coord.X / fX, p.Origem.Coord.Y / fY), new Point(p.Destino.Coord.X / fX, p.Destino.Coord.Y / fY));
            }
            Application.DoEvents();
            marte.DesenharCidades(pbMapa);
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            /*if (tbMarte.SelectedIndex == 1)
            {
                marte.DesenharArvore(pbArvore);
                Application.DoEvents();
            }*/
        }

        private void pbArvore_Paint(object sender, PaintEventArgs e)
        {
            marte.DesenharArvore(e.Graphics);
        }
    }
}
