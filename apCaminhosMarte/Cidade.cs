// Gabriel Alves de Arruda 19170
// Nouani Gabriel Sanches 19194
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCaminhosMarte
{
    class Cidade : IComparable<Cidade>
    {
        private int id;
        private string nome;
        private int x, y;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Cidade(int id, string nome, int x, int y)
        {
            this.id = id;
            this.nome = nome;
            this.x = x;
            this.y = y;
        }

        public int CompareTo(Cidade other)
        {
            return this.id.CompareTo(other.id);
        }
    }
}
