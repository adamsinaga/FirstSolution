using firstSolution.Domain.ProjectDomain;


/*

//alimentação de objeto tipos de atividades
var tipoAtividade= new TipoAtividade();
System.Console.WriteLine("Digite as infor de tipo de atividade: ");
System.Console.WriteLine("id:1");
tipoAtividade.TipoAtividadeID = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Descrição: ");
tipoAtividade.Descricao = System.Console.ReadLine();

//alimentação de objeto para atividade complementar
var atividadeComplementar = new AtividadeComplementar();
atividadeComplementar.Aluno = pessoa;
atividadeComplementar.Tipo = tipoAtividade;
System.Console.WriteLine("Digite as infor da atividade complementar: ");
System.Console.WriteLine("id: #1");
tipoAtividade.TipoAtividadeID = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Descricao");
tipoAtividade.Descricao = System.Console.ReadLine();

 */

//implementar e trazer em Lista
Console.WriteLine("Menu Pessoas: (1) Lista de pessoas (2) Inclui pessoas (3) Exclui pessoas (9) Sair ");

int op = Int32.Parse(System.Console.ReadLine());

while (op != 9)
{
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine($"Lista de pessoas:");
            break;

        case "2":
            Console.WriteLine($"incluir pessoas:");
            //alimentação do objeto pessoa
            var pessoa = new Pessoa(); //tipos anonimos
            Console.WriteLine("Digite as informações da pessoa");
            Console.WriteLine("id :");
            pessoa.PessoaId = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Nome: ");
            pessoa.Nome = System.Console.ReadLine();
            System.Console.WriteLine("Data de nascimento: dd/mm/ano");
            pessoa.DataNascimento = DateTime.Parse(System.Console.ReadLine());
            break;

        case "3":
            Console.WriteLine($"Excluir pessoas:");
            break;

        case "9":
            Console.Clear(); //limpar tela
            Console.WriteLine($"Sai"); //ok
            break;

        default: Console.WriteLine("valor invalido");
            break;
    }
}