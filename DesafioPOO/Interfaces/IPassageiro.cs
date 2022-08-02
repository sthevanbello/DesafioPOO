using DesafioPOO.Entidades;
using DesafioPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Interfaces
{
    public interface IPassageiro
    {
        string PedirCorrida(Endereco origem, Endereco destino);
        string AlterarTipoDePagamento(ETipoPagamento tipoPagamento);
        string PagarCorrida(ETipoPagamento tipoPagamento, decimal valor);
        string InformarEnderecoDeOrigem(Endereco origem);
        string InformarEnderecoDeDestino(Endereco destino);
    }
}
