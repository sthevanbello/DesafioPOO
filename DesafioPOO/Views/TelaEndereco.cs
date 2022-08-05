using DesafioPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Views
{
    public static class TelaEndereco
    {
        public static Endereco SolicitarEndereco()
        {
            Console.Clear();
            Console.Write("Insira o logradouro:");
            string logradouro = Console.ReadLine();
            Console.Write("Insira o bairro:");
            string bairro = Console.ReadLine();
            Console.Write("Insira o numero:");
            int.TryParse(Console.ReadLine(), out int numero);
            Console.Write("Insira a cidade:");
            string cidade = Console.ReadLine();
            Console.Write("Insira o Estado:");
            string uf = Console.ReadLine();
            Console.Write("Insira o CEP:");
            string Cep = Console.ReadLine();

            return new Endereco(logradouro, bairro, numero, cidade, uf, Cep);
        }
    }
}
