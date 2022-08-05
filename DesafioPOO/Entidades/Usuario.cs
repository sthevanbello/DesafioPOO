using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    /// <summary>
    /// Classe Base para os usuários do sistema
    /// </summary>
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

        protected Guid Id { get; set; }
        protected string Login { get; set; }
        protected string Senha { get; private set; }
        protected string Nome { get; set; }
        protected string Email { get; set; }
        protected string Telefone { get; set; }
        protected string CPF { get; set; }

        /// <summary>
        /// Método base para efetuar login
        /// </summary>
        /// <returns>padrão de retorno é <b>false</b></returns>
        public virtual bool EfetuarLogin()
        {
            return false;
        }
    }
}
