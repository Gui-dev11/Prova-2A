using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_2A
{
    public class Endereco
    {
        private string logradouro, numero, bairro, cidade, cep;

        public Endereco()
        {

        }

        public Endereco(string logradouro, string numero, string bairro, string cidade, string cep)
        {
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.cep = cep;
        }

        public string getLogradouro() => this.logradouro;
        public void setLogradouro(string logradouro) => this.logradouro = logradouro;

        public string getNumero() => this.numero;
        public void setNumero(string numero) => this.numero = numero;

        public string getBairro() => this.bairro;
        public void setBairro(string bairro) => this.bairro = bairro;

        public string getCidade() => this.cidade;
        public void setCidade(string cidade) => this.cidade = cidade;

        public string getCep() => this.cep;
        public void setCep(string cep)=> this.cep = cep;
    }
}
