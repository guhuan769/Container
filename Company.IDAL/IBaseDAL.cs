using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Company.IDAL
{
    public partial interface IBaseDAL<T> where T:class,new()
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        IQueryable<T> GetModels(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> GetModelsByPage<type>(int pageSize, int pageIndex, bool isAsc, Expression<Func<T, type>> orderByLamdba, Expression<Func<T, bool>> whereLambda);

        bool SaveChanges();
    }
}
