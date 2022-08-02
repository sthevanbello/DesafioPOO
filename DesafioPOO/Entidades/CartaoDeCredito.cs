using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class CartaoDeCredito : Cartao
    {
        public CartaoDeCredito(string numeroDoCartao, string cpf, int cvv, DateTime validade) : base(numeroDoCartao, cpf, cvv, validade)
        {
        }

        public string Pagar()
        {
            return "Pagamento com cartão de crédito efetuado com sucesso";
        }
    }
}
