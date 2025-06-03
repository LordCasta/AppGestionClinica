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
    public class CitaRepository
    {
        private readonly SqlConnection _conn;
        public CitaRepository() => _conn = Database.GetConnection();

        public void Agregar(Cita c)
        {
            const string sql = @"
                INSERT INTO Citas (PacienteID,DoctorID,Fecha,Hora,Estado)
                VALUES (@PacienteID,@DoctorID,@Fecha,@Hora,@Estado)";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@PacienteID", c.PacienteID);
            cmd.Parameters.AddWithValue("@DoctorID", c.DoctorID);
            cmd.Parameters.AddWithValue("@Fecha", c.Fecha);
            cmd.Parameters.AddWithValue("@Hora", c.Hora);
            cmd.Parameters.AddWithValue("@Estado", c.Estado);
            cmd.ExecuteNonQuery();
        }

        public List<Cita> ObtenerTodos()
        {
            var list = new List<Cita>();
            const string sql = "SELECT * FROM Citas";
            using var cmd = new SqlCommand(sql, _conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Cita
                {
                    CitaID = (int)rdr["CitaID"],
                    PacienteID = (int)rdr["PacienteID"],
                    DoctorID = (int)rdr["DoctorID"],
                    Fecha = (DateTime)rdr["Fecha"],
                    Hora = (TimeSpan)rdr["Hora"],
                    Estado = (string)rdr["Estado"]
                });
            }
            return list;
        }

        public List<TimeSpan> ObtenerHorasOcupadas(int doctorId, DateTime fecha)
        {
            const string sql = @"SELECT Hora FROM Citas WHERE DoctorID = @DoctorID AND Fecha = @Fecha";
            var lista = new List<TimeSpan>();
            using var cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@DoctorID", doctorId);
            cmd.Parameters.AddWithValue("@Fecha", fecha.Date);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                lista.Add(TimeSpan.Parse(reader["Hora"].ToString()));
            return lista;
        }

        public Cita ObtenerPorId(int id)
        {
            const string sql = "SELECT * FROM Citas WHERE CitaID=@id";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var rdr = cmd.ExecuteReader();
            if (rdr.Read()) return new Cita
            {
                CitaID = (int)rdr["CitaID"],
                PacienteID = (int)rdr["PacienteID"],
                DoctorID = (int)rdr["DoctorID"],
                Fecha = (DateTime)rdr["Fecha"],
                Hora = (TimeSpan)rdr["Hora"],
                Estado = (string)rdr["Estado"]
            };
            return null;
        }

        public void Actualizar(Cita c)
        {
            const string sql = @"
                UPDATE Citas
                SET PacienteID=@PacienteID, DoctorID=@DoctorID,
                    Fecha=@Fecha, Hora=@Hora, Estado=@Estado
                WHERE CitaID=@CitaID";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@PacienteID", c.PacienteID);
            cmd.Parameters.AddWithValue("@DoctorID", c.DoctorID);
            cmd.Parameters.AddWithValue("@Fecha", c.Fecha);
            cmd.Parameters.AddWithValue("@Hora", c.Hora);
            cmd.Parameters.AddWithValue("@Estado", c.Estado);
            cmd.Parameters.AddWithValue("@CitaID", c.CitaID);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            const string sql = "DELETE FROM Citas WHERE CitaID=@id";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
