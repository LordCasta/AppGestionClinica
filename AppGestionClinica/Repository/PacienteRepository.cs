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
    public class PacienteRepository : Interfaces.IPacienteRepository
    {
        private readonly SqlConnection _conn;
        public PacienteRepository() => _conn = Database.GetConnection();

        public void Agregar(Paciente p)
        {
            const string sql = @"
                INSERT INTO Pacientes (Nombre, Apellido, FechaNacimiento, Direccion, Telefono)
                VALUES (@Nombre,@Apellido,@FechaNacimiento,@Direccion,@Telefono)";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", p.Apellido);
            cmd.Parameters.AddWithValue("@FechaNacimiento", p.FechaNacimiento);
            cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
            cmd.ExecuteNonQuery();
        }

        public List<Paciente> ObtenerTodos()
        {
            var list = new List<Paciente>();
            const string sql = "SELECT * FROM Pacientes";
            using var cmd = new SqlCommand(sql, _conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Paciente
                {
                    PacienteID = (int)rdr["PacienteID"],
                    Nombre = (string)rdr["Nombre"],
                    Apellido = (string)rdr["Apellido"],
                    FechaNacimiento = (DateTime)rdr["FechaNacimiento"],
                    Direccion = (string)rdr["Direccion"],
                    Telefono = (string)rdr["Telefono"]
                });
            }
            return list;
        }

        public Paciente ObtenerPorId(int id)
        {
            const string sql = "SELECT * FROM Pacientes WHERE PacienteID=@id";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var rdr = cmd.ExecuteReader();
            if (rdr.Read()) return new Paciente
            {
                PacienteID = (int)rdr["PacienteID"],
                Nombre = (string)rdr["Nombre"],
                Apellido = (string)rdr["Apellido"],
                FechaNacimiento = (DateTime)rdr["FechaNacimiento"],
                Direccion = (string)rdr["Direccion"],
                Telefono = (string)rdr["Telefono"]
            };
            return null;
        }

        public void Actualizar(Paciente p)
        {
            const string sql = @"
                UPDATE Pacientes
                SET Nombre=@Nombre, Apellido=@Apellido, FechaNacimiento=@FechaNacimiento,
                    Direccion=@Direccion, Telefono=@Telefono
                WHERE PacienteID=@PacienteID";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", p.Apellido);
            cmd.Parameters.AddWithValue("@FechaNacimiento", p.FechaNacimiento);
            cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
            cmd.Parameters.AddWithValue("@PacienteID", p.PacienteID);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            const string sql = "DELETE FROM Pacientes WHERE PacienteID=@id";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
