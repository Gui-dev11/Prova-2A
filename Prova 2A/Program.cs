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


            //cadastro cliente
            WriteLine("Cadastro cliente: ");
            WriteLine();
            Write("Nome completo: ");
            cliente.setNomeCompleto(ReadLine());

            Write("cpf: ");
            cliente.setCpf(ReadLine());

            Write("telefone: (ex: +55 69 1234-5678)");
            cliente.setTelefone(ReadLine());

            Write("data nascimento(dd/MM/yyyy):");
            cliente.setdataNascimento(DateTime.Parse(ReadLine()));

            WriteLine("Endereço cliente: ");
            Write("cidade: ");
            endereco.setCidade(ReadLine());
            Write("bairro: ");
            endereco.setBairro(ReadLine()); 
            Write("cep: ");
            endereco.setCep(ReadLine());
            Write("numero: ");
            endereco.setNumero(ReadLine()); 
            Write("logradouro: ");
            endereco.setLogradouro(ReadLine());

            cliente.setEndereco(endereco);


            //dados filme
            Clear();
            WriteLine("Cadastro filme: ");
            WriteLine();
            Write("Titulo: ");
            filme.setTitulo(ReadLine());

            Write("Genero: ");
            filme.setGenero(ReadLine());   

            Write("Ano de lançamento(ex: 2009): ");
            filme.setanoLancamento(int.Parse(ReadLine()));


            Write("Duração do filme: (somente numeros)");
            filme.setduracaoMinutos(int.Parse(ReadLine()));


            Write("Diretor do filme: ");
            filme.setDiretor(ReadLine());




            //dados locação
            Clear();
            WriteLine("Cadastro de locação: ");
            WriteLine();

            //dados locação Cliente
            WriteLine("Cliente: ");
            Write("Nome completo: ");
            cliente.setNomeCompleto(ReadLine());

            Write("cpf: ");
            cliente.setCpf(ReadLine());

            Write("telefone: (ex: +55 69 1234-5678)");
            cliente.setTelefone(ReadLine());

            Write("data nascimento(dd/MM/yyyy):");
            cliente.setdataNascimento(DateTime.Parse(ReadLine()));

            WriteLine("Endereço cliente: ");
            Write("cidade: ");
            endereco.setCidade(ReadLine());
            Write("bairro: ");
            endereco.setBairro(ReadLine());
            Write("cep: ");
            endereco.setCep(ReadLine());
            Write("numero: ");
            endereco.setNumero(ReadLine());
            Write("logradouro: ");
            endereco.setLogradouro(ReadLine());

            cliente.setEndereco(endereco);

            locacao.setClienteLocador(cliente);

            //dados locação Filme
            WriteLine("Filme: ");
            Write("Titulo: ");
            filme.setTitulo(ReadLine());

            Write("Genero: ");
            filme.setGenero(ReadLine());

            Write("Ano de lançamento: ");
            filme.setanoLancamento(int.Parse(ReadLine()));

            Write("Duração do filme: (somente numeros)");
            filme.setduracaoMinutos(int.Parse(ReadLine()));

            Write("Diretor do filme: ");
            filme.setDiretor(ReadLine());

            locacao.setFilmeAlugado(filme);


            //dados locação Data locação e devolução prevista e valor cobrado
            Clear();
            Write("Data de locação (ex: 12/02/2000): ");
            locacao.setDataLocacao(DateTime.Parse(ReadLine()));
            Write("Data de devolução prevista (ex: 12/02/2000): ");
            locacao.setDataLocacao(DateTime.Parse(ReadLine()));
            Write("Valor cobrado pela locação: (ex: 122.00) ");
            locacao.setValorCobrado(double.Parse(ReadLine()));
            



            Clear();
            WriteLine("Dados clinete: ");
            WriteLine($"Nome: {cliente.getNomeCompleto()}");
            WriteLine($"cpf: {cliente.getCpf()}");
            WriteLine($"Data nascimento: {cliente.getdataNascimento():dd/MM/yyyy}");
            WriteLine("Endereço: ");
            WriteLine($" - cidade: {cliente.getEndereco().getCidade()}");
            WriteLine($" - bairro: {cliente.getEndereco().getBairro()}");
            WriteLine($" - cep: {cliente.getEndereco().getCep()}");
            WriteLine($" - logradouro: {cliente.getEndereco().getLogradouro()}");
            WriteLine($" - numero: {cliente.getEndereco().getNumero()}");
            WriteLine();

            WriteLine("Dados filme: ");
            WriteLine($"Titulo: {filme.getTitulo()}");
            WriteLine($"Genero: {filme.getGenero()}");
            WriteLine($"Ano de lançamento: {filme.getanoLancamento()}");
            WriteLine($"Duração: {filme.getduracaoMinutos()}");
            WriteLine($"Diretor: {filme.getDiretor()}");
            WriteLine();

            WriteLine("Dados locação: ");
            WriteLine();
            Write("Cliente locador: ");
            WriteLine($"Nome: {locacao.getClienteLocador().getNomeCompleto()}");
            WriteLine($"cpf: {locacao.getClienteLocador().getCpf()}");
            WriteLine($"Data nascimento: {locacao.getClienteLocador().getdataNascimento():dd/MM/yyyy}");
            WriteLine("Endereço: ");
            WriteLine($" - cidade: {locacao.getClienteLocador().getEndereco().getCidade()}");
            WriteLine($" - bairro: {locacao.getClienteLocador().getEndereco().getBairro()}");
            WriteLine($" - cep: {locacao.getClienteLocador().getEndereco().getCep()}");
            WriteLine($" - logradouro: {locacao.getClienteLocador().getEndereco().getLogradouro()}");
            WriteLine($" - numero: {locacao.getClienteLocador().getEndereco().getNumero()}");
            WriteLine();
            WriteLine("Filme alugado: ");
            WriteLine($"Titulo: {locacao.getFilmeAlugado().getTitulo()}");
            WriteLine($"Genero: {locacao.getFilmeAlugado().getGenero()}");
            WriteLine($"Ano de lançamento: {locacao.getFilmeAlugado().getanoLancamento()}");
            WriteLine($"Duração: {locacao.getFilmeAlugado().getduracaoMinutos()}");
            WriteLine($"Diretor: {locacao.getFilmeAlugado().getDiretor()}");
            WriteLine();
            WriteLine("Data de locação: ");
            WriteLine($"- data: {locacao.getDataLocacao():dd/MM/yyyy}");
            WriteLine("Data de devolução prevista: ");
            WriteLine($"- data: {locacao.getDataDevolucaoPrevista():dd/MM/yyyy}");
            WriteLine("Valor cobrado: ");
            WriteLine($"- valor: {locacao.getValorCobrado():F2}");



        }
    }
}
