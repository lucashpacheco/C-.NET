using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voce ja possui uma conta ? Digite 'sim' para ir para LOGIN e 'nao' para ir para CADASTRO.");
            string temconta = Console.ReadLine();

            if (temconta == "sim")
            {
                Console.WriteLine("Digite seu login:");

                bool first = false;
                string enterpass = "";
                string enterlogin = Console.ReadLine();
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LogConsole;Data Source=DESKTOPW");
                SqlCommand slogin = new SqlCommand("select Logg from users where Logg=@login", sql);
                slogin.Parameters.Add("@login", SqlDbType.VarChar).Value = enterlogin;
                
                try
                {
                    sql.Open();
                    SqlDataReader dataReader = slogin.ExecuteReader();
                    if (dataReader.HasRows == false)
                    {
                        throw new Exception("Usuario invalido");
                        
                    }
                    
                    dataReader.Read();
                    dataReader.Close();
                    first = true;
                    Console.WriteLine("Digite sua senha:");
                    enterpass = Console.ReadLine();
                    SqlCommand spass = new SqlCommand("select * from users where Logg=@login and Pass=@pass", sql);
                    spass.Parameters.Add("@pass", SqlDbType.VarChar).Value = enterpass;
                    SqlDataReader dataReader1 = spass.ExecuteReader();
                    if (first = false || dataReader1.HasRows == false)
                    {
                        throw new Exception("Senha invalida");
                    }
                    dataReader1.Read();
                    Console.WriteLine("LOGADO");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sql.Close();
                }

            }
            else
            {
                Console.WriteLine("Digite o login para cadastro:");
                string enterlogin = Console.ReadLine();
                Console.WriteLine("Digite sua senha:");
                string enterpass = Console.ReadLine();



                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LogConsole;Data Source=DESKTOPW");
                SqlCommand add = new SqlCommand("insert into users(Logg,Pass) values(@login,@pass)", sql);
                add.Parameters.Add("@login", SqlDbType.VarChar).Value = enterlogin;
                add.Parameters.Add("@pass", SqlDbType.VarChar).Value = enterpass;
                if (enterlogin != "" && enterpass != "")
                {
                    try
                    {
                        sql.Open();
                        add.ExecuteNonQuery();
                        Console.WriteLine("CAD COM SUCESSO");

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        sql.Close();
                    }
                }
            }
        }
    }
}
