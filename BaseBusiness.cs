using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Implanta.Common
{
    public abstract class BaseBusiness<TEntity, TFilterEntity, TData> : IBusiness<TEntity, TFilterEntity>
        where TEntity : BaseEntity, new()
        where TFilterEntity : BaseFilterEntity, new()
        where TData : class, new()
    {
        public virtual TEntity BuscarRegistro(Guid id)
        {
            var filtro = new TFilterEntity
            {
                Id = id
            };

            return BuscarRegistros(filtro).FirstOrDefault();
        }

        public abstract List<TEntity> BuscarRegistros(TFilterEntity filtro);

        public Operacao<TEntity> Salvar(Operacao<TEntity> operacao)
        {
            var operacaoLista = new Operacao<List<TEntity>>
            {
                Entidade = new List<TEntity> { operacao.Entidade }
            };

            operacaoLista = SalvarLista(operacaoLista);
            operacao.AdicionarErro(operacaoLista);

            return operacao;
        }

        public abstract Operacao<List<TEntity>> SalvarLista(Operacao<List<TEntity>> operacao);

        protected virtual ActionReturn SalvarListaEntidade<TDb>(ICollection<TEntity> entities, TDb context)
        {
            var result = new ActionReturn();

            try
            {
                if (context is DbContext dbContext)
                {
                    entities.Where(w => w.Acao == EntityAction.Delete).ToList().ForEach(entity =>
                    {
                        TData data = new TData();
                        PropertyCopy.Copy(entity, data);
                        dbContext.Entry(data).State = EntityState.Deleted;
                    });

                    entities.Where(w => w.Acao == EntityAction.New).ToList().ForEach(entity =>
                    {
                        TData data = new TData();
                        PropertyCopy.Copy(entity, data);
                        dbContext.Entry(data).State = EntityState.Added;
                    });

                    entities.Where(w => w.Acao == EntityAction.Update).ToList().ForEach(entity =>
                    {
                        TData data = new TData();
                        PropertyCopy.Copy(entity, data);
                        dbContext.Entry(data).State = EntityState.Modified;
                    });

                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                result.AdicionarErro(ex.Message);
            }

            return result;
        }
    }

}
