/*****************************************************
 * Author: 卢云海
 * Mail: lyh_oralce@hotmail.com
 * QQ: 1289927096
 * Date: 2017-04-20
 * **************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IBaseDAL<T>
    {
        #region 增加
        int Add(T model); 
        #endregion

        #region 删除
        int Delete(T model); 
        #endregion

        #region 根据条件删除
        int DeleteBy(Expression<Func<T, bool>> where); 
        #endregion

        #region 修改
        int Modify(T model, params string[] proNames); 
        #endregion

        #region 批量修改
        int ModifyBy(T model, Expression<Func<T, bool>> where, params string[] proNames); 
        #endregion

        #region 根据条件查询
        List<T> QueryBy(Expression<Func<T, bool>> where); 
        #endregion

        #region 查询后排序
        List<T> QueryBy<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, bool isAsc = true); 
        #endregion

        #region 分页查询
        List<T> QueryBy<TKey>(int pageIndex, int pageSize, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, bool isAsc = true); 
        #endregion

        #region 分页查询返回并总条数
        List<T> QueryBy<TKey>(int pageIndex, int pageSize, ref int rowCount, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, bool isAsc = true);
        #endregion
    }
}
