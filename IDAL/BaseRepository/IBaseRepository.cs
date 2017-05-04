
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IBaseRepository<T> where T : class
    {
        #region 0.数据源
        IQueryable<T> Entities
        {
            get;
        }
        #endregion

        #region 新增实体
        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int AddEntity(T entity);
        #endregion

        #region 批量新增实体
        /// <summary>
        /// 批量新增实体
        /// </summary>
        /// <param name="entitys"></param>
        /// <returns></returns>
        int AddListEntity(List<T> entitys);
        #endregion

        #region 根据PKID主键删除实体
        /// <summary>
        ///  删除实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int DeleteEntity(T entity);
        #endregion


        #region 根据条件 删除实体
        /// <summary>
        /// 根据条件 删除实体
        /// </summary>
        /// <param name="doWhere"></param>
        /// <returns></returns>
        int DelByWhere(Expression<Func<T, bool>> doWhere);
        #endregion


        #region 根据条件 删除实体--批量SQL删除
        /// <summary>
        /// 根据条件 删除实体
        /// </summary>
        /// <param name="doWhere"></param>
        /// <returns></returns>
        int DelBySqlWhere(Expression<Func<T, bool>> doWhere);
        #endregion

        int UpdateEntity(T model, params Expression<Func<T, object>>[] ignoreProperties);

        #region 修改实体
        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="entity">修改对象</param>
        /// <param name="pNas">要修改的属性名称集体</param>
        /// <returns></returns>
        int UpdateEntity(T entity, params string[] pNas);
        #endregion

        #region 根据条件检索集合中的数据并排序
        /// <summary>
        /// 根据条件检索集合中的数据
        /// </summary>
        /// <param name="doWhere"></param>
        /// <param name="doOrder"></param>
        /// <returns></returns>
        List<T> GetListByCondition<Tkey>(Expression<Func<T, bool>> doWhere, Expression<Func<T, Tkey>> doOrder);
        #endregion

        #region 根据查询和排序条件以分页的方式检索集合
        /// <summary>
        /// 实现对数据的分页查询
        /// </summary>
        /// <typeparam name="Tkey">按照某个类进行排序</typeparam>
        /// <param name="pageIndex">当前第几页</param>
        /// <param name="pageSize">一页显示多少条数据</param>
        /// <param name="total">总条数</param>
        /// <param name="doWhere">取得排序的条件</param>
        /// <param name="isAsc">如何排序，根据true升序false倒序</param>
        /// <param name="doOrder">根据那个字段进行排序</param>
        /// <returns>返回一个实体类型的List集合</returns>
        List<T> GetListPages<Tkey>(int pageIndex, int pageSize, out int total, Expression<Func<T, bool>> doWhere,
                                                bool isAsc, Expression<Func<T, Tkey>> doOrder);
        #endregion


        #region 批量修改
        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="dWhere"></param>
        /// <param name="uProName">要修改的列名</param>
        /// <returns></returns>
        int UpdateListEntity(T entity, Expression<Func<T, bool>> dWhere, params string[] uProName);
        #endregion

        T GetModel(string sql);
    }
}
