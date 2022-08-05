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
        Corrida PedirCorrida(Passageiro passageiro, Corrida corrida);
        string SelecionarTipoPagamento();
        string PagarCorrida(decimal valor, Corrida corrida);
        string AdicionarEnderecoDeOrigem(Endereco origem);
        string AdicionarEnderecoDeDestino(Endereco destino);
    }
}
