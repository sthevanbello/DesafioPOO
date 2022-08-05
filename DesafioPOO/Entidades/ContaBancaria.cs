using DesafioPOO.Auxiliares;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class ContaBancaria
    {
        public ContaBancaria(string agencia, string nomeDoBanco, string numeroDaConta, decimal saldo)
        {
            Agencia = agencia;
            NomeDoBanco = nomeDoBanco;
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        private string Agencia { get; set; }
        private string NomeDoBanco { get; set; }
        private string NumeroDaConta { get; set; }
        private decimal Saldo { get; set; }

        /// <summary>
        /// Recebe pagamento na conta do motorista
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public string ReceberPagamento(decimal valor)
        {
            Saldo += valor;
            Thread.Sleep(1000);
            Console.WriteLine();
            Auxiliar.ExibirDivisoriaHorizontal("$-");
            Thread.Sleep(1000);
            return $"\nPagamento de {Saldo.ToString("C", CultureInfo.GetCultureInfo("pt-br"))} recebido com sucesso";
        }
    }
}
