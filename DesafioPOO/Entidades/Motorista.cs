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
        public Motorista(string login, string nome, string email, string telefone, string cpf, string senha) : base(login, nome, email, telefone, cpf, senha)
        {
        }

        public ContaBancaria Conta { get; set; }
        public Veiculo TipoDeVeiculo { get; set; }
        public Corrida _corrida { get; set; }

        public bool AceitarCorrida(decimal valor)
        {
            if (valor < 10m)
            {
                Console.WriteLine("A corrida não foi aceita pelo motorista");
                return false;
            }
            Console.WriteLine("A corrida foi aceita pelo motorista");
            return true;
        }

        public string IniciarCorrida(Endereco origem, Endereco destino)
        {
            return _corrida.Iniciar(origem, destino);
            
        }

        public Veiculo ObterDadosDoVeiculo()
        {
            return TipoDeVeiculo;
        }

        public string ObterNomeDoMotorista()
        {
            return Nome;
        }

        public string PararCorrida()
        {
            return _corrida.Parar();
        }

        public string ReceberPagamento(decimal valor)
        {
            return Conta.ReceberPagamento(valor);
        }

        public override bool EfetuarLogin(string login, string senha)
        {
            if (Login == login && Senha == senha)
            {
                Console.WriteLine("Motorista efetuou o login com sucesso");
                return true;
            }
            Console.WriteLine("Motorista com acesso negado");
            return false;
        }
    }
}
