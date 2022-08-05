using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class Veiculo
    {
        public Veiculo(string placa, string modelo, string cor)
        {
            Placa = placa;
            Modelo = modelo;
            Cor = cor;
        }

        private string Placa { get; set; }
        private string Modelo { get; set; }
        private string Cor { get; set; }

        /// <summary>
        /// Retorna apenas a placa do carro
        /// </summary>
        /// <returns></returns>
        public string ObterPlaca()
        {
            return Placa;
        }

        /// <summary>
        /// Retorna apenas o modelo do carro
        /// </summary>
        /// <returns></returns>
        public string ObterModelo()
        {
            return Modelo;
        }

        /// <summary>
        /// Retorna apenas a cor do carro
        /// </summary>
        /// <returns></returns>
        public string ObterCor()
        {
            return Cor;
        }
    }
}
