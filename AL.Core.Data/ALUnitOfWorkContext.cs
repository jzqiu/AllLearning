using AL.Component.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL.Core.Data
{
    /// <summary>
    ///     AL项目单元操作类
    /// </summary>
    public class ALUnitOfWorkContext : UnitOfWorkContextBase
    {
        /// <summary>
        ///     获取或设置 默认的AL项目数据访问上下文对象
        /// </summary>
        public ALDbContext ALDbContext { get; set; }

        /// <summary>
        ///     获取或设置 当前使用的数据访问上下文对象
        /// </summary>
        protected override System.Data.Entity.DbContext Context
        {
            get { return ALDbContext; }
        }
    }
}
