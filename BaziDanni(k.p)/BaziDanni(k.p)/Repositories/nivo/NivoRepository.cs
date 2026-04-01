using System.Data;
using BaziDanni_k.p_.Repositories.Common;
using Oracle.ManagedDataAccess.Client;

namespace BaziDanni_k.p_.Repositories.nivo;

public sealed class NivoRepository(string connectionString) : IRepository
{
    public DataTable GetAll() => RepositoryGuard.Query(connectionString,
        "SELECT N_nivo, Ime_nivo, Cvyat FROM nivo ORDER BY N_nivo");

    public void Insert(Dictionary<string, object?> values)
    {
        const string sql = "INSERT INTO nivo (N_nivo, Ime_nivo, Cvyat) VALUES (:N_nivo, :Ime_nivo, :Cvyat)";
        RepositoryGuard.Execute(connectionString, sql, "Добавяне в NIVO", false,
            new OracleParameter(":N_nivo", values["N_nivo"] ?? DBNull.Value),
            new OracleParameter(":Ime_nivo", values["Ime_nivo"] ?? DBNull.Value),
            new OracleParameter(":Cvyat", values["Cvyat"] ?? DBNull.Value));
    }

    public void Update(Dictionary<string, object?> values)
    {
        const string sql = "UPDATE nivo SET Ime_nivo = :Ime_nivo, Cvyat = :Cvyat WHERE N_nivo = :N_nivo";
        RepositoryGuard.Execute(connectionString, sql, "Редакция в NIVO", true,
            new OracleParameter(":Ime_nivo", values["Ime_nivo"] ?? DBNull.Value),
            new OracleParameter(":Cvyat", values["Cvyat"] ?? DBNull.Value),
            new OracleParameter(":N_nivo", values["N_nivo"] ?? DBNull.Value));
    }

    public void Delete(object key)
    {
        const string sql = "DELETE FROM nivo WHERE N_nivo = :p_key";
        RepositoryGuard.Execute(connectionString, sql, "Изтриване от NIVO", true,
            new OracleParameter(":p_key", key));
    }
}
