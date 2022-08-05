using DesafioPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class CartaoDeDebito : Cartao
    {
        public CartaoDeDebito(string numeroDoCartao, string cpf, int cvv, string validade, string nomeDoCartao) : base(numeroDoCartao, cpf, cvv, validade, nomeDoCartao)
        {
            Tipo = ETipoPagamento.Debito;
        }
        public string Pagar()
        {
            return "Pagamento com cartão de crédito efetuado com sucesso";
        }
        public override string ToString()
        {
            return $"\n- Cartão de débito\nNúmero: {NumeroDoCartao}\nCpf: {Cpf}\nDígito verificador: {Cvv}\nValidade: {Validade}\n";
        }
    }
}
