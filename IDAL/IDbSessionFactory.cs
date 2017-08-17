using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    #region 提取仓储对象的工程
    /// <summary>
    /// 提取仓储对象的工程
    /// </summary>
    public interface IDbSessionFactory
    {
        IDbSession GetDbSession();
    }
    #endregion
}
