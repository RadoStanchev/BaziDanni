using System.Data;
using BaziDanni_k.p_.Repositories.Common;
using Oracle.ManagedDataAccess.Client;

namespace BaziDanni_k.p_.Repositories.zapisani_abonamenti;

public sealed class ZapisaniAbonamentiRepository(string connectionString) : IRepository
{
    public DataTable GetAll() => RepositoryGuard.Query(connectionString,
        "SELECT N_chlen, N_grupa, N_abonament, Data_zapis FROM zapisani_abonamenti ORDER BY N_chlen");

    public void Insert(Dictionary<string, object?> values)
    {
        const string sql = "INSERT INTO zapisani_abonamenti (N_chlen, N_grupa, N_abonament, Data_zapis) VALUES (:N_chlen, :N_grupa, :N_abonament, :Data_zapis)";
        RepositoryGuard.Execute(connectionString, sql, "Добавяне в ZAPISANI_ABONAMENTI", false,
            new OracleParameter(":N_chlen", values["N_chlen"] ?? DBNull.Value),
            new OracleParameter(":N_grupa", values["N_grupa"] ?? DBNull.Value),
            new OracleParameter(":N_abonament", values["N_abonament"] ?? DBNull.Value),
            new OracleParameter(":Data_zapis", values["Data_zapis"] ?? DBNull.Value));
    }

    public void Update(Dictionary<string, object?> values)
    {
        const string sql = "UPDATE zapisani_abonamenti SET N_grupa = :N_grupa, N_abonament = :N_abonament, Data_zapis = :Data_zapis WHERE N_chlen = :N_chlen";
        RepositoryGuard.Execute(connectionString, sql, "Редакция в ZAPISANI_ABONAMENTI", true,
            new OracleParameter(":N_grupa", values["N_grupa"] ?? DBNull.Value),
            new OracleParameter(":N_abonament", values["N_abonament"] ?? DBNull.Value),
            new OracleParameter(":Data_zapis", values["Data_zapis"] ?? DBNull.Value),
            new OracleParameter(":N_chlen", values["N_chlen"] ?? DBNull.Value));
    }

    public void Delete(object key)
    {
        const string sql = "DELETE FROM zapisani_abonamenti WHERE N_chlen = :p_key";
        RepositoryGuard.Execute(connectionString, sql, "Изтриване от ZAPISANI_ABONAMENTI", true,
            new OracleParameter(":p_key", key));
    }
}
