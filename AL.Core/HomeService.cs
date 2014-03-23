using AL.Component.Data;
using AL.Core.Data;
using AL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AL.Core
{
    public class HomeService
    {
        private EFRepositoryBase<TestTable> repository { get; set; }
        private ALUnitOfWorkContext unit { get; set; }

        public HomeService()
        {
            unit = new ALUnitOfWorkContext();
            repository = new EFRepositoryBase<TestTable>
            {
                UnitOfWork = unit
            };
        }

        public List<TestTable> Test()
        {
            return repository.Entities.ToList();
        }
    }
}
