using DesafioPOO.Auxiliares;
using DesafioPOO.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class Corrida
    {
        public Corrida()
        {
            Valor = 70m;
        }

        private Motorista _motorista { get; set; }
        private EStatusCorrida StatusCorrida { get; set; }
        private decimal Valor { get; set; }

        /// <summary>
        /// Inicia a corrida
        /// </summary>
        /// <param name="origem"></param>
        /// <param name="destino"></param>
        /// <returns>Retorna o objeto corrida modificado com motorista selecionado e status atualizado</returns>
        public Corrida Iniciar(Endereco origem, Endereco destino)
        {
            Console.WriteLine($"O valor da corrida será de {Valor.ToString("C", CultureInfo.GetCultureInfo("pt-br"))}");
            _motorista = SelecionarMotorista(Valor);
            StatusCorrida = EStatusCorrida.Iniciada;
            _motorista._corrida = this;
            return this;
        }

        /// <summary>
        /// Para a corrida modificando o status para Finalizada
        /// </summary>
        /// <returns></returns>
        public string Parar()
        {
            StatusCorrida = EStatusCorrida.Finalizada;
            return "Corrida parada";
        }

        /// <summary>
        /// Seleciona um motorista dentro da lista de motoristas cadastrados
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna um objeto da Classe <b>Motorista</b></returns>
        public Motorista SelecionarMotorista(decimal valor)
        {
            // Cria uma lista de motoristas
            List<Motorista> motoristas = new List<Motorista>();
            
            // Criação de cada instância de motorista
            Motorista motorista1 = new Motorista("bart", "Bart Simpson", "bart@simpsons.com","987456321", "22255515945", "skate");
            motorista1.TipoDeVeiculo = new Veiculo("ABC-1234", "Skate", "Verde com listra vermelha");
            Motorista motorista2 = new Motorista("marge", "Marge Simpson", "marge@simpsons.com","921543698", "22255515945", "hair");
            motorista2.TipoDeVeiculo = new Veiculo("DEF-5678", "Orange Station Wagon", "Laranja");
            Motorista motorista3 = new Motorista("lisa", "Lisa Simpson", "lisa@simpsons.com","945678521", "22255515945", "book");
            motorista3.TipoDeVeiculo = new Veiculo("GHI-4567", "Plymouth Junkerolla", "Rosa");
            Motorista motorista4 = new Motorista("moe", "Moe Szyslak", "Moe@simpsons.com","956789456", "22255515945", "duff");
            motorista4.TipoDeVeiculo = new Veiculo("ABC-1234", "Sedan do Moe", "Verde com rosa no capô");
            Motorista motorista5 = new Motorista("milhouse", "Milhouse Van Houten", "milhouse@simpsons.com","977452210", "22255515945", "glasses");
            motorista5.TipoDeVeiculo = new Veiculo("QWE-9876", "Bicicleta", "Laranja e cinza");

            //Adiciona cada motorista à lista de motoristas
            motoristas.Add(motorista1);
            motoristas.Add(motorista2);
            motoristas.Add(motorista3);
            motoristas.Add(motorista4);
            motoristas.Add(motorista5);

            Random random = new Random();
            int selecionado = random.Next(0, motoristas.Count); // Gera um número aleatório para poder selecionar o motorista na lista

            Auxiliar.WriteProgress("motorista", true); // Gera uma barra de progresso com porcentagem
            
            Console.WriteLine(motoristas[selecionado]);

            if (motoristas[selecionado].AceitarCorrida(valor))
            {
                return motoristas[selecionado];// Utiliza o número aleatório da variável "selecionado" e usa como índice na lista de motoristas para retornar um motorista.
            }
            return new Motorista("burns", "Sr. Burns", "burns@simpsons.com","966665656", "02545685125", "old"); // Caso não haja um motorista, retorna um motorista 
        }

        /// <summary>
        /// Retorna o motorista adicionado à corrida
        /// </summary>
        /// <returns></returns>
        public Motorista ObterMotorista()
        {
            return _motorista; // Retorna um motorista quando solicitado
        }

        /// <summary>
        /// Realiza o pagamento ao motorista
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public string PagarMotorista(decimal valor)
        {
            return _motorista.ReceberPagamento(valor); // Realiza o pagamento ao motorista
        }
    }
}
