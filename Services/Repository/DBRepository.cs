using ArdalanAraghi_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalanAraghi_CRUD.Services.Repository
{
    public class DBRepository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        DBCRUD db;
        public DBRepository()
        {
            db = new DBCRUD();
        }

        public bool Delete(TKey Id)
        {
            try
            {
                db.Remove(Find(Id));
                Save();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public TEntity Find(TKey Id)
        {
            return db.Find<TEntity>(Id);
        }

        public List<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TKey Insert(TEntity entity)
        {
            db.Add(entity);
            Save();
            return entity.Id;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool Update(TEntity entity)
        {
            try
            {
                db.Update(entity);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
