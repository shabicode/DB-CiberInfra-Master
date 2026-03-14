namespace DBConnection_CiberInfra_Master.git
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblUsuario = new Label();
			txtUsuario = new TextBox();
			lblContrasena = new Label();
			txtContrasena = new TextBox();
			lblHost = new Label();
			txtHost = new TextBox();
			lblBaseDatos = new Label();
			txtBaseDatos = new TextBox();
			lblPuerto = new Label();
			txtPuerto = new TextBox();
			btnConectar = new Button();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// lblUsuario
			// 
			lblUsuario.AutoSize = true;
			lblUsuario.Location = new Point(50, 135);
			lblUsuario.Name = "lblUsuario";
			lblUsuario.Size = new Size(47, 15);
			lblUsuario.TabIndex = 0;
			lblUsuario.Text = "Usuario";
			// 
			// txtUsuario
			// 
			txtUsuario.Location = new Point(113, 132);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.Size = new Size(180, 23);
			txtUsuario.TabIndex = 1;
			// 
			// lblContrasena
			// 
			lblContrasena.AutoSize = true;
			lblContrasena.Location = new Point(32, 164);
			lblContrasena.Name = "lblContrasena";
			lblContrasena.Size = new Size(67, 15);
			lblContrasena.TabIndex = 2;
			lblContrasena.Text = "Contraseña";
			// 
			// txtContrasena
			// 
			txtContrasena.Location = new Point(113, 161);
			txtContrasena.Name = "txtContrasena";
			txtContrasena.PasswordChar = '●';
			txtContrasena.Size = new Size(180, 23);
			txtContrasena.TabIndex = 3;
			// 
			// lblHost
			// 
			lblHost.AutoSize = true;
			lblHost.Location = new Point(56, 193);
			lblHost.Name = "lblHost";
			lblHost.Size = new Size(32, 15);
			lblHost.TabIndex = 4;
			lblHost.Text = "Host";
			// 
			// txtHost
			// 
			txtHost.Location = new Point(113, 190);
			txtHost.Name = "txtHost";
			txtHost.Size = new Size(180, 23);
			txtHost.TabIndex = 5;
			// 
			// lblBaseDatos
			// 
			lblBaseDatos.AutoSize = true;
			lblBaseDatos.Location = new Point(28, 222);
			lblBaseDatos.Name = "lblBaseDatos";
			lblBaseDatos.Size = new Size(79, 15);
			lblBaseDatos.TabIndex = 6;
			lblBaseDatos.Text = "Base de datos";
			// 
			// txtBaseDatos
			// 
			txtBaseDatos.Location = new Point(113, 219);
			txtBaseDatos.Name = "txtBaseDatos";
			txtBaseDatos.Size = new Size(180, 23);
			txtBaseDatos.TabIndex = 7;
			// 
			// lblPuerto
			// 
			lblPuerto.AutoSize = true;
			lblPuerto.Location = new Point(56, 277);
			lblPuerto.Name = "lblPuerto";
			lblPuerto.Size = new Size(42, 15);
			lblPuerto.TabIndex = 8;
			lblPuerto.Text = "Puerto";
			// 
			// txtPuerto
			// 
			txtPuerto.Location = new Point(113, 274);
			txtPuerto.Name = "txtPuerto";
			txtPuerto.Size = new Size(180, 23);
			txtPuerto.TabIndex = 9;
			// 
			// btnConectar
			// 
			btnConectar.Location = new Point(130, 327);
			btnConectar.Name = "btnConectar";
			btnConectar.Size = new Size(95, 28);
			btnConectar.TabIndex = 10;
			btnConectar.Text = "Conectar";
			btnConectar.UseVisualStyleBackColor = true;
			btnConectar.Click += btnConectar_Click;
			btnConectar.Click += btnConectar_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(315, 62);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(460, 280);
			dataGridView1.TabIndex = 11;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridView1);
			Controls.Add(btnConectar);
			Controls.Add(txtPuerto);
			Controls.Add(lblPuerto);
			Controls.Add(txtBaseDatos);
			Controls.Add(lblBaseDatos);
			Controls.Add(txtHost);
			Controls.Add(lblHost);
			Controls.Add(txtContrasena);
			Controls.Add(lblContrasena);
			Controls.Add(txtUsuario);
			Controls.Add(lblUsuario);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblUsuario;
		private TextBox txtUsuario;
		private Label lblContrasena;
		private TextBox txtContrasena;
		private Label lblHost;
		private TextBox txtHost;
		private Label lblBaseDatos;
		private TextBox txtBaseDatos;
		private Label lblPuerto;
		private TextBox txtPuerto;
		private Button btnConectar;
		private DataGridView dataGridView1;
	}
}
