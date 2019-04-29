using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TheosWebApplication.APP.Validators;
using TheosWebApplication.APP.ViewModel;
using TheosWebApplication.Domain.Entities;
using TheosWebApplication.Domain.Repositories;
using TheosWebApplication.Resources;

namespace TheosWebApplication.APP.Services
{
    public class ContractLivrosApp
    {
        private LivrosRepository _rep;

        public ContractLivrosApp(LivrosRepository livrosRepository)
        {
            _rep = livrosRepository;
        }

        private Livros CreateEntity(LivroViewModel requestViewModel)
        {
            return Mapper.Map<LivroViewModel, Livros>(requestViewModel);
        }

        private void MergeEntity(Livros entity, LivroViewModel viewModel)
        {
            entity.Nome = viewModel.Nome;
            entity.AutorId = viewModel.AutorId;
            entity.GeneroId = viewModel.GeneroId;
        }

        public IEnumerable<Livros> GetLivros()
        {
            return _rep.GetLivros();
        }

        public Livros GetLivroById(int id)
        {
            return _rep.GetLivroById(id);
        }

        public Livros Save(LivroViewModel livro)
        {
            try
            {
                var livroEntity = CreateEntity(livro);
                var validator = new LivrosValidator();
                if (validator.Valid(livroEntity))
                {
                    _rep.Save(livroEntity);
                }
                else
                {
                    throw new Exception(MessagesAPI.ObjetoLivroInvalido);
                }

                return livroEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Livros Update(LivroViewModel livro)
        {
            try
            {
                var validator = new LivrosValidator();
                var livroEntity = _rep.GetLivroById(livro.Id);
                if (livroEntity == null)
                    throw new KeyNotFoundException();

                MergeEntity(livroEntity, livro);
                if (validator.Valid(livroEntity))
                {
                    _rep.Update(livroEntity);

                }
                return livroEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
