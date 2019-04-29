using System;
using System.Collections.Generic;
using System.Text;
using TheosWebApplication.Domain.Entities;

namespace TheosWebApplication.APP.Validators
{
    public class LivrosValidator
    {
        public bool Valid(Livros livro)
        {
            var valid = true;

            if (string.IsNullOrEmpty(livro.Nome)) valid = false;
            
            return valid;
        }
    }
}
