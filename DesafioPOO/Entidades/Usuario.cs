﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Entidades
{
    public class Usuario
    {
        public Usuario(string login, string nome, string email, string telefone, string cpf)
        {
            Id = new Guid();
            Login = login;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
        }

        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
    }
}
