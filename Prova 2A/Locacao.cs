using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_2A
{
    public class Locacao
    {
        private Cliente clienteLocador;
        private Filme filmeAlugado;
        private DateTime dataLocacao, dataDevolucaoPrevista;
        private double valorCobrado;

        public Locacao()
        {

        }

        public Locacao(Cliente clienteLocador, Filme filmeAlugado, DateTime dataLocacao, DateTime dataDevolucaoPrevista, double valorCobrado)
        {
            this.clienteLocador = clienteLocador;
            this.filmeAlugado = filmeAlugado;
            this.dataLocacao = dataLocacao;
            this.dataDevolucaoPrevista = dataDevolucaoPrevista;
            this.valorCobrado = valorCobrado;
        }

        public Cliente getClienteLocador() => this.clienteLocador;
        public void setClienteLocador(Cliente clienteLocador) => this.clienteLocador = clienteLocador;

        public Filme getFilmeAlugado() => this.filmeAlugado;
        public void setFilmeAlugado(Filme filmeAlugado) => this.filmeAlugado = filmeAlugado;

        public DateTime getDataLocacao() => this.dataLocacao;
        public void setDataLocacao(DateTime dataLocacao) => this.dataLocacao = dataLocacao;

        public DateTime getDataDevolucaoPrevista() => this.dataDevolucaoPrevista;
        public void setDataDevolucaoPrevista(DateTime dataDevolucaoPrevista) => this.dataDevolucaoPrevista = dataDevolucaoPrevista;
        public double getValorCobrado() => this.valorCobrado;
        public void setValorCobrado(double valorCobrado) => this.valorCobrado = valorCobrado;
    }
}
