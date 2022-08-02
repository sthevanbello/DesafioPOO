using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public abstract class Cartao
    {
        public Cartao(string numeroDoCartao, string cpf, int cvv, DateTime validade)
        {
            NumeroDoCartao = numeroDoCartao;
            Cpf = cpf;
            Cvv = cvv;
            Validade = validade;
        }

        public string NumeroDoCartao { get; set; }
        public string Cpf { get; set; }
        public int Cvv { get; set; }
        public DateTime Validade { get; set; }

    }
}
