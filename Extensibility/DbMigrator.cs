using System;


namespace Interfaces.Extensibility
{
    class DbMigrator 
    {
        private readonly ILogger logger;

        //Dependency Injection
        // Here the extensibility is achieved by injecting an interface
        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.LogInfo("Migrating started at " + DateTime.Now);
            logger.LogInfo("Migrating finished at " + DateTime.Now);
        }
    }
}
