namespace SQLScriptExecuteInDB.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SQLScriptExecuteInDB.DB.ApplicationDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SQLScriptExecuteInDB.DB.ApplicationDBContext context)
        {
            //  This method will be called after migrating to the latest version
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method

            base.Seed(context);
        }
    }
}
