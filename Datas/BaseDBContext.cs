using Microsoft.EntityFrameworkCore;

namespace LazyPeopleAPI.Datas;

public class BaseDBContext :DbContext
{
    public BaseDBContext(DbContextOptions<BaseDBContext> options) : base(options) { }

    public DbSet<Project> Projects { get; set; }
}