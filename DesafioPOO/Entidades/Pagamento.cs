using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class Pagamento
    {
        public CartaoDeCredito Credito { get; set; }
        public CartaoDeDebito Debito { get; set; }

        public string PagarComCredito(decimal valor, CartaoDeCredito cartaoDeCredito)
        {
            return "";
        }
        public string PagarComDebito(decimal valor, CartaoDeDebito cartaoDeDebito)
        {
            return "";
        }
        public string PagarComDinheiro(decimal valor)
        {
            return "";
        }
    }
}
