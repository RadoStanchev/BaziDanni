using System.Data;
using BaziDanni_k.p_.Repositories.Common;
using Oracle.ManagedDataAccess.Client;

namespace BaziDanni_k.p_.Repositories.trenirovka;

public sealed class TrenirovkaRepository(string connectionString) : IRepository
{
    public DataTable GetAll() => RepositoryGuard.Query(connectionString,
        "SELECT N_grupa, datata, chas, N_chlen, N_den FROM trenirovka ORDER BY N_grupa");

    public void Insert(Dictionary<string, object?> values)
    {
        const string sql = "INSERT INTO trenirovka (N_grupa, datata, chas, N_chlen, N_den) VALUES (:N_grupa, :datata, :chas, :N_chlen, :N_den)";
        RepositoryGuard.Execute(connectionString, sql, "Добавяне в TRENIROVKA", false,
            new OracleParameter(":N_grupa", values["N_grupa"] ?? DBNull.Value),
            new OracleParameter(":datata", values["datata"] ?? DBNull.Value),
            new OracleParameter(":chas", values["chas"] ?? DBNull.Value),
            new OracleParameter(":N_chlen", values["N_chlen"] ?? DBNull.Value),
            new OracleParameter(":N_den", values["N_den"] ?? DBNull.Value));
    }

    public void Update(Dictionary<string, object?> values)
    {
        const string sql = "UPDATE trenirovka SET datata = :datata, chas = :chas, N_chlen = :N_chlen, N_den = :N_den WHERE N_grupa = :N_grupa";
        RepositoryGuard.Execute(connectionString, sql, "Редакция в TRENIROVKA", true,
            new OracleParameter(":datata", values["datata"] ?? DBNull.Value),
            new OracleParameter(":chas", values["chas"] ?? DBNull.Value),
            new OracleParameter(":N_chlen", values["N_chlen"] ?? DBNull.Value),
            new OracleParameter(":N_den", values["N_den"] ?? DBNull.Value),
            new OracleParameter(":N_grupa", values["N_grupa"] ?? DBNull.Value));
    }

    public void Delete(object key)
    {
        const string sql = "DELETE FROM trenirovka WHERE N_grupa = :p_key";
        RepositoryGuard.Execute(connectionString, sql, "Изтриване от TRENIROVKA", true,
            new OracleParameter(":p_key", key));
    }
}
