using DesafioPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class Motorista : Usuario, IMotorista
    {
        public Motorista(string login, string nome, string email, string telefone, string cpf) : base(login, nome, email, telefone, cpf)
        {
        }

        public ContaBancaria Conta { get; set; }
        public Veiculo TipoDeVeiculo { get; set; }

        public string AceitarCorrida()
        {
            throw new NotImplementedException();
        }

        public string IniciarCorrida()
        {
            throw new NotImplementedException();
        }

        public Veiculo ObterDadosDoVeiculo()
        {
            throw new NotImplementedException();
        }

        public string ObterNomeDoMotorista()
        {
            throw new NotImplementedException();
        }

        public string PararCorrida()
        {
            throw new NotImplementedException();
        }

        public string ReceberPagamento(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
