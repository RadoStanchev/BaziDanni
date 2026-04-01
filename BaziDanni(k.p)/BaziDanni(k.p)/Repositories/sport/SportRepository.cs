using System.Data;
using BaziDanni_k.p_.Repositories.Common;
using Oracle.ManagedDataAccess.Client;

namespace BaziDanni_k.p_.Repositories.sport;

public sealed class SportRepository(string connectionString) : IRepository
{
    public DataTable GetAll() => RepositoryGuard.Query(connectionString,
        "SELECT N_sport, Ime_sport, Cvyat FROM sport ORDER BY N_sport");

    public void Insert(Dictionary<string, object?> values)
    {
        const string sql = "INSERT INTO sport (N_sport, Ime_sport, Cvyat) VALUES (:N_sport, :Ime_sport, :Cvyat)";
        RepositoryGuard.Execute(connectionString, sql, "Добавяне в SPORT", false,
            new OracleParameter(":N_sport", values["N_sport"] ?? DBNull.Value),
            new OracleParameter(":Ime_sport", values["Ime_sport"] ?? DBNull.Value),
            new OracleParameter(":Cvyat", values["Cvyat"] ?? DBNull.Value));
    }

    public void Update(Dictionary<string, object?> values)
    {
        const string sql = "UPDATE sport SET Ime_sport = :Ime_sport, Cvyat = :Cvyat WHERE N_sport = :N_sport";
        RepositoryGuard.Execute(connectionString, sql, "Редакция в SPORT", true,
            new OracleParameter(":Ime_sport", values["Ime_sport"] ?? DBNull.Value),
            new OracleParameter(":Cvyat", values["Cvyat"] ?? DBNull.Value),
            new OracleParameter(":N_sport", values["N_sport"] ?? DBNull.Value));
    }

    public void Delete(object key)
    {
        const string sql = "DELETE FROM sport WHERE N_sport = :p_key";
        RepositoryGuard.Execute(connectionString, sql, "Изтриване от SPORT", true,
            new OracleParameter(":p_key", key));
    }
}
