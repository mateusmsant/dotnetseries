using System.Collections.Generic;

namespace series.Interfaces

{
    public interface IRepository<T>
    {
         List<T> List();
         T ReturnById(int id);
         void Put(T entity);
         void Delete(int id);
         void Update(int id, T entity);
         int NextId();
    }
}