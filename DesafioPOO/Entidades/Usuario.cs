using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public abstract class Usuario
    {
        public Usuario(string login, string nome, string email, string telefone, string cpf, string senha)
        {
            Id = new Guid();
            Login = login;
            Senha = senha;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
        }

        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        public virtual bool EfetuarLogin(string login, string senha)
        {
            return false;
        }
    }
}
