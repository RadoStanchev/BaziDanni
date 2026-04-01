using System.Data;
using BaziDanni_k.p_.Repositories.Common;
using Oracle.ManagedDataAccess.Client;

namespace BaziDanni_k.p_.Repositories.trenior;

public sealed class TreniorRepository(string connectionString) : IRepository
{
    public DataTable GetAll() => RepositoryGuard.Query(connectionString,
        "SELECT N_trenior, Ime_trenior, N_sport, Telefon_trenior FROM trenior ORDER BY N_trenior");

    public void Insert(Dictionary<string, object?> values)
    {
        const string sql = "INSERT INTO trenior (N_trenior, Ime_trenior, N_sport, Telefon_trenior) VALUES (:N_trenior, :Ime_trenior, :N_sport, :Telefon_trenior)";
        RepositoryGuard.Execute(connectionString, sql, "Добавяне в TRENIOR", false,
            new OracleParameter(":N_trenior", values["N_trenior"] ?? DBNull.Value),
            new OracleParameter(":Ime_trenior", values["Ime_trenior"] ?? DBNull.Value),
            new OracleParameter(":N_sport", values["N_sport"] ?? DBNull.Value),
            new OracleParameter(":Telefon_trenior", values["Telefon_trenior"] ?? DBNull.Value));
    }

    public void Update(Dictionary<string, object?> values)
    {
        const string sql = "UPDATE trenior SET Ime_trenior = :Ime_trenior, N_sport = :N_sport, Telefon_trenior = :Telefon_trenior WHERE N_trenior = :N_trenior";
        RepositoryGuard.Execute(connectionString, sql, "Редакция в TRENIOR", true,
            new OracleParameter(":Ime_trenior", values["Ime_trenior"] ?? DBNull.Value),
            new OracleParameter(":N_sport", values["N_sport"] ?? DBNull.Value),
            new OracleParameter(":Telefon_trenior", values["Telefon_trenior"] ?? DBNull.Value),
            new OracleParameter(":N_trenior", values["N_trenior"] ?? DBNull.Value));
    }

    public void Delete(object key)
    {
        const string sql = "DELETE FROM trenior WHERE N_trenior = :p_key";
        RepositoryGuard.Execute(connectionString, sql, "Изтриване от TRENIOR", true,
            new OracleParameter(":p_key", key));
    }
}
