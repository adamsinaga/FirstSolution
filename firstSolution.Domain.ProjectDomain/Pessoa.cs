namespace firstSolution.Domain.ProjectDomain
{
    public class Pessoa
    {
        public int PessoaId { get; set; } //propiedade PessoaId
        public String Nome { get; set; } //propriedade nome

        public DateTime DataNascimento { get; set; }

        public class PessoaRepository
        {
            private List<Pessoa> pessoas = new List<Pessoa>();

            public void Adicionar(Pessoa pessoa)
            {
                pessoas.Add(pessoa);
            }

            public void Remover(Pessoa pessoa)
            {
                pessoas.Remove(pessoa);
            }

            public List<Pessoa> BuscarPorNome(string nome)
            {
                return pessoas.Where(p => p.Nome == nome).ToList();
            }

            public void Atualizar(Pessoa pessoa)
            {
                int index = pessoas.FindIndex(p => p.PessoaId == pessoa.PessoaId);
                if (index != -1)
                {
                    pessoas[index] = pessoa;
                }
            }
        }

    }