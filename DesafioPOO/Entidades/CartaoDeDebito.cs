using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class CartaoDeDebito : Cartao
    {
        public CartaoDeDebito(string numeroDoCartao, string cpf, int cvv, DateTime validade) : base(numeroDoCartao, cpf, cvv, validade)
        {
        }

        public string Pagar()
        {
            return "Pagamento com cartão de débito efetuado com sucesso";
        }
    }
}
