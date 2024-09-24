using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Lab05_Arcos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Boton01_Click(object sender, RoutedEventArgs e)
        {
            string cadena = "Server=DESKTOP-SRDOPL1\\SQLEXPRESS; Database=Neptuno05; user id=joseArcos; Password=David2023-";
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();

            SqlCommand command = new SqlCommand("ListarClientes01", connection);
            command.CommandType = CommandType.StoredProcedure;

            List<Cliente> listaClientes = new List<Cliente>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Cliente Cliente = new Cliente();
                Cliente.IdCliente = reader["idCliente"].ToString();
                Cliente.NombreCompania= reader["NombreCompania"].ToString();
                Cliente.NombreContacto = reader["NombreContacto"].ToString();
                Cliente.CargoContacto = reader["CargoContacto"].ToString();
                Cliente.Direccion = reader["Direccion"].ToString();
                Cliente.Ciudad = reader["Ciudad"].ToString();
                Cliente.Region= reader["Region"].ToString();
                Cliente.CodigoPostal = reader["CodPostal"].ToString();
                Cliente.Pais = reader["Pais"].ToString();
                Cliente.Telefono= reader["Telefono"].ToString();
                Cliente.Fax = reader["Fax"].ToString();
                listaClientes.Add(Cliente);

            }

            connection.Close();

            dgClientes.ItemsSource = listaClientes;
        }

        private void Boton02_Click(object sender, RoutedEventArgs e)
        {
            string cadena = "Server=DESKTOP-SRDOPL1\\SQLEXPRESS; Database=Neptuno05; user id=joseArcos; Password=David2023-";
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();

            SqlCommand command = new SqlCommand("InsertarClientes01", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlIdCliente = new SqlParameter("@idCliente", SqlDbType.VarChar, 5);
            sqlIdCliente.Value = txt01.Text;
            SqlParameter sqlNombreCompania = new SqlParameter("@NombreCompania", SqlDbType.VarChar, 100);
            sqlNombreCompania.Value = txt02.Text;
            SqlParameter sqlNombreContacto = new SqlParameter("@NombreContacto ", SqlDbType.VarChar, 100);
            sqlNombreContacto.Value = txt03.Text;
            SqlParameter sqlCargoContacto = new SqlParameter("@CargoContacto", SqlDbType.VarChar, 100);
            sqlCargoContacto.Value = txt04.Text;
            SqlParameter sqlDireccion = new SqlParameter("@Direccion", SqlDbType.VarChar, 100);
            sqlDireccion.Value = txt05.Text;
            SqlParameter sqlCiudad= new SqlParameter("@Ciudad", SqlDbType.VarChar, 100);
            sqlCiudad.Value = txt06.Text;
            SqlParameter sqlRegion = new SqlParameter("@Region", SqlDbType.VarChar, 100);
            sqlRegion.Value = txt07.Text;
            SqlParameter sqlCodPostal = new SqlParameter("@CodPostal", SqlDbType.VarChar, 100);
            sqlCodPostal.Value = txt08.Text;
            SqlParameter sqlPais = new SqlParameter("@Pais", SqlDbType.VarChar, 100);
            sqlPais.Value = txt09.Text;
            SqlParameter sqlTelefono = new SqlParameter("@Telefono", SqlDbType.VarChar, 100);
            sqlTelefono.Value = txt10.Text;
            SqlParameter sqlFax = new SqlParameter("@Fax", SqlDbType.VarChar, 100);
            sqlFax.Value = txt11.Text;


            command.Parameters.Add(sqlIdCliente);
            command.Parameters.Add(sqlNombreCompania);
            command.Parameters.Add(sqlNombreContacto);
            command.Parameters.Add(sqlCargoContacto);
            command.Parameters.Add(sqlDireccion);
            command.Parameters.Add(sqlCiudad);
            command.Parameters.Add(sqlRegion);
            command.Parameters.Add(sqlCodPostal);
            command.Parameters.Add(sqlPais);
            command.Parameters.Add(sqlTelefono);
            command.Parameters.Add(sqlFax);


            command.ExecuteNonQuery();

            MessageBox.Show("Registro Exitoso");

        
        }

        private void Boton03_Click(object sender, RoutedEventArgs e)
        {
            string cadena = "Server=DESKTOP-SRDOPL1\\SQLEXPRESS; Database=Neptuno05; user id=joseArcos; Password=David2023-";
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();

            SqlCommand command = new SqlCommand("ModificarClientes01", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlIdCliente = new SqlParameter("@idCliente", SqlDbType.VarChar, 5);
            sqlIdCliente.Value = txt01.Text;
            SqlParameter sqlNombreCompania = new SqlParameter("@NombreCompania", SqlDbType.VarChar, 100);
            sqlNombreCompania.Value = txt02.Text;
            SqlParameter sqlNombreContacto = new SqlParameter("@NombreContacto ", SqlDbType.VarChar, 100);
            sqlNombreContacto.Value = txt03.Text;
            SqlParameter sqlCargoContacto = new SqlParameter("@CargoContacto", SqlDbType.VarChar, 100);
            sqlCargoContacto.Value = txt04.Text;
            SqlParameter sqlDireccion = new SqlParameter("@Direccion", SqlDbType.VarChar, 100);
            sqlDireccion.Value = txt05.Text;
            SqlParameter sqlCiudad = new SqlParameter("@Ciudad", SqlDbType.VarChar, 100);
            sqlCiudad.Value = txt06.Text;
            SqlParameter sqlRegion = new SqlParameter("@Region", SqlDbType.VarChar, 100);
            sqlRegion.Value = txt07.Text;
            SqlParameter sqlCodPostal = new SqlParameter("@CodPostal", SqlDbType.VarChar, 100);
            sqlCodPostal.Value = txt08.Text;
            SqlParameter sqlPais = new SqlParameter("@Pais", SqlDbType.VarChar, 100);
            sqlPais.Value = txt09.Text;
            SqlParameter sqlTelefono = new SqlParameter("@Telefono", SqlDbType.VarChar, 100);
            sqlTelefono.Value = txt10.Text;
            SqlParameter sqlFax = new SqlParameter("@Fax", SqlDbType.VarChar, 100);
            sqlFax.Value = txt11.Text;

            command.Parameters.Add(sqlIdCliente);
            command.Parameters.Add(sqlNombreCompania);
            command.Parameters.Add(sqlNombreContacto);
            command.Parameters.Add(sqlCargoContacto);
            command.Parameters.Add(sqlDireccion);
            command.Parameters.Add(sqlCiudad);
            command.Parameters.Add(sqlRegion);
            command.Parameters.Add(sqlCodPostal);
            command.Parameters.Add(sqlPais);
            command.Parameters.Add(sqlTelefono);
            command.Parameters.Add(sqlFax);

            command.ExecuteNonQuery();
            
            MessageBox.Show("Modificación Exitosa");
        }

        private void Boton04_Click(object sender, RoutedEventArgs e)
        {
            string cadena = "Server=DESKTOP-SRDOPL1\\SQLEXPRESS; Database=Neptuno05; user id=joseArcos; Password=David2023-";
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();

            SqlCommand command = new SqlCommand("BorrarClientes01", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlIdCliente = new SqlParameter("@idCliente", SqlDbType.VarChar, 5);
            sqlIdCliente.Value = txt01.Text;

            command.Parameters.Add(sqlIdCliente);

            command.ExecuteNonQuery() ;

            MessageBox.Show("Fila eliminada");

        }
    }
}
