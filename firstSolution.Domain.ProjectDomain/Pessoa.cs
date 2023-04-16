using System.Runtime.Intrinsics.X86;

namespace firstSolution.Domain.ProjectDomain
{
    public class Pessoa 
    {
        public int PessoaId { get; set; } //propiedade PessoaId
        public String Nome { get; set; } //propriedade nome

        public DateTime DataNascimento { get; set; }

        public class PessoaRepository //gerenciar uma lista de objetos "Pessoa".
        {
            //cria uma lista vazia de pessoas
            private List<Pessoa> pessoas = new List<Pessoa>(); 

            public void Adicionar(Pessoa pessoa)
            {
                // Adiciona um objeto "Pessoa" à lista.
                pessoas.Add(pessoa); 
            }

            public void Remover(Pessoa pessoa)
            {
                // Remove um objeto "Pessoa" da lista.
                pessoas.Remove(pessoa);  
            }

            public List<Pessoa> BuscarPorNome(string nome)
            {
                // Retorna uma lista de objetos "Pessoa" que têm um nome correspondente ao parâmetro de entrada.
                return pessoas.Where(p => p.Nome == nome).ToList(); 

            }

            public void Atualizar(Pessoa pessoa)
            {
                // Atualiza um objeto "Pessoa" existente na lista com as informações do objeto "Pessoa" passado como parâmetro
                int index = pessoas.FindIndex(p => p.PessoaId == pessoa.PessoaId); 
                if (index != -1)
                {
                    pessoas[index] = pessoa;
                }
            }
        }

    }
}