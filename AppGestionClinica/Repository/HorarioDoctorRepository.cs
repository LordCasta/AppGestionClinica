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
    public class HorarioDoctorRepository
    {
        private readonly SqlConnection _conn;
        public HorarioDoctorRepository() => _conn = Database.GetConnection();

        public void Agregar(HorarioDoctor h)
        {
            const string sql = @"
                INSERT INTO HorariosDoctores (DoctorID,DiaSemana,HoraInicio,HoraFin)
                VALUES (@DoctorID,@DiaSemana,@HoraInicio,@HoraFin)";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@DoctorID", h.DoctorID);
            cmd.Parameters.AddWithValue("@DiaSemana", h.DiaSemana);
            cmd.Parameters.AddWithValue("@HoraInicio", h.HoraInicio);
            cmd.Parameters.AddWithValue("@HoraFin", h.HoraFin);
            cmd.ExecuteNonQuery();
        }

        public List<HorarioDoctor> ObtenerTodos()
        {
            var list = new List<HorarioDoctor>();
            const string sql = "SELECT * FROM HorariosDoctores";
            using var cmd = new SqlCommand(sql, _conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new HorarioDoctor
                {
                    HorarioID = (int)rdr["HorarioID"],
                    DoctorID = (int)rdr["DoctorID"],
                    DiaSemana = (int)rdr["DiaSemana"],
                    HoraInicio = (TimeSpan)rdr["HoraInicio"],
                    HoraFin = (TimeSpan)rdr["HoraFin"]
                });
            }
            return list;
        }

        public void Eliminar(int id)
        {
            const string sql = "DELETE FROM HorariosDoctores WHERE HorarioID=@id";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
