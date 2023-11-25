using Domain.Models;
using Repository.Datas;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepositroy<T> where T : BaseEntity
    {
        public void Create(T entity)
        {
            DbContext<T>.Datas.Add(entity);
        }

        public void Delete(T entity)
        {
            DbContext<T>.Datas.Remove(entity);
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll(T entity)
        {
            return DbContext<T>.Datas.ToList();
        }

        public T GetById(int id)
        {
            return DbContext<T>.Datas.FirstOrDefault(d => d.Id == id);
        }
    }
}
