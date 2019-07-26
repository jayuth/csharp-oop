using System;

namespace Composition
{
    // common behaviors/methods that are used by other classes
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DbMigrator
    {
        // to use composition, that class needs to pass a composition class object as an argumentand initialize it

        private readonly Logger _logger;

        // initialize the field
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating...");
        }
    }

    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing the application.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
