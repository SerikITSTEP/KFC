using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary
{
    public class KFCDbContext : DbContext
    {
        public KFCDbContext()
            : base(@"Server=1203_02PC\SQLEXPRESS120302;Database=KFCDbContext;Trusted_Connection=True;")
        {
        }

        //

    }
}
