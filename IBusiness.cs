using System;
using System.Collections.Generic;

namespace Implanta.Common
{
    public interface IBusiness<TEntity, TFilterEntity>
        where TEntity : BaseEntity, new()
        where TFilterEntity : BaseFilterEntity, new()
    {
        TEntity BuscarRegistro(Guid id);
        List<TEntity> BuscarRegistros(TFilterEntity filtro);
        Operacao<TEntity> Salvar(Operacao<TEntity> operacao);
        Operacao<List<TEntity>> SalvarLista(Operacao<List<TEntity>> operacao);
    }

}
