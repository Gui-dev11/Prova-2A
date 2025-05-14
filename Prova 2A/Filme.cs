using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_2A
{
    public class Filme
    {
        private string titulo, genero, diretor;
        private int anoLancamento, duracaoMinutos;

        public Filme()
        {

        }

        public Filme(string titulo, string genero, string diretor, int anoLancamento, int duracaoMinutos)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.diretor = diretor;
            this.anoLancamento = anoLancamento;
            this.duracaoMinutos = duracaoMinutos;
        }

        public string getTitulo() => this.titulo;
        public void setTitulo(string titulo) => this.titulo = titulo;

        public string getGenero() => this.genero;
        public void setGenero(string genero) => this.genero = genero;

        public string getDiretor() => this.diretor;
        public void setDiretor(string diretor) => this.diretor = diretor;

        public int getanoLancamento() => this.anoLancamento;
        public void setanoLancamento(int anoLancamento) => this.anoLancamento = anoLancamento;

        public int getduracaoMinutos() => this.duracaoMinutos;

        public void setduracaoMinutos(int duracaoMinutos) => this.duracaoMinutos = duracaoMinutos;


    }
}
