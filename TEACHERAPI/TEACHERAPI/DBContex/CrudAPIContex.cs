using TEACHERAPI.Model.Entyties;
using Microsoft.EntityFrameworkCore;

namespace TEACHERAPI.DBContex
{
    public class TEACHERContext: DbContext
    {
        public TEACHERContext(DbContextOptions<TEACHERContext> options) : base(options)
        {
        }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
