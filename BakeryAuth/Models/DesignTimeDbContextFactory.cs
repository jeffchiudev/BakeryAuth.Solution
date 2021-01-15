using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BakeryAuth.Models
{
    public class BakeryAuthContextFactory : IDesignTimeDbContextFactory<BakeryAuthContext>
    {

        BakeryAuthContext IDesignTimeDbContextFactory<BakeryAuthContext>.CreateDbContext(string[] args)
        {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<BakeryAuthContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        builder.UseMySql(connectionString);

        return new BakeryAuthContext(builder.Options);
        }
    }
}