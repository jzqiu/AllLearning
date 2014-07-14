using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AL.Component.Data;
using AL.Component.Tools;
using AL.Core.Data;

namespace AL.Core
{
    public abstract class BaseService<T> where T:Entity
    {
        public EFRepositoryBase<T> repository { get; set; }
        public ALUnitOfWorkContext unit { get; set; }

        public BaseService()
        {
            unit = new ALUnitOfWorkContext();
            repository = new EFRepositoryBase<T>
            {
                UnitOfWork = unit
            };
        }
    }
}
