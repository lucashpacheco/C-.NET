using System;
using System.Configuration;
using Crud_2.register;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;



namespace Crud_2.repository
{
    public static class Repository
    {
        private static readonly string _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static List<Register> GetAllRegisters()
        {
            
            var query = "SELECT * FROM users";
            using (var conn = new SqlConnection(_connString))
            {
                var register = conn.Query<Register>(query).ToList();
                return register;
            }
        }
        public static List<Register> GetRegistersById(int? id)
        {

            var query = "SELECT * FROM users WHERE id=@Id";
            using (var conn = new SqlConnection(_connString))
            {
                var register = conn.Query<Register>(query, new { id = id }).ToList();
                //var register = conn.Query<Register>(query).ToList();
                return register;
            }
        }
        public static int InsertRegisters(Register register)
        {

            var query = "INSERT INTO users(nome, sobrenome, telefone, login, senha) VALUES (@Nome, @Sobrenome, @Telefone, @Login, @Senha)";
            using (var conn = new SqlConnection(_connString))
            {
                return conn.Execute(query, register);
            }
        }
        public static int EditRegisters(Register register)
        {

            var query = "UPDATE users SET nome=@Nome, sobrenome=@Sobrenome, telefone=@Telefone, login=@Login, senha=@Senha WHERE id=@Id";
            using (var conn = new SqlConnection(_connString))
            {
                return conn.Execute(query, register);
            }
        }
        public static int DeleteRegisters(Register register)
        {

            var query = "DELETE users WHERE id=@Id";
            using (var conn = new SqlConnection(_connString))
            {
                return conn.Execute(query, register);
            }
        }

    }
}