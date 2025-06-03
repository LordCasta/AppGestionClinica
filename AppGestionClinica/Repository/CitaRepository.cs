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

        public List<dynamic> ObtenerPorDoctor(int doctorId)
        {
            var lista = new List<dynamic>();
            string sql = @"SELECT CitaID, P.Nombre AS Paciente, Fecha, Hora, Estado
                   FROM Citas C
                   JOIN Pacientes P ON P.PacienteID = C.PacienteID
                   WHERE C.DoctorID = @DoctorID";
            using var cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@DoctorID", doctorId);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lista.Add(new
                {
                    CitaID = (int)rdr["CitaID"],
                    Paciente = rdr["Paciente"].ToString(),
                    Fecha = (DateTime)rdr["Fecha"],
                    Hora = TimeSpan.Parse(rdr["Hora"].ToString()),
                    Estado = rdr["Estado"].ToString()
                });
            }
            return lista;
        }

        public List<dynamic> ObtenerPorPaciente(int pacienteId)
        {
            var lista = new List<dynamic>();
            string sql = @"SELECT CitaID, D.Nombre AS Doctor, Fecha, Hora, Estado
                   FROM Citas C
                   JOIN Doctores D ON D.DoctorID = C.DoctorID
                   WHERE C.PacienteID = @PacienteID";
            using var cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@PacienteID", pacienteId);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lista.Add(new
                {
                    CitaID = (int)rdr["CitaID"],
                    Doctor = rdr["Doctor"].ToString(),
                    Fecha = (DateTime)rdr["Fecha"],
                    Hora = TimeSpan.Parse(rdr["Hora"].ToString()),
                    Estado = rdr["Estado"].ToString()
                });
            }
            return lista;
        }

        public List<Paciente> ObtenerPacientesConCitaDelDoctor(int doctorId)
        {
            const string sql = @"
        SELECT DISTINCT P.PacienteID, P.Nombre
        FROM Citas C
        INNER JOIN Pacientes P ON P.PacienteID = C.PacienteID
        WHERE C.DoctorID = @DoctorID";

            var lista = new List<Paciente>();

            using var cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@DoctorID", doctorId);
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lista.Add(new Paciente
                {
                    PacienteID = (int)rdr["PacienteID"],
                    Nombre = rdr["Nombre"].ToString()
                });
            }

            return lista;
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
