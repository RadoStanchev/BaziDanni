using System.Data;
using BaziDanni_k.p_.Repositories.Common;
using Oracle.ManagedDataAccess.Client;

namespace BaziDanni_k.p_.Repositories.grupa;

public sealed class GrupaRepository(string connectionString) : IRepository
{
    public DataTable GetAll() => RepositoryGuard.Query(connectionString,
        "SELECT N_grupa, N_sport, N_nivo, N_trenior FROM grupa ORDER BY N_grupa");

    public void Insert(Dictionary<string, object?> values)
    {
        const string sql = "INSERT INTO grupa (N_grupa, N_sport, N_nivo, N_trenior) VALUES (:N_grupa, :N_sport, :N_nivo, :N_trenior)";
        RepositoryGuard.Execute(connectionString, sql, "Добавяне в GRUPA", false,
            new OracleParameter(":N_grupa", values["N_grupa"] ?? DBNull.Value),
            new OracleParameter(":N_sport", values["N_sport"] ?? DBNull.Value),
            new OracleParameter(":N_nivo", values["N_nivo"] ?? DBNull.Value),
            new OracleParameter(":N_trenior", values["N_trenior"] ?? DBNull.Value));
    }

    public void Update(Dictionary<string, object?> values)
    {
        const string sql = "UPDATE grupa SET N_sport = :N_sport, N_nivo = :N_nivo, N_trenior = :N_trenior WHERE N_grupa = :N_grupa";
        RepositoryGuard.Execute(connectionString, sql, "Редакция в GRUPA", true,
            new OracleParameter(":N_sport", values["N_sport"] ?? DBNull.Value),
            new OracleParameter(":N_nivo", values["N_nivo"] ?? DBNull.Value),
            new OracleParameter(":N_trenior", values["N_trenior"] ?? DBNull.Value),
            new OracleParameter(":N_grupa", values["N_grupa"] ?? DBNull.Value));
    }

    public void Delete(object key)
    {
        const string sql = "DELETE FROM grupa WHERE N_grupa = :p_key";
        RepositoryGuard.Execute(connectionString, sql, "Изтриване от GRUPA", true,
            new OracleParameter(":p_key", key));
    }
}
