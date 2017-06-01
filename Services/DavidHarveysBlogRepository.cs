using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace davidharveysblog.Services
{
    public class DavidHarveysBlogRepository : EntityFrameworkReadOnlyRepository<DavidHarveysBlogContext>
    {
        public DavidHarveysBlogRepository(DavidHarveysBlogContext context)
            : base(context)
        {
        }
    }
}
