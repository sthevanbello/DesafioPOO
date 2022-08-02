using DesafioPOO.Enums;
using DesafioPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class Passageiro : Usuario, IPassageiro
    {
        public Passageiro(string login, string nome, string email, string telefone, string cpf) : base(login, nome, email, telefone, cpf)
        {
        }

        public ETipoPagamento TipoPagamento { get; set; }
        public Endereco EnderecoOrigem { get; set; }
        public Endereco EnderecoDestino { get; set; }

        public string AlterarTipoDePagamento(ETipoPagamento tipoPagamento)
        {
            throw new NotImplementedException();
        }

        public string InformarEnderecoDeDestino(Endereco destino)
        {
            throw new NotImplementedException();
        }

        public string InformarEnderecoDeOrigem(Endereco origem)
        {
            throw new NotImplementedException();
        }

        public string PagarCorrida(ETipoPagamento tipoPagamento, decimal valor)
        {
            throw new NotImplementedException();
        }

        public string PedirCorrida(Endereco origem, Endereco destino)
        {
            throw new NotImplementedException();
        }
    }
}
