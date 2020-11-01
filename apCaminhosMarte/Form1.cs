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
            // limpa o mapa
            pbMapa.Image = Image.FromFile("mars_political_map_by_axiaterraartunion_d4vfxdf-pre.jpg");
            Application.DoEvents();
            marte.DesenharCidades(pbMapa, this.imgWidth, this.imgHeight);

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

                    // 'for' para ajustar as colunas do datagridview
                    if(caminho.Count > maiorDistancia) 
                    {
                        dgvCaminhos.ColumnCount = caminho.Count(); 
                        maiorDistancia = caminho.Count();          
                    }


                    // preenche as colunas do caminho, salvando a distancia pecorrida
                    int j = 0;
                    int distanciaTotal = 0;
                    foreach (Passo passo in caminho) 
                    {
                        dgvCaminhos.Rows[i].Cells[j].Value = $"{passo.Destino.Nome}"; 
                        j++;
                        distanciaTotal += passo.Distancia;
                    }


                    // verifica se o caminho atual é menor que os já feitos
                    if (distanciaTotal < menorDistancia) 
                    {
                        menorCaminho = caminho; 
                        menorDistancia = distanciaTotal;                       
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
                int distancia = 0;
                int custo = 0;
                int tempo = 0;

                Graphics g = pbMapa.CreateGraphics();
                Pen pen = new Pen(Color.Blue, 3);

                // variáveis que armazenam a proporção do mapa real para o exibido na tela
                int fX = this.imgWidth / pbMapa.Width;
                int fY = this.imgHeight / pbMapa.Height;

                foreach (Passo p in caminho)
                {
                    g.DrawLine(pen, new Point(p.Origem.Coord.X / fX, p.Origem.Coord.Y / fY), new Point(p.Destino.Coord.X / fX, p.Destino.Coord.Y / fY));
                    distancia += p.Distancia;
                    custo += p.Custo;
                    tempo += p.Tempo;
                }
                Application.DoEvents();
                marte.DesenharCidades(pbMapa, this.imgWidth, this.imgHeight);

                MessageBox.Show($"Distância: {distancia} \nTempo: {tempo} \nCusto: {custo}");
            }           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbArvore_Paint(object sender, PaintEventArgs e)
        {
            // ao exibir o picturebox da arvore, chamamos o método que a desenha
            marte.DesenharArvore(e.Graphics);
        }
    }
}
