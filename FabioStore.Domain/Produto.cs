using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabioStore.Domain
{
    public class Produto : EntidadeBase
    {
        public Produto(int id, string nome, string descricao, decimal valor, int quantidadedeEstoque)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            QuantidadedeEstoque = quantidadedeEstoque;

            Ativar();
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; } = 0;
        public int QuantidadedeEstoque { get; private set; }

        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade < 0) quantidade *= -1;
            QuantidadedeEstoque -= quantidade;
        }

        public void ReporEstoque(int quantidade)
        {
            QuantidadedeEstoque += quantidade;
        }
        public bool PossuiEstoque(int quantidade)
        {
            return QuantidadedeEstoque >= quantidade;
        }
    }
}
