namespace FirstSolution.UserInterface.Console.ConsoleApp
{
    class Program
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
        private static List<TipoAtividade> tiposAtividades = new List<TipoAtividade>();
        private static List<AtividadeComplementar> atividadesComplementares = new List<AtividadeComplementar>();

        public static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("\n 1-Cadastrar Aluno \r\n 2-Cadastrar Tipo de Atividade \r\n 3-Cadastrar Atividade Complementar \r\n 7-Excluir Aluno \r\n 8-Excluir Tipo de Atividade \r\n 9-Excluir Atividade Complementar \r\n 10-Listar \r\n 11-Sair");
                int op = Int32.Parse(System.Console.ReadLine());

                switch (op)
                {
                    case 1:
                        //CADASTRAR ALUNO
                        System.Console.WriteLine("Digite o ID do aluno:");
                        int pessoaID = Int32.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Digite o nome do aluno:");
                        string nome = System.Console.ReadLine();
                        System.Console.WriteLine("Digite a data de nascimento do aluno:");
                        DateTime dataNascimento = DateTime.Parse(System.Console.ReadLine());
                        Pessoa p = new Pessoa(pessoaID, nome, dataNascimento);

                        pessoas.Add(p);

                        break;

                    case 2:
                        //CADASTRAR TIPO ATIVIDADE
                        System.Console.WriteLine("Digite o ID do Tipo de Atividade: ");
                        int tipoAtividadeID = Int32.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Digite o Tipo de Atividade: ");
                        string descricao = System.Console.ReadLine();

                        TipoAtividade ta = new TipoAtividade(tipoAtividadeID, descricao);

                        tiposAtividades.Add(ta);

                        break;

                    case 3:
                        //CADASTRAR ATIVIDADE COMPLEMENTAR
                        System.Console.WriteLine("Digite o ID da Atividade Complementar: ");
                        int atividadeComplementarID = Int32.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Digite a data da Atividade: ");
                        DateTime data = DateTime.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("ID do tipo de Atividade: ");
                        int id = Int32.Parse(System.Console.ReadLine());
                        var tipo = tiposAtividades.Where(y => y.tipoAtividadeId == id).SingleOrDefault();
                        System.Console.WriteLine("ID do Aluno: ");
                        int idAluno = Int32.Parse(System.Console.ReadLine());
                        var aluno = pessoas.Where(x => x.pessoaID == idAluno).SingleOrDefault();
                        System.Console.WriteLine("Qual instituição? ");
                        string instituicao = System.Console.ReadLine();
                        System.Console.WriteLine("Qual o ano de formação? ");
                        int anoFormacao = Int32.Parse(System.Console.ReadLine());

                        AtividadeComplementar ac = new AtividadeComplementar(atividadeComplementarID, data, aluno, tipo, instituicao, anoFormacao);

                        atividadesComplementares.Add(ac);

                        break;

                    case 4:

                        // alteração aluno
                        System.Console.WriteLine("Digite o ID do aluno a alterar:");
                        int idAlterar = Int32.Parse(System.Console.ReadLine());

                        var filtrado = pessoas.Where(x => x.pessoaID == idAlterar);


                        var alunoAlterar = GetPessoa(idAlterar);
                        if (alunoAlterar == null) continue;


                        System.Console.WriteLine("digite o novo nome:");
                        string novoNome = System.Console.ReadLine();
                        System.Console.WriteLine("digite o novo ano de nascimento:");
                        DateTime novaData = DateTime.Parse(System.Console.ReadLine());
                        alunoAlterar.dataNascimento = novaData;
                        alunoAlterar.nome = novoNome;

                        break;

                    case 5:
                        // alteração TA
                        System.Console.WriteLine("digite o id da atividade a alterar");
                        int idAtividadeAlterar = Int32.Parse(System.Console.ReadLine());
                        var atividadeAlterar = GetTipoAtividade(idAtividadeAlterar);
                        if (atividadeAlterar == null) continue;
                        System.Console.WriteLine("digite a nova descricao:");
                        string novaDescricao = System.Console.ReadLine();
                        atividadeAlterar.descricao = novaDescricao;


                        break;

                    case 6:
                        // alteração AC
                        System.Console.WriteLine("digite o id da atividade complementar a alterar");
                        int idAtividadeComplementarAlterar = Int32.Parse(System.Console.ReadLine());
                        var atividadeComplementarAlterar = GetAtividadeComplementar(idAtividadeComplementarAlterar);
                        if (atividadeComplementarAlterar == null) continue;
                        System.Console.WriteLine("digite a");


                        break;

                    case 7:
                        // exclusão Aluno
                        System.Console.WriteLine("digite o id do aluno a ser excluido:");
                        int idAlunoExcluir = Int32.Parse(System.Console.ReadLine());
                        var alunoExcluir = GetPessoa(idAlunoExcluir);
                        pessoas.Remove(alunoExcluir);

                        break;

                    case 8:
                        // exclusão TA
                        System.Console.WriteLine("digite o id da atividade a ser excluida");
                        int idAtividadeExcluir = Int32.Parse(System.Console.ReadLine());
                        var atividadeExcluir = GetTipoAtividade(idAtividadeExcluir);
                        tiposAtividades.Remove(atividadeExcluir);

                        break;

                    case 9:
                        // exclusão AC
                        System.Console.WriteLine("Digite o ID da Atividade Complementar que quer excluir:");
                        int idExcluir = Int32.Parse(System.Console.ReadLine());

                        break;

                    case 10:
                        //Listar os Alunos

                        System.Console.WriteLine(" \r\nAlunos:");
                        foreach (Pessoa a in pessoas)
                        {
                            System.Console.WriteLine(a.pessoaID + " - " + a.nome + " - dtnasc.: " + a.dataNascimento);
                        }


                        System.Console.WriteLine("\r\nTipos de Atividade:");
                        foreach (TipoAtividade a in tiposAtividades)
                        {
                            System.Console.WriteLine(a.tipoAtividadeId + " - " + a.descricao);
                        }


                        System.Console.WriteLine("\r\nAtividades Complementares:");
                        foreach (AtividadeComplementar a in atividadesComplementares)
                        {
                            System.Console.WriteLine(a.atividadeComplementarID
                                                     + " - "
                                                     + a.aluno.nome
                                                     + " - dt: "
                                                     + a.data
                                                     + " - "
                                                     + a.tipo.descricao
                                                     + " - "
                                                     + a.instituicao
                                                     + " - dt Formação: "
                                                     + a.anoFormacao);
                        }
                        System.Console.ReadKey();

                        break;

                    case 11:
                        //SAIR
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private static Pessoa GetPessoa(int pessoaId)
        {
            var pessoa = pessoas.Where(x => x.pessoaID == pessoaId).First();
            return pessoa;
        }

        private static TipoAtividade GetTipoAtividade(int tipoAtividadeId)
        {
            var atividade = tiposAtividades.Where(x => x.tipoAtividadeId == tipoAtividadeId).First();
            return atividade;

        }

        private static AtividadeComplementar GetAtividadeComplementar(int AtividadeComplementarId)
        {
            var complemento = atividadesComplementares.Where(x => x.atividadeComplementarID == AtividadeComplementarId).First();
            return complemento;
        }
    }

    internal class AtividadeComplementar
    {
        internal readonly string instituicao;
        internal int atividadeComplementarID;
        internal Pessoa aluno;
        internal string data;
        internal TipoAtividade tipo;

        public AtividadeComplementar(int atividadeComplementarID, DateTime data, Pessoa? aluno, TipoAtividade? tipo, string? instituicao, int anoFormacao)
        {
        }

        public string anoFormacao { get; internal set; }
    }

    internal class TipoAtividade
    {
        internal int tipoAtividadeId;
        internal string? descricao;

        public TipoAtividade(int tipoAtividadeID, string? descricao)
        {
        }
    }

    internal class Pessoa
    {
        internal int pessoaID;
        internal DateTime dataNascimento;
        internal string? nome;

        public Pessoa(int pessoaID, string? nome, DateTime dataNascimento)
        {
        }
    }
}