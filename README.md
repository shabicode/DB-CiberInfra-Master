# DBConnection-CiberInfra

**Monica Martinez**  
Maestría en Cómputo Aplicado — Materia: Ciberinfraestructura

---

##  Descripción

Aplicación de escritorio desarrollada en **C# Windows Forms** que establece conexión a una base de datos **MySQL** de forma asíncrona y muestra los datos en un `DataGridView`. Permite conectarse tanto a un servidor local como a uno en la nube (AWS).


---

## Código fuente

### `DatabaseService.cs`

Clase responsable de construir la cadena de conexión y ejecutar la consulta a la base de datos de forma asíncrona.
```csharp
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

```

### `Form1.cs`

Formulario principal que recibe los datos de conexión del usuario y los pasa al `DatabaseService`.
```csharp
using MySql.Data.MySqlClient;
using System.Data;

namespace DBConnection_CiberInfra_Master.git
{
	public partial class Connection : Form
	{
		public Connection()
		{
			InitializeComponent();
			txtHost.Text = "localhost";
			txtPuerto.Text = "3306";
		}

		private async void btnConectar_Click(object sender, EventArgs e)
		{

			try
			{
				var dbService = new DatabaseService(
					txtHost.Text.Trim(),
					txtPuerto.Text.Trim(),
					txtBaseDatos.Text.Trim(),
					txtUsuario.Text.Trim(),
					txtContrasena.Text
				);

				var datos = await dbService.GetDataAsync("CatPersonal");
				dataGridView1.DataSource = datos;

				MessageBox.Show("Conexion exitosa", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}

```

---

##  Escenarios  
### Escenario 1 — Conexión local (localhost)

Conexión a una instancia de MySQL corriendo localmente en la máquina.
<img width="855" height="452" alt="image" src="https://github.com/user-attachments/assets/7ce532d8-8798-4ac1-9932-1330eace1bd7" />

 

 
---

### Escenario 2 — Conexión remota (AWS RDS)

Conexión a una instancia de MySQL alojada en **Amazon RDS**.

<img width="800" height="445" alt="image" src="https://github.com/user-attachments/assets/af91c5cd-e639-43b7-9405-c23c9a981c4e" />

---

##   Requisitos

- Visual Studio 2026
- .NET 8
- Paquete NuGet: `MySql.Data`
- MySQL Server (local o instancia AWS RDS)

--- 
 
 
