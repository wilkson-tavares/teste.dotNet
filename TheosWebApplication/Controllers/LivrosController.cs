using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheosWebApplication.APP.Services;
using TheosWebApplication.APP.ViewModel;
using TheosWebApplication.Domain.Entities;

namespace TheosWebApplication.API.Controllers
{
    [Route("api")]
    public class LivrosController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        [Route("livros")]
        public IEnumerable<Livros> Get([FromServices] ContractLivrosApp contractLivrosApp)
        {
            try
            {
                return contractLivrosApp.GetLivros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        [HttpGet]
        [Route("livros/{id}")]
        public Livros Get(int id, [FromServices] ContractLivrosApp contractLivrosApp)
        {
            try
            {
                return contractLivrosApp.GetLivroById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("livros")]
        public Livros Post([FromBody] LivroViewModel livro, [FromServices] ContractLivrosApp contractLivrosApp)
        {
            try
            {
                return contractLivrosApp.Save(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
