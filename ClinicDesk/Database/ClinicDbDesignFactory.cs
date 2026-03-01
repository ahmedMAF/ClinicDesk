using Microsoft.EntityFrameworkCore.Design;

namespace ClinicDesk.Database;

public class ClinicDbDesignFactory : IDesignTimeDbContextFactory<ClinicDb>
{
    public ClinicDb CreateDbContext(string[] args)
    {
        Settings.Initialize();

        ClinicDb.GetDbServerType();

        if (!ClinicDb.Create(out ClinicDb? db))
            throw new Exception("Can't connect to MySQL.");

        return db!;
    }
}