using DesafioPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Interfaces
{
    public interface IMotorista
    {
        string ObterNomeDoMotorista();
        Veiculo ObterDadosDoVeiculo();
        string ReceberPagamento(decimal valor);
        string AceitarCorrida();
        string IniciarCorrida();
        string PararCorrida();
    }
}
