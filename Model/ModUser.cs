﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softPrice.Model
{
    class ModUser
    {
        private int id;
        private String nome;
        private String email;
        private String senha;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getSenha()
        {
            return senha;
        }

        public void setSenha(String senha)
        {
            this.senha = senha;
        }


    }
}

