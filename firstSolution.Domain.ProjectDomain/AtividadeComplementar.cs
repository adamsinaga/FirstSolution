using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSolution.Domain.ProjectDomain
{
    public class AtividadeComplementar
    {
        public int AtividadeComplementarID { get; set; }

        public DateTime Data { get; set; }

        public Pessoa Aluno { get; set; }

        public TipoAtividade Tipo { get; set; }

        public string Instituicao { get; set; }

        public int AnoFormacao { get; set; }


        

    }
}
