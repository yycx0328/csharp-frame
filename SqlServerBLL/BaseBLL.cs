using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using IBLL;
using IDAL;
using DI;

namespace SqlServerBLL
{
    public abstract class BaseBLL<T>: IBaseBLL<T> where T : class, new()
    {
        // EF上下文不能直接实例化，否则仓储层与业务层之间产生紧耦合
        protected IBaseDAL<T> idal;

        // 初始化仓储对象
        private IDbSession dbSession;
        public IDbSession DbSession
        {
            get
            {
                if (dbSession == null)
                {
                    IDbSessionFactory dbSessionFactory = SpringHelper.GetObject<IDbSessionFactory>("DbSessionFactory");
                    dbSession = dbSessionFactory.GetDbSession();
                }
                return dbSession;
            }
        }

        #region 增加
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="model">要新增的实体</param>
        /// <returns>增加影响条数</returns>
        public int Add(T model)
        {
            return idal.Add(model);
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
            return idal.Delete(model);
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
            return idal.DeleteBy(where);
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
            return idal.Modify(model, proNames);
        }
        #endregion

        #region 批量修改
        public int ModifyBy(T model, Expression<Func<T, bool>> where, params string[] proNames)
        {
            return idal.ModifyBy(model, where, proNames);
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
            return idal.QueryBy(where);
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
        public List<T> QueryBy<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, bool isAsc = true)
        {
            return idal.QueryBy<TKey>(where, orderBy, isAsc);
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
            return idal.QueryBy<TKey>(pageIndex, pageSize, where, orderBy, isAsc);
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
            return idal.QueryBy<TKey>(pageIndex, pageSize, ref rowCount, where, orderBy, isAsc);
        }
        #endregion
    }
}
