/*****************************************************
 * Author: 卢云海
 * Mail: lyh_oralce@hotmail.com
 * QQ: 1289927096
 * Date: 2017-04-20
 * **************************************************/
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Models;
using log4net;
using Common.Log;

namespace SqlServerDAL
{
    public class BaseDAL<T> : BaseLog<T>, IBaseDAL<T> where T : class,new()
    {
        DbContext db = new DBContextFactory().GetDbContext();

        #region 增加
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="model">要新增的实体</param>
        /// <returns>增加影响条数</returns>
        public int Add(T model)
        {
            int result = -1;
            Logger(string.Format("{0}_{1}", typeof(T).Name, System.Reflection.MethodBase.GetCurrentMethod().Name),
                ()=> {
                    db.Set<T>().Add(model);
                    result = db.SaveChanges();
                });
            return result;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model">要删除的实体</param>
        /// <returns>删除影响的条数</returns>
        public int Delete(T model)
        {
            int result = -1;
            Logger(string.Format("{0}_{1}", typeof(T).Name, System.Reflection.MethodBase.GetCurrentMethod().Name),
                () => {
                    db.Set<T>().Attach(model);
                    db.Set<T>().Remove(model);
                    result = db.SaveChanges();
                });
            return result;
        }
        #endregion

        #region 根据条件删除
        /// <summary>
        /// 根据条件删除实体
        /// </summary>
        /// <param name="where"></param>
        /// <returns>返回删除影响的条数</returns>
        public int DeleteBy(Expression<Func<T, bool>> where)
        {
            int result = -1;
            Logger(string.Format("{0}_{1}", typeof(T).Name, System.Reflection.MethodBase.GetCurrentMethod().Name),
                () => {
                    List<T> list = db.Set<T>().Where(where).ToList();
                    list.ForEach(p => {
                        db.Set<T>().Remove(p);
                    });
                    result =  db.SaveChanges();
                });
            return result;
        }
        #endregion

        #region 修改
        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="model">要修改的实体模型</param>
        /// <param name="proNames">要修改的属性数组</param>
        /// <returns>修改影响条数</returns>
        public int Modify(T model, params string[] proNames)
        {
            int result = -1;
            Logger(string.Format("{0}_{1}", typeof(T).Name, System.Reflection.MethodBase.GetCurrentMethod().Name),
                () => {
                    DbEntityEntry entry = db.Entry<T>(model);
                    entry.State = System.Data.EntityState.Unchanged;
                    foreach (var prop in proNames)
                    {
                        entry.Property(prop).IsModified = true;
                    }
                    result = db.SaveChanges();
                });
            return result;
        }
        #endregion

        #region 批量修改
        public int ModifyBy(T model, Expression<Func<T, bool>> where, params string[] proNames)
        {
            int result = -1;
            Logger(string.Format("{0}_{1}", typeof(T).Name, System.Reflection.MethodBase.GetCurrentMethod().Name),
                () => {
                    List<T> list = db.Set<T>().Where(where).ToList();
                    Type type = typeof(T);
                    List<PropertyInfo> listProperty = type.GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();
                    Dictionary<string, PropertyInfo> dicProperty = new Dictionary<string, PropertyInfo>();
                    listProperty.ForEach(p => {
                        if (proNames.Contains(p.Name))
                        {
                            dicProperty.Add(p.Name, p);
                        }
                    });
                    foreach (string proName in proNames)
                    {
                        if (dicProperty.ContainsKey(proName))
                        {
                            PropertyInfo prop = dicProperty[proName];
                            object newValue = prop.GetValue(model, null);
                            foreach (var item in list)
                            {
                                prop.SetValue(item, newValue, null);
                            }
                        }
                    }
                    result = db.SaveChanges();
                });
            return result;
        }
        #endregion

        #region 根据条件查询
        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>返回查询列表</returns>
        public List<T> QueryBy(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().Where(where).ToList();
        }
        #endregion

        #region 查询后排序
        /// <summary>
        /// 查询后排序
        /// </summary>
        /// <typeparam name="TKey">排序字段类型</typeparam>
        /// <param name="where">查询条件</param>
        /// <param name="orderBy">排序条件</param>
        /// <param name="isAsc">是否正序</param>
        /// <returns>返回查询列表</returns>
        public List<T> QueryBy<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy,bool isAsc = true)
        {
            if (isAsc)
                return db.Set<T>().Where(where).OrderBy(orderBy).ToList();
            else
                return db.Set<T>().Where(where).OrderByDescending(orderBy).ToList();
        }
        #endregion

        #region 分页查询
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="TKey">排序字段类型</typeparam>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页大小</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderBy">排序条件</param>
        /// <param name="isAsc">是否正序</param>
        /// <returns>返回查询列表</returns>
        public List<T> QueryBy<TKey>(int pageIndex, int pageSize, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, bool isAsc = true)
        {
            if (isAsc)
                return db.Set<T>().Where(where).OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            else
                return db.Set<T>().Where(where).OrderByDescending(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
        #endregion

        #region 分页查询返回并总条数
        /// <summary>
        /// 分页查询返回并总条数
        /// </summary>
        /// <typeparam name="TKey">排序字段类型</typeparam>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页大小</param>
        /// <param name="rowCount">总查询行数</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderBy">排序</param>
        /// <param name="isAsc">是否正序</param>
        /// <returns>返回查询列表</returns>
        public List<T> QueryBy<TKey>(int pageIndex, int pageSize, ref int rowCount, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, bool isAsc = true)
        {
            var listTotal = db.Set<T>().Where(where);
            rowCount = listTotal.Count();
            if (isAsc)
                return listTotal.OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            else
                return listTotal.OrderByDescending(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
        #endregion
    }
}
