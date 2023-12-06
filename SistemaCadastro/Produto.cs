using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    class Produto
    {
        string nome;
        string tipo;
        int quantidade;
        double preco;

        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Preco { get => preco; set => preco = value; }
    }
}
