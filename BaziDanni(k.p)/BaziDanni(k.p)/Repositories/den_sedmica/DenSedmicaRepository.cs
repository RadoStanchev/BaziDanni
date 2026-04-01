using System.Data;
using BaziDanni_k.p_.Repositories.Common;
using Oracle.ManagedDataAccess.Client;

namespace BaziDanni_k.p_.Repositories.den_sedmica;

public sealed class DenSedmicaRepository(string connectionString) : IRepository
{
    public DataTable GetAll() => RepositoryGuard.Query(connectionString,
        "SELECT N_den, Den, Cvyat FROM den_sedmica ORDER BY N_den");

    public void Insert(Dictionary<string, object?> values)
    {
        const string sql = "INSERT INTO den_sedmica (N_den, Den, Cvyat) VALUES (:N_den, :Den, :Cvyat)";
        RepositoryGuard.Execute(connectionString, sql, "Добавяне в DEN_SEDMICA", false,
            new OracleParameter(":N_den", values["N_den"] ?? DBNull.Value),
            new OracleParameter(":Den", values["Den"] ?? DBNull.Value),
            new OracleParameter(":Cvyat", values["Cvyat"] ?? DBNull.Value));
    }

    public void Update(Dictionary<string, object?> values)
    {
        const string sql = "UPDATE den_sedmica SET Den = :Den, Cvyat = :Cvyat WHERE N_den = :N_den";
        RepositoryGuard.Execute(connectionString, sql, "Редакция в DEN_SEDMICA", true,
            new OracleParameter(":Den", values["Den"] ?? DBNull.Value),
            new OracleParameter(":Cvyat", values["Cvyat"] ?? DBNull.Value),
            new OracleParameter(":N_den", values["N_den"] ?? DBNull.Value));
    }

    public void Delete(object key)
    {
        const string sql = "DELETE FROM den_sedmica WHERE N_den = :p_key";
        RepositoryGuard.Execute(connectionString, sql, "Изтриване от DEN_SEDMICA", true,
            new OracleParameter(":p_key", key));
    }
}
