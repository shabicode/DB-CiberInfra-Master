using MySql.Data.MySqlClient;
using System.Data;

namespace DBConnection_CiberInfra_Master.git
{
	public class DatabaseService
	{
		private readonly string _connectionString;

		public DatabaseService(string host, string port, string database, string user, string password)
		{
			_connectionString = $"Server={host};Port={port};Database={database};Uid={user};Pwd={password};";
		}

		public async Task<DataTable> GetDataAsync(string tableName)
		{
			using var connection = new MySqlConnection(_connectionString);
			await connection.OpenAsync();

			string query = $"SELECT * FROM {tableName}";
			using var adapter = new MySqlDataAdapter(query, connection);
			
			var dataTable = new DataTable();
			adapter.Fill(dataTable);
			
			return dataTable;
		} 
	}
}
