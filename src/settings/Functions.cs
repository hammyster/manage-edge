using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using ManageEdge;

namespace a
{
    public class Functions
    {
        public void UpdateDB(string table, string column, string value, string message)
        {
            NpgsqlConnection connpg = new NpgsqlConnection(Settings.connpgpb);
            connpg.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connpg;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("UPDATE "+table+" SET "+column+" = '"+value+"'");

            int RowsCount = cmd.ExecuteNonQuery();

            if (RowsCount == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show(message);
            }

            connpg.Close();
        }

        public void DeleteDB(string table)
        {
            NpgsqlConnection connpg = new NpgsqlConnection(Settings.connpgpb);
            connpg.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connpg;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("DELETE FROM " + table);

            int RowsCount = cmd.ExecuteNonQuery();

            if (RowsCount == 0)
            {
                
            }

            connpg.Close();
        }

        public static implicit operator Form(Functions v)
        {
            throw new NotImplementedException();
        }
    }
}
