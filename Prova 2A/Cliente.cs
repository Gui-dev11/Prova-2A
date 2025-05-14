using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_2A
{
    public class Cliente
    {
        private string nomeCompleto, cpf, telefone;
        private DateTime dataNascimento;
        private Endereco endereco;

        public Cliente()
        {

        }

        public Cliente(string nomeCompleto, string cpf, string telefone, DateTime dataNascimento, Endereco endereco)
        {
            this.nomeCompleto = nomeCompleto;
            this.cpf = cpf;
            this.telefone = telefone;
            this.dataNascimento = dataNascimento;
            this.endereco = endereco;
        }

        public string getNomeCompleto() => this.nomeCompleto;
        public void setNomeCompleto(string nomeCompleto) => this.nomeCompleto = nomeCompleto;

        public string getCpf() => this.cpf;
        public void setCpf(string cpf) => this.cpf = cpf;

        public string getTelefone() => this.telefone;
        public void setTelefone(string telefone)=> this.telefone = telefone;

        public DateTime getdataNascimento() => this.dataNascimento;
        public void setdataNascimento(DateTime dataNascimento) => this.dataNascimento = dataNascimento;

        public Endereco getEndereco() => this.endereco;
        public void setEndereco(Endereco endereco)=> this.endereco = endereco;


    }
}
