﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_exemplo_heranca
{
    class funcionario : pessoa_fisica
    {
        private string cartao;
        
        public void setCartao(string cartao)
        {
            this.cartao = cartao;
        }

        public string getCartao()
        {
            return this.cartao;
        }
    }
}
