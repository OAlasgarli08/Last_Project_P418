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
        private static int _id = 1;

        public void Create(T entity)
        {
            entity.Id = _id;
            DbContext<T>.Datas.Add(entity);
            _id++;
        }

        public void Delete(T entity)
        {
            DbContext<T>.Datas.Remove(entity);
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return DbContext<T>.Datas.ToList();
        }

        public T GetById(int id)
        {
            return DbContext<T>.Datas.FirstOrDefault(d => d.Id == id);
        }
    }
}
