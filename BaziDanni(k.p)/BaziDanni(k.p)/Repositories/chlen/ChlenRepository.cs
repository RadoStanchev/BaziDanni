using System.Data;
using BaziDanni_k.p_.Repositories.Common;
using Oracle.ManagedDataAccess.Client;

namespace BaziDanni_k.p_.Repositories.chlen;

public sealed class ChlenRepository(string connectionString) : IRepository
{
    public DataTable GetAll() => RepositoryGuard.Query(connectionString,
        "SELECT N_chlen, Ime_chlen, EGN, Telefon, Adres FROM chlen ORDER BY N_chlen");

    public void Insert(Dictionary<string, object?> values)
    {
        const string sql = "INSERT INTO chlen (N_chlen, Ime_chlen, EGN, Telefon, Adres) VALUES (:N_chlen, :Ime_chlen, :EGN, :Telefon, :Adres)";
        RepositoryGuard.Execute(connectionString, sql, "Добавяне в CHLEN", false,
            new OracleParameter(":N_chlen", values["N_chlen"] ?? DBNull.Value),
            new OracleParameter(":Ime_chlen", values["Ime_chlen"] ?? DBNull.Value),
            new OracleParameter(":EGN", values["EGN"] ?? DBNull.Value),
            new OracleParameter(":Telefon", values["Telefon"] ?? DBNull.Value),
            new OracleParameter(":Adres", values["Adres"] ?? DBNull.Value));
    }

    public void Update(Dictionary<string, object?> values)
    {
        const string sql = "UPDATE chlen SET Ime_chlen = :Ime_chlen, EGN = :EGN, Telefon = :Telefon, Adres = :Adres WHERE N_chlen = :N_chlen";
        RepositoryGuard.Execute(connectionString, sql, "Редакция в CHLEN", true,
            new OracleParameter(":Ime_chlen", values["Ime_chlen"] ?? DBNull.Value),
            new OracleParameter(":EGN", values["EGN"] ?? DBNull.Value),
            new OracleParameter(":Telefon", values["Telefon"] ?? DBNull.Value),
            new OracleParameter(":Adres", values["Adres"] ?? DBNull.Value),
            new OracleParameter(":N_chlen", values["N_chlen"] ?? DBNull.Value));
    }

    public void Delete(object key)
    {
        const string sql = "DELETE FROM chlen WHERE N_chlen = :p_key";
        RepositoryGuard.Execute(connectionString, sql, "Изтриване от CHLEN", true,
            new OracleParameter(":p_key", key));
    }
}
