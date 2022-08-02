using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class ContaBancaria
    {
        public ContaBancaria(string agencia, string nomeDoBanco, string numeroDaConta, decimal saldoParaReceber)
        {
            Agencia = agencia;
            NomeDoBanco = nomeDoBanco;
            NumeroDaConta = numeroDaConta;
            SaldoParaReceber = saldoParaReceber;
        }

        private string Agencia { get; set; }
        private string NomeDoBanco { get; set; }
        private string NumeroDaConta { get; set; }
        private decimal SaldoParaReceber { get; set; }

        public string ReceberPagamento(decimal valor)
        {
            return "Pagamento recebido com sucesso";
        }
    }
}
