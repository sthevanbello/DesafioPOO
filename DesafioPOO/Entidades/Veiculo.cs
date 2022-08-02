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

        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public string ObterPlaca()
        {
            return Placa;
        }

        public string ObterModelo()
        {
            return Modelo;
        }

        public string ObterCor()
        {
            return Cor;
        }
    }
}
