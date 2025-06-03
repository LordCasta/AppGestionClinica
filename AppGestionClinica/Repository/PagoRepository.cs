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
    public class PagoRepository
    {
        private readonly SqlConnection _conn;
        public PagoRepository() => _conn = Database.GetConnection();

        public void Agregar(Pago p)
        {
            const string sql = @"
                INSERT INTO Pagos (TratamientoID,FechaPago,Monto,MetodoPago)
                VALUES (@TratamientoID,GETDATE(),@Monto,@MetodoPago)";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@TratamientoID", p.TratamientoID);
            cmd.Parameters.AddWithValue("@Monto", p.Monto);
            cmd.Parameters.AddWithValue("@MetodoPago", p.MetodoPago);
            cmd.ExecuteNonQuery();
        }

        public List<Pago> ObtenerPorTratamiento(int tratamientoId)
        {
            const string sql = @"SELECT * FROM Pagos WHERE TratamientoID = @TratamientoID ORDER BY FechaPago DESC";

            var lista = new List<Pago>();
            using var cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@TratamientoID", tratamientoId);
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lista.Add(new Pago
                {
                    PagoID = (int)rdr["PagoID"],
                    TratamientoID = (int)rdr["TratamientoID"],
                    FechaPago = (DateTime)rdr["FechaPago"],
                    Monto = (decimal)rdr["Monto"],
                    MetodoPago = rdr["MetodoPago"].ToString()
                });
            }

            return lista;
        }

        public decimal ObtenerTotalPagado(int tratamientoId)
        {
            const string sql = @"SELECT ISNULL(SUM(Monto), 0) FROM Pagos WHERE TratamientoID = @TratamientoID";

            using var cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@TratamientoID", tratamientoId);
            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        public List<Pago> ObtenerTodos()
        {
            var list = new List<Pago>();
            const string sql = "SELECT * FROM Pagos";
            using var cmd = new SqlCommand(sql, _conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Pago
                {
                    PagoID = (int)rdr["PagoID"],
                    TratamientoID = (int)rdr["TratamientoID"],
                    FechaPago = (DateTime)rdr["FechaPago"],
                    Monto = (decimal)rdr["Monto"],
                    MetodoPago = (string)rdr["MetodoPago"]
                });
            }
            return list;
        }


        public void Eliminar(int id)
        {
            const string sql = "DELETE FROM Pagos WHERE PagoID=@id";
            using var cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
