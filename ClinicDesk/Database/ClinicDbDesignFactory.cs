using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ClinicDesk.Database;

public class ClinicDbDesignFactory : IDesignTimeDbContextFactory<ClinicDb>
{
    public ClinicDb CreateDbContext(string[] args)
    {
        Settings.Initialize();
        return ClinicDb.Create();
    }
}