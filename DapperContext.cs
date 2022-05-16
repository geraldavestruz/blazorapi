using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace blazorapi
{
    public class DapperContext
    {

        private readonly IConfiguration _config;
        private readonly string _connectionString;
        public IDbConnection CreateConnection() => new SQLiteConnection(_connectionString);
        public DapperContext(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("DefaultConnection");
        }
        
    }
}