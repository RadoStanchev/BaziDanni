using Oracle.ManagedDataAccess.Client;

namespace BaziDanni_k.p_.Infrastructure;

public static class DatabaseInitializer
{
    public static void Initialize(string connectionString)
    {
        using var connection = new OracleConnection(connectionString);
        connection.Open();

        if (SchemaAlreadyExists(connection))
        {
            return;
        }

        var scriptPath = Path.Combine(Directory.GetCurrentDirectory(), "Sql", "schema_all.sql");
        if (!File.Exists(scriptPath))
        {
            throw new FileNotFoundException("Не е намерен SQL файлът за инициализация.", scriptPath);
        }

        var scriptText = File.ReadAllText(scriptPath);
        var statements = SplitStatements(scriptText);

        foreach (var statement in statements)
        {
            using var command = new OracleCommand(statement, connection);
            command.ExecuteNonQuery();
        }
    }

    private static bool SchemaAlreadyExists(OracleConnection connection)
    {
        const string sql = "SELECT COUNT(*) FROM USER_TABLES WHERE TABLE_NAME IN ('CHLEN', 'NIVO')";
        using var command = new OracleCommand(sql, connection);
        var count = Convert.ToInt32(command.ExecuteScalar());
        return count > 0;
    }

    private static IReadOnlyList<string> SplitStatements(string script)
    {
        var cleanedScript = RemoveComments(script);
        var statements = new List<string>();
        var current = new System.Text.StringBuilder();
        var inString = false;

        foreach (var ch in cleanedScript)
        {
            if (ch == '\'')
            {
                inString = !inString;
            }

            if (ch == ';' && !inString)
            {
                var sql = current.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(sql))
                {
                    statements.Add(sql);
                }

                current.Clear();
                continue;
            }

            current.Append(ch);
        }

        var trailing = current.ToString().Trim();
        if (!string.IsNullOrWhiteSpace(trailing))
        {
            statements.Add(trailing);
        }

        return statements;
    }

    private static string RemoveComments(string script)
    {
        var lines = script
            .Split(Environment.NewLine)
            .Select(line =>
            {
                var trimmed = line.TrimStart();
                return trimmed.StartsWith("--", StringComparison.Ordinal) ? string.Empty : line;
            });

        return string.Join(Environment.NewLine, lines);
    }
}
