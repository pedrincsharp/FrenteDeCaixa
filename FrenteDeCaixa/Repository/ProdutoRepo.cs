using Dapper;
using FrenteDeCaixa.Model;

namespace FrenteDeCaixa.Repository
{
    internal class ProdutoRepo : IRepo<Produto>
    {
        public int Delete(int id)
        {
            string ssql = "DELETE FROM produtos WHERE Id = @id";
            using (var db = Conexao.GetSqlConnection())
            {
                return db.Execute(ssql, new { id });
            }
        }

        public List<Produto> GetAll()
        {
            string ssql = "SELECT * FROM produtos";
            using (var db = Conexao.GetSqlConnection())
            {
                return db.Query<Produto>(ssql).ToList();
            }
        }

        public int GetUltCod()
        {
            string ssql = "SELECT (IFNULL(MAX(Id),0) + 1) AS ULTCOD FROM produtos";
            using(var db = Conexao.GetSqlConnection())
            {
                return db.Query<int>(ssql).ToList()[0];
            }
        }

        public Produto GetValue(int id)
        {
            string ssql = "SELECT * FROM produtos WHERE Id = @id";
            using (var db = Conexao.GetSqlConnection())
            {
                return db.QueryFirstOrDefault<Produto>(ssql, new { id });
            }
        }

        public int Insert(Produto value)
        {
            string ssql = "INSERT INTO produtos (Id,Nome,Observacao,Venda,Custo,Estoque)";
            ssql += " VALUES (@Id,@Nome,@Observacao,@Venda,@Custo,@Estoque)";
            using (var db = Conexao.GetSqlConnection())
            {
                return db.Execute(ssql, value);
            }
        }

        public int Update(Produto value)
        {
            string ssql = "UPDATE produtos SET Nome = @Nome, Observacao = @Observacao, Venda = @Venda, Custo = @Custo, Estoque = @Estoque";
            ssql += " WHERE Id = @Id";
            using (var db = Conexao.GetSqlConnection())
            {
                return db.Execute(ssql, value);
            }
        }
    }
}
