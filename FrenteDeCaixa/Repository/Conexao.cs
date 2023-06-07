using MySqlConnector;

namespace FrenteDeCaixa.Repository
{
    internal static class Conexao
    {
        public static MySqlConnection GetSqlConnection()
        {
            MySqlConnection con = new MySqlConnection(GetConnectionString());
            con.Open();
            return con;
        }

        private static string GetConnectionString()
        {
            return "Server=localhost;Port=3306;Database=bd_frente_caixa;Uid=root;Pwd=1234;ConvertZeroDateTime=True;";
        }
    }
}
