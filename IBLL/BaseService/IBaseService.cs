
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IBaseService<T> where T : class
    {
        #region 0.数据源
        IQueryable<T> Entities
        {
            get;
        }
        #endregion
        int AddEntity(T entity);
        int AddListEntity(List<T> entitys);
        int UpdateEntity(T model, params Expression<Func<T, object>>[] ignoreProperties);
        int UpdateEntity(T entity, params string[] pNas);
        int DeleteEntity(T entity);
        int DelByWhere(Expression<Func<T, bool>> doWhere);
        int DelBySqlWhere(Expression<Func<T, bool>> doWhere);
        List<T> GetListByCondition<Tkey>(Expression<Func<T, bool>> doWhere, Expression<Func<T, Tkey>> doOrder);
        List<T> GetListPages<Tkey>(int pageIndex, int pageSize, out int total, Expression<Func<T, bool>> doWhere,
                                                 bool isAsc, Expression<Func<T, Tkey>> doOrder);
        int UpdateListEntity(T entity, Expression<Func<T, bool>> dWhere, params string[] uProName);

        T GetModel(string sql);
    }
}
