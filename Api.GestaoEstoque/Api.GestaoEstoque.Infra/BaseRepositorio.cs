using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Api.GestaoEstoque.Infra
{
    public class BaseRepositorio : IDisposable
    {
        private readonly IConfiguration _configuration;
        protected SqlConnection _connection;

        public BaseRepositorio(IConfiguration configuration)
        {            
            _configuration = configuration;
        }

        protected SqlConnection Connection()
        {
            if (_connection == null)
             {
              _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
              _connection.Open();
             }
            else if (_connection.State == ConnectionState.Closed)
            {
              _connection.Open();
            }
          return _connection;
        }

        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }


    }
}
