using MySql.Data.MySqlClient;
using System.Data;

namespace DBConnection_CiberInfra_Master.git
{
	public partial class Form1 : Form
	{
		public Form1()
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
