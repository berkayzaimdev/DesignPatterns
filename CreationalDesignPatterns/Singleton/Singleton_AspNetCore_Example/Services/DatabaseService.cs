namespace Singleton_AspNetCore_Example.Services
{
    public class DatabaseService
    {
        DatabaseService()
        {
            Console.WriteLine($"{nameof(DatabaseService)} is created");
        }

        static DatabaseService databaseService;

        public static DatabaseService Instance 
        { 
            get
            {
                if (databaseService == null)
                {
                    databaseService = new DatabaseService();
                }
                return databaseService;
            } 
        }

        public int Count { get; set; }

        public bool Connection()
        {
            Console.WriteLine($"bağlantı sağlandı");
            Count++;
            return true;
        }

        public bool Disconnection()
        {
            Console.WriteLine($"bağlantı kesildi");

            return true;
        }
    }
}
