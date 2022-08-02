using DesafioPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class Corrida
    {
        private Motorista _motorista { get; set; }
        public EStatusCorrida StatusCorrida { get; set; }

        public string Iniciar(Endereco origem, Endereco destino)
        {
            return "Corrida iniciada";
        }

        public string Parar()
        {
            return "Corrida parada";
        }

        public void SelecionarMotorista()
        {
            // Instanciar motorista
        }
    }
}
