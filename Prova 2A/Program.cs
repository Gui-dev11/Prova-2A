using static System.Console;
namespace Prova_2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Locacao locacao = new Locacao();
            Filme filme = new Filme();
            Cliente cliente = new Cliente();
            Endereco endereco = new Endereco();

            // cadastro cliente
            WriteLine("Cadastro cliente:");
            WriteLine();
            Write("Nome completo: ");
            cliente.setNomeCompleto(ReadLine());

            Write("CPF: ");
            cliente.setCpf(ReadLine());

            Write("Telefone (ex: +55 69 1234-5678): ");
            cliente.setTelefone(ReadLine());

            Write("Data de nascimento (dd/MM/yyyy): ");
            cliente.setdataNascimento(DateTime.Parse(ReadLine()));

            WriteLine("Endereço cliente:");
            Write("Cidade: ");
            endereco.setCidade(ReadLine());
            Write("Bairro: ");
            endereco.setBairro(ReadLine());
            Write("CEP: ");
            endereco.setCep(ReadLine());
            Write("Número: ");
            endereco.setNumero(ReadLine());
            Write("Logradouro: ");
            endereco.setLogradouro(ReadLine());

            cliente.setEndereco(endereco);

            // dados filme
            Clear();
            WriteLine("Cadastro filme:");
            WriteLine();
            Write("Título: ");
            filme.setTitulo(ReadLine());

            Write("Gênero: ");
            filme.setGenero(ReadLine());

            Write("Ano de lançamento (ex: 2009): ");
            filme.setanoLancamento(int.Parse(ReadLine()));

            Write("Duração do filme (somente números): ");
            filme.setduracaoMinutos(int.Parse(ReadLine()));

            Write("Diretor do filme: ");
            filme.setDiretor(ReadLine());


            // usa os objetos já preenchidos
            //locacao.setClienteLocador(cliente);
            //locacao.setFilmeAlugado(filme);


            Clear();
            // dados locação
            WriteLine("Cadastro de locação: ");
            WriteLine();

            //dados locação Cliente
            WriteLine("Cliente: ");
            Write("Nome completo: ");
            cliente.setNomeCompleto(ReadLine());

            Write("CPF: ");
            cliente.setCpf(ReadLine());

            Write("Telefone (ex: +55 69 1234-5678): ");
            cliente.setTelefone(ReadLine());

            Write("Data de nascimento (dd/MM/yyyy): ");
            cliente.setdataNascimento(DateTime.Parse(ReadLine()));

            WriteLine("Endereço cliente:");
            Write("Cidade: ");
            endereco.setCidade(ReadLine());
            Write("Bairro: ");
            endereco.setBairro(ReadLine());
            Write("CEP: ");
            endereco.setCep(ReadLine());
            Write("Número: ");
            endereco.setNumero(ReadLine());
            Write("Logradouro: ");
            endereco.setLogradouro(ReadLine());
            cliente.setEndereco(endereco);

            //dados locação Filme
            Clear();
            WriteLine("Cadastro de locação: ");
            WriteLine();
            WriteLine("Filme: ");
            Write("Título: ");
            filme.setTitulo(ReadLine());

            Write("Gênero: ");
            filme.setGenero(ReadLine());

            Write("Ano de lançamento (ex: 2009): ");
            filme.setanoLancamento(int.Parse(ReadLine()));

            Write("Duração do filme (somente números): ");
            filme.setduracaoMinutos(int.Parse(ReadLine()));

            Write("Diretor do filme: ");
            filme.setDiretor(ReadLine());

            locacao.setFilmeAlugado(filme);
            locacao.setClienteLocador(cliente);


            //dados locação Data locação e devolução prevista e valor cobrado
            Clear();
            Write("Data de locação (ex: 12/02/2000): ");
            locacao.setDataLocacao(DateTime.Parse(ReadLine()));
            Write("Data de devolução prevista (ex: 12/02/2000): ");
            locacao.setDataDevolucaoPrevista(DateTime.Parse(ReadLine()));
            Write("Valor cobrado pela locação (ex: 122): ");
            locacao.setValorCobrado(double.Parse(ReadLine()));

            // exibição
            Clear();
            WriteLine("Dados cliente:");
            WriteLine();
            WriteLine($"Nome: {cliente.getNomeCompleto()}");
            WriteLine($"CPF: {cliente.getCpf()}");
            WriteLine($"Data de nascimento: {cliente.getdataNascimento():dd/MM/yyyy}");
            WriteLine();
            WriteLine("Endereço:");
            WriteLine($" - Cidade: {cliente.getEndereco().getCidade()}");
            WriteLine($" - Bairro: {cliente.getEndereco().getBairro()}");
            WriteLine($" - CEP: {cliente.getEndereco().getCep()}");
            WriteLine($" - Logradouro: {cliente.getEndereco().getLogradouro()}");
            WriteLine($" - Número: {cliente.getEndereco().getNumero()}");
            WriteLine("-------------------------------------------");

            WriteLine("Dados filme:");
            WriteLine();
            WriteLine($"Título: {filme.getTitulo()}");
            WriteLine($"Gênero: {filme.getGenero()}");
            WriteLine($"Ano de lançamento: {filme.getanoLancamento()}");
            WriteLine($"Duração: {filme.getduracaoMinutos()} min");
            WriteLine($"Diretor: {filme.getDiretor()}");
            WriteLine("-------------------------------------------");

            WriteLine("Dados locação:");
            WriteLine();
            WriteLine("Cliente locador:");
            WriteLine($"Nome: {locacao.getClienteLocador().getNomeCompleto()}");
            WriteLine($"CPF: {locacao.getClienteLocador().getCpf()}");
            WriteLine($"Data de nascimento: {locacao.getClienteLocador().getdataNascimento():dd/MM/yyyy}");
            WriteLine();
            WriteLine("Endereço:");
            WriteLine($" - Cidade: {locacao.getClienteLocador().getEndereco().getCidade()}");
            WriteLine($" - Bairro: {locacao.getClienteLocador().getEndereco().getBairro()}");
            WriteLine($" - CEP: {locacao.getClienteLocador().getEndereco().getCep()}");
            WriteLine($" - Logradouro: {locacao.getClienteLocador().getEndereco().getLogradouro()}");
            WriteLine($" - Número: {locacao.getClienteLocador().getEndereco().getNumero()}");
            WriteLine();
            WriteLine("Filme alugado:");
            WriteLine($"Título: {locacao.getFilmeAlugado().getTitulo()}");
            WriteLine($"Gênero: {locacao.getFilmeAlugado().getGenero()}");
            WriteLine($"Ano de lançamento: {locacao.getFilmeAlugado().getanoLancamento()}");
            WriteLine($"Duração: {locacao.getFilmeAlugado().getduracaoMinutos()} min");
            WriteLine($"Diretor: {locacao.getFilmeAlugado().getDiretor()}");
            WriteLine("-------------------------------------------");
            WriteLine();
            WriteLine("Data de locação:");
            WriteLine();
            WriteLine($" - Data: {locacao.getDataLocacao():dd/MM/yyyy}");
            WriteLine();
            WriteLine("Data de devolução prevista:");
            WriteLine();
            WriteLine($" - Data: {locacao.getDataDevolucaoPrevista():dd/MM/yyyy}");
            WriteLine();
            WriteLine("Valor cobrado:");
            WriteLine();
            WriteLine($" - Valor: R$ {locacao.getValorCobrado():F2}");
        }
    }
}
