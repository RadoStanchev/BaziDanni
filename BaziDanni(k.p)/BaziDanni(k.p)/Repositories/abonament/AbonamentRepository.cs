using System.Data;
using BaziDanni_k.p_.Repositories.Common;
using Oracle.ManagedDataAccess.Client;

namespace BaziDanni_k.p_.Repositories.abonament;

public sealed class AbonamentRepository(string connectionString) : IRepository
{
    public DataTable GetAll() => RepositoryGuard.Query(connectionString,
        "SELECT N_abonament, Period_meseci, Cena_lv FROM abonament ORDER BY N_abonament");

    public void Insert(Dictionary<string, object?> values)
    {
        const string sql = "INSERT INTO abonament (N_abonament, Period_meseci, Cena_lv) VALUES (:N_abonament, :Period_meseci, :Cena_lv)";
        RepositoryGuard.Execute(connectionString, sql, "Добавяне в ABONAMENT", false,
            new OracleParameter(":N_abonament", values["N_abonament"] ?? DBNull.Value),
            new OracleParameter(":Period_meseci", values["Period_meseci"] ?? DBNull.Value),
            new OracleParameter(":Cena_lv", values["Cena_lv"] ?? DBNull.Value));
    }

    public void Update(Dictionary<string, object?> values)
    {
        const string sql = "UPDATE abonament SET Period_meseci = :Period_meseci, Cena_lv = :Cena_lv WHERE N_abonament = :N_abonament";
        RepositoryGuard.Execute(connectionString, sql, "Редакция в ABONAMENT", true,
            new OracleParameter(":Period_meseci", values["Period_meseci"] ?? DBNull.Value),
            new OracleParameter(":Cena_lv", values["Cena_lv"] ?? DBNull.Value),
            new OracleParameter(":N_abonament", values["N_abonament"] ?? DBNull.Value));
    }

    public void Delete(object key)
    {
        const string sql = "DELETE FROM abonament WHERE N_abonament = :p_key";
        RepositoryGuard.Execute(connectionString, sql, "Изтриване от ABONAMENT", true,
            new OracleParameter(":p_key", key));
    }
}
