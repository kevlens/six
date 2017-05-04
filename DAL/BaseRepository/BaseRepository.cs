using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using DAL;
using Common;
using Model;
using EntityFramework.Extensions;

namespace DAL
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class,new()
    {
        //<summary>
        //EF数据上下文
        //</summary>
        protected DbContext _db = new EFContextFactory().GetDbContext();
        //SxShEntities _db = new SxShEntities();

        #region 0.数据源
        public IQueryable<T> Entities
        {
            get
            {
                //return _db.Set<T>();
                return _db.Set<T>().AsNoTracking();

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
                using (DbContext _dbx = new Model.Entities())
                {
                    _dbx.Set<T>().Add(entity);
                    //_dbx.Configuration.ValidateOnSaveEnabled = false;
                    int count = _dbx.SaveChanges();
                    //_dbx.Configuration.ValidateOnSaveEnabled = true;
                    return count;
                }


                //DbSet<T> dst = _db.Set<T>();
                //dst.Add(entity);
                //return _db.SaveChanges();
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
                using (DbContext _dbx = new Model.Entities())
                {
                    foreach (T entity in entitys)
                    {
                        _dbx.Set<T>().Add(entity);
                    }
                    return _dbx.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 根据PKID主键删除实体
        /// <summary>
        ///  根据PKID主键删除实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int DeleteEntity(T entity)
        {
            try
            {
                _db.Set<T>().Attach(entity);
                _db.Entry<T>(entity).State = EntityState.Deleted;
                return _db.SaveChanges();
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
                //  List<T> pDels = _db.Set<T>().Where<T>(doWhere).ToList();
                ////List<T> pDels = _db.Set<T>().Where<T>(doWhere).AsQueryable();
                //  pDels.ForEach(
                //      //p => _db.Set<T>().Remove(p)
                //       p =>
                //       {
                //           _db.Entry<T>(p).State = EntityState.Detached;//oracle数据库没这一句不能修改
                //           _db.Set<T>().Attach(p);
                //          _db.Entry<T>(p).State = EntityState.Deleted;
                //       }
                //      );
                //  return _db.SaveChanges();



                int iret = -1;
                //Logger("根据条件删除" + typeof(T).Name + "中的数据", () =>
                //{
                using (DbContext _dbx = new Model.Entities())
                {
                    List<T> listDels = _dbx.Set<T>().Where(doWhere).ToList();

                    listDels.ForEach(d =>
                    {
                        _dbx.Set<T>().Attach(d);
                        _dbx.Set<T>().Remove(d);
                    });
                    iret = _dbx.SaveChanges();

                    //});
                }
                return iret;
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
                int iret = -1;

                using (DbContext _dbx = new Model.Entities())
                {
                    iret = BatchExtensions.Delete(_dbx.Set<T>().Where(doWhere));
                }
                return iret;
            }
            catch (Exception ex)
            {
                RecordLog.RecordWarn(ex.ToString());
                throw ex;
            }
        }
        #endregion

        #region 4.x扩展修改方法（把不须要修改的列用LAMBDA数组表示出来）
        /// <summary>
        /// 4.x扩展修改方法（把不须要修改的列用LAMBDA数组表示出来）
        /// </summary>
        /// <param name="model">要修改的实体对象</param>
        /// <param name="ignoreProperties">不须要修改的相关字段</param>
        /// <returns>受影响的行数</returns>
        public int UpdateEntity(T model, params Expression<Func<T, object>>[] ignoreProperties)
        {
            int iret = -1;

            //Logger("修改" + typeof(T).Name + "中的数据", () =>
            //{
            using (DbContext db = new Model.Entities()) //DBContextFactory().GetDbContext()
            {
                db.Entry<T>(model).State = EntityState.Detached;
                db.Set<T>().Attach(model);

                DbEntityEntry entry = db.Entry<T>(model);
                entry.State = System.Data.EntityState.Unchanged;

                Type t = typeof(T);
                List<PropertyInfo> proInfos = t.GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();

                Dictionary<string, PropertyInfo> dicPros = new Dictionary<string, PropertyInfo>();
                proInfos.ForEach(
                    p => dicPros.Add(p.Name, p)
                    );

                if (ignoreProperties != null)
                {
                    foreach (var ignorePropertyExpression in ignoreProperties)
                    {
                        //根据表达式得到对应的字段信息
                        var ignorePropertyName = new PropertyExpressionParser<T>(ignorePropertyExpression).Name;
                        dicPros.Remove(ignorePropertyName);
                    }
                }

                foreach (string proName in dicPros.Keys)
                {
                    entry.Property(proName).IsModified = true;
                }
                iret = db.SaveChanges();
            }
            return iret;
        }
        #endregion
        #region 修改实体
        /// <summary>
        /// 修改实
        /// </summary>
        /// <param name="entity">修改对象</param>
        /// <param name="pNas">要修改的属性名称集体</param>
        /// <returns></returns>
        public int UpdateEntity(T entity, params string[] pNas)
        {
            try
            {
                using (DbContext _dbx = new Model.Entities())
                {
                    _dbx.Entry<T>(entity).State = EntityState.Detached;//oracle数据库没这一句不能修改

                    DbEntityEntry upEntity = _dbx.Entry<T>(entity);
                    upEntity.State = System.Data.EntityState.Unchanged;
                    foreach (string pNa in pNas)
                    {
                        upEntity.Property(pNa).IsModified = true;
                    }
                    return _dbx.SaveChanges();
                }
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
                return _db.Set<T>().Where(doWhere).AsNoTracking().OrderBy(doOrder).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region 根据查询和排序条件以分页的方式检索集合
        /// <summary>
        /// 根据查询和排序条件以分页的方式检索集合
        /// </summary>
        /// <typeparam name="Tkey">排序字段的类型</typeparam>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="doWhere"></param>
        /// <param name="doOrder"></param>
        /// <returns></returns>
        public List<T> GetListPages<Tkey>(int pageIndex, int pageSize, Expression<Func<T, bool>> doWhere, Expression<Func<T, Tkey>> doOrder)
        {
            try
            {
                return _db.Set<T>().Where(doWhere).OrderBy(doOrder).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
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
            //EF5.0
            var temp = _db.Set<T>().Where<T>(doWhere);
            total = temp.Count(); //得到总的条数
            //排序,获取当前页的数据
            if (isAsc)//升序
            {
                temp = temp.OrderBy<T, Tkey>(doOrder)
                    .Skip<T>(pageSize * (pageIndex - 1)) //越过多少条
                    .Take<T>(pageSize).AsQueryable(); //取出多少条
            }
            else//降序
            {
                temp = temp.OrderByDescending<T, Tkey>(doOrder)
                    .Skip<T>(pageSize * (pageIndex - 1)) //越过多少条
                    .Take<T>(pageSize).AsQueryable(); //取出多少条
            }
            return temp.ToList();
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
                using (DbContext db = new Model.Entities()) //DBContextFactory().GetDbContext()
                {
                    //1.查询要修改的数据
                    List<T> listModifing = db.Set<T>().Where(dWhere).ToList();
                    //2.获取实体类对象
                    Type t = typeof(T);
                    //3.获取实体类的所有属性
                    List<PropertyInfo> pInfos = t.GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();
                    //4.创建一个实体属性的字典集合
                    Dictionary<string, PropertyInfo> dictPros = new Dictionary<string, PropertyInfo>();
                    //5.将实体属性中要修改的属性添加到字典集合中，健：属性名，值：属性对象
                    pInfos.ForEach(p =>
                    {
                        if (uProName.Contains(p.Name))
                        {
                            dictPros.Add(p.Name, p);
                        }
                    });
                    //6.循环要修改的属性名
                    foreach (string proName in uProName)
                    {
                        //如果存在则取出要修改的属性
                        PropertyInfo proInfo = dictPros[proName];
                        //取出要修改的值
                        object newValue = proInfo.GetValue(entity, null);
                        //批量设置要修改对象的属性
                        foreach (T su in listModifing)
                        {
                            //为要修改的对象属性设置新的值
                            proInfo.SetValue(su, newValue, null);
                        }

                    }
                    return db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        public T GetModel(string sql)
        {
            DataSet ds = new DataSet();
            using (var db = new Model.Entities())
            {
                return db.Set<T>().SqlQuery(sql).FirstOrDefault();
            }

        }
    }
}
