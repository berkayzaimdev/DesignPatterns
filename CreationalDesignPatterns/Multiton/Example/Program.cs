var msSQL = Database.GetInstance("MSSQL");
var postgres = Database.GetInstance("PostgresSQL");
var oracle = Database.GetInstance("Oracle");

var msSQL2 = Database.GetInstance("MSSQL", "...");
var postgres2 = Database.GetInstance("PostgresSQL", "...");
var oracle2 = Database.GetInstance("Oracle", "...");    

msSQL.ConnectionString("...");
msSQL.Connection();

class Database
{
    private Database()
    {
        Console.WriteLine($"{nameof(Database)} nesnesi üretildi!");
    }

    static Dictionary<string, Database> _databases = new();

    public static Database GetInstance(string key)
    {
        if (_databases.ContainsKey(key))
        {
            _databases[key] = new Database();
        }

        return _databases[key];
    }

    string connectionString = "";

    public static Database GetInstance(string key, string connectionString)
    {
        Database database = GetInstance(key);

        database.ConnectionString(connectionString);
        return database;
    }

    public void Connection()
    {
        Console.WriteLine("Connected");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnected");
    }

    public void ConnectionString(string connectionString)
    {
        //
    }
}