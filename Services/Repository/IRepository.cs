using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalanAraghi_CRUD.Services.Repository
{
    public interface IRepository<TEntity, TKey>
        where TEntity: class, IEntity<TKey>
    {
        List<TEntity> GetAll();
        TEntity Find(TKey Id);
        bool Delete(TKey Id);
        TKey Insert(TEntity entity);
        bool Update(TEntity entity);
        void Save();
    }
}
