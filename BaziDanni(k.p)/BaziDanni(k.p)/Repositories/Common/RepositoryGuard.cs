using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BaziDanni_k.p_.Repositories.Common;

internal static class RepositoryGuard
{
    public static DataTable Query(string connectionString, string sql, params OracleParameter[] parameters)
    {
        try
        {
            using var connection = new OracleConnection(connectionString);
            using var command = new OracleCommand(sql, connection);
            foreach (var parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            using var adapter = new OracleDataAdapter(command);

            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        catch (Exception ex)
        {
            ShowError("Зареждане на данни", ex);
            return new DataTable();
        }
    }

    public static void Execute(
        string connectionString,
        string sql,
        string operationName,
        bool requireAffectedRow = false,
        params OracleParameter[] parameters)
    {
        try
        {
            using var connection = new OracleConnection(connectionString);
            connection.Open();

            using var command = new OracleCommand(sql, connection);
            foreach (var parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            var affectedRows = command.ExecuteNonQuery();

            if (requireAffectedRow && affectedRows == 0)
            {
                MessageBox.Show($"{operationName}: не е намерен запис със зададения идентификатор.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            ShowError(operationName, ex);
        }
    }

    private static void ShowError(string operationName, Exception ex)
    {
        if (ex is OracleException oracleException)
        {
            MessageBox.Show($"{operationName}: {MapError(oracleException)}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        MessageBox.Show($"{operationName}: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private static string MapError(OracleException ex)
    {
        return ex.Number switch
        {
            1 => "Вече съществува запис със същия идентификатор (duplicate id).",
            1400 => "Задължително поле е празно.",
            2291 => "Невалидна външна връзка: липсва свързан родителски запис (foreign key).",
            2292 => "Записът не може да бъде изтрит, защото се използва в други таблици (foreign key).",
            12899 => "Стойност в поле е по-дълга от позволеното.",
            1722 => "Невалиден числов формат в едно от полетата.",
            _ => $"Грешка при работа с базата данни (ORA-{ex.Number})."
        };
    }
}
