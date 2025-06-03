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
    public class TratamientoRepository
    {
        private readonly SqlConnection _conn;
        public TratamientoRepository() => _conn = Database.GetConnection();

        public void Agregar(Tratamiento t)
        {
            const string sql = @"
                INSERT INTO Tratamientos (PacienteID,TipoTratamiento,FechaInicio,Duracion,CostoTotal,SaldoPendiente)
                VALUES (@PacienteID,@TipoTratamiento,@FechaInicio,@Duracion,@CostoTotal,@SaldoPendiente)";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@PacienteID", t.PacienteID);
            cmd.Parameters.AddWithValue("@TipoTratamiento", t.TipoTratamiento);
            cmd.Parameters.AddWithValue("@FechaInicio", t.FechaInicio);
            cmd.Parameters.AddWithValue("@Duracion", t.Duracion);
            cmd.Parameters.AddWithValue("@CostoTotal", t.CostoTotal);
            cmd.Parameters.AddWithValue("@SaldoPendiente", t.SaldoPendiente);
            cmd.ExecuteNonQuery();
        }

        public List<Tratamiento> ObtenerTodos()
        {
            var list = new List<Tratamiento>();
            const string sql = "SELECT * FROM Tratamientos";
            using var cmd = new SqlCommand(sql, _conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Tratamiento
                {
                    TratamientoID = (int)rdr["TratamientoID"],
                    PacienteID = (int)rdr["PacienteID"],
                    TipoTratamiento = (string)rdr["TipoTratamiento"],
                    FechaInicio = (DateTime)rdr["FechaInicio"],
                    Duracion = (int)rdr["Duracion"],
                    CostoTotal = (decimal)rdr["CostoTotal"],
                    SaldoPendiente = (decimal)rdr["SaldoPendiente"]
                });
            }
            return list;
        }

        public List<Tratamiento> ObtenerPorPaciente(int pacienteId)
        {
            const string sql = @"
            SELECT * FROM Tratamientos
            WHERE PacienteID = @PacienteID
            ORDER BY FechaInicio DESC";

            var lista = new List<Tratamiento>();
            using var cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@PacienteID", pacienteId);
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lista.Add(new Tratamiento
                {
                    TratamientoID = (int)rdr["TratamientoID"],
                    PacienteID = (int)rdr["PacienteID"],
                    TipoTratamiento = rdr["TipoTratamiento"].ToString(),
                    FechaInicio = Convert.ToDateTime(rdr["FechaInicio"]),
                    Duracion = (int)rdr["Duracion"],
                    CostoTotal = (decimal)rdr["CostoTotal"],
                    SaldoPendiente = (decimal)rdr["SaldoPendiente"]
                });
            }

            return lista;
        }

        public void Actualizar(Tratamiento t)
        {
            const string sql = @"
                UPDATE Tratamientos
                SET PacienteID=@PacienteID, TipoTratamiento=@TipoTratamiento,
                    FechaInicio=@FechaInicio, Duracion=@Duracion,
                    CostoTotal=@CostoTotal, SaldoPendiente=@SaldoPendiente
                WHERE TratamientoID=@TratamientoID";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@PacienteID", t.PacienteID);
            cmd.Parameters.AddWithValue("@TipoTratamiento", t.TipoTratamiento);
            cmd.Parameters.AddWithValue("@FechaInicio", t.FechaInicio);
            cmd.Parameters.AddWithValue("@Duracion", t.Duracion);
            cmd.Parameters.AddWithValue("@CostoTotal", t.CostoTotal);
            cmd.Parameters.AddWithValue("@SaldoPendiente", t.SaldoPendiente);
            cmd.Parameters.AddWithValue("@TratamientoID", t.TratamientoID);
            cmd.ExecuteNonQuery();
        }

        public void ActualizarSaldo(int tratamientoId, decimal nuevoSaldo)
        {
            const string sql = "UPDATE Tratamientos SET SaldoPendiente = @Saldo WHERE TratamientoID = @ID";

            using var cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@Saldo", nuevoSaldo);
            cmd.Parameters.AddWithValue("@ID", tratamientoId);
            cmd.ExecuteNonQuery();
        }
        public void Eliminar(int id)
        {
            const string sql = "DELETE FROM Tratamientos WHERE TratamientoID=@id";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
