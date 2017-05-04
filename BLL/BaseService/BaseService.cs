using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAL;
using DAL;
using System.Data;

namespace BLL
{
    public abstract class BaseService<T> : IBaseService<T> where T : class,new()
    {

        //public IDbSession _DbSession = DbSessionFactory.GetCurrenntDbSession();//new DbSession();

        //初始化创建对象
        private IDBSession _DbSession;

        public IDBSession DbSession
        {
            get
            {
                if (_DbSession == null)
                {
                    IDBSessionFactory dbSessionFactory = new DBSessionFactory();// SpringHelper.GetObject<IDBSessionFactory>("DBSessionFactory");
                    _DbSession = dbSessionFactory.GetDbSession();
                }

                return _DbSession;
            }

        }


        public IBaseRepository<T> CurrentRepository { get; set; }

        public BaseService()
        {
            SetCurrentRepository();
        }
        public abstract void SetCurrentRepository();  //子类必须实现

        #region 0.数据源
        public IQueryable<T> Entities
        {
            get
            {
                return CurrentRepository.Entities;
            }

        }
        #endregion

        #region 新增实体
        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int AddEntity(T entity)
        {
            try
            {
                return CurrentRepository.AddEntity(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region 批量新增实体
        /// <summary>
        /// 批量新增实体
        /// </summary>
        /// <param name="entitys"></param>
        /// <returns></returns>
        public int AddListEntity(List<T> entitys)
        {
            try
            {
                return CurrentRepository.AddListEntity(entitys);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 根据PKID主键删除实体
        /// <summary>
        /// 根据PKID主键删除实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int DeleteEntity(T entity)
        {
            try
            {
                return CurrentRepository.DeleteEntity(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 根据条件 删除实体
        /// <summary>
        /// 根据条件 删除实体
        /// </summary>
        /// <param name="doWhere"></param>
        /// <returns></returns>
        public int DelByWhere(Expression<Func<T, bool>> doWhere)
        {
            try
            {
                return CurrentRepository.DelByWhere(doWhere);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 根据条件 删除实体--批量SQL删除
        /// <summary>
        /// 根据条件 删除实体
        /// </summary>
        /// <param name="doWhere"></param>
        /// <returns></returns>
        public int DelBySqlWhere(Expression<Func<T, bool>> doWhere)
        {
            try
            {
                return CurrentRepository.DelBySqlWhere(doWhere);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public int UpdateEntity(T entity, params Expression<Func<T, object>>[] ignoreProperties)
        {
            try
            {
                return CurrentRepository.UpdateEntity(entity, ignoreProperties);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region 修改实体
        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int UpdateEntity(T entity, params string[] pNas)
        {
            try
            {
                return CurrentRepository.UpdateEntity(entity, pNas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 批量修改
        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="dWhere"></param>
        /// <param name="uProName">要修改的列名</param>
        /// <returns></returns>
        public int UpdateListEntity(T entity, Expression<Func<T, bool>> dWhere, params string[] uProName)
        {
            try
            {
                return CurrentRepository.UpdateListEntity(entity, dWhere, uProName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 根据条件检索集合中的数据并排序
        /// <summary>
        /// 根据条件检索集合中的数据
        /// </summary>
        /// <param name="doWhere"></param>
        /// <param name="doOrder"></param>
        /// <returns></returns>
        public List<T> GetListByCondition<Tkey>(Expression<Func<T, bool>> doWhere, Expression<Func<T, Tkey>> doOrder)
        {
            try
            {
                return CurrentRepository.GetListByCondition<Tkey>(doWhere, doOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
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
        public List<T> GetListPages<Tkey>(int pageIndex, int pageSize, out int total, Expression<Func<T, bool>> doWhere,
                                                bool isAsc, Expression<Func<T, Tkey>> doOrder)
        {
            try
            {
                return CurrentRepository.GetListPages<Tkey>(pageIndex, pageSize, out total, doWhere, isAsc, doOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        public T GetModel(string sql)
        {
            return CurrentRepository.GetModel(sql);
            //  return null;
        }
    }
}
