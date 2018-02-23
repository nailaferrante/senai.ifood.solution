using System;
using System.Collections.Generic;
using senai.ifood.domain.Contracts;
using senai.ifood.repository.Context;

namespace senai.ifood.repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IFoodContext _dbContext;

        public BaseRepository (IFoodContext ifoodcontext)
        {
            _dbContext = ifoodcontext;
        }
        public int Atualizar(T dados)
        {
            try{
                _dbContext.Set<T>().Update(dados);
                return _dbContext.SaveChanges();
                }
            catch(System.Exception ex){
                throw new Exception (ex.Message);
            }
        }

        public T BuscarPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Deletar(T dados)
        {
            throw new System.NotImplementedException();
        }

        public int Inserir(T dados)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}