using DesafioPOO.Auxiliares;
using DesafioPOO.Entidades;
using DesafioPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafioPOO.Views
{
    internal class TelaPassageiro
    {
        public void IniciarPrograma()
        {
            Console.WriteLine("Olá, gostaria de Iniciar uma corrida?");
            bool inicio = ExibirOpcoesIniciais(); // Exibe as opções iniciais
            if (inicio)
            {
                // cria um passageiro novo e passa os dados pelo construtor da classe
                Passageiro passageiroNovo = new Passageiro(login: "homerSimpson", nome: "Homer", email: "homer@simpson.com", telefone: "987654321", cpf: "22245678904", senha: "1234");
                passageiroNovo.AdicionarEnderecoDeOrigem(new Endereco(logradouro: "Evergreen Terrace", bairro: "", numero: 632, cidade: "Springfield", uf: "Oregon", cep: "08051456"));
                passageiroNovo.AdicionarEnderecoDeDestino(new Endereco("Fifth Avenue", "Manhattan", 33, "New York City", "New York", "09050412"));

                // Confirma o endereço de origem
                bool confirmaEnderecoOrigem = ConfirmarEnderecoOrigem(passageiroNovo);
                // Confirmar endereços
                if (confirmaEnderecoOrigem)
                {
                    Console.WriteLine("Endereço de origem confirmado");
                }
                else
                {
                    passageiroNovo.AdicionarEnderecoDeOrigem(TelaEndereco.SolicitarEndereco());
                }

                // Confirma o endereço de destino
                bool confirmaEnderecoDestino = ConfirmarEnderecoDestino(passageiroNovo);
                // Confirmar endereços
                if (confirmaEnderecoDestino)
                {

                    Console.WriteLine("Endereço de destino confirmado");
                }
                else
                {
                    passageiroNovo.AdicionarEnderecoDeDestino(TelaEndereco.SolicitarEndereco());
                }
                Console.Clear();

                Console.WriteLine(passageiroNovo.ObterEnderecoOrigem());
                Console.WriteLine(passageiroNovo.ObterEnderecoDestino());

                bool resultadoCartao = ExibirOpcoesAdiconarCartao(); // Passageiro escolhe se quer adicionar algum cartão
                do
                {
                    if (resultadoCartao)
                    {
                        Console.Clear();
                        Console.WriteLine("--- Caso não adicione um cartão, o padrão será apenas 'Dinheiro' ---");
                        var tipoCartao = EscolherCartao();
                        if (tipoCartao != ETipoPagamento.Dinheiro)
                        {
                            var cartao = PreencherDadosDoCartao();
                            passageiroNovo.AdicionarCartao(cartao, tipoCartao);
                            if (passageiroNovo.Cartoes.Count > 1)
                            {
                                break;
                            }
                        }
                        Console.WriteLine("\nGostaria de adicionar mais um cartão à lista de pagamentos? ");
                        resultadoCartao = ExibirOpcoesAdiconarCartao("adicional");
                    }
                } while (resultadoCartao);
                passageiroNovo.ObterPagamentosCadastrados();
                var corrida = new Corrida();
                Console.WriteLine("Selecione o tipo de pagamento desejado");
                // selecionar tipo de pagamento
                Console.WriteLine(passageiroNovo.SelecionarTipoPagamento());

                passageiroNovo.PedirCorrida(passageiroNovo, corrida);

                Console.WriteLine("Aperte qualquer tecla para iniciar a corrida");
                Console.ReadKey();
                // Colocar uma validação se aceita mesmo a corrida 
                ConsoleUtility.WriteProgress("corrida", true);
                Thread.Sleep(1000);
                Console.WriteLine("\n--- Corrida finalizada! ---\n");
                Thread.Sleep(1000);
                Console.WriteLine("\nPassageiro chegou ao seu destino\n");
                Console.WriteLine("Aperte qualquer tecla para iniciar o pagamento");
                Console.ReadKey();
                ConsoleUtility.WriteProgress("pagamento", true);
                Thread.Sleep(1000);
                Console.WriteLine(passageiroNovo.PagarCorrida(70, corrida));
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(2000);
                Console.WriteLine("--- Obrigado pela preferência --- =)\n");
                Console.ResetColor();
                Thread.Sleep(2000);
                // falta organizar as telas e deixar melhor apresentável
            }
            else
            {
                Sair();
            }

        }

        private object[] PreencherDadosDoCartao()
        {
            // Cria um cartão de Crédito
            Console.Clear();
            Console.WriteLine("Inserir dados do cartão novo");
            Console.Write("Insira um nome para identificar o cartão: ");
            string nome = Console.ReadLine();
            Console.Write("Insira o número do cartão: ");
            string numero = Console.ReadLine();
            Console.Write("Insira o dígito verificador: ");
            int.TryParse(Console.ReadLine(), out int cvv);
            Console.Write("Insira a validade mm/aa: ");
            string validade = Console.ReadLine();
            object[] dados = { nome, numero, cvv, validade };
            return dados;
        }

        private bool ConfirmarEnderecoOrigem(Passageiro passageiroNovo)
        {
            Console.Clear();
            Console.WriteLine("O endereço de origem está correto?\n");
            var origem = passageiroNovo.ObterEnderecoOrigem(); // Obtém o endereço de origem armazenado inicialmente
            Console.WriteLine(origem);
            string resultado = "";
            bool valido = true;
            do
            {
                Console.Write("Digite apenas S ou N: ");
                resultado = Console.ReadLine().ToLower();
                if (resultado == "s")
                {
                    Console.WriteLine("Endereço confirmado");
                    valido = true;
                }
                else if (resultado == "n")
                {
                    Console.WriteLine("Endereço não confirmado");
                    valido = false;
                }
                else
                {
                    Console.Write("Digite apenas S ou N: ");
                    resultado = Console.ReadLine().ToLower();
                }
            } while (resultado != "s" && resultado != "n");
            return valido;
        }

        private bool ConfirmarEnderecoDestino(Passageiro passageiroNovo)
        {
            Console.Clear();
            Console.WriteLine("O endereço de destino está correto?\n");
            var destino = passageiroNovo.ObterEnderecoDestino(); // Obtém o endereço de origem armazenado inicialmente
            Console.WriteLine($"{destino}");
            string resultado = "";
            bool valido = true;
            do
            {
                Console.Write("Digite apenas S ou N: ");
                resultado = Console.ReadLine().ToLower();
                if (resultado == "s")
                {
                    Console.WriteLine("\nEndereço confirmado");
                    valido = true;
                }
                else if (resultado == "n")
                {
                    Console.WriteLine("\nEndereço não confirmado");
                    valido = false;
                }
                else
                {
                    Console.Write("\nDigite apenas S ou N: ");
                    resultado = Console.ReadLine().ToLower();
                }
            } while (resultado != "s" && resultado != "n");
            return valido;
        }

        static bool ExibirOpcoesIniciais()
        {
            Console.WriteLine();
            bool fim = false;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira a opção desejada\n");
            Console.ResetColor();
            Console.Write("Digite ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1 ");
            Console.ResetColor();
            Console.Write("- Sim, iniciar uma corrida\n");
            Console.Write("Digite ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2 ");
            Console.ResetColor();
            Console.Write("- Não, sair do programa\n");

            ExibirDivisoriaHorizontal(".-");
            while (!fim)
            {
                Console.Write("Opção: ");
                int escolha = 0;
                bool digitou = int.TryParse(Console.ReadLine(), out escolha);

                if (digitou)
                {
                    if (escolha == 1)
                    {
                        return true;
                    }
                    else if (escolha == 2)
                    {
                        return false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nDigite uma opção válida - 1 para Iniciar ou 2 para Sair");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDigite uma opção válida - 1 para Iniciar ou 2 para Sair");
                    Console.ResetColor();
                }
            }
            return false;
        }
        public bool ExibirOpcoesAdiconarCartao(string tipo = "")
        {
            if (tipo != "adicional")
            {
                Console.WriteLine("Gostaria de adicionar algum cartão como meio de pagamento?");
            }
            Console.WriteLine();
            bool fim = false;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira a opção desejada\n");
            Console.ResetColor();
            Console.Write("Digite ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1 ");
            Console.ResetColor();
            Console.Write("- Sim\n");
            Console.Write("Digite ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2 ");
            Console.ResetColor();
            Console.Write("- Não\n");

            Auxiliar.ExibirDivisoriaHorizontal(".-"); // Classe estática Auxiliar para exibir divisória
            while (!fim)
            {
                Console.Write("Opção: ");
                bool digitou = int.TryParse(Console.ReadLine(), out int escolha);

                if (digitou)
                {
                    if (escolha == 1)
                    {
                        return true;
                    }
                    else if (escolha == 2)
                    {
                        return false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nDigite uma opção válida - 1 para Sim, 2 Não");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDigite uma opção válida - 1 para Sim, 2 Não");
                    Console.ResetColor();
                }
            }
            return false;
        }
        public ETipoPagamento EscolherCartao()
        {
            Console.WriteLine();
            bool fim = false;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira a opção desejada\n");
            Console.ResetColor();
            Console.Write("Digite ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("1 ");
            Console.ResetColor();
            Console.Write("- Crédito\n");
            Console.Write("Digite ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("2 ");
            Console.ResetColor();
            Console.Write("- Débito\n");
            Console.Write("Digite ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3 ");
            Console.ResetColor();
            Console.Write("- Não adicionar cartão\n");

            Auxiliar.ExibirDivisoriaHorizontal(".-"); // Classe estática Auxiliar para exibir divisória
            while (!fim)
            {
                Console.Write("Opção: ");
                bool digitou = int.TryParse(Console.ReadLine(), out int escolha);

                if (digitou)
                {
                    if (escolha == 1)
                    {
                        return ETipoPagamento.Credito;
                    }
                    else if (escolha == 2)
                    {
                        return ETipoPagamento.Debito;
                    }
                    else if (escolha == 3)
                    {
                        return ETipoPagamento.Dinheiro;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nDigite uma opção válida - 1 para Crédito, 2 para Débito ou 3 para não adicionar");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDigite uma opção válida - 1 para Crédito, 2 para Débito ou 3 para não adicionar");
                    Console.ResetColor();
                }
            }
            return ETipoPagamento.Dinheiro;
        }
        static void Sair()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Até mais...");
            Console.ResetColor();
            Environment.Exit(0);
        }

        static void ExibirDivisoriaHorizontal(string simbolo)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < Console.WindowWidth / simbolo.Length; i++)
            {
                Console.Write(simbolo);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
