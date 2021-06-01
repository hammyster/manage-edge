using System;
using System.Data;
using Npgsql;
using System.Security.Cryptography;
using System.Text;

namespace ManageEdge
{
    public class Npgsql
    {
        NpgsqlConnection pgsqlConnection = null;
        public static string loginResult;
        public Npgsql()
        {
            
        }
        public DataTable GetTodosRegistros(string ip)
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(Settings.connpgpb))
                {
                    pgsqlConnection.Open();
                    string cmdSeleciona = "SELECT login, player_id, player_name, lastip, hwid FROM accounts WHERE lastip = '" + ip +"' ORDER BY player_id";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
        public static string EncryptPass(string text)
        {
            
            using (var hmacMD5 = new HMACMD5(Encoding.UTF8.GetBytes("/x!a@r-$r%an¨.&e&+f*f(f(a)")))
            {
                byte[] data = hmacMD5.ComputeHash(Encoding.UTF8.GetBytes(text));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                    sBuilder.Append(data[i].ToString("x2"));
                return sBuilder.ToString();
            }
        }
    }
}
