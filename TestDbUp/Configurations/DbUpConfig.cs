using DbUp;
using System.Reflection;

namespace TestDbUp.Configurations
{
    public static class DbUpConfig
    {
        public static void InitDatabase()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Trusted_Connection=true;Initial Catalog=TestDbUp";
            var upgradeEngine = DeployChanges.To
                .SqlDatabase(connectionString)
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .LogToConsole()
                .Build();

            EnsureDatabase.For.SqlDatabase(connectionString);

            upgradeEngine.PerformUpgrade();

        }
    }
}
