using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL.Core.Data
{
    /// <summary>
    /// 数据库初始化策略
    /// </summary>
    public class SampleData : CreateDatabaseIfNotExists<ALDbContext>
    {
        protected override void Seed(ALDbContext context)
        {
            
        }
    }
}
