using DesafioPOO.Auxiliares;
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
        public Passageiro(string login, string nome, string email, string telefone, string cpf, string senha) : base(login, nome, email, telefone, cpf, senha)
        {
        }

        private ETipoPagamento TipoPagamento { get; set; }
        private Endereco EnderecoOrigem { get; set; }
        private Endereco EnderecoDestino { get; set; }
        public List<Cartao> Cartoes = new List<Cartao>();

        /// <summary>
        /// Solicitação de corrida pelo passageiro instanciado recebendo o passageiro e a corrida criada inicialmente.
        /// </summary>
        /// <param name="passageiro"></param>
        /// <param name="corrida"></param>
        /// <returns>Retorna a corrida iniciada com os dados do veículo e do motorista </returns>
        public Corrida PedirCorrida(Passageiro passageiro, Corrida corrida)
        {
            return corrida.Iniciar(passageiro.EnderecoOrigem, passageiro.EnderecoDestino);
        }

        /// <summary>
        /// Faz o pagamento da corrida ao motorista
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="corrida"></param>
        /// <returns>Retorna uma string com o informativo de pagamento efetuado</returns>
        public string PagarCorrida(decimal valor, Corrida corrida)
        {
            return corrida.PagarMotorista(valor); // Paga a corrida ao motorista
        }

        /// <summary>
        /// Adiciona um endereço de Origem
        /// </summary>
        /// <param name="origem"></param>
        /// <returns>Retorna uma string com a mensagem de que o novo endereço foi informado</returns>
        public string AdicionarEnderecoDeOrigem(Endereco origem)
        {
            EnderecoOrigem = origem;
            return "Novo endereço de origem informado";
        }

        /// <summary>
        /// Adiciona um endereço de Origem
        /// </summary>
        /// <param name="origem"></param>
        /// <returns>Retorna uma string com a mensagem de que o novo endereço foi informado</returns>
        public string AdicionarEnderecoDeDestino(Endereco destino)
        {
            EnderecoDestino = destino;
            return "Novo endereço de destino informado";
        }

        /// <summary>
        /// Mostra o endereço de origem
        /// </summary>
        /// <returns>Retorna o endereço de origem formatado pela classe Endereco</returns>
        public Endereco ObterEnderecoOrigem()
        {
            Console.WriteLine("Endereço de origem");
            return EnderecoOrigem;
        }

        /// <summary>
        /// informa o endereço de destino
        /// </summary>
        /// <returns>Retorna o endereço de destino formatado pela classe Endereco</returns>
        public Endereco ObterEnderecoDestino()
        {
            Console.WriteLine("Endereço de destino");
            return EnderecoDestino;
        }

        /// <summary>
        ///  Mostra o tipo de pagamento selecionado
        /// </summary>
        /// <returns>Retorna o tipo de pagamento selecionado</returns>
        public ETipoPagamento ObterTipoPagamentoSelecionado()
        {
            return TipoPagamento;
        }

        /// <summary>
        /// Cria e adiciona um cartão à lista de cartões cadastrados
        /// </summary>
        /// <param name="dados"></param>
        /// <param name="tipoPagamento"></param>
        public void AdicionarCartao(object[] dados, ETipoPagamento tipoPagamento)
        {

            TipoPagamento = tipoPagamento;
            if (TipoPagamento == ETipoPagamento.Credito)
            {
                // Cria um cartão de Crédito
                string nome = dados[0].ToString();
                string numero = dados[1].ToString();
                int.TryParse(dados[2].ToString(), out int cvv);
                string validade = dados[3].ToString();
                CartaoDeCredito cartaoDeCredito = new CartaoDeCredito(numero, CPF, cvv, validade, nome);

                Cartoes.Add(cartaoDeCredito); // Adiciona o cartão de crédito à lista de cartões

            }
            if (TipoPagamento == ETipoPagamento.Debito)
            {
                // Cria um cartão de Débito
                string nome = dados[0].ToString();
                string numero = dados[1].ToString();
                int.TryParse(dados[2].ToString(), out int cvv);
                string validade = dados[3].ToString();
                CartaoDeDebito cartaoDeDebito = new CartaoDeDebito(numero, CPF, cvv, validade, nome);

                Cartoes.Add(cartaoDeDebito); // Adiciona o cartão de débito à lista de cartões
            }
        }

        /// <summary>
        /// Seleciona o tipo de pagamento a partir da lista exibida
        /// </summary>
        /// <returns>Retorna uma string com a mensagem do tipo de pagamento que será utilizado</returns>
        public string SelecionarTipoPagamento()
        {
            var tipoPagamentoSelecionado = SelecionarOpcoesDePagamentos();
            Console.Clear();
            return $"\nPagamento será feito com {tipoPagamentoSelecionado}\n";
        }
        
        /// <summary>
        /// Exibe uma lista com os pagamentos cadastrados
        /// </summary>
        public void ObterPagamentosCadastrados()
        {
            Console.Clear();
            Console.WriteLine("\n--- Pagamentos cadastrados ---\n");
            for (int i = 0; i < Cartoes.Count; i++)
            {
                Console.WriteLine($"{Cartoes[i]}");
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine($"{ETipoPagamento.Dinheiro}\n");
        }
        /// <summary>
        /// Realiza o login do Passageiro quando necessário
        /// </summary>
        /// <returns> retorna um <b>bool</b> para resultado da tentativa de acesso</returns>
        public override bool EfetuarLogin()
        {
            Console.Write("Digite o login: ");
            string login = Console.ReadLine();
            Console.Write("Digite a sua senha");
            string senha = Console.ReadLine();

            if (Login == login && Senha == senha)
            {
                Console.WriteLine("Passageiro efetuou o login com sucesso");
                return true;
            }
            Console.WriteLine("Passageiro com acesso negado");
            return false;
        }

        /// <summary>
        /// Seleciona as opções de pagamentos disponíveis
        /// <para>O "Default" é Dinheiro</para>
        /// </summary>
        /// <returns>Retorna um <b>enum</b> com o tipo de pagamento selecionado</returns>
        public ETipoPagamento SelecionarOpcoesDePagamentos()
        {
            bool fim = false;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira a opção desejada\n");
            Console.ResetColor();
            Console.Write("Digite ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"1 ");
            Console.ResetColor();
            Console.Write($"- {ETipoPagamento.Dinheiro}\n");

            for (int i = 0; i < Cartoes.Count; i++)
            {
                Console.Write("Digite ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{i + 2} ");
                Console.ResetColor();
                Console.Write($"- {Cartoes[i].NomeDoCartao}\n");
            }
            Auxiliar.ExibirDivisoriaHorizontal(".-"); // Classe estática Auxiliar para exibir divisória
            while (!fim)
            {
                Console.Write("Opção: ");
                bool digitou = int.TryParse(Console.ReadLine(), out int escolha);

                if (digitou)
                {
                    if (escolha == 1)
                    {
                        return ETipoPagamento.Dinheiro;
                    }
                    else if (escolha == 2 && Cartoes.Count > 0) // Se houver algum cartão adicionado
                    {
                        return Cartoes[0].Tipo;
                    }
                    else if (escolha == 3 && Cartoes.Count > 1) // Se houver algum cartão adicionado
                    {
                        return Cartoes[1].Tipo;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nDigite uma opção válida");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDigite uma opção válida");
                    Console.ResetColor();
                }
            }
            return ETipoPagamento.Dinheiro;
        }
    }
}
