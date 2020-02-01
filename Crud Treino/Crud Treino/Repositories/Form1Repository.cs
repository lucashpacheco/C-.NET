using Crud_Treino.Models;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Crud_Treino.Repositories
{
    public static class Form1Repository
    {
        private static readonly string _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static List<Register> GetAllRegisters()
        {
            var query = "SELECT * FROM list_users";
            using (var conn = new SqlConnection(_connString))
            {
                var registers = conn.Query<Register>(query).ToList();

                return registers;
            }
        }

        public static List<Register> GetRegisterById(int? id)
        {
            var query = "SELECT * FROM list_users WHERE Id=@id";

            using (var conn = new SqlConnection(_connString))
            {
                var register = conn.Query<Register>(query, new { id = id}).ToList();

                return register;
            }
        }

        public static int InsertRegister(Register register)
        {
            var query = "INSERT INTO list_users(Nome,Apelido,Login,Senha,Obs) VALUES(@Nome,@Apelido,@Login,@Senha,@Obs)";

            using (var conn = new SqlConnection(_connString))
            {
                return conn.Execute(query, register);
            }
        }

        public static int UpdateRegister(Register register)
        {
            var query = "UPDATE list_users SET Nome=@Nome, Apelido=@Apelido, Login=@Login, Senha=@Senha, Obs=@Obs WHERE Id=@Id";

            using (var conn = new SqlConnection(_connString))
            {
                return conn.Execute(query, register);
            }
        }

        public static int DeleteRegister(int? id)
        {
            var query = "DELETE list_users WHERE Id=@id";

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand(query, conn))
            {
                return conn.Execute(query, new { id = id});
            }
        }
    }
}
