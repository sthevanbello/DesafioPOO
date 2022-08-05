using DesafioPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class Motorista : Usuario, IMotorista
    {
        public Motorista(string login, string nome, string email, string telefone, string cpf, string senha) : base(login, nome, email, telefone, cpf, senha)
        {
            CriarConta(); // Cria uma conta obrigatoriamente ao criar um motorista
        }

        public ContaBancaria Conta { get; set; }
        public Veiculo TipoDeVeiculo { get; set; }
        public Corrida _corrida { get; set; }

        /// <summary>
        /// Aceita a corrida ou não de acordo com o valor recebido como argumento
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna um <b>bool</b> aceitando ou rejeitando a corrida</returns>
        public bool AceitarCorrida(decimal valor)
        {
            if (valor < 50m)
            {
                Console.WriteLine("A corrida não foi aceita pelo motorista");
                return false;
            }
            Console.WriteLine("A corrida foi aceita pelo motorista");
            return true;
        }

        /// <summary>
        /// Inicia a corrida com endereços de origem, destino e valor
        /// </summary>
        /// <param name="origem"></param>
        /// <param name="destino"></param>
        /// <param name="valor"></param>
        /// <returns>Retorna a corrida iniciada</returns>
        public Corrida IniciarCorrida(Endereco origem, Endereco destino, decimal valor)
        {
            return _corrida.Iniciar(origem, destino);
            
        }

        
        /// <summary>
        /// Retorna o veículo vinculado ao motorista
        /// </summary>
        /// <returns>Retorna um Veículo</returns>
        public Veiculo ObterDadosDoVeiculo()
        {
            return TipoDeVeiculo;
        }

        /// <summary>
        /// Obtém o nome do motorista
        /// </summary>
        /// <returns>Retorna uma String com o nome do motorista</returns>
        public string ObterNomeDoMotorista()
        {
            return Nome;
        }

        /// <summary>
        /// Para a corrida já iniciada
        /// </summary>
        /// <returns></returns>
        public string PararCorrida()
        {
            _corrida.Parar();
            return _corrida.Parar();
        }

        /// <summary>
        /// Executa o método na conta bancária e Recebe o pagamento do valor da corrida
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna uma string informando que o pagamento foi efetuado</returns>
        public string ReceberPagamento(decimal valor)
        {
            return Conta.ReceberPagamento(valor);
        }

        /// <summary>
        /// Cria uma conta bancária e faz o vínculo com o motorista
        /// </summary>
        public void CriarConta()
        {
            Conta = new ContaBancaria("1234", "Banco de Springfield", "45678-9", 0);
        }

        /// <summary>
        /// Efetua login do motorista
        /// </summary>
        /// <returns>Retorna um <b>bool</b> informando se o login foi efetuado ou não</returns>
        public override bool EfetuarLogin()
        {
            Console.Write("Digite o login: ");
            string login = Console.ReadLine();
            Console.Write("Digite a sua senha");
            string senha = Console.ReadLine();
            if (Login == login && Senha == senha)
            {
                Console.WriteLine("Motorista efetuou o login com sucesso");
                return true;
            }
            Console.WriteLine("Motorista com acesso negado");
            return false;
        }

        public override string ToString()
        {
            Thread.Sleep(1000);
            return $"\nNome do motorista: {Nome}\n Tipo de veículo: {TipoDeVeiculo.ObterModelo()}\n Placa: {TipoDeVeiculo.ObterPlaca()}\n Cor: {TipoDeVeiculo.ObterCor()}\n";
        }
    }
}
