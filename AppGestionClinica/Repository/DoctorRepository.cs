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
    public class DoctorRepository
    {
        private readonly SqlConnection _conn;
        public DoctorRepository() => _conn = Database.GetConnection();

        public void Agregar(Doctor d)
        {
            const string sql = @"
                INSERT INTO Doctores (Nombre, Especializacion, Telefono)
                VALUES (@Nombre,@Especializacion,@Telefono)";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@Nombre", d.Nombre);
            cmd.Parameters.AddWithValue("@Especializacion", d.Especializacion);
            cmd.Parameters.AddWithValue("@Telefono", d.Telefono);
            cmd.ExecuteNonQuery();
        }

        public List<Doctor> ObtenerTodos()
        {
            var list = new List<Doctor>();
            const string sql = "SELECT * FROM Doctores";
            using var cmd = new SqlCommand(sql, _conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Doctor
                {
                    DoctorID = (int)rdr["DoctorID"],
                    Nombre = (string)rdr["Nombre"],
                    Especializacion = (string)rdr["Especializacion"],
                    Telefono = (string)rdr["Telefono"]
                });
            }
            return list;
        }

        public Doctor ObtenerPorId(int id)
        {
            const string sql = "SELECT * FROM Doctores WHERE DoctorID=@id";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var rdr = cmd.ExecuteReader();
            if (rdr.Read()) return new Doctor
            {
                DoctorID = (int)rdr["DoctorID"],
                Nombre = (string)rdr["Nombre"],
                Especializacion = (string)rdr["Especializacion"],
                Telefono = (string)rdr["Telefono"]
            };
            return null;
        }

        public void Actualizar(Doctor d)
        {
            const string sql = @"
                UPDATE Doctores
                SET Nombre=@Nombre, Especializacion=@Especializacion, Telefono=@Telefono
                WHERE DoctorID=@DoctorID";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@Nombre", d.Nombre);
            cmd.Parameters.AddWithValue("@Especializacion", d.Especializacion);
            cmd.Parameters.AddWithValue("@Telefono", d.Telefono);
            cmd.Parameters.AddWithValue("@DoctorID", d.DoctorID);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            const string sql = "DELETE FROM Doctores WHERE DoctorID=@id";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
