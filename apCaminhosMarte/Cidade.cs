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
        private Coordenada coord;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public Coordenada Coord { get => coord; set => coord = value; }

        public Cidade(int id)
        {
            this.id = id;
        }
        public Cidade(int id, string nome, Coordenada coord)
        {
            this.id = id;
            this.nome = nome;
            this.Coord = coord;
        }

        public int CompareTo(Cidade other)
        {
            return this.id.CompareTo(other.id);
        }

        public override string ToString()
        {
            return  Id + ": " + Nome;
        }
    }
}
