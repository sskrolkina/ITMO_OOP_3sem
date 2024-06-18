using Npgsql;

namespace Lab5.DataAccess.Services.DataBaseConnectionHandler;

public class ConnectionHandler
{
   public ConnectionHandler(string connection)
   {
      DataSource = NpgsqlDataSource.Create(connection);
   }

   public NpgsqlDataSource DataSource { get; }
}