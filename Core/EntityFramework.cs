using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core
{
    public class EntityFramework<T, Connect> : IEntityFrameworkBase<T> where Connect:DbContext,new()
     where T:class, IEntity,new()
    {
        public void Add(T Entity)
        {
            using (Connect connect=new Connect())
            {
               
                var result = connect.Entry(Entity);
                result.State = EntityState.Added;
                connect.SaveChanges();
              
            }
        }

        public void Delete(T Entity)
        {
            using (Connect connect = new Connect())
            {
                var result = connect.Entry(Entity);
                result.State = EntityState.Deleted;
                connect.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (Connect connect = new Connect())
            {
                return connect.Set<T>().SingleOrDefault(filter);
            }

        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (Connect connect = new Connect())
            {
                return filter == null ? connect.Set<T>().ToList() : connect.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T Entity)
        {
            using (Connect connect = new Connect())
            {
                var result = connect.Entry(Entity);
                result.State = EntityState.Modified;
                connect.SaveChanges();
            }
        }
    }
}
