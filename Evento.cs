using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Evento_MELHORADO
{
    public class Evento
    {
        public string Nome { get; set; }

        public DateTime DataDoEvento { get; set; }

        public List<Convidados> Convidados { get; set; }

        public List<Convidados> Sorteio { get; set; }

        public double LucroEveto { get; set; }

        public int QtdMesa { get; set; }

        public int[] MesasDisponives { get; set; }

        public Evento()
        {
            Convidados = new List<Convidados>();
            Sorteio = new List<Convidados>();
        }
    }
}
