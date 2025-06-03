using AppGestionClinica.Data;
using AppGestionClinica.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionClinica.Repository
{
    public class UsuarioRepository
    {
        private readonly SqlConnection _conn;
        public UsuarioRepository() => _conn = Database.GetConnection();

        public void Agregar(Usuario u)
        {
            const string sql = @"
                INSERT INTO Usuarios (Username,Password,Rol)
                VALUES (@Username,@Password,@Rol)";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@Username", u.Username);
            cmd.Parameters.AddWithValue("@Password", u.Password);
            cmd.Parameters.AddWithValue("@Rol", u.Rol);
            cmd.ExecuteNonQuery();
        }

        public void AgregarDoctor(Usuario u, int doctorId)
        {
            const string sql = @"
                INSERT INTO Usuarios (Username,Password,Rol,DoctorID)
                VALUES (@Username,@Password,@Rol,@DoctorID)";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@Username", u.Username);
            cmd.Parameters.AddWithValue("@Password", u.Password);
            cmd.Parameters.AddWithValue("@Rol", u.Rol);
            cmd.Parameters.AddWithValue("@DoctorID", doctorId);
            cmd.ExecuteNonQuery();
        }

        public Usuario ObtenerPorCredenciales(string user, string pass)
        {
            const string sql = "SELECT * FROM Usuarios WHERE Username=@u AND Password=@p";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@u", user);
            cmd.Parameters.AddWithValue("@p", pass);
            using var rdr = cmd.ExecuteReader();
            if (rdr.Read()) return new Usuario
            {
                UsuarioID = (int)rdr["UsuarioID"],
                Username = (string)rdr["Username"],
                Password = (string)rdr["Password"],
                Rol = (string)rdr["Rol"],
                DoctorID = rdr["DoctorID"] == DBNull.Value ? (int?)null : Convert.ToInt32(rdr["DoctorID"]) // Maneja DoctorID como nullable
            };
            return null;
        }

        public List<Usuario> ObtenerTodos()
        {
            var list = new List<Usuario>();
            const string sql = "SELECT * FROM Usuarios";
            using var cmd = new SqlCommand(sql, _conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Usuario
                {
                    UsuarioID = (int)rdr["UsuarioID"],
                    Username = (string)rdr["Username"],
                    Password = (string)rdr["Password"],
                    Rol = (string)rdr["Rol"],
                    DoctorID = rdr["DoctorID"] == DBNull.Value ? (int?)null : Convert.ToInt32(rdr["DoctorID"]) // Maneja DoctorID como nullable
                });
            }
            return list;
        }

        public void Actualizar(Usuario usuario)
        {
            const string sql = @"
            UPDATE Usuarios
            SET Username = @Username,
                Password = @Password,
                Rol = @Rol,
                DoctorID = @DoctorID
            WHERE UsuarioID = @UsuarioID";

            using var cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@Username", usuario.Username);
            cmd.Parameters.AddWithValue("@Password", usuario.Password);
            cmd.Parameters.AddWithValue("@Rol", usuario.Rol);

            // Usa DBNull si DoctorID es null
            if (usuario.DoctorID.HasValue)
                cmd.Parameters.AddWithValue("@DoctorID", usuario.DoctorID.Value);
            else
                cmd.Parameters.AddWithValue("@DoctorID", DBNull.Value);

            cmd.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID);
            cmd.ExecuteNonQuery();
        }


        public void Eliminar(int id)
        {
            const string sql = "DELETE FROM Usuarios WHERE UsuarioID=@id";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
