using DesafioPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public abstract class Cartao
    {
        public Cartao(string numeroDoCartao, string cpf, int cvv, string validade, string nomeDoCartao)
        {
            
            NumeroDoCartao = numeroDoCartao;
            Cpf = cpf;
            Cvv = cvv;
            Validade = validade;
            NomeDoCartao = nomeDoCartao;
        }
        public string NomeDoCartao { get; set; }
        protected string NumeroDoCartao { get; set; }
        protected string Cpf { get; set; }
        protected int Cvv { get; set; }
        protected string Validade { get; set; }
        public ETipoPagamento Tipo { get; set; }

        public override string ToString()
        {
            return $"\nNúmero: {NumeroDoCartao}\nCpf: {Cpf}\nDígito verificador: {Cvv}\nValidade: {Validade}\n";
        }
    }
}
