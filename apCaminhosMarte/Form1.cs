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
        
        List<List<Passo>> caminhos; // Lista com todos os caminhos
        List<Passo> melhorCaminho;  // Variável que armazena o melhor caminho

        int imgWidth = 4096, imgHeight = 2048; // variáveis responsáveis por amarzenar o tamanho do picture box
        
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // limpa os datagridview's
            dgvMelhorCaminho.Rows.Clear();
            dgvCaminhos.Rows.Clear();

            try
            {
                // busca todos os caminhos passando o índice (ID) das cidades selecionadas como parâmetro
                List<List<Passo>> caminhos = marte.AcharCaminhos(lsbOrigem.SelectedIndex, lsbDestino.SelectedIndex);

                List<Passo> menorCaminho = null;
                int menorDistancia = int.MaxValue;
                int maiorDistancia = int.MinValue;

                int i = 0;
               
                dgvCaminhos.RowCount = caminhos.Count();

                foreach (List<Passo> caminho in caminhos) // para cada caminho na lista de caminhos
                {
                    if(caminho.Count > maiorDistancia) // se o caminho atual for maior que o maior caminho
                    {
                        dgvCaminhos.ColumnCount = caminho.Count(); // troca-se o valor de colunas do datagridview, 
                        maiorDistancia = caminho.Count();          // para podermos usar todas suas colunas
                    }

                    int j = 0;
                    
                    foreach (Passo passo in caminho) // para cada passo realizado no caminho
                    {
                        dgvCaminhos.Rows[i].Cells[j].Value = $"{passo.Destino.Nome}"; // insere o destino do passo no datagridview
                        j++;
                    }

                    if (j < menorDistancia) // se o tamanho do caminho atual for menor que o do menorCaminho
                    {
                        menorCaminho = caminho; // troca-se a variável do menor caminho feito
                        menorDistancia = j;
                    }

                    i++;
                }

                // após exibir todos caminhos, exibe-se o melhor deles no dgvMelhor Caminho
                dgvMelhorCaminho.RowCount = 1;
                dgvMelhorCaminho.ColumnCount = menorCaminho.Count();
                i = 0;
                foreach (Passo passo in menorCaminho)
                    dgvMelhorCaminho.Rows[0].Cells[i++].Value = $"{passo.Destino.Nome}";


                // setamos as variáveis globais para salvar os caminhos
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
            marte.DesenharCidades(pbMapa, this.imgWidth, this.imgHeight);
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
            if(caminho != null)
            {
                Graphics g = pbMapa.CreateGraphics();
                Pen pen = new Pen(Color.Blue, 3);

                // variáveis que armazenam a proporção do mapa real para o exibido na tela
                int fX = this.imgWidth / pbMapa.Width;
                int fY = this.imgHeight / pbMapa.Height;

                foreach (Passo p in caminho)
                {
                    g.DrawLine(pen, new Point(p.Origem.Coord.X / fX, p.Origem.Coord.Y / fY), new Point(p.Destino.Coord.X / fX, p.Destino.Coord.Y / fY));
                }
                Application.DoEvents();
                marte.DesenharCidades(pbMapa, this.imgWidth, this.imgHeight);
            }           
        }

        private void pbArvore_Paint(object sender, PaintEventArgs e)
        {
            // ao exibir o picturebox da arvore, chamamos o método que a desenha
            marte.DesenharArvore(e.Graphics);
        }
    }
}
