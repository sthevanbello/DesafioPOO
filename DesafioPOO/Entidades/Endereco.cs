using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class Endereco
    {
        public Endereco(string logradouro, string bairro, int numero, string cidade, string uf, string cep)
        {
            Logradouro = logradouro;
            Bairro = bairro;
            Numero = numero;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;
        }

        private string Logradouro { get; set; }
        private string Bairro { get; set; }
        private int Numero { get; set; }
        private string Cidade { get; set; }
        private string Uf { get; set; }
        private string Cep { get; set; }

        public override string ToString()
        {
            return $"\nLogradouro: {Logradouro}\nBairro: {Bairro}\nNumero: {Numero}\nCidade: {Cidade}\nEstado: {Uf}\nCep:{Cep}\n";
        }
    }

    
}
